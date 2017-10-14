using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random(); //Random Number Generator
            int rps_num_choice; //RPS Numerical Choice
            string rps_choice = "r"; //Converted Choice to Text
            string plyr_choice; //Player Choice
            string playAgain = "y"; //Choose to play again. 

            Console.WriteLine("Rock Paper Scissors\n");

            do
            {
                Console.Write("Type in r for (R)ock, p for (P)aper, or s for (S)cissors to try and beat the computer: ");
                plyr_choice = Console.ReadLine();

                rps_num_choice = rng.Next(1, 4); //Randomly select rock paper or scissors by having it represent a number between 1-3
                switch (rps_num_choice)
                {
                    case 1:
                        rps_choice = "r";
                        break;
                    case 2:
                        rps_choice = "p";
                        break;
                    case 3:
                        rps_choice = "s";
                        break;
                }

                if (rps_choice == "r")
                {
                    if (plyr_choice == "r")
                    {
                        Console.WriteLine("Well we both chose Rock... How uneventful. It's a Tie.");
                    }
                    else if (plyr_choice == "p")
                    {
                        Console.WriteLine("So you beat me. Paper covers Rock. Good Job! You Win.");
                    }
                    else
                    {
                        Console.WriteLine("You lost there champ. Scissors crushed by Rock. You Lose.");
                    }
                }
                else if (rps_choice == "p")
                {
                    if (plyr_choice == "r")
                    {
                        Console.WriteLine("You just got GOT! Paper covers Rock. You Lose.");
                    }
                    else if (plyr_choice == "p")
                    {
                        Console.WriteLine("It's a tie! Neither good or bad really. Both of us chose Paper.");
                    }
                    else
                    {
                        Console.WriteLine("I am not a graceful loser. :( Scissors cuts Paper. You Win...");
                    }
                }
                else
                {
                    if (plyr_choice == "r")
                    {
                        Console.WriteLine("Your Rock destroyed my Scissors. I hate you. You Win.");
                    }
                    else if (plyr_choice == "p")
                    {
                        Console.WriteLine("Damn you suck at this game! My Scissors cuts your Paper. You Lose");
                    }
                    else
                    {
                        Console.WriteLine("I can't accept a tie but we did. We both chose Scissors. It's a Tie.");
                    }
                }
               
                Console.Write("Want to play again? Type y for Yes or n for No: ");
                playAgain = Console.ReadLine();
                Console.WriteLine();
            } while (playAgain == "y");

            Console.WriteLine("Thank you for playing! See you later.");
            Console.ReadKey();
        }
    }
}
