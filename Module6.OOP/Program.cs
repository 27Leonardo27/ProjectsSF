namespace Module6.OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human = new Human("Дмитрий");
            human.Greetings();

            human = new Human("Дмитрий", 23);
            human.Greetings();

            Console.ReadKey();
        }
    }

    class Human
    {
        public string name;
        public int age;

        public void Greetings()
        {
            Console.WriteLine("My name is {0}, my age is {1}", name, age);
        }

        public Human()
        {
            name = "Unknow";
            age = 20;
        }

        public Human(string n)
        {
            name = n;
            age = 20;
        }

        public Human(string n, int a)
        {
            name = n;
            age = a;
        }
    }

    struct Animal
    {
        public string type;
        public string name;
        public int age;

        public void Info()
        {
            Console.WriteLine("This is {0} named {1} he is {2} old");
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;
        }

        public Pen(string penColor, int penCost)
        {
            color = penColor;
            cost = penCost;
        }

    }

    class Rectangle
    {
        public int a;
        public int b;

        public Rectangle()
        {
            a = 6;
            b = 4;
        }

        public Rectangle(int side)
        {
            a = side;
            b = side;
        }

        public Rectangle(int first, int second)
        {
            a = first;
            b = second;
        }

        public int Square()
        {
            return a * b;   
        }

    }
}
