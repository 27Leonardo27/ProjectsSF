namespace Module4.CLR
{
    internal class Program
    {
        static string ShowColor(string username, int userage)
        {
            Console.WriteLine("{0}, {1} years \nWrite u favorite color by small letter", username, userage);

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

        static int[] GetArrayFromConsole(ref int num)
        {
            var result = new int[num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }

            return result;
        }

        static void SortArray(in int[] array, out int[] sorteddesc, out int[] sortedasc)
        {
            sortedasc = SortArrayAsc(array.ToArray());
            sorteddesc = SortArrayDesc(array.ToArray());
        }

        static int[] SortArrayAsc(int[] array)
        {
            Array.Sort(array);
            return array;
        }

        static int[] SortArrayDesc(int[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }

        public static void Main(string[] args)
        {
            var Array = new int[] { 41, 69, 1488 };
                
            SortArray(Array, out var sorteddesc, out var sortedasc); 

            var Myage = 12;
            ChangeAge(ref Myage);
            Console.WriteLine(Myage);

            var (name, age) = ("Andrew", 25);

            Console.WriteLine("My name is: {0}", name);            
            Console.WriteLine("My age is: {0}", age);

            Console.Write("Enter name: ");          
            name = Console.ReadLine();
            
            Console.Write("Enter age with numbers: ");           
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your name: {0}", name);            
            Console.WriteLine("Your age: {0}", age);
            

            var favcolors = new string[3];

            for (int i = 0; i < favcolors.Length; i++)
            {
                favcolors[i] = ShowColor(name, age);
            }

            Console.WriteLine("Your favorite colors:");

            foreach (var color in favcolors)
            {
                Console.WriteLine(color);
            }

            var size = 6;

            var array = GetArrayFromConsole(ref size);

            ShowArray(array, true);

              Console.ReadKey();
        }

        static void ChangeAge(ref int age) 
        {
            Console.Write("Enter your age:");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(age);
        }
        static void ShowArray(int[] array, bool sort = false)
        {
            if (sort)
            {
                //SortArray(array);
            }

            foreach (var i in array)
            {
                Console.WriteLine(i);
            }
            
        }
    }    
}