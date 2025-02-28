using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Text;
using Telegram.Bot;
using Module11.VoiceTexterBot.Controllers;
using Module11.VoiceTexterBot.Services;
using Module11.VoiceTexterBot.Configuration;

namespace Module11.VoiceTexterBot
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            
            var host = new HostBuilder()  // Объект, отвечающий за постоянный жизненный цикл приложения
                .ConfigureServices((hostContext, services) => ConfigureServices(services))  // Задаем конфигурацию
                .UseConsoleLifetime()  // Позволяет поддерживать приложение активным в консоли
                .Build(); // Собираем

            Console.WriteLine("Сервис запущен");
            
            await host.RunAsync();  // Запускаем сервис

            Console.WriteLine("Сервис остановлен");
        }

        static void ConfigureServices(IServiceCollection services)
        {
            AppSettings appSettings = BuildAppSettings();

            services.AddSingleton(appSettings);

            services.AddSingleton<IStorage, MemoryStorage>();

            // Подключаем контроллеры
            services.AddTransient<DefaultMessageController>();
            services.AddTransient<VoiceMessageController>();
            services.AddTransient<TextMessageController>();
            services.AddTransient<InlineKeyboardController>();
           
            services.AddSingleton<ITelegramBotClient>(provider => new TelegramBotClient(appSettings.BotToken));  // Регистрируем объект TelegramBotClient c токеном подключения

            services.AddSingleton<IFileHandler, AudioFileHandler>();

            services.AddHostedService<Bot>();   // Регистрируем постоянно активный сервис бота
        }

        static AppSettings BuildAppSettings()
        {
            return new AppSettings()
            {
                DownloadsFolder = "C:\\Users\\12dol\\Downloads",
                BotToken = "",
                AudioFileName = "audio",
                InputAudioFormat = "ogg",
                OutputAudioFormat = "wav", 
                InputAudioBitrate = 48000,
            };
        }
    }
}
    
