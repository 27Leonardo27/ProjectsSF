using System;

namespace Module3.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string MyName = "Andrew";
            byte age = 25;
            bool pet = true;
            double ShoeSize = 42;

            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is " + age);
            Console.WriteLine("Do I have a pet? " + pet);
            Console.WriteLine("My shoe size is " + ShoeSize);
          

            Console.ReadKey();
        }

    }
}
