using Microsoft.Extensions.Hosting;
using Module11.UtilityBot.Controllers;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace Module11.UtilityBot
{
    internal class Bot : BackgroundService
    {
        private ITelegramBotClient _telegramClient;
        private readonly TextMessageController textMessageController;
        private readonly InlineKeyboardController inlineKeyboardController;

        public Bot(
            ITelegramBotClient telegramClient,
            TextMessageController textMessageController,
            InlineKeyboardController inlineKeyboardController)
        {
            _telegramClient = telegramClient;
            this.textMessageController = textMessageController;
            this.inlineKeyboardController = inlineKeyboardController;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _telegramClient.StartReceiving(
                HandleUpdateAsync,
                HandleErrorAsync,
                new ReceiverOptions() { AllowedUpdates = { } }, // Здесь выбираем, какие обновления хотим получать. В данном случае разрешены все
                cancellationToken: stoppingToken);

            Console.WriteLine("Бот запущен");
            return Task.CompletedTask;
        }

        async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {            
            if (update.Type == UpdateType.CallbackQuery)  //  Обрабатываем нажатия на кнопки из Telegram Bot API
            {
                await inlineKeyboardController.Handle(update.CallbackQuery, cancellationToken);
            }
           
            if (update.Type == UpdateType.Message)  // Обрабатываем входящие сообщения из Telegram Bot API
            {
                await textMessageController.Handle(update.Message, cancellationToken);
            }
        }

        Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {          
            var errorMessage = exception switch  // Задаем сообщение об ошибке в зависимости от того, какая именно ошибка произошла
            {
                ApiRequestException apiRequestException
                    => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
                _ => exception.ToString()
            };
          
            Console.WriteLine(errorMessage);  // Выводим в консоль информацию об ошибке
 
            Console.WriteLine("Ожидаем 5 секунд перед повторным подключением.");  // Задержка перед повторным подключением

            Thread.Sleep(5000);

            return Task.CompletedTask;
        }
    }
}
