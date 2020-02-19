using System;

namespace Slaux_lab_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string blackListedWord = "pill";
            bool isSpam = false;
            string message = Console.ReadLine();
            if (message.Contains(blackListedWord))
            {
                Console.WriteLine("This message is spam");      
            }
            else
            {
                Console.WriteLine("This message is not spam");
            }
        }
    }
}
