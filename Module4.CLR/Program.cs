using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { -1, 2, 4, -8, 9, 10, -13, 11, 0, 8 };

            int positive = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                { 
                    positive++;
                }

            }

            Console.WriteLine(positive);
        }
    }
}