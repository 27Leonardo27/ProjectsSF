using System.Security.Cryptography.X509Certificates;

namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter u name:");
            var name = Console.ReadLine();

            Console.WriteLine("Your name on the opposite:");

            for(int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i] + " ");
            }

            Console.ReadKey();
        }
    }
}