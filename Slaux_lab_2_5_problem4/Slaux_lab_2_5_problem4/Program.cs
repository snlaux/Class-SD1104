using System;

namespace Slaux_lab_2_5_problem4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Write a C# program that takes an age (for example 20) as input and prints 
            // something like "You look younger than 20 (the age the user entered)".
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("You look way younger than " + userAge + "!!");
        }
    }
}
