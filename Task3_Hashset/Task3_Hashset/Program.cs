using System;
using System.Collections.Generic;

namespace Task3_Hashset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            AddElements(set);
        }

        static void AddElements(HashSet<int> set)
        {
            while(true)
            {
                Console.WriteLine("Enter number to add: ");
                int num = int.Parse(Console.ReadLine());

                CheckElement(set, num);

                Console.WriteLine("1 - Add one more number 2 - Show current collection 3 - exit");  
                string choice = Console.ReadLine();

                if (choice == "1") continue;

                else if (choice == "2")
                {
                    PrintOut(set);
                    Console.WriteLine("\nContinue? y/n");
                    string choice2 = Console.ReadLine();
                    if (choice2 == "y") continue;
                    else break;
                }

                else break;
            }
        }

        static void CheckElement(HashSet<int> set , int num)
        {
            if (set.Contains(num)) Console.WriteLine($"There already is {num} enter another number!");

            else
            {
                set.Add(num);
                Console.WriteLine($"Number {num} is saved succesfully!");
            }
        }

        static void PrintOut(HashSet<int> set)
        {
            Console.Write($"Your collection contains: ");

            foreach (var e in set)
            {
                Console.Write($"{e} ");
            }
        }
    }
}
