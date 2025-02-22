using YoutubeExplode;
using YoutubeExplode.Search;
using YoutubeExplode.Videos;

namespace Module18.Patterns_Part2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var sender = new Sender();
            Console.Write("Введите ссылку на Youtube-видео: ");
            var id = Console.ReadLine();

            sender.SetCommand(new CommandInfo(id));
            sender.Run();

            sender.SetCommand(new CommandDownload(id));
            sender.Run();
        }
    }
}
