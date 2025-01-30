using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace Module14.Basics_LINQ_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listNumbers = new List<int>();

            while (true)
            {
                Console.WriteLine();
                Console.Write("Введите число: ");

                var input = Console.ReadLine();
                var isInt = int.TryParse(input, out int isNums);

                if (!isInt)
                {
                    Console.WriteLine("Вы ввели не число!");
                    Console.WriteLine();
                }
                else
                {
                    listNumbers.Add(isNums);
                    Console.WriteLine($"Всего в списке - {listNumbers.Count}" +
                         $"\nСумма всех чисел списка - {listNumbers.Sum()}" +
                         $"\nНаименьшее число - {listNumbers.Min()}" +
                         $"\nНаибольшее число - {listNumbers.Max()}" +
                         $"\nСреднее значение всех чисел - {listNumbers.Average()}");
                }
            }
        }
    } 
}
    