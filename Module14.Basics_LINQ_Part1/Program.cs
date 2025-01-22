using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace Module14.Basics_LINQ_Part1;

internal class Program
{
    static void Main(string[] args)
    {
        // создаём пустой список Contact
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", "Брин", 799900000013, "serg@example.com"));
        phoneBook.Add(new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com"));

        // сортируем по имени и затем по фамилии
        var sortedBook = phoneBook
            .OrderBy(s => s.Name)
            .ThenBy(s => s.LastName);

        while (true)
        {
            var input = Console.ReadKey().KeyChar;
            var parsed = Int32.TryParse(input.ToString(), out int pageNumber);


            if (!parsed || pageNumber < 1 || pageNumber > 3)
            {
                Console.WriteLine();
                Console.WriteLine("Страницы не существует");
            }
            else
            {
                var pageCont = sortedBook.Skip((pageNumber - 1) * 2).Take(2);
                Console.WriteLine();
                
                foreach (var ent in pageCont)
                    Console.WriteLine(ent.Name + " " + ent.LastName + ": " + ent.PhoneNumber);

                Console.WriteLine();
            }
        }
    }
}


public class Contact //  класс контактов
{
    public Contact(string name, string lastName, long phoneNumber, String email) // конструктор
    {
        Name = name;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
    }

    public String Name { get; }
    public String LastName { get; }
    public long PhoneNumber { get; }
    public String Email { get; }
}
// Доработайте вашу телефонную книгу из задания 14.2.10 предыдущего юнита так, чтобы контакты телефонной книги были отсортированы сперва по имени, а затем по фамилии.