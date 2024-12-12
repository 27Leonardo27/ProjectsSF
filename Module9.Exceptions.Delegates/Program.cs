namespace Module9.Exceptions.Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exceptions = new Exception[5];
            exceptions[0] = new NegativeAgeException("Неверный возраст!");
            exceptions[1] = new Exception("Исключение");
            exceptions[2] = new DivideByZeroException("Делить на ноль нельзя!");
            exceptions[3] = new NotImplementedException("Метод не реализован!");
            exceptions[4] = new ArgumentNullException("Пустой аргумент!");

            foreach (var exception in exceptions) 
            {
                try
                {
                    throw exception;
                }
                catch (NegativeAgeException ex)
                {
                    Console.WriteLine("NegativeAgeException");
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("DivideByZeroException");
                    Console.WriteLine(ex.Message);
                }
                catch (NotImplementedException ex)
                {
                    Console.WriteLine("NotImplementedException");
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("ArgumentNullException");
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine(ex.Message);
                }
            }
            
        }

    }

    class NegativeAgeException : Exception 
    {
        public NegativeAgeException(string message)
            : base(message)
        { 
            
        }
    }
}
