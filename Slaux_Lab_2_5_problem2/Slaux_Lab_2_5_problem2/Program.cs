using System;

namespace Slaux_Lab_2_5_problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Write a C# program to print Hello and your name (which you will type in on the  Console) in a separate line.
            Console.WriteLine("Please type your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName);
        }
    }
}
