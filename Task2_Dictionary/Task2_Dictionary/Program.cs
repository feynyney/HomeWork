using System;
using System.Collections.Generic;

namespace Task2_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            AddPerson(dictionary);
            PrintOut(dictionary);
            FindPerson(dictionary);
        }

        static void AddPerson(Dictionary <string,string> dictionary)
        {
            while(true)
            {
                Console.WriteLine("\nAdd name: ");
                string name = Console.ReadLine();

                while (true)
                {
                    Console.WriteLine("\nAdd number: ");
                    string number = Console.ReadLine();

                    dictionary.Add(number, name);

                    Console.WriteLine("\nAdd one more number? y/n");

                    if (Console.ReadKey().Key == ConsoleKey.N) break;
                }

                Console.WriteLine("\nDo you want to add a new person? y/n");

                if (Console.ReadKey().Key == ConsoleKey.N) break; 
            }
            
        }

        static void PrintOut(Dictionary <string,string> dictionary) 
        {
            foreach (var e in dictionary)
            {
                Console.WriteLine($"\n{e}");
            }
        }

        static void FindPerson(Dictionary<string, string> dictionary)
        {
            while(true)
            {
                Console.WriteLine("\nEnter number to find a person: ");
                string num_to_find = Console.ReadLine();

                if (dictionary.TryGetValue(num_to_find, out string name)) Console.WriteLine(name);

                else Console.WriteLine("\nThere is no such person...");

                Console.WriteLine("\nDo you want to find a new person? y/n");

                if (Console.ReadKey().Key == ConsoleKey.N) break;
            }
            

            
        }
    }
}
