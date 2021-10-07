using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minigame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int cubeRandomNum;

            int playerPoints = 0;
            int cubePoints = 0;

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("press a key to roll a dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                cubeRandomNum = random.Next(1, 7);
                Console.WriteLine("the cube/room rolled a " + cubeRandomNum);

                if (playerRandomNum > cubeRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("player wins this round");
                }
                else if (playerRandomNum < cubeRandomNum)
                {
                    cubePoints++;
                    Console.WriteLine("cube/room wins this round");
                }
                else
                {
                    Console.WriteLine("how did you even tie? ");
                }
                Console.WriteLine("the score is now - Player : " + playerPoints + ". Enemy : " + cubePoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > cubePoints)
            {
                Console.WriteLine("You beat the room.");
            }
            else if (playerPoints < cubePoints)
            {
                Console.WriteLine("you died in the room. Game Over.");
            }
            else
            {

                Console.WriteLine("Dear Math, grow up and solve your own problems.");

                Console.ReadKey();
            }
        }
    }
}
