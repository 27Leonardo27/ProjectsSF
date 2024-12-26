using Module11.UtilityBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11.UtilityBot.Services
{
    public interface IStorage
    {
        Session GetSession(long chatId);
    }
}
