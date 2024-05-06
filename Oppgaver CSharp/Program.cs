
using System;
using System.Collections.Concurrent;

namespace MyCsharp
{

    class Program
    {
        static void Main()
        {

            Program myProgram = new Program();

            PrintVars();
            PrintCars();
            PrintList();

            Person person = new("Ola Nordmann", 42);

            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);

            Numbers();
        }

        public static void PrintVars()
        {
            // Definere variabler
            int age = 42;
            string Name = "Ola Nordmann";
            double Temp = 13.37;

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Temp: " + Temp + " Celsius");
        }

        public static void PrintCars()
        {
            string[] cars = { "Bmw", "Audi", "Mercedes" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car: " + cars[i]);
            }
        }

        public class ShoppingList
        {
            private readonly List<string> items;

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
            ShoppingList myShoppingList = new();
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

        static void Numbers()
        {
            int x = 8;
            int y = 5;
            int sum = x + y;

            Console.WriteLine(sum);

            Decimal a1 = 6.5m;
            Decimal a2 = 6.3m;

            Decimal value = Decimal.Add(a1, a2);

            Console.WriteLine("Decimal Sum : {0}", 
                                           value);

        }



    }
}