using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace Module18.Patterns_Part2
{
    class CommandDownload : Command
    {
        private readonly string videoId;
        private YoutubeClient client = new YoutubeClient();

        public CommandDownload(string videoId)
        {
            this.videoId = videoId;
        }

        public override void Cancel()
        {
           
        }

        public override void Run()
        {
            Console.WriteLine("Загружаем видео...");
            client.Videos.DownloadAsync(videoId, "video.mp4", builder => builder.SetPreset(ConversionPreset.UltraFast)).GetAwaiter().GetResult();
            Console.WriteLine("Видео загружено!");
        }
    }
}
