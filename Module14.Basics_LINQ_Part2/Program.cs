using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Module14.Basics_LINQ_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>();

            // добавляем контакты
            phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
            phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
            phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
            phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
            phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
            phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

            var group = phoneBook.GroupBy(c => c.Mail.Split('@').Last());

            foreach (var group1 in group)
            {
                if (group1.Key.Contains("example"))
                {
                    Console.WriteLine("Fake: ");

                    foreach (var cont in group1)
                    {
                        Console.WriteLine(cont.Name + " " + cont.Mail);
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Real: ");
                    foreach(var cont in group1)
                    {
                        Console.WriteLine(cont.Name + " " + cont.Mail);
                    }
                }
            }
        }
    }

    class Contact
    {
        public Contact(string name, long phone, string mail)
        {
            Name = name;
            Phone = phone;
            Mail = mail;
        }

        public string Name { get; set; }
        public long Phone { get; set; }
        public string Mail { get; set; }
    }
}