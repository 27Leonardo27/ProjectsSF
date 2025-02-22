using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos;

namespace Module18.Patterns_Part2
{
    class CommandInfo : Command
    {
        private readonly string videoId;
        private YoutubeClient client = new YoutubeClient();

        public CommandInfo(string videoId)
        {
            this.videoId = videoId;
        }

        public override void Cancel()
        {

        }

        public override void Run()
        {
            Console.WriteLine("Запрашиваем информацию о видео...");

            var videoInfo = client.Videos.GetAsync(videoId).Result;

            Console.WriteLine($"Название: {videoInfo.Title}");
            Console.WriteLine($"Описание: {videoInfo.Description}");
        }
    }
}
