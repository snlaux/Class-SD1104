using System;

namespace Slaux_Lab_4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] task = new string[7];
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine("What do you need to do on " + day[i] + "?");
                task[i] = Console.ReadLine();
            }
            Console.WriteLine("Your schedule...");
            for (int i = 0;i <= 6; i++)
            {
                Console.WriteLine(day[i] + " : " + task[i]);
            }
        }
    }
}
