using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you choose rock,paper,scissors,lizard,spock");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(4);

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("It is a tie ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("It is a tie ");
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("It is a tie ");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper,scissors,lizard,spock!");

                }

            }

            else if (computerChoice == 2)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("Sorry you lose,paper beat rock");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,scissors beat paper ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose,rock beats scissors");
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("Sorry you lose,Rock crushes Lizard");
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("Sorry you lose,Spock vaporizes Rock ");
                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors,lizard,spock!");
                }
            }
            else if (computerChoice == 3)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,rock beats scissors");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,paper beats rock");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors beat paper");

                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("You win,Scissors decapitates Lizard");

                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors beat paper");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper or scissors!");

                }

            }

            bool keepPlaying = true;
            while (keepPlaying)
            {
                //game logic here

                Console.WriteLine("New game? y/n");
                ConsoleKeyInfo cki = Console.ReadKey(); //wait for player to press a key
                keepPlaying = cki.KeyChar == 'y'; //continue only if y was pressed
            }
        }
    }
}

