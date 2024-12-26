using Module11.UtilityBot.Services;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace Module11.UtilityBot.Controllers
{
    public class TextMessageController
    {
        private readonly ITelegramBotClient _telegramClient;
        private readonly IStorage storage;

        public TextMessageController(
            ITelegramBotClient telegramClient,
            IStorage storage)
        {
            _telegramClient = telegramClient;
            this.storage = storage;
        }

        public async Task Handle(Message message, CancellationToken ct)
        {
            if (message.Text == "/start")
            {
                var buttons = new List<InlineKeyboardButton[]>();  // Объект, представляющий кнопки
                buttons.Add(new[]
                {
                    InlineKeyboardButton.WithCallbackData("Длина текста", "txt"),
                    InlineKeyboardButton.WithCallbackData("Сумма чисел", "num")
                });

                // передаем кнопки вместе с сообщением 
                await _telegramClient.SendMessage(
                    message.Chat.Id, 
                    "<b>Выберите, что наш бот должен посчитать.</b>",
                    cancellationToken: ct,
                    parseMode: ParseMode.Html,
                    replyMarkup: new InlineKeyboardMarkup(buttons));
                
                return;
            }
            
            var session = storage.GetSession(message.From.Id);

            switch (session.Command)
            {
                case "txt":
                    await _telegramClient.SendMessage(message.Chat.Id, $"Количество символов: {message.Text.Length}", cancellationToken: ct);
                    break;
                case "num":
                    var sum = 0;

                    foreach (var symbol in message.Text)
                    {
                        if (!char.IsPunctuation(symbol))
                        {
                            int.TryParse(symbol.ToString(), out var num);

                            sum += num;
                        }
                    }
                    
                    await _telegramClient.SendMessage(message.Chat.Id, $"Сумма чисел: {sum}", cancellationToken: ct);
                    break;
                default:
                    await _telegramClient.SendMessage(message.Chat.Id, $"Введено неверное сообщение!", cancellationToken: ct);
                    break;
            }
        }
    }
}
