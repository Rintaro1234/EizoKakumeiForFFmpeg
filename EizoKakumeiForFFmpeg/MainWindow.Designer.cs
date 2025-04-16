namespace EizoKakumeiForFFmpeg
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieThumbnailPanel = new System.Windows.Forms.Panel();
            this.MovieNameLabel = new System.Windows.Forms.Label();
            this.thumbnailImage = new System.Windows.Forms.PictureBox();
            this.OpenMovie = new System.Windows.Forms.Button();
            this.MovieFilePathTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.OutputSettingGroup = new System.Windows.Forms.GroupBox();
            this.StartProcessButton = new System.Windows.Forms.Button();
            this.outputAudioSettingGrid = new System.Windows.Forms.DataGridView();
            this.trackNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isOutputDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isReCombinationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.outputOptionItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AudioCordecComboBox = new System.Windows.Forms.ComboBox();
            this.AudioCordecLabel = new System.Windows.Forms.Label();
            this.MovieCordecComboBox = new System.Windows.Forms.ComboBox();
            this.MovieCordecLabel = new System.Windows.Forms.Label();
            this.TrackNumLabel = new System.Windows.Forms.Label();
            this.TrackNumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AppSettingGroup = new System.Windows.Forms.GroupBox();
            this.SelectMovieOutputPathButton = new System.Windows.Forms.Button();
            this.useMovieOutputPathCheckBox = new System.Windows.Forms.CheckBox();
            this.SelectMovieOutputPathTextBox = new System.Windows.Forms.TextBox();
            this.OutputPathLabel = new System.Windows.Forms.Label();
            this.SelectFFmpegPathButton = new System.Windows.Forms.Button();
            this.useEnvironmentVariableCheckBox = new System.Windows.Forms.CheckBox();
            this.FFmpegPathTextBox = new System.Windows.Forms.TextBox();
            this.FFmpegPath = new System.Windows.Forms.Label();
            this.MovieGroupBox.SuspendLayout();
            this.MovieThumbnailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).BeginInit();
            this.OutputSettingGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputAudioSettingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputOptionItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackNumNumericUpDown)).BeginInit();
            this.AppSettingGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.MovieThumbnailPanel);
            this.MovieGroupBox.Controls.Add(this.OpenMovie);
            this.MovieGroupBox.Controls.Add(this.MovieFilePathTextBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(312, 226);
            this.MovieGroupBox.TabIndex = 0;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "動画";
            // 
            // MovieThumbnailPanel
            // 
            this.MovieThumbnailPanel.AllowDrop = true;
            this.MovieThumbnailPanel.Controls.Add(this.MovieNameLabel);
            this.MovieThumbnailPanel.Controls.Add(this.thumbnailImage);
            this.MovieThumbnailPanel.Location = new System.Drawing.Point(8, 18);
            this.MovieThumbnailPanel.Name = "MovieThumbnailPanel";
            this.MovieThumbnailPanel.Size = new System.Drawing.Size(298, 170);
            this.MovieThumbnailPanel.TabIndex = 3;
            this.MovieThumbnailPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.MovieThumbnailPanel_DragDrop);
            this.MovieThumbnailPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.MovieThumbnailPanel_DragEnter);
            // 
            // MovieNameLabel
            // 
            this.MovieNameLabel.AutoSize = true;
            this.MovieNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.MovieNameLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.MovieNameLabel.Location = new System.Drawing.Point(3, 8);
            this.MovieNameLabel.MaximumSize = new System.Drawing.Size(290, 20);
            this.MovieNameLabel.Name = "MovieNameLabel";
            this.MovieNameLabel.Size = new System.Drawing.Size(0, 16);
            this.MovieNameLabel.TabIndex = 3;
            // 
            // thumbnailImage
            // 
            this.thumbnailImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnailImage.Image = global::EizoKakumeiForFFmpeg.Properties.Resources.DragDropHere;
            this.thumbnailImage.InitialImage = null;
            this.thumbnailImage.Location = new System.Drawing.Point(0, 0);
            this.thumbnailImage.Name = "thumbnailImage";
            this.thumbnailImage.Size = new System.Drawing.Size(298, 170);
            this.thumbnailImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.thumbnailImage.TabIndex = 2;
            this.thumbnailImage.TabStop = false;
            // 
            // OpenMovie
            // 
            this.OpenMovie.Location = new System.Drawing.Point(231, 192);
            this.OpenMovie.Name = "OpenMovie";
            this.OpenMovie.Size = new System.Drawing.Size(75, 23);
            this.OpenMovie.TabIndex = 3;
            this.OpenMovie.Text = "開く";
            this.OpenMovie.UseVisualStyleBackColor = true;
            this.OpenMovie.Click += new System.EventHandler(this.OpenMovie_Click);
            // 
            // MovieFilePathTextBox
            // 
            this.MovieFilePathTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.MovieFilePathTextBox.Location = new System.Drawing.Point(7, 194);
            this.MovieFilePathTextBox.Name = "MovieFilePathTextBox";
            this.MovieFilePathTextBox.Size = new System.Drawing.Size(222, 19);
            this.MovieFilePathTextBox.TabIndex = 1;
            this.MovieFilePathTextBox.TextChanged += new System.EventHandler(this.MovieFilePath_TextChanged);
            // 
            // OutputSettingGroup
            // 
            this.OutputSettingGroup.Controls.Add(this.StartProcessButton);
            this.OutputSettingGroup.Controls.Add(this.outputAudioSettingGrid);
            this.OutputSettingGroup.Controls.Add(this.AudioCordecComboBox);
            this.OutputSettingGroup.Controls.Add(this.AudioCordecLabel);
            this.OutputSettingGroup.Controls.Add(this.MovieCordecComboBox);
            this.OutputSettingGroup.Controls.Add(this.MovieCordecLabel);
            this.OutputSettingGroup.Controls.Add(this.TrackNumLabel);
            this.OutputSettingGroup.Controls.Add(this.TrackNumNumericUpDown);
            this.OutputSettingGroup.Location = new System.Drawing.Point(12, 244);
            this.OutputSettingGroup.Name = "OutputSettingGroup";
            this.OutputSettingGroup.Size = new System.Drawing.Size(680, 234);
            this.OutputSettingGroup.TabIndex = 1;
            this.OutputSettingGroup.TabStop = false;
            this.OutputSettingGroup.Text = "出力設定";
            // 
            // StartProcessButton
            // 
            this.StartProcessButton.Location = new System.Drawing.Point(599, 201);
            this.StartProcessButton.Name = "StartProcessButton";
            this.StartProcessButton.Size = new System.Drawing.Size(75, 23);
            this.StartProcessButton.TabIndex = 7;
            this.StartProcessButton.Text = "出力";
            this.StartProcessButton.UseVisualStyleBackColor = true;
            this.StartProcessButton.Click += new System.EventHandler(this.StartProcessButton_Click);
            // 
            // outputAudioSettingGrid
            // 
            this.outputAudioSettingGrid.AllowUserToAddRows = false;
            this.outputAudioSettingGrid.AllowUserToDeleteRows = false;
            this.outputAudioSettingGrid.AutoGenerateColumns = false;
            this.outputAudioSettingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputAudioSettingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackNumberDataGridViewTextBoxColumn,
            this.isOutputDataGridViewCheckBoxColumn,
            this.fileNameDataGridViewTextBoxColumn,
            this.isReCombinationDataGridViewCheckBoxColumn});
            this.outputAudioSettingGrid.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EizoKakumeiForFFmpeg.Properties.Settings.Default, "outputAudioSetting", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.outputAudioSettingGrid.DataSource = this.outputOptionItemBindingSource;
            this.outputAudioSettingGrid.Location = new System.Drawing.Point(8, 18);
            this.outputAudioSettingGrid.MultiSelect = false;
            this.outputAudioSettingGrid.Name = "outputAudioSettingGrid";
            this.outputAudioSettingGrid.RowTemplate.Height = 21;
            this.outputAudioSettingGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.outputAudioSettingGrid.Size = new System.Drawing.Size(666, 176);
            this.outputAudioSettingGrid.TabIndex = 6;
            // 
            // trackNumberDataGridViewTextBoxColumn
            // 
            this.trackNumberDataGridViewTextBoxColumn.DataPropertyName = "trackNumber";
            this.trackNumberDataGridViewTextBoxColumn.HeaderText = "trackNumber";
            this.trackNumberDataGridViewTextBoxColumn.Name = "trackNumberDataGridViewTextBoxColumn";
            // 
            // isOutputDataGridViewCheckBoxColumn
            // 
            this.isOutputDataGridViewCheckBoxColumn.DataPropertyName = "isOutput";
            this.isOutputDataGridViewCheckBoxColumn.HeaderText = "isOutput";
            this.isOutputDataGridViewCheckBoxColumn.Name = "isOutputDataGridViewCheckBoxColumn";
            // 
            // fileNameDataGridViewTextBoxColumn
            // 
            this.fileNameDataGridViewTextBoxColumn.DataPropertyName = "fileName";
            this.fileNameDataGridViewTextBoxColumn.HeaderText = "fileName";
            this.fileNameDataGridViewTextBoxColumn.Name = "fileNameDataGridViewTextBoxColumn";
            // 
            // isReCombinationDataGridViewCheckBoxColumn
            // 
            this.isReCombinationDataGridViewCheckBoxColumn.DataPropertyName = "isReCombination";
            this.isReCombinationDataGridViewCheckBoxColumn.HeaderText = "isReCombination";
            this.isReCombinationDataGridViewCheckBoxColumn.Name = "isReCombinationDataGridViewCheckBoxColumn";
            // 
            // outputOptionItemBindingSource
            // 
            this.outputOptionItemBindingSource.DataSource = typeof(EizoKakumeiForFFmpeg.OutputOptionItem);
            // 
            // AudioCordecComboBox
            // 
            this.AudioCordecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AudioCordecComboBox.DropDownWidth = 150;
            this.AudioCordecComboBox.FormattingEnabled = true;
            this.AudioCordecComboBox.Location = new System.Drawing.Point(386, 202);
            this.AudioCordecComboBox.Name = "AudioCordecComboBox";
            this.AudioCordecComboBox.Size = new System.Drawing.Size(55, 20);
            this.AudioCordecComboBox.TabIndex = 5;
            // 
            // AudioCordecLabel
            // 
            this.AudioCordecLabel.AutoSize = true;
            this.AudioCordecLabel.Location = new System.Drawing.Point(295, 208);
            this.AudioCordecLabel.Name = "AudioCordecLabel";
            this.AudioCordecLabel.Size = new System.Drawing.Size(85, 12);
            this.AudioCordecLabel.TabIndex = 4;
            this.AudioCordecLabel.Text = "音声コーディック：";
            // 
            // MovieCordecComboBox
            // 
            this.MovieCordecComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MovieCordecComboBox.DropDownWidth = 150;
            this.MovieCordecComboBox.FormattingEnabled = true;
            this.MovieCordecComboBox.Location = new System.Drawing.Point(234, 202);
            this.MovieCordecComboBox.Name = "MovieCordecComboBox";
            this.MovieCordecComboBox.Size = new System.Drawing.Size(55, 20);
            this.MovieCordecComboBox.TabIndex = 3;
            // 
            // MovieCordecLabel
            // 
            this.MovieCordecLabel.AutoSize = true;
            this.MovieCordecLabel.Location = new System.Drawing.Point(143, 208);
            this.MovieCordecLabel.Name = "MovieCordecLabel";
            this.MovieCordecLabel.Size = new System.Drawing.Size(85, 12);
            this.MovieCordecLabel.TabIndex = 2;
            this.MovieCordecLabel.Text = "映像コーディック：";
            // 
            // TrackNumLabel
            // 
            this.TrackNumLabel.AutoSize = true;
            this.TrackNumLabel.Location = new System.Drawing.Point(6, 208);
            this.TrackNumLabel.Name = "TrackNumLabel";
            this.TrackNumLabel.Size = new System.Drawing.Size(78, 12);
            this.TrackNumLabel.TabIndex = 1;
            this.TrackNumLabel.Text = "音声トラック数：";
            // 
            // TrackNumNumericUpDown
            // 
            this.TrackNumNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::EizoKakumeiForFFmpeg.Properties.Settings.Default, "TrackNumNumeric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TrackNumNumericUpDown.Location = new System.Drawing.Point(90, 203);
            this.TrackNumNumericUpDown.Name = "TrackNumNumericUpDown";
            this.TrackNumNumericUpDown.Size = new System.Drawing.Size(47, 19);
            this.TrackNumNumericUpDown.TabIndex = 0;
            this.TrackNumNumericUpDown.Value = global::EizoKakumeiForFFmpeg.Properties.Settings.Default.TrackNumNumeric;
            this.TrackNumNumericUpDown.ValueChanged += new System.EventHandler(this.TrackNumNumericUpDown_ValueChanged);
            // 
            // AppSettingGroup
            // 
            this.AppSettingGroup.Controls.Add(this.SelectMovieOutputPathButton);
            this.AppSettingGroup.Controls.Add(this.useMovieOutputPathCheckBox);
            this.AppSettingGroup.Controls.Add(this.SelectMovieOutputPathTextBox);
            this.AppSettingGroup.Controls.Add(this.OutputPathLabel);
            this.AppSettingGroup.Controls.Add(this.SelectFFmpegPathButton);
            this.AppSettingGroup.Controls.Add(this.useEnvironmentVariableCheckBox);
            this.AppSettingGroup.Controls.Add(this.FFmpegPathTextBox);
            this.AppSettingGroup.Controls.Add(this.FFmpegPath);
            this.AppSettingGroup.Location = new System.Drawing.Point(345, 12);
            this.AppSettingGroup.Name = "AppSettingGroup";
            this.AppSettingGroup.Size = new System.Drawing.Size(341, 226);
            this.AppSettingGroup.TabIndex = 2;
            this.AppSettingGroup.TabStop = false;
            this.AppSettingGroup.Text = "アプリ設定";
            // 
            // SelectMovieOutputPathButton
            // 
            this.SelectMovieOutputPathButton.Location = new System.Drawing.Point(260, 108);
            this.SelectMovieOutputPathButton.Name = "SelectMovieOutputPathButton";
            this.SelectMovieOutputPathButton.Size = new System.Drawing.Size(75, 23);
            this.SelectMovieOutputPathButton.TabIndex = 8;
            this.SelectMovieOutputPathButton.Text = "開く";
            this.SelectMovieOutputPathButton.UseVisualStyleBackColor = true;
            this.SelectMovieOutputPathButton.Click += new System.EventHandler(this.SelectMovieOutputPathButton_Click);
            // 
            // useMovieOutputPathCheckBox
            // 
            this.useMovieOutputPathCheckBox.AutoSize = true;
            this.useMovieOutputPathCheckBox.Checked = global::EizoKakumeiForFFmpeg.Properties.Settings.Default.useMovieOutputPath;
            this.useMovieOutputPathCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EizoKakumeiForFFmpeg.Properties.Settings.Default, "useMovieOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useMovieOutputPathCheckBox.Location = new System.Drawing.Point(178, 86);
            this.useMovieOutputPathCheckBox.Name = "useMovieOutputPathCheckBox";
            this.useMovieOutputPathCheckBox.Size = new System.Drawing.Size(157, 16);
            this.useMovieOutputPathCheckBox.TabIndex = 7;
            this.useMovieOutputPathCheckBox.Text = "元動画の保存フォルダを使う";
            this.useMovieOutputPathCheckBox.UseVisualStyleBackColor = true;
            this.useMovieOutputPathCheckBox.CheckedChanged += new System.EventHandler(this.useMovieOutputPathCheckBox_CheckedChanged);
            // 
            // SelectMovieOutputPathTextBox
            // 
            this.SelectMovieOutputPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EizoKakumeiForFFmpeg.Properties.Settings.Default, "MovieOutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SelectMovieOutputPathTextBox.Location = new System.Drawing.Point(14, 110);
            this.SelectMovieOutputPathTextBox.Name = "SelectMovieOutputPathTextBox";
            this.SelectMovieOutputPathTextBox.Size = new System.Drawing.Size(240, 19);
            this.SelectMovieOutputPathTextBox.TabIndex = 6;
            this.SelectMovieOutputPathTextBox.Text = global::EizoKakumeiForFFmpeg.Properties.Settings.Default.MovieOutputPath;
            // 
            // OutputPathLabel
            // 
            this.OutputPathLabel.AutoSize = true;
            this.OutputPathLabel.Location = new System.Drawing.Point(12, 87);
            this.OutputPathLabel.Name = "OutputPathLabel";
            this.OutputPathLabel.Size = new System.Drawing.Size(76, 12);
            this.OutputPathLabel.TabIndex = 5;
            this.OutputPathLabel.Text = "保存先フォルダ";
            // 
            // SelectFFmpegPathButton
            // 
            this.SelectFFmpegPathButton.Enabled = false;
            this.SelectFFmpegPathButton.Location = new System.Drawing.Point(260, 51);
            this.SelectFFmpegPathButton.Name = "SelectFFmpegPathButton";
            this.SelectFFmpegPathButton.Size = new System.Drawing.Size(75, 23);
            this.SelectFFmpegPathButton.TabIndex = 4;
            this.SelectFFmpegPathButton.Text = "開く";
            this.SelectFFmpegPathButton.UseVisualStyleBackColor = true;
            this.SelectFFmpegPathButton.Click += new System.EventHandler(this.SelectFFmpegPathButton_Click);
            // 
            // useEnvironmentVariableCheckBox
            // 
            this.useEnvironmentVariableCheckBox.AutoSize = true;
            this.useEnvironmentVariableCheckBox.Checked = global::EizoKakumeiForFFmpeg.Properties.Settings.Default.useEnvironmentFFmpeg;
            this.useEnvironmentVariableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::EizoKakumeiForFFmpeg.Properties.Settings.Default, "useEnvironmentFFmpeg", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useEnvironmentVariableCheckBox.Location = new System.Drawing.Point(235, 29);
            this.useEnvironmentVariableCheckBox.Name = "useEnvironmentVariableCheckBox";
            this.useEnvironmentVariableCheckBox.Size = new System.Drawing.Size(100, 16);
            this.useEnvironmentVariableCheckBox.TabIndex = 2;
            this.useEnvironmentVariableCheckBox.Text = "環境変数を使う";
            this.useEnvironmentVariableCheckBox.UseVisualStyleBackColor = true;
            this.useEnvironmentVariableCheckBox.CheckedChanged += new System.EventHandler(this.useEnvironmentVariableCheckBox_CheckedChanged);
            // 
            // FFmpegPathTextBox
            // 
            this.FFmpegPathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::EizoKakumeiForFFmpeg.Properties.Settings.Default, "ffmpegPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FFmpegPathTextBox.Enabled = false;
            this.FFmpegPathTextBox.Location = new System.Drawing.Point(14, 53);
            this.FFmpegPathTextBox.Name = "FFmpegPathTextBox";
            this.FFmpegPathTextBox.Size = new System.Drawing.Size(240, 19);
            this.FFmpegPathTextBox.TabIndex = 1;
            this.FFmpegPathTextBox.Text = global::EizoKakumeiForFFmpeg.Properties.Settings.Default.ffmpegPath;
            this.FFmpegPathTextBox.TextChanged += new System.EventHandler(this.FFmpegPathTextBox_TextChanged);
            // 
            // FFmpegPath
            // 
            this.FFmpegPath.AutoSize = true;
            this.FFmpegPath.Location = new System.Drawing.Point(12, 30);
            this.FFmpegPath.Name = "FFmpegPath";
            this.FFmpegPath.Size = new System.Drawing.Size(100, 12);
            this.FFmpegPath.TabIndex = 0;
            this.FFmpegPath.Text = "FFmpeg.exeの場所";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 489);
            this.Controls.Add(this.AppSettingGroup);
            this.Controls.Add(this.OutputSettingGroup);
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MainWindow";
            this.Text = "映像革命";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.MovieThumbnailPanel.ResumeLayout(false);
            this.MovieThumbnailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnailImage)).EndInit();
            this.OutputSettingGroup.ResumeLayout(false);
            this.OutputSettingGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputAudioSettingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputOptionItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackNumNumericUpDown)).EndInit();
            this.AppSettingGroup.ResumeLayout(false);
            this.AppSettingGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.PictureBox thumbnailImage;
        private System.Windows.Forms.TextBox MovieFilePathTextBox;
        private System.Windows.Forms.Button OpenMovie;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox OutputSettingGroup;
        private System.Windows.Forms.Label MovieCordecLabel;
        private System.Windows.Forms.Label TrackNumLabel;
        private System.Windows.Forms.NumericUpDown TrackNumNumericUpDown;
        private System.Windows.Forms.DataGridView outputAudioSettingGrid;
        private System.Windows.Forms.ComboBox AudioCordecComboBox;
        private System.Windows.Forms.Label AudioCordecLabel;
        private System.Windows.Forms.ComboBox MovieCordecComboBox;
        private System.Windows.Forms.Button StartProcessButton;
        private System.Windows.Forms.GroupBox AppSettingGroup;
        private System.Windows.Forms.TextBox FFmpegPathTextBox;
        private System.Windows.Forms.Label FFmpegPath;
        private System.Windows.Forms.CheckBox useEnvironmentVariableCheckBox;
        private System.Windows.Forms.Button SelectMovieOutputPathButton;
        private System.Windows.Forms.CheckBox useMovieOutputPathCheckBox;
        private System.Windows.Forms.TextBox SelectMovieOutputPathTextBox;
        private System.Windows.Forms.Label OutputPathLabel;
        private System.Windows.Forms.Button SelectFFmpegPathButton;
        private System.Windows.Forms.Panel MovieThumbnailPanel;
        internal System.Windows.Forms.Label MovieNameLabel;
        private System.Windows.Forms.BindingSource outputOptionItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isOutputDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isReCombinationDataGridViewCheckBoxColumn;
    }
}

