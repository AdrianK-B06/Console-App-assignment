
using System;
using System.Collections.Concurrent;
using System.Runtime.ConstrainedExecution;

namespace MyCsharp
{

    class Program
    {
        static void Main()
        {
            // Main method that acts as the entry point for the application

            Program myProgram = new Program();

            // Prints various predefined variables
            PrintVars();

            // Prints a list of car brands
            PrintCars();

            // Prints a shopping list
            PrintList();

            // Create a new person instance and print their details
            Person person = new("Ola Nordmann", 42);

            Console.WriteLine("Name: " + person.Name);

            Console.WriteLine("Age: " + person.Age);

            // Perform some arithmetic operations and print results
            Numbers();

            // Splits a sentence into words and print each word
            Split();

            // Create a dog instance and make it "speak"
            Dog dog = new();
            dog.Speak();

            // Calculate and display the estimated population growth
            PeopleOnEarth();
        }

        public static void PrintVars()
        {
            // Definere variabler
            int age = 42;
            string Name = "Ola Nordmann";
            double Temp = 13.37;

            // Print variabler
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Temp: " + Temp + " Celsius");

        }

        public static void PrintCars()
        {
            // Initialize and print car brands
            string[] cars = { "Bmw", "Audi", "Mercedes" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine("Car: " + cars[i]);
            }
        }

        public class ShoppingList
        {
            // List to hold shopping items
            private readonly List<string> items = new();

            public ShoppingList()
            {
                items = new List<string>();
            }

            // Add an item to the shopping list
            public void AddItem(string item)
            {
                items.Add(item);
            }

            // Print all items in the shopping list
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
            // Create a ShoppingList instance and print items
            ShoppingList myShoppingList = new();
            myShoppingList.AddItem("Milk");
            myShoppingList.AddItem("Eggs");
            myShoppingList.AddItem("Bread");

            myShoppingList.PrintItems();
        }

        public class Person
        {
            // Properties for Person
            public string Name { get; set; }
            public int Age { get; set; }

            // Constructor to initialize a new Person
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }

        static void Numbers()
        {
            // Perform arithmetic with integers and decimals, then print
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

        public static void Split()
        {
            // Split a string into substrings and print each substring
            string text = "Det er artig å lære C#.";

            string[] subs = text.Split(' ');

            foreach (var sub in subs)
            {
                Console.WriteLine($"Substring: {sub}");
            }
        }

        interface IAnimal
        {
            // Define a method that all animals should implement
            void Speak();
        }

        class Dog : IAnimal
        {
            // Implement the Speak method for Dog
            public void Speak()
            {
                Console.WriteLine("Woof!");
            }
        }


        static void PeopleOnEarth()
        {
            int startYear = 1950;
            int endYear = 2024;
            double startPopulation = 2.5e9; // Start population in billions
            double annualGrowthRate = 0.016; // Annual growth rate of 1.60%

            Console.WriteLine("Year\tPopulation (in billions)");
            Console.WriteLine("==========================");

            for (int year = startYear; year <= endYear; year++)
            {
                double yearsElapsed = year - startYear;
                double population = startPopulation * Math.Pow(1 + annualGrowthRate, yearsElapsed);
                Console.WriteLine($"{year}\t{population / 1e9:0.##} billion");
            }
        }


    }
}
