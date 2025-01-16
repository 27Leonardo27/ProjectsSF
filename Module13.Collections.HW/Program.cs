using System.Diagnostics;

namespace Module13.Collections.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Произведем замеры по времени вставки в коллекцию List.");    // вступительный текст
            Console.WriteLine("Вставляем текст размером в 933'318 символов...");    // общая информация о тексте (вставляем мы не символы ,а строковую переменную в коллекцию)
            Thread.Sleep(3000);

            List<string> list = new List<string>();     // создаем коллекцию

            string textArray = File.ReadAllText("C:\\Users\\12dol\\OneDrive\\Рабочий стол\\input.txt");     // вводим наш текст в переменную

            var sw = Stopwatch.StartNew();

            for (int i = 0; i < 10; i++)
            {
                list.Add(textArray);  // вставляем переменную в нашу коллекцию 10 раз
            }

            Console.WriteLine($"Результат вставки в List: {sw.Elapsed.TotalMilliseconds} мс");  // результат вставки по времени
        }
    }
}
