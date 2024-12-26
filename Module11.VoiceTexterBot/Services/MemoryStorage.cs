using Module11.VoiceTexterBot.Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11.VoiceTexterBot.Services
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
            
            var newSession = new Session() { LanguageCode = "ru" };  // Создаем и возвращаем новую, если такой не было

            _sessions.TryAdd(chatId, newSession);

            return newSession;
        }
    }
}
