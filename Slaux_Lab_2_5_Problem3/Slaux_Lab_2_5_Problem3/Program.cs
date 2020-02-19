using System;

namespace Slaux_Lab_2_5_Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Write a C# program to print the output of multiplication of three numbers which will be entered by the user
            Console.WriteLine("Please enter your first number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your third number");
            int thirdNum = int.Parse(Console.ReadLine());
            int result = firstNum * secondNum * thirdNum;
            Console.WriteLine(firstNum + " * " + secondNum + " * " + thirdNum + " = " + result);
        }
    }
}
