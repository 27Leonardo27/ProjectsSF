using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11.VoiceTexterBot.Extensions
{
    public static class StringExtension
    {        
        public static string UppercaseFirst(string s)  // Преобразуем строку, чтобы она начиналась с заглавной буквы
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            return char.ToUpper(s[0]) + s.Substring(1);
        }
    }
}
