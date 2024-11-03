using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace TEST_proj
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            Console.WriteLine(PowerUp(2, 3));

            Console.WriteLine("Write anything");
            var str = Console.ReadLine();

            Console.WriteLine("Select echo depth");
            var deep = int.Parse(Console.ReadLine());

            Echo(str, deep);

            Console.ReadKey();

        }
        static void Echo(string saidworld, int deep)
        {
            var modif = saidworld;

            if (modif.Length > 2)
            {
                modif = modif.Remove(0, 2);
            }

            Console.BackgroundColor = (ConsoleColor)deep;
            Console.WriteLine("..." + modif);

            if (deep > 1)
            {
                Echo(modif, deep - 1);
            }
        }

        static decimal Factorial(int x)
        {
            if (x == 0 && x == 1)
            { 
                return 1;            
            }
            else
            {
                return x * Factorial(x -1);
            }
        }
        
        private static int PowerUp(int N, byte pow)
        {
            if (pow == 0)
            {
                return 1;
            }
            else
            {
                if (pow == 1)
                {
                    return N;
                }
                else
                {
                    return N * PowerUp(N, --pow);
                }
            }
        }
    }
}


