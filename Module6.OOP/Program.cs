﻿namespace Module6.OOP;

internal class Program
{
    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();

        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }

        /*Human human = new Human();
        human.Greetings();

        human = new Human("Дмитрий");
        human.Greetings();

        human = new Human("Дмитрий", 23);
        human.Greetings();

        Console.ReadKey();*/
    }
  
    static Department GetCurrentDepartment()
    {       
        var department = new Department();

        department.City = new City();
        department.City.Name = "Санкт-Петербург";

        department.Company = new Company();
        department.Company.Name = "Sber";
        department.Company.Type = "Банк";

        return department;
    }
}

class Bus
{
    public int? Load;

    public void PrintStatus()
    {
        if (Load.HasValue && Load > 0)
        {
            Console.WriteLine("В автобусе {0} пассажиров", Load.Value);
        }
        else
        {
            Console.WriteLine("Автобус пуст!");
        }
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

class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}

class Circle
{
    public double radius;

    public double Square()
    {

    }

    public double Length()
    {

    }
}

class Triangle
{
    public int a;
    public int b;
    public int c;

    public double Square()
    {

    }

    public double Perimeter()
    {

    }
}

class Square
{
    public int side;

    public double Square()
    {

    }

    public double Perimeter()
    {

    }
}

class TrafficLight
{
    private void ChangeColor(string color)
    {

    }
    
    public string GetColor()
    {
        var color = Console.ReadLine();
        return color;
    }
}

class User
{
    private string login;

    public string Login
    {
        get
        {
            return login;
        }

        set
        {
            if (value.Length < 3)
            {
                Console.WriteLine("Логин должен быть длиной от 3 символов");
            }
            else
            {
                login = value;
            }
        }
    }

    private string email;

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            if (!value.Contains('@'))
            {
                Console.WriteLine("Неверный формат адреса электронной почты");
            }
            else
            {
                email = value;
            }
        }
    }

    private int age;

    public int Age
    {
        get
        {
            return age;
        }

        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст должен быть не меньше 18");
            }
            else
            {
                age = value;
            }
        }
    }
}