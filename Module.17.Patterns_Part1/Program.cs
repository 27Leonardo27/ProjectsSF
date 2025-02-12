using System.Security.AccessControl;

namespace Module._17.Patterns_Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    //создаем отдельный интерфейс
    public interface IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; }

        public void CalculateInterest();
    }
    //различные классы соответствующего типа
    public class SalaryAccount : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; private set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.5;
        }
    }

    public class NormalAccount : IAccount
    {
        public double Balance { get ; set; }
        public double Interest { get; private set; }

        public void CalculateInterest()
        {
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance >= 1000)
                Interest -= Balance * 0.4;
        }
    }

    public static class Calculator
    {
        public static void CalculateInterest(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
