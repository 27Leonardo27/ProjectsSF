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
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }
        // Используем метод SelectMany
        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(s  => s.Students).ToArray();
        }
    }    

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }
}