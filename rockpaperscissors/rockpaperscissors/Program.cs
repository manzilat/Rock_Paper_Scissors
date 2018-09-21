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
            Console.WriteLine("please select any one of the following\n rock\n paper\n scissors\n lizard\n spock");
            string userChoice = Console.ReadLine();

            Random r = new Random();
            int computerChoice = r.Next(6);

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
                    Console.WriteLine("Sorry you lose,paper covers rock");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,Scissors cuts Paper ");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("Sorry you lose,Scissors decapitates Lizard");
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("Sorry you lose,Lizard poisons Spock");
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose rock");
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
                    Console.WriteLine("You win,rock crushes scissors");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("You lose,Lizard eats Paper");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("You lose,Spock smashes Scissors");

                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,Rock crushes Lizard");

                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You lose,Paper disproves Spock");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper,scissors,lizard or spock!");

                }

            }
           else if (computerChoice == 4)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("You win,rock crushes lizard");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("You win,Paper disproves Spock");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You lose,rock crushes Scissors");

                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,Lizard eats Paper");

                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,Spock smashes Scissors");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper,scissors,lizard or spock!");

                }

            }



            else if (computerChoice == 5)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("You win,Spock vaporizes Rock ");

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,Paper covers rock");

                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors cut rock");

                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You lose,Scissors decapitates Lizard");

                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("You lose,Lizard poisons Spock");

                }
                else
                {
                    Console.WriteLine("You must choose rock,paper,scissors,lizard or spock!");

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

