using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    public class Player
    {

        public int score;
        public string gesture;
        public Player()
        {
            score = 0;
        }
        public string SelectGestures(List<string> gestures)
        {
            Console.WriteLine("select any one gesture:");
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            return  Console.ReadLine().ToUpper();
        }

    }
}
