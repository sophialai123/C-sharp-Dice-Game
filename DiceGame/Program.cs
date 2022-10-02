using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            int playerRoll = 0;
            int computerRoll = 0;
            int playerPoint = 0;
            int computerPoint = 0;

            Random random = new Random();

            Console.WriteLine("Welcome to Dice Game :) !");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\npress any key to roll the dice! ");

                Console.WriteLine("**********************************");

                Console.ReadKey();

                //Generate randome between 1-6
                playerRoll = random.Next(1, 7);

                Console.WriteLine($"\nPlayer rolled a { playerPoint }.");

                computerRoll = random.Next(1, 7);

                Console.WriteLine($"\nComputer rolled a { computerPoint}.");


                //compare the dice
                if (playerRoll > computerRoll)
                {
                    playerPoint++;
                    Console.WriteLine($"\nPlayer wins this round!");
                }
                else if (playerRoll < computerRoll)
                {
                    computerPoint++;
                    Console.WriteLine($"\nComputer wins this round!");
                }
                else
                {
                    Console.WriteLine("\nIt is a draw!");
                }
            }


            if (playerPoint > computerPoint)
            {
                Console.WriteLine($"\nPlayer Wins with {playerPoint} points :) !");
            }
            else if (playerPoint < computerPoint) { Console.WriteLine($"\nComputer Wins with {computerPoint} points :) !"); }
            else { Console.WriteLine("\nIt is a draw !"); }


            Console.WriteLine("\nGame over, Thank you!");

        }

    }
}
