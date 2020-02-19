using System;
using System.Collections;

namespace Slaux_lab_4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Create a list that holds the scores you’ve been given.
            ArrayList scores = new ArrayList();
            scores.Add(4400);
            scores.Add(8900);
            scores.Add(1200);
            scores.Add(3700);
            scores.Add(7200);
            // 2.Sort the scores lowest to highest and output to the screen.
            scores.Sort();
            int length = scores.Count;
            for(int i = 0; i <= length-1; i++)
            {
                Console.WriteLine(scores[i]);
            }
            //3.Sort the scores highest to lowest and output to the screen.
            Console.WriteLine("Ordered highest to lowest");
            scores.Reverse();
            for (int i = 0; i <= length - 1; i++)
            {
                Console.WriteLine(scores[i]);
            }
            //4.You’ve just been given a new score that wasn’t part of the original list. Add the score 2400 to the list.
            Console.WriteLine("Updated leaderboards");
            scores.Insert(5,2400);
            length = scores.Count;
            scores.Sort();
            scores.Reverse();
            for (int i = 0; i <= length - 1; i++)
            {
                Console.WriteLine(scores[i]);
            }
            //5..A user has closed their account and needs to have all of their information deleted. 
            //Remove the score 4400 from the list
            Console.WriteLine("Updated leaderboards");
            scores.Remove(4400);
            length = scores.Count;
            for (int i = 0; i <= length - 1; i++)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }
}
