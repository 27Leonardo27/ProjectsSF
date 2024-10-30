namespace Module4.CLR
{
    internal class Program
    {
        static string ShowColor()
        {
            Console.WriteLine("Write u favorite color by small letter");

            var color = Console.ReadLine();

            switch (color)
            {
                case "red":
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red!");
                        break;
                    }
                case "green":
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green!");
                        break;
                    }
                case "cyan":
                    {
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan!");
                        break;
                    }
                default:
                    {
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow!");
                        break;
                    }
            }

            return color;

        }

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(result);

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            return result;
        }

        public static void Main(string[] args)
        {
            GetArrayFromConsole();           

            var favcolors = new string[3];


            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor();
            }

            Console.WriteLine("Your favorite colors:");

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }
            
            Console.ReadKey();

        }
    }    
}