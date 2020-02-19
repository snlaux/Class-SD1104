using System;

namespace Slaux_Lab_2_4_problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Write a C# program to print on screen the output of adding, subtracting, 
            //multiplying and dividing of two numbers which will be entered by the user.

            Console.WriteLine("What is your first number?");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your second number?");
            int secondNum = int.Parse(Console.ReadLine());
            int addResult = firstNum + secondNum;
            int subResult = firstNum - secondNum;
            int multResult = firstNum * secondNum;
            int divResult = firstNum / secondNum;
            Console.WriteLine(firstNum + " + " + secondNum + " = " + addResult);
            Console.WriteLine(firstNum + " - " + secondNum + " = " + subResult);
            Console.WriteLine(firstNum + " * " + secondNum + " = " + multResult);
            Console.WriteLine(firstNum + " / " + secondNum + " = " + divResult);
        }
    }
}
