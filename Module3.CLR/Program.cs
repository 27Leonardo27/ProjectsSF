using System;

namespace Module3.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Andrew";

            Console.WriteLine(MyName);

            Console.WriteLine("\t Привет, мир");
            Console.WriteLine("\t Мне 25 лет");
            Console.WriteLine("\t My name is \n Andrew");
            Console.WriteLine('\u0040');
            Console.WriteLine('\x23');

            Console.ReadKey();
        }

    }
}
