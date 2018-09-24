using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class humanplayer : Player
    {
        public humanplayer()
        {
            Console.WriteLine("enter you're name:");
            string userInput = Console.ReadLine();
        }
       
}
}
