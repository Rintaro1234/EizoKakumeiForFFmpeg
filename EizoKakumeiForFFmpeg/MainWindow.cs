using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace EizoKakumeiForFFmpeg
{
    public partial class MainWindow : Form
    {
        public readonly string[] supportExt = { ".mp4", ".mkv", ".avi", ".mov", ".wmv", ".flv", ".webm", ".MP4", ".MKV", ".AVI", ".MOV", ".WMV", ".FLV", ".WEBM"};
        private readonly string _thumbnailImagePath = $"{Directory.GetCurrentDirectory()}\\temp\\thumbnail.png";
        private readonly string _tempFolderPath = $"{Directory.GetCurrentDirectory()}\\temp\\";
        private String _ffmpegPath = "ffmpeg";
        private BindingList<OutputOptionItem> _outputOptionList = new BindingList<OutputOptionItem>();


        public MainWindow()
        {
            InitializeComponent();
        }

        // 最初にロードが終わった時の処理
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // DataGridに列(属性)を追加する
            outputAudioSettingGrid.Columns[0].HeaderText = "トラック名";
            outputAudioSettingGrid.Columns[0].Width = 80;
            outputAudioSettingGrid.Columns[1].HeaderText = "出力";
            outputAudioSettingGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            outputAudioSettingGrid.Columns[1].Width = 50;
            outputAudioSettingGrid.Columns[2].HeaderText = "音声ファイル名";
            outputAudioSettingGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            outputAudioSettingGrid.Columns[3].HeaderText = "再結合";
            outputAudioSettingGrid.Columns[3].Width = 50;
            outputAudioSettingGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // 前回のオーディオ出力設定を復帰させる
            if (Properties.Settings.Default.outputAudioSetting != null)
            {
                foreach (string row in Properties.Settings.Default.outputAudioSetting.Split(';'))
                {
                    string[] items = row.Split(',');
                    try
                    {
                        _outputOptionList.Add(new OutputOptionItem(items[0], items[1] == "True", items[2], items[3] == "True"));
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(row);
                    }
                }
            }
            outputAudioSettingGrid.DataSource = _outputOptionList;

            // 前回の設定を反映させる
            SelectFFmpegPathButton.Enabled = !useEnvironmentVariableCheckBox.Checked;
            FFmpegPathTextBox.Enabled = !useEnvironmentVariableCheckBox.Checked;
            _ffmpegPath = (useEnvironmentVariableCheckBox.Checked) ? "ffmpeg" : FFmpegPathTextBox.Text;
            SelectMovieOutputPathButton.Enabled = !useMovieOutputPathCheckBox.Checked;
            SelectMovieOutputPathTextBox.Enabled = !useMovieOutputPathCheckBox.Checked;

            // 選択可能なコーディックをドロップダウンリストに入れる
            foreach (MOVIE_CORDEC cordec in Enum.GetValues(typeof(MOVIE_CORDEC)))
            {
                MovieCordecComboBox.Items.Add(CordecList.MovieCordecOption[cordec]);
            }
            foreach (AUDIO_CORDEC cordec in Enum.GetValues(typeof(AUDIO_CORDEC)))
            {
                AudioCordecComboBox.Items.Add(CordecList.AudioCordecOption[cordec]);
            }

            // コーディックの初期値を決める
            MovieCordecComboBox.SelectedIndex = 0;
            AudioCordecComboBox.SelectedIndex = 0;
        }

        // フォームが閉じられたときの処理
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            String outputData = "";
            foreach(OutputOptionItem item in _outputOptionList)
            {
                outputData += item.ToString() + ";";
            }
            Properties.Settings.Default.outputAudioSetting = outputData;
            Properties.Settings.Default.Save();
        }

        // 与えられた引数argでFFmpegのコマンドを実行する関数
        private Process runFFmpegCmd(String arg)
        {
            ProcessStartInfo psi = new ProcessStartInfo(_ffmpegPath, arg);

            return Process.Start(psi); // 実行
        }

        // FFmpegが存在するかチェック
        private bool isFFmpegAvailable()
        {
            string ffmpegPath = _ffmpegPath;
            // 環境変数を使う場合，whereコマンドを実行して本当に存在するか確認する
            if (useEnvironmentVariableCheckBox.Checked)
            {
                ProcessStartInfo psi = new ProcessStartInfo("where.exe", "ffmpeg");
                psi.RedirectStandardOutput = true;
                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                Process process = Process.Start(psi);
                process.WaitForExit();
                ffmpegPath = process.StandardOutput.ReadToEnd().Split('\n')[0]; // 複数行出てきたときのために，1行目のパスを使う
            }
            return File.Exists(ffmpegPath);
        }

        // 動画を取得したときの処理
        private void MovieFilePath_TextChanged(object sender, EventArgs e)
        {
            // ファイルが存在し，サポートする拡張子であるか確認
            if (File.Exists(MovieFilePathTextBox.Text) && Array.IndexOf(supportExt, Path.GetExtension(MovieFilePathTextBox.Text)) != -1)
            {
                // ファイル名を表示
                MovieNameLabel.Text = Path.GetFileName(MovieFilePathTextBox.Text);
                // tempフォルダが無ければ作成する
                Directory.CreateDirectory(_tempFolderPath);
                try
                {
                    // サムネイルを作成
                    String arg = $"-ss 1 -i \"{MovieFilePathTextBox.Text}\" -frames:v 1 \"{_thumbnailImagePath}\" -y";
                    runFFmpegCmd(arg).WaitForExit(); // 終了を待つ

                    // 完成したサムネイルを表示
                    thumbnailImage.ImageLocation = _thumbnailImagePath;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.ToString());
                }
            }
        }

        // 動画がドラッグされ，画面の上まで持ってきたとき
        private void MovieThumbnailPanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        // 動画をドラック&ドロップを受けたときの処理
        private void MovieThumbnailPanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // まとめてドロップされた場合，一番最初のファイルだけを対象とする
                string fileName = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                MovieFilePathTextBox.Text = fileName;
            }
        }

        // 動画選択をエクスプローラから開く
        private void OpenMovie_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"%USERPROFILE%\Videos";
            ofd.Filter = "Video Files|*.mp4;*.mkv;*.avi;*.mov;*.wmv;*.flv;*.webm";
            ofd.Title = "動画選択";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                MovieFilePathTextBox.Text = ofd.FileName;
            }
        }

        private void TrackNumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            // 入力された音声トラックの数と行数を揃える．
            while (TrackNumNumericUpDown.Value != outputAudioSettingGrid.Rows.Count)
            {
                if(TrackNumNumericUpDown.Value - outputAudioSettingGrid.RowCount < 0)
                {
                    _outputOptionList.RemoveAt(outputAudioSettingGrid.RowCount - 1);
                }
                else
                {
                    _outputOptionList.Add(new OutputOptionItem($"Track_{outputAudioSettingGrid.RowCount}", true, $"%MOVIENAME%_Audio%TRUCKNUM%", false));
                }
            }
        }

        // 保存先の選択
        private void SelectMovieOutputPathButton_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog cofd = new CommonOpenFileDialog();
            cofd.Title = "保存先";
            cofd.Multiselect = false;
            cofd.IsFolderPicker = true;

            if (cofd.ShowDialog() == CommonFileDialogResult.Ok)
            {
                SelectMovieOutputPathTextBox.Text = cofd.FileName;
            }
        }

        // 出力動画の保存先は，元動画と同じにするというチェックボックスを有効にした時，出力先フォルダの入力欄を無効にする
        private void useMovieOutputPathCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SelectMovieOutputPathButton.Enabled = !useMovieOutputPathCheckBox.Checked;
            SelectMovieOutputPathTextBox.Enabled = !useMovieOutputPathCheckBox.Checked;
        }

        // FFmpegの選択
        private void SelectFFmpegPathButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"%USERPROFILE%\Videos";
            ofd.Filter = "実行ファイル|FFmpeg.exe";
            ofd.Title = "FFmpeg.exeの選択";
            ofd.RestoreDirectory = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FFmpegPathTextBox.Text = ofd.FileName;
            }
        }

        // FFmpegは環境変数を使う場合，FFmpegの保存先の入力欄を無効にする
        private void useEnvironmentVariableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SelectFFmpegPathButton.Enabled = !useEnvironmentVariableCheckBox.Checked;
            FFmpegPathTextBox.Enabled = !useEnvironmentVariableCheckBox.Checked;
            _ffmpegPath = (useEnvironmentVariableCheckBox.Checked) ? "ffmpeg.exe" : FFmpegPathTextBox.Text;
        }

        // FFmpegの保存先に関してのテキストボックスが編集されたときに実行
        private void FFmpegPathTextBox_TextChanged(object sender, EventArgs e)
        {
            _ffmpegPath = FFmpegPathTextBox.Text;
        }

        private void StartProcessButton_Click(object sender, EventArgs e)
        {
            // 必須情報が埋まっているか確認する
            string err = "";
            if (!File.Exists(MovieFilePathTextBox.Text)) err += "指定された動画ファイルが存在しません\n";
            if (!useMovieOutputPathCheckBox.Checked && SelectMovieOutputPathTextBox.Text == "") err += "動画の出力先が指定されていません\n";
            if (!isFFmpegAvailable()) err += "FFmpegが見つかりませんでした\n";
            if (MovieCordecComboBox.SelectedItem == null) err += "動画のコーディックが指定されていません\n";
            if (AudioCordecComboBox.SelectedItem == null) err += "音声のコーディックが指定されていません\n";
            foreach (OutputOptionItem item in _outputOptionList)
            {
                if (!item.isOutput) continue;
                if(item.fileName == "" || item.fileName == null)
                {
                    err += "音声ファイル名が指定されていません\n";
                    break;
                }
            }

            // 必要事項が埋まっていなかった場合，エラーを出力する
            if (err.Length > 0)
            {
                MessageBox.Show(err, "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // 動画のファイル名を取得
            string movieFileName = Path.GetFileNameWithoutExtension(MovieFilePathTextBox.Text);
            // 動画の保存先の決定
            string outputPath = "";
            if (useMovieOutputPathCheckBox.Checked)
            {
                outputPath = Path.GetDirectoryName(MovieFilePathTextBox.Text);
                outputPath += $"\\{movieFileName}";
            }
            else
            {
                outputPath = SelectMovieOutputPathTextBox.Text;
            }
            // 保存先フォルダがなければ生成する．
            Directory.CreateDirectory(outputPath);

            // 動画のコーディックを取得する
            MovieCordec movieCordec = MovieCordecComboBox.SelectedItem as MovieCordec;
            string ext = Path.GetExtension(MovieFilePathTextBox.Text);

            // コマンドを作成する
            string sepalateCMD = "";
            // 動画を抽出するコマンド
            sepalateCMD += "-i ";
            sepalateCMD += $"\"{MovieFilePathTextBox.Text}\" ";
            string movieFilePath = "";
            if(movieCordec.cordec == MOVIE_CORDEC.COPY)
            {
                movieFilePath = $"{outputPath}\\{movieFileName}{ext}";
            }
            else
            {
                movieFilePath = $"-map 0:0? -vcodec {movieCordec.option} \"{outputPath}\\{movieFileName}{movieCordec.extension} ";
            }
            sepalateCMD += $"-map 0:0? -vcodec {movieCordec.option} \"{movieFilePath}\" ";

            // 音声を抽出するコマンド
            AudioCordec audioCordec = AudioCordecComboBox.SelectedItem as AudioCordec;
            int map = 0;
            foreach (OutputOptionItem item in _outputOptionList)
            {
                map++;
                if (!item.isOutput) continue;
                string audioFilePath = outputPath + "\\" + item.fileName.Replace("%MOVIENAME%", movieFileName).Replace("%TRUCKNUM%", map.ToString()) + audioCordec.extension;
                sepalateCMD += $"-map 0:{map}? -vn -acodec {audioCordec.option} \"{audioFilePath}\" ";
            }

            // 分解
            runFFmpegCmd(sepalateCMD).WaitForExit();

            // 音声を合成
            string audioMixedCMD = "";
            map = 0;
            int audioNum = 0;
            foreach (OutputOptionItem item in _outputOptionList)
            {
                map++;
                if (!(item.isReCombination && item.isOutput)) continue;
                audioNum++;
                string filepath = outputPath + "\\" + item.fileName.Replace("%MOVIENAME%", movieFileName).Replace("%TRUCKNUM%", map.ToString()) + audioCordec.extension;
                audioMixedCMD += $"-i \"{filepath}\" ";
            }

            // 音声を合成しないなら終了
            if (audioNum == 0) return;

            // 音声が複数ある場合，それを合成する
            if(audioNum > 1)
            {
                audioMixedCMD += "-filter_complex ";
                audioMixedCMD += $"amix={audioNum} -y \"{outputPath}\\temp.m4a\"";

                runFFmpegCmd(audioMixedCMD).WaitForExit();
            }

            // 音声と動画を再合成する
            string reconbinationCMD = $"-i \"{movieFilePath}\" ";
            if (audioNum > 1)
            {
                reconbinationCMD += $"-i \"{outputPath}\\temp.m4a\" ";
            }
            else
            {
                reconbinationCMD += audioMixedCMD;
            }
            reconbinationCMD += $"-vcodec copy -acodec copy \"{outputPath}\\{movieFileName}_Miexed{ext}\"";

            runFFmpegCmd(reconbinationCMD).WaitForExit();

            // 一時的に作成した音声合成データは削除する
            if (File.Exists($"{movieFilePath}\\temp.m4a")) File.Delete($"{movieFilePath}\\temp.m4a");
        }
    }
}
