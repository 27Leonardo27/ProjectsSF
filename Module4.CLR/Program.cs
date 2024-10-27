using System.Security.Cryptography.X509Certificates;

namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 6, 9, 1, 2, 3, 4, };

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = a + 1; b < arr.Length; b++)
                {
                    if (arr[a] > arr[b])
                    {
                        int c = arr[a];
                        arr[a] = arr[b];
                        arr[b] = c;
                    }
                }

            }

            foreach (var order in arr)
            {
                Console.Write(order);
            }
        }
    }
}