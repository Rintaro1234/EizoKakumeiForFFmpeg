using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EizoKakumeiForFFmpeg
{
    enum MOVIE_CORDEC
    {
        COPY,
        H264,
        H264_NVENC,
        H265,
        HEVC_NVENC,
        VP9,
        AV1
    }

    enum AUDIO_CORDEC
    {
        COPY,
        AAC,
        MP3,
        WMAV1,
        WMAV2,
        PCMS16IE,
        PCMS24IE,
    }

    class MovieCordec
    {
        public readonly MOVIE_CORDEC cordec;
        public readonly string option;
        public readonly string extension;
        public readonly string description;
        public MovieCordec(MOVIE_CORDEC co, string opt, String ext, String desc) 
        {
            this.cordec = co;
            this.option = opt;
            this.extension = ext;
            this.description = desc;
        }

        public override string ToString()
        {
            return this.description;
        }
    }

    class AudioCordec
    {
        public readonly AUDIO_CORDEC cordec;
        public readonly string option;
        public readonly string extension;
        public readonly string description;
        public AudioCordec(AUDIO_CORDEC co, string opt, String ext, String desc)
        {
            this.cordec = co;
            this.option = opt;
            this.extension = ext;
            this.description = desc;
        }

        public override string ToString()
        {
            return this.description;
        }

    }

    internal class CordecList
    {

        public static Dictionary<MOVIE_CORDEC, MovieCordec> MovieCordecOption = new Dictionary<MOVIE_CORDEC, MovieCordec>
        {
            {MOVIE_CORDEC.COPY, new MovieCordec(MOVIE_CORDEC.COPY, "copy", "", "copy") },
            {MOVIE_CORDEC.H264, new MovieCordec(MOVIE_CORDEC.H264, "libx264", ".mp4", "h.264 (mp4)") },
            {MOVIE_CORDEC.H264_NVENC, new MovieCordec(MOVIE_CORDEC.H264_NVENC, "h264_nvenc", ".mp4", "h.264 (mp4) NVIDIA") },
            {MOVIE_CORDEC.H265, new MovieCordec(MOVIE_CORDEC.H265, "libx265", ".mp4", "h.265 (mp4)") },
            {MOVIE_CORDEC.HEVC_NVENC, new MovieCordec(MOVIE_CORDEC.HEVC_NVENC, "hevc_nvenc", ".mp4", "h.265 (mp4) NVIDIA") },
            {MOVIE_CORDEC.VP9, new MovieCordec(MOVIE_CORDEC.VP9, "libvpx-vp9", ".webm", "webm (mp4) 高圧縮・品質") },
            {MOVIE_CORDEC.AV1, new MovieCordec(MOVIE_CORDEC.AV1, "libaom-av1", ".mp4", "av1 (mp4) 高圧縮・品質") },
        };

        public static Dictionary<AUDIO_CORDEC, AudioCordec> AudioCordecOption = new Dictionary<AUDIO_CORDEC, AudioCordec>
        {
            {AUDIO_CORDEC.COPY, new AudioCordec(AUDIO_CORDEC.COPY, "copy", ".m4a", "copy") },
            {AUDIO_CORDEC.AAC, new AudioCordec(AUDIO_CORDEC.AAC, "aac", ".aac", "aac") },
            {AUDIO_CORDEC.MP3, new AudioCordec(AUDIO_CORDEC.MP3, "mp3", ".mp3", "mp3") },
            {AUDIO_CORDEC.WMAV1, new AudioCordec(AUDIO_CORDEC.WMAV1, "wmav1", ".wma", "wma1 (wma)") },
            {AUDIO_CORDEC.WMAV2, new AudioCordec(AUDIO_CORDEC.WMAV2, "wmav2", ".wma", "wma2 (wma)") },
            {AUDIO_CORDEC.PCMS16IE, new AudioCordec(AUDIO_CORDEC.PCMS16IE, "pcm_s16le", ".wav", "PCM 16bit (wav)") },
            {AUDIO_CORDEC.PCMS24IE, new AudioCordec(AUDIO_CORDEC.PCMS24IE, "pcm_s24le", ".wav", "PCM 24bit (wav)")},
        };
    }
}
