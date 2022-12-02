using System;

namespace Rock_Paper_Scissors_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputEnemy;
            int randomInt;
            bool playAgain = true;

            while (playAgain)
            {
                int scorePlayer = 0;
                int scoreEnemy = 0;

                while (scoreEnemy < 3 && scorePlayer < 3)
                {
                    Console.WriteLine("Choose between ROCK, PAPER, SCISSORS");
                    inputPlayer = Console.ReadLine();

                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputEnemy = "rock";
                            Console.WriteLine("Enemy chose Rock");
                            if (inputPlayer == "rock")
                                Console.WriteLine("Draw!\n");
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Player wins!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("Enemy wins!\n");
                                scoreEnemy++;
                            }
                            break;
                        case 2:
                            inputEnemy = "paper";
                            Console.WriteLine("Enemy chose Paper");
                            if (inputPlayer == "paper")
                                Console.WriteLine("Draw!\n");
                            else if (inputPlayer == "scissors")
                            {
                                Console.WriteLine("Player wins!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Enemy wins!\n");
                                scoreEnemy++;
                            }
                            break;
                        case 3:
                            inputEnemy = "scissors";
                            Console.WriteLine("Enemy chose Scissors");
                            if (inputPlayer == "scissors")
                                Console.WriteLine("Draw!\n");
                            else if (inputPlayer == "rock")
                            {
                                Console.WriteLine("Player wins!\n");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "paper")
                            {
                                Console.WriteLine("Enemy wins!\n");
                                scoreEnemy++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry, please select an item and use capital letters");
                            break;
                    }
                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tENEMY:\t{1}", scorePlayer, scoreEnemy); //place holder for strings
                }

                if (scorePlayer == 3)
                    Console.WriteLine("PLAYER WON!");
                else if (scoreEnemy == 3)
                    Console.WriteLine("ENEMY WON!");
                else { } //continue running

                Console.WriteLine("PLAY AGAIN? (yes/no)");
                string loop = Console.ReadLine();

                if (loop == "yes")
                {
                    playAgain = true;
                    Console.Clear();
                }  
                else if (loop == "no")
                    playAgain =false;
                else { } //continue running
            }
        }
    }
}
