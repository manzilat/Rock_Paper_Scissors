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
            int win = 0;
            int lose = 0;
            int tie = 0;

            if (computerChoice == 1)
            {
                if (userChoice == "rock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("It is a tie ");
                    tie++;
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("It is a tie ");
                    tie++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("It is a tie ");
                    tie++;
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("It is a tie ");
                    tie++;

                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("It is a tie ");
                    tie++;
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
                    lose++;
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("Sorry you lose,Scissors cuts Paper ");
                    lose++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("Sorry you lose,Scissors decapitates Lizard");
                    lose++;
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("Sorry you lose,Lizard poisons Spock");
                    lose++;
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("Sorry you lose,Spock vaporizes Rock ");
                    lose++;
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
                    win++;

                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("You lose,Lizard eats Paper");
                    lose++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("You lose,Spock smashes Scissors");
                    lose++;
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,Rock crushes Lizard");
                    win++;
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You lose,Paper disproves Spock");
                    lose++;
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
                    win++;
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose spock");
                    Console.WriteLine("You win,Paper disproves Spock");
                    win++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You lose,rock crushes Scissors");
                    lose++;
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,Lizard eats Paper");
                    win++;
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You win,Spock smashes Scissors");
                    win++;
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
                    win++;
                }
                else if (userChoice == "paper")
                {
                    Console.WriteLine("The computer chose rock");
                    Console.WriteLine("You win,Paper covers rock");
                    win++;
                }
                else if (userChoice == "scissors")
                {
                    Console.WriteLine("The computer chose paper");
                    Console.WriteLine("You win,scissors cut rock");
                    win++;
                }
                else if (userChoice == "lizard")
                {
                    Console.WriteLine("The computer chose scissors");
                    Console.WriteLine("You lose,Scissors decapitates Lizard");
                    lose++;
                }
                else if (userChoice == "spock")
                {
                    Console.WriteLine("The computer chose lizard");
                    Console.WriteLine("You lose,Lizard poisons Spock");
                    lose++;
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

