using System;

namespace Module3.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numb = 10;
            numb &= 4;
            Console.WriteLine(numb);

            Console.Write("Enter your name: ");
            var MyName = Console.ReadLine();

            Console.Write("Enter your age: ");
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Your name is {MyName} and age is {age}");
            Console.Write("Enter your birthday: ");

            var birthday = Console.ReadLine();
            Console.WriteLine($"Your birthday is {birthday}");

            Console.ReadKey();
      


        }

    }

}





