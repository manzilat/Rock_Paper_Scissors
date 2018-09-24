using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Game
    {
       
        public void RunGame()
        {
            //display rules
            //set players
            //get player gestures

            string inputPlayer1, inputPlayer2;
            int randomInt;

            bool playAgain = true;

            while (playAgain)
            {

                int player1 = 0;
                int player2 = 0;

                while (player1 < 3 && player2 < 3)
                {
                    List<string> listOfGestures = new List<string>();
                    listOfGestures.Add("rock");
                    listOfGestures.Add("paper");
                    listOfGestures.Add("scissors");
                    listOfGestures.Add("lizard");
                    listOfGestures.Add("spock");
                    foreach (string listOfGesture in listOfGestures)
                    {
                        Console.WriteLine(listOfGesture);
                    }


                    inputPlayer1 = Console.ReadLine();
                    inputPlayer2 = inputPlayer1.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 6);

                    switch (randomInt)
                    {
                        case 1:
                            inputPlayer2 = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("YEAH!!!PLAYER WINS,PAPER COVERS ROCK\n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS,ROCK CRUSHES SCISSORS!!\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == "LIZARD")
                            {
                                Console.WriteLine("CPU WINS,ROCK CRUSHES LIZARD!!\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == "SPOCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS,SPOCK VAPORIZES ROCK\n\n");
                                player1++;
                            }
                            break;
                        case 2:
                            inputPlayer2 = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("CPU WINS,PAPER COVERS ROCK!!\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS,SCISSORS CUTS PAPER\n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "LIZARD")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS,LIZARD EATS  PAPER\n\n");
                                player1++;

                            }
                            else if (inputPlayer1 == "SPOCK")
                            {
                                Console.WriteLine("CPU WINS,PAPER DISPROVES SPOCK!!\n\n");
                                player2++;
                            }
                            break;
                        case 3:
                            inputPlayer2 = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS, ROCK CRUSHES SCISSORS \n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("CPU WINS,SCISSORS CUTS PAPER\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == " LIZARD")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS, LIZARD DECAPITATES SCISSORS \n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "SPOCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS, SPOCK SMASHES SCISSORS \n\n");
                                player1++;
                            }
                            break;
                        case 4:
                            inputPlayer2 = "LIZARD";
                            Console.WriteLine("Computer chose LIZARD");
                            if (inputPlayer1 == "LIZARD")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS, ROCK CRUSHES LIZARD \n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("CPU WINS,LIZARD EATS PAPER\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS, SCISSORS CUTS LIZARD \n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "SPOCK")
                            {
                                Console.WriteLine("CPU WINS,LIZARD PIOSONS SPOCK\n\n");
                                player2++;
                            }
                            break;
                        case 5:
                            inputPlayer2 = "SPOCK";
                            Console.WriteLine("Computer chose SPOCK");
                            if (inputPlayer1 == "SPOCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (inputPlayer1 == "ROCK")
                            {
                                Console.WriteLine("CPU WINS,SPOCK VAPORIZES ROCK\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == "PAPER")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS, PAPER DISPROVES SPOCK \n\n");
                                player1++;
                            }
                            else if (inputPlayer1 == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS,SPOCK SMASHES PAPER\n\n");
                                player2++;
                            }
                            else if (inputPlayer1 == "LIZARD")
                            {
                                Console.WriteLine("YEAH!!PLAYER WINS,LIZARD PIOSONS SPOCK\n\n");
                                player1++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}",player1, player2);
                }
                if (player1 == 3)
                {
                    Console.WriteLine("YIPPIEEE!!!PLAYER WON");
                }
                else if (player2 == 3)
                {
                    Console.WriteLine("CPU WON!!");
                }
                Console.WriteLine("DO YOU WANT TO PLAY AGAIN? (Y/N)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }



            }
        }
    }
            


    
}
