using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    public enum Navigation
    {
        up,
        right,
        left,
        down
    };

    public class Prop
    {
        public static int width { get; set; }
        public static int height { get; set; }
        public static int speed { get; set; }
        public static int score { get; set; }
        public static int points { get; set; }
        public static bool gameover{ get; set; }
        public static Navigation navigate { get; set; }

        public Prop()
        {
            width = 16;
            height = 16;
            speed = 16;
            score = 0;
            points = 100;
            gameover = false;
            navigate = Navigation.down;
        }
    }
}
