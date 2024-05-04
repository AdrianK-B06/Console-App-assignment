
using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {

        Program myProgram = new Program();

        myProgram.PrintVars();
        myProgram.PrintCars();
        PrintList();

        Person person = new Person("Ola Nordmann", 42);

        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);

    }

    public void PrintVars()
    {
        // Definere variabler
        int age = 42;
        string Name = "Ola Nordmann";
        double Temp = 13.37;

        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Temp: " + Temp + " Celsius");
    }

    public void PrintCars()
    {
        string[] cars = { "Bmw", "Audi", "Mercedes" };

        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine("Car: " + cars[i]);
        }
    }

    public class ShoppingList
    {
        private List <string> items;

        public ShoppingList()
        {
            items = new List<string>();
        }

        public void AddItem(string item)
        {
            items.Add(item);
        }

        public void PrintItems()
        {
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    static void PrintList()
    {
        ShoppingList myShoppingList = new ShoppingList();
        myShoppingList.AddItem("Milk");
        myShoppingList.AddItem("Eggs");
        myShoppingList.AddItem("Bread");

        myShoppingList.PrintItems();
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

}