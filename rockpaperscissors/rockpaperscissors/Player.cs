using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Player
    {
        Player player1;
        Player player2;

        public int score;
        public void SetPlayers()
        {
            Console.WriteLine("How many players?");
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
