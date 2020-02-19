using System;

namespace Slaux_Lab_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a variable called myFirstNumber as an integer with the value of 19.
            int myFirstNumber = 19;
            // 2. Create a variable called mySecondNumber as an integer with the value of 244.
            int mySecondNumber = 244;
            //3. Use Console.WriteLine to print the results of multiplying myFirstNumber and mySecondNumber.
            int result = 0;
            result = myFirstNumber * mySecondNumber;
            Console.WriteLine(result);
            // 4. Create a variable called myText as a string with the value “Some Text”
            string myText = "Some Text";
            // 5. Use Console.WriteLine to print the results of myText and mySecondNumber together.
            //Console.WriteLine(myText * mySecondNumber);
            // 5. Create a variable called moreText as a string with the value “Goes Here”.
            string moreText = "Goes Here";
            // 6. Use Console.WriteLine to print the results of adding myText and moreText.
            Console.WriteLine(myText + moreText);
            // 7. Create two strings with the name color1 and color2. Assign color1 the value “Yellow”. Assign color2 the value “Red”
            string color1 = "Yellow";
            string color2 = "Red";
            // 8. Create two bools, isYellow and isGreen. Set isYellow to true and isGreen to false.
            bool isYellow = true;
            bool isGreen = false;
            // 9.Use Console.WriteLine to print the values of color1, isYellow, color2, isGreen.
            Console.WriteLine(color1);
            Console.WriteLine(isYellow);
            Console.WriteLine(color2);
            Console.WriteLine(isGreen);
            // 10. Create a variable called numbers as a double, but don’t assign it any value yet.
            double numbers;
            // 11. On a new line, assign numbers the value of mySecondNumber divided by myFirstNumber.
            numbers = mySecondNumber / myFirstNumber;
            //12. Print the value of numbers to the console.
            Console.WriteLine(numbers);
            // 13. On a new line, assign numbers the value of mySecondNumber divided by myFirstNumber, 
            //but this time, cast myFirstNumber as a double.
            numbers = mySecondNumber / (Double) myFirstNumber;
            // 14. Print the value of numbers to the console.
            Console.WriteLine(numbers);
            //  15.Use Console.WriteLine to print the text “Breakpoint Here”. Insert a breakpoint to pause execution at this line. 
            //Run the program, and inspect the values of all of your variables. Hover your mouse over the variable to see it’s value appear.
            Console.WriteLine("Breakpoint here");
            //  16. Create a variable called textToNumber as a string with the value “80473”
            string textToNumber = "80473";
            // 17. Create a variable call results as an integer and assign it the value of 99 * 
            // textToNumber. Use int.Parse() to complete the operation. Print the results.
            int results = 99 * int.Parse(textToNumber);
            // 18. Create a DateTime variable called rightNow and set it’s value to Datetime.Now. Print the results.
            DateTime rightNow = DateTime.Now;
        }
    }
}
