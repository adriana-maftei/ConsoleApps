namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int PlayerRandomNr, EnemyRandomNr;
            Random random = new Random();

            for (int i = 0; i< 10; i++) 
            {
                Console.WriteLine("Press any key to roll a dice");
                Console.ReadKey();

                PlayerRandomNr = random.Next(1, 7); 
                Console.WriteLine("You rolled a " + PlayerRandomNr);

                EnemyRandomNr = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + EnemyRandomNr);
            } 
            Console.ReadKey();//so the app will not automatically close after the loop is ended
        }
    }
}
