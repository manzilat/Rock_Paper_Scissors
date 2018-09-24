using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockpaperscissors
{
    class computerplayer : Player
    {

        Random rnd = new Random();
        public string SelectGestures(List<string> gestures)
        {
  
            int randomInt = rnd.Next(0, gestures.Count);
           return gesture = gestures[randomInt].ToUpper();
        }
    }
}
