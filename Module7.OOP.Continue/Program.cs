namespace Module7.OOP.Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }


    }

    class Car
    {
        public double Fuel;

        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }

        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }

        public void FillTheCar()
        {
            Fuel = 50;
        }
    }

    enum FuelType
    {
        Gas = 0,
        Electricity
    }

    class HybridCar : Car
    {
        public FuelType FuelType;

        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }

    class Employee
    {
        public string Name;
        public int Age;
        public int Salary;
    }

    class ProjectManager: Employee
    {
        public string ProjectName;
    }

    class Developer: Employee
    {
        private string ProgrammingLanguage;
    }

    class Food 
    {

    }

    class Fruit : Food 
    {

    }

    class Vegetable : Food
    { 

    }

    class Apple : Fruit
    {

    }

    class Banana : Fruit
    {

    }

    class Pear : Fruit 
    { 

    }

    class Potato : Vegetable
    {

    }

    class Carrot : Vegetable
    { 

    }

    
}
