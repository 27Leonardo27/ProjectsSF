using System.Security.Cryptography.X509Certificates;

namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4, };

            int amount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                amount += arr[i];
            }

            Console.WriteLine(amount);
        }
    }
}