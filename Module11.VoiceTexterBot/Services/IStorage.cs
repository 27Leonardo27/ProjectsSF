using Module11.VoiceTexterBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11.VoiceTexterBot.Services
{
    public interface IStorage
    {
        Session GetSession(long chatId);  // Получение сессии пользователя по идентификатору
    }
}
