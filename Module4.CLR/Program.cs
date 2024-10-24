using System.Security.Cryptography.X509Certificates;

namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write u favourite color in English with a small letter");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Iteration {0}", i);
                switch (Console.ReadLine())
                {
                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You color is yellow!");
                        break;
                }
            }

            Console.WriteLine("Цикл while");

            
                int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number:");

                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                {
                    continue;
                }
                else if (number == 0)
                {
                    break;
                }

                sum += number;

                Console.WriteLine($"Total amount:{sum}");
            }

            Console.WriteLine("Цикл do while");

            int t = 0;

            do
            {
                Console.WriteLine(t);

                Console.WriteLine("Write u favourite color in English with a small letter");

                switch (Console.ReadLine())
                {

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You color is red!");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You color is green!");
                        break;

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("You color is cyan!");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You color is yellow!");
                        break;

                }

                t++;

            } while (t < 3);
        }
    }

}
