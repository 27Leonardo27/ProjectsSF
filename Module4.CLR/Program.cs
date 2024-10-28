using System.ComponentModel.Design;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string LastName, string Login, int LoginLength, bool HasPet, string[] favcolors, double Age) User; //task 4.5.2

            for (int k = 0; k < 3; k++)
            {
                Console.Write("Введите имя:");

                User.Name = Console.ReadLine();

                Console.Write("Введите фамилию:");

                User.LastName = Console.ReadLine();

                Console.Write("Введите логин:");

                User.Login = Console.ReadLine();

                User.LoginLength = User.Login.Length; //task 4.5.3

                Console.WriteLine("Есть ли у вас животные? Да или Нет");

                var ansPet = Console.ReadLine();

                if (ansPet == "Да") //task 4.5.4
                {
                    User.HasPet = true;
                }
                else
                {
                    User.HasPet = false;
                }

                Console.WriteLine("Введите возраст пользователя"); //task 4.5.5

                User.Age = double.Parse(Console.ReadLine());

                User.favcolors = new string[3];

                Console.WriteLine("Введите три любимых цвета пользователя");

                for (int i = 0; i < User.favcolors.Length; i++)
                {
                    User.favcolors[i] = Console.ReadLine();
                }
            }
        }
    }
    
}