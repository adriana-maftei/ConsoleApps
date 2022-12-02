using System;

namespace Roll_a_dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PlayerRandomNr, EnemyRandomNr;
            Random random = new Random();            
            int playerPoints = 0;
            int enemyPoints = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("  Press any key to roll a dice");
                Console.ReadKey();

                PlayerRandomNr = random.Next(1, 7);
                Console.WriteLine("  You rolled a " + PlayerRandomNr);

                Console.WriteLine("  Enemy is rolling...");
                System.Threading.Thread.Sleep(1000); // waiting time before enemy AI gives the answer

                EnemyRandomNr = random.Next(1, 7);
                Console.WriteLine("  Enemy AI rolled a " + EnemyRandomNr);

                if(PlayerRandomNr > EnemyRandomNr)
                {
                    playerPoints++;
                    Console.WriteLine("  You won this round!");
                }
                else if (PlayerRandomNr < EnemyRandomNr)
                {
                    enemyPoints++;
                    Console.WriteLine("  Enemy won this round!");
                }
                else
                {
                    Console.WriteLine("  Draw!");
                }

                Console.WriteLine();
                Console.WriteLine("  The score is: You: " + playerPoints + "   Enemy: " + enemyPoints);
                Console.WriteLine(); // empty line between each round
            }

            if (playerPoints > enemyPoints)
                Console.WriteLine("  YOU WON!");
            else if (playerPoints < enemyPoints)
                Console.WriteLine("  YOU LOSE!");
            else
                Console.WriteLine("  DRAW!");

            Console.ReadKey(); //so the app will not automatically close after the loop is ended
        }
    }
}
