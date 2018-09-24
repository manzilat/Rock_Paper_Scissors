using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class Program:humanplayer
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.SetPlayers();
            Game game = new Game();
            game.RunGame();
            
        }
    }
}

