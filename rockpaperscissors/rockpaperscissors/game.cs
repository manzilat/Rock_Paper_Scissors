using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Game
    {
        Player player1;
        Player player2;
        
        List<string> listOfGestures = new List<string>();

        public Game()
        {
            
            
            listOfGestures.Add("ROCK");
            listOfGestures.Add("PAPER");
            listOfGestures.Add("SCISSOR");
            listOfGestures.Add("LIZARD");
            listOfGestures.Add("SPOCK");
            listOfGestures.Add("");
         
        }
        public void RunGame()
        {
            //display rules
            //set players
            SetPlayers();
            //get player gestures

           

                bool playAgain = true;

            while (playAgain)
            {
                while (player1.score < 3 && player2.score < 3)
                {


                    player1.SelectGestures(listOfGestures);


                    player2.SelectGestures(listOfGestures);
                   
                    

                    switch (player2.gesture)
                    {
                        case "ROCK":
                            Console.WriteLine("PLAYER 2 chose ROCK");
                            if (player1.gesture == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (player1.gesture == "PAPER")
                            {
                                Console.WriteLine("YEAH!!!PLAYER 1 WINS,PAPER COVERS ROCK\n\n");
                                player1.score++;
                            }
                            else if (player1.gesture == "SCISSOR")
                            {
                                Console.WriteLine("PLAYER 2 WINS,ROCK CRUSHES SCISSOR!!\n\n");
                                player2.score++;
                            }
                            else if (player1.gesture == "LIZARD")
                            {
                                Console.WriteLine("PLAYER 2 WINS,ROCK CRUSHES LIZARD!!\n\n");
                                player2.score++;
                            }
                            else if (player1.gesture == "SPOCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS,SPOCK VAPORIZES ROCK\n\n");
                                player1.score++;
                            }
                            
                            break;
                        case "PAPER":
                           
                            Console.WriteLine("PLAYER 2 chose PAPER");
                            if (player1.gesture == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (player1.gesture == "ROCK")
                            {
                                Console.WriteLine("PLAYER 2 WINS,PAPER COVERS ROCK!!\n\n");
                                player2.score++;
                            }
                            else if (player1.gesture == "SCISSOR")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS,SCISSOR CUTS PAPER\n\n");
                                player1.score++;
                            }
                            else if (player1.gesture == "LIZARD")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS,LIZARD EATS  PAPER\n\n");
                                player1.score++;

                            }
                            else if (player1.gesture == "SPOCK")
                            {
                                Console.WriteLine("PLAYER 2 WINS,PAPER DISPROVES SPOCK!!\n\n");
                                player2.score++;
                            }
                            break;
                        case "SCISSORS":
                           
                            Console.WriteLine("PLAYER 2 chose SCISSOR");
                            if (player1.gesture == "SCISSOR")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (player1.gesture == "ROCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS, ROCK CRUSHES SCISSOR \n\n");
                                player1.score++;
                            }
                            else if (player1.gesture == "PAPER")
                            {
                                Console.WriteLine("PLAYER 2 WINS,SCISSOR CUTS PAPER\n\n");
                                player2.score++;
                            }
                            else if (player1.gesture == " LIZARD")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS, LIZARD DECAPITATES SCISSOR \n\n");
                                player1.score++;
                            }
                            else if (player1.gesture == "SPOCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS, SPOCK SMASHES SCISSOR \n\n");
                                player1.score++;
                            }
                            break;
                        case "LIZARD":
                            
                            Console.WriteLine("PLAYER 2 chose LIZARD");
                            if (player1.gesture == "LIZARD")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (player1.gesture == "ROCK")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS, ROCK CRUSHES LIZARD \n\n");
                                player1.score++;
                                
                            }
                            else if (player1.gesture == "PAPER")
                            {
                                Console.WriteLine("PLAYER 2 WINS,LIZARD EATS PAPER\n\n");
                                player2.score++;

                            }
                            else if (player1.gesture == "SCISSOR")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS, SCISSOR CUTS LIZARD \n\n");
                                player1.score++;
                            }
                            else if (player1.gesture == "SPOCK")
                            {
                                Console.WriteLine("PLAYER 2 WINS,LIZARD PIOSONS SPOCK\n\n");
                                player2.score++;
                            }
                            break;
                        case "SPOCK":
                            
                            Console.WriteLine("PLAYER 2 chose SPOCK");
                            if (player1.gesture == "SPOCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (player1.gesture == "ROCK" )
                            {
                                Console.WriteLine("PLAYER 2 WINS,SPOCK VAPORIZES ROCK\n\n");
                                player2.score++;
                            }
                            else if (player1.gesture == "PAPER")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS, PAPER DISPROVES SPOCK \n\n");
                                player1.score++;
                            }
                            else if (player1.gesture == "SCISSOR")
                            {
                                Console.WriteLine("PLAYER 2 WINS,SPOCK SMASHES SCISSOR\n\n");
                                player2.score++;
                            }
                            else if (player1.gesture == "LIZARD")
                            {
                                Console.WriteLine("YEAH!!PLAYER 1 WINS,LIZARD PIOSONS SPOCK\n\n");
                                player1.score++;
                            }
                            
                            break;
                            
                        default:

                            Console.WriteLine("Invalid entry!");
                            break;
                            
                    }

                    Console.WriteLine("\n\nSCORES:\nPLAYER1:\t{0}\tPLAYER2:\t{1}", player1.score, player2.score);
                }
                if (player1.score == 3)
                {
                    Console.WriteLine("YIPPIEEE!!!PLAYER 1 WON");
                }
                else if (player2.score == 3)
                {
                    Console.WriteLine("HURRAY !! PLAYER 2 WON!!");
                }
                Console.WriteLine("DO YOU WANT TO PLAY AGAIN? (Y/N)");
                string loop = Console.ReadLine();
                if ((loop == "Y") || (loop == "YES") || (loop == "y")||(loop == "yes"))
                {
                    playAgain = true;
                    player1.score = 0;
                    player2.score = 0;
                    Console.Clear();
                }
                else if ((loop == "N") || (loop == "n") || (loop == "no") || (loop == "NO") )
                {
                    playAgain = false;
                }



            }
        }

        public void SetPlayers()
        {
            Console.WriteLine("How many players 1 or 2?");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                player1 = new humanplayer();
                player2 = new computerplayer();
            }
            else if (userInput == "2")
            {
                player1 = new humanplayer();
                player2 = new humanplayer();
            }


        }

    }





}
