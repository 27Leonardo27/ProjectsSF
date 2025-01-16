using System.Diagnostics;

namespace Module13.Collections.HW_13._6._1_LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Произведем замеры по времени вставки в коллекцию LinkedList.");    // вступительный текст
            Console.WriteLine("Вставляем текст размером в 933'318 символов...");    // общая информация о тексте (вставляем мы не символы ,а строковую переменную в коллекцию)
            Thread.Sleep(3000);

            LinkedList<string> list = new LinkedList<string>();     // создаем коллекцию

            string textArray = File.ReadAllText("C:\\Users\\12dol\\OneDrive\\Рабочий стол\\input.txt");     // вводим наш текст в переменную

            var sw = Stopwatch.StartNew();

            for (int i = 0; i < 10; i++)
            {
                list.AddLast(textArray);  // вставляем переменную в нашу коллекцию 10 раз
            }

            Console.WriteLine($"Результат вставки в LinkedList: {sw.Elapsed.TotalMilliseconds} мс");  // результат вставки по времени

            Console.WriteLine(list.Count);
        }
    }
}
