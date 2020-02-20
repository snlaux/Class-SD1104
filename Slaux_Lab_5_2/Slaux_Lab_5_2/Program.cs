using System;
using System.Collections;
using System.Collections.Generic;

namespace Slaux_Lab_5_2
{
    class Program
    {
        public enum weekdays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            List<string> tasklist = new List<string>();
            foreach(weekdays day in Enum.GetValues(typeof(weekdays)))
            {
                Console.WriteLine("Enter a task for " + day);
                string task = day + " : " + Console.ReadLine();
                tasklist.Add(task);
            }
            foreach(string task in tasklist)
            {
                Console.WriteLine(task);
            }
        }
    }
}
