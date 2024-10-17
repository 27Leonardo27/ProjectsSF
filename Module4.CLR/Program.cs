namespace Module4.CLR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write u favourite color in English with a small letter");
            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You color is red!");
            }
            else if (color == "green") 
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("You color is cyan!");
            }
        }
    }
}
