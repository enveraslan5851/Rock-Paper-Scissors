using System;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            int playerAWinsCount = 0;
            int playerBWinsCount = 0;
            int tieCounts = 0;

            // 0, 1 and 2 represent ROCK, PAPER, SCISSORS respectively. Player A choosed PAPER = 1
            int playerARole = 1;
            int playerBRole;
            for (int i = 0; i < 100; i++)
            {           
                // Player B randomly choose
                playerBRole = rnd.Next(0, 3);

                // If the player B choose the paper, the round is counted as a tie
                if (playerBRole==1)
                    tieCounts++;
                // If the player B choose the scissors, the player B is win
                else if (playerBRole == 2)
                    playerBWinsCount++;
                // If the player B choose the rock, the player A is win
                else
                    playerAWinsCount++;
            }

            Console.WriteLine("Player A wins {0} of 100 games", playerAWinsCount);
            Console.WriteLine("Player B wins {0} of 100 games", playerBWinsCount);
            Console.WriteLine("Tie: {0} of 100 games", tieCounts);
        }
    }
}
