namespace Module12.Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much elements must be in array?");
            var count = int.Parse(Console.ReadLine());

            var array = new string[count];

            for (int i = 0; i < count; i++)
            {
                array[i] = Console.ReadLine();
            }

            Console.WriteLine("All elements are written");
        }
    }
}
