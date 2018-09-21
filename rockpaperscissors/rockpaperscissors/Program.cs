using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class RPSLSGame
    {
        static void Main(string[] args)
        {
            RPSLSGame rpslsGame = new RPSLSGame();
            Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock!!");
           
            
            Console.WriteLine("Would you like to play? Enter 'yes', 'y', 'Yes', or 'Y' for yes.\nEnter 'no', 'No', 'n', 'N' for no.\nDecision?");
            string playerChoice = Console.ReadLine();
            if (playerChoice == "yes" || playerChoice == "y" || playerChoice == "Yes" || playerChoice == "Y")
            {
                //calling method to start game
                rpslsGame.StartGame();
                //calling method to display results of game
                rpslsGame.DetermineWinner();
            }

            else if (playerChoice == "no" || playerChoice == "n" || playerChoice == "No" || playerChoice == "N")
            {
                Console.WriteLine("See ya!");
            }

            else
            {
                Console.WriteLine("Invalid choice.");
                Console.WriteLine("Yes or no?");
                playerChoice = Console.ReadLine();
            }

            //beginning game again.
            rpslsGame.PlayAgain();


        }
    }
}

