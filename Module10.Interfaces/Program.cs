namespace Module10.Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var a = 0;
                var b = 0;

                try
                {
                    Console.Write("Первое число: ");
                    a = int.Parse(Console.ReadLine());

                    Console.Write("Второе число: ");
                    b = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка при вводе числа!");
                    continue;
                }

                var calculator = new Calculator();
                var result = calculator.Sum(a, b);

                Console.WriteLine($"Результат: {result}");

            } while (true);
        }
    }
}
