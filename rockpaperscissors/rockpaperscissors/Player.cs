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
        
        virtual public void SelectGestures(List<string> gestures)
        {

        }

    }
}
