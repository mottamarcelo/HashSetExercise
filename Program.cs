using System;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int studA = int.Parse (Console.ReadLine());
            for (int i = 0; i < studA; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            int studB = int.Parse(Console.ReadLine());
            for (int i = 0; i < studB; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            int studC = int.Parse(Console.ReadLine());
            for (int i = 0; i < studC; i++)
            {
                set.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine("Total students: " + set.Count());
        }
    }
}
