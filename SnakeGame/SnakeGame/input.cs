using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
     internal class input
    {
        private static Hashtable keyTable = new Hashtable();

        public static bool keypressed(Keys key)
        {
            if(keyTable[key]==null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        public static void Changestate(Keys key ,bool state)
        {
            keyTable[key] = state;
        }
    }
}
