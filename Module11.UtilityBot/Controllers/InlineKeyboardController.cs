using Module11.UtilityBot.Services;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace Module11.UtilityBot.Controllers
{
    internal class InlineKeyboardController
    {
        private readonly IStorage _memoryStorage;
        private readonly ITelegramBotClient _telegramClient;

        public InlineKeyboardController(ITelegramBotClient telegramBotClient, IStorage memoryStorage)
        {
            _telegramClient = telegramBotClient;
            _memoryStorage = memoryStorage;
        }

        public async Task Handle(CallbackQuery? callbackQuery, CancellationToken ct)
        {
            if (callbackQuery?.Data == null)
                return;

            var session = _memoryStorage.GetSession(callbackQuery.From.Id);
            session.Command = callbackQuery.Data;
            
            var command = session.Command switch
            {
                "txt" => "Подсчет кол-ва символов",
                "num" => "Вычисление суммы чисел",
                _ => throw new ArgumentOutOfRangeException()
            };
            
            await _telegramClient.SendMessage(callbackQuery.From.Id, $"Выбрана команда: {command}", cancellationToken: ct);
        }
    }
}
