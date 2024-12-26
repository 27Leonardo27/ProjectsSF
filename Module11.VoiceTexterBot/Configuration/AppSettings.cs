using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11.VoiceTexterBot.Configuration
{
    public class AppSettings
    {
        public string BotToken { get; set; }

        public string DownloadsFolder { get; set; }  // Папка загрузки аудио файлов

        public string AudioFileName { get; set; }  // Имя файла при загрузке

        public string InputAudioFormat { get; set; }  // Формат аудио при загрузке

        public string OutputAudioFormat { get; set; }

        public float InputAudioBitrate { get; set; }  // Битрейт аудио при загрузке
    }
}
