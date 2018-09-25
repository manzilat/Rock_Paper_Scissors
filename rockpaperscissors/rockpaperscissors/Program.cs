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
            string Rules = "Rock-paper-scissors-lizard-Spock Rulezz:\n";
            Rules = Rules + "Scissors cut paper\n";
            Rules = Rules + "Paper covers rock\n";
            Rules = Rules + "Rock crushes lizard\n";
            Rules = Rules + "Lizard poisons Spock\n";
            Rules = Rules + "Spock smashes scissors\n";
            Rules = Rules + "Scissors decapitate lizard\n";
            Rules = Rules + "Lizard eats paper\n";
            Rules = Rules + "Paper disproves Spock\n";
            Rules = Rules + "Spock vaporizes rock\n";
            Rules = Rules + "Rock crushes scissors\n";

            Console.WriteLine(Rules);

            Game game = new Game();
            game.RunGame();

            
        }
    }
}

