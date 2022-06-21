using System;
using System.Collections.Generic;

namespace Task1_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ls = new List<int>();

            Console.WriteLine("Initial list is: ");
            RandomFill(ls);
            PrintOut(ls);
            DeleteElement(ls);
            Console.WriteLine("\n\nNew list is: ");
            PrintOut(ls);
        }

        static void RandomFill(List<int> ls)
        {
            Random rnd = new Random();

            for (int i = 0; i < 101; i++)
            {
                ls.Add(rnd.Next(0, 101));
            }
        }

        static void PrintOut(List<int> ls)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                Console.Write($"{ls[i]} , ");
            }
        }

        static void DeleteElement(List<int> ls)
        {
            ls.RemoveAll(element => element > 25 && element < 50);

            //for (int i = ls.Count - 1; i > -1; i--)   //second method of deleting
            //{
            //    if (ls[i] > 25 && ls[i] < 50)
            //    {
            //        ls.RemoveAt(i);
            //    }
            //}
        }

    }
}
