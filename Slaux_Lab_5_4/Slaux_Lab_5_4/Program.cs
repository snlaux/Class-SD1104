using System;
using System.Collections;

namespace Slaux_Lab_5_4
{
    struct mario
    {
        public enum Size
        {
            small,
            large
        }
        public int numOfLives;
        public string currentLevel;
        public Size sizeOfMario;
        public bool canShootFireballs;
        public bool isJumping;
        public int numOfCoins;

    }
    class Program
    {
        static void Main(string[] args)
        {
            mario mario1 = new mario();
            mario1.numOfLives = 3;
            mario1.numOfCoins = 0;
            mario1.currentLevel = "World 1-1";
            mario1.sizeOfMario = mario.Size.small;
            mario1.canShootFireballs = false;
            mario1.isJumping = false;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            mario1.isJumping = true;
            Console.WriteLine("Mario squashes the Gooba. Now he needs to land!");
            mario1.isJumping = false;
            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            mario1.numOfLives = mario1.numOfLives + 1;
            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change mario!");
            mario1.canShootFireballs = true;
            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario");
            mario1.sizeOfMario = mario.Size.large;
            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            mario1.numOfCoins = 10;
            Console.WriteLine("Mario finshes the level! Change Mario's current level to World 1-2");
            mario1.currentLevel = "World 1-2";
        }
    }
}
