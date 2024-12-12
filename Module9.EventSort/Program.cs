namespace Module9.EventSort
{
    internal class Program
    {
        public static event Action<string[]> OnSort;

        private static string[] lastNames =
        {
            "Elfie",
            "Gerson",
            "Bond",
            "Willis",
            "Parker"
        };

        static void Main(string[] args)
        {
            OnSort += Sort;

            Console.WriteLine("Before sort: ");
            foreach(var lastName in lastNames)
            {
                Console.WriteLine(lastName);
            }

            try
            {
                OnSort?.Invoke(lastNames);
            }
            catch (InvalidSortTypeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nAfter sort: ");
            foreach(var lastName in lastNames)
            {
                Console.WriteLine(lastName);
            }

            Console.ReadLine();
        }

        public static void Sort(string[] lastNames)
        {
            Console.Write("Enter sort type (1/2): ");
            var sortType = Console.ReadLine();

            if (sortType != "1" && sortType != "2")
                throw new InvalidSortTypeException("Sort type must be '1' or '2'");

            Array.Sort(lastNames);

            if ( sortType == "2")
                Array.Reverse(lastNames);
        }
    }
}
