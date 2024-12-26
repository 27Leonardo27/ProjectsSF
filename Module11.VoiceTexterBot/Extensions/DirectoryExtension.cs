using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11.VoiceTexterBot.Extensions
{
    public static class DirectoryExtension
    {        
        public static string GetSolutionRoot() // Получаем путь до каталога с .sln файлом
        {
            var dir = Path.GetDirectoryName(Directory.GetCurrentDirectory());
            var fullname = Directory.GetParent(dir).FullName;
            var projectRoot = fullname.Substring(0, fullname.Length - 4);
            return Directory.GetParent(projectRoot)?.FullName;
        }
    }
}
