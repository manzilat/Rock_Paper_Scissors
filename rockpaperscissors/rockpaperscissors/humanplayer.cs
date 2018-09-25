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
        }

        public override void SelectGestures(List<string> gestures)
        {
            Console.WriteLine("select any one gesture:");
            foreach (string gesture in gestures)
            {
                Console.WriteLine(gesture);
            }
            gesture = Console.ReadLine().ToUpper();
        }
    }
}
