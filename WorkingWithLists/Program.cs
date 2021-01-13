using System;
using System.Collections.Generic;

namespace WorkingWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // WorkingWithLists();
            Fibonacci();
        }

        static void WorkingWithLists()
        {

            var names = new List<string> { "Harald", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($" Hello, {name.ToUpper()}!");
            }

            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");

            Console.WriteLine($"My name is {names[0]}!");
            Console.WriteLine($"I have added {names[2]} and {names[3]} to the list.");

            Console.WriteLine($"The list contains {names.Count} elements.");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"Item not found. The Index returns {index}.");
            }
            else
            {
                Console.WriteLine($" The name {names[index]} is at index {index}.");
            }

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"{name}");
            }


        }


        static void Fibonacci()
        {

            var fibonacciNumbers = new List<int> { 1, 1 };

            
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                fibonacciNumbers.Add(previous + previous2);
                
            }
            

            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }

        }
    }
}
