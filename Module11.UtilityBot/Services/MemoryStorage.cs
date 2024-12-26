using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module11.UtilityBot.Models;

namespace Module11.UtilityBot.Services
{
    public class MemoryStorage : IStorage
    {
        private readonly ConcurrentDictionary<long, Session> _sessions;  // Хранилище сессий

        public MemoryStorage()
        {
            _sessions = new ConcurrentDictionary<long, Session>();
        }

        public Session GetSession(long chatId)
        {
            if (_sessions.ContainsKey(chatId))  // Возвращаем сессию по ключу, если она существует
                return _sessions[chatId];

            var newSession = new Session() { Command = "Text" };  // Создаем и возвращаем новую, если такой не было

            _sessions.TryAdd(chatId, newSession);

            return newSession;
        }
    }
}
