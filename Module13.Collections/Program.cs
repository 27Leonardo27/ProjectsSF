namespace Module13.Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, -5, 0, 23, -4 };
            Console.WriteLine(CheckArray(array));
        }

        static bool CheckArray(int[] numbers)
        {
            //  используем цикл for для обхода массива
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //  проверяем следующий элемент на предмет того, что он меньше предыдушего
                if (numbers[i + 1] < numbers[i])
                    return false;
            }
            return true;
        }
    }
}
