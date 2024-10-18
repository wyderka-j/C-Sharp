using System;

namespace Dice_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            Console.WriteLine("You will play dice against the computer.");
            Console.WriteLine("The game has 5 rounds.");
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                
                Console.WriteLine("Please press any key to roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("You win this rund!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this rund!");
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                }

                Console.WriteLine("The score is now - You : " + playerPoints + " - Enemy : " + enemyPoints);
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("Enemy wins!");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }

            Console.ReadKey();
        }
    }
}