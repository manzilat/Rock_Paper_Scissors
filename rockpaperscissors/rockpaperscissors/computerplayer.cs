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
        public override void SelectGestures(List<string> gestures)
        {
  
            int randomInt = rnd.Next(0, gestures.Count);
            gesture = gestures[randomInt].ToUpper();
        }
    }
}
