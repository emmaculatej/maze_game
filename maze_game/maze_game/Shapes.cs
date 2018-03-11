using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace maze_game
{
    public class Shapes
    {
        public  Point ShapePosition { get; set; }
        public Size ShapeSize { get; set; }

        public ConsoleColor ForegroundColour { get; set; }
        public ConsoleColor BackgroundColour { get; set; }

        // Creates a shape
        public virtual void Create(Point position, Size size, ConsoleColor foregroundColour, ConsoleColor backgorundColour, string title = "")
        {
            ShapePosition = position;
            ShapeSize = size;
            ForegroundColour = foregroundColour;
            BackgroundColour = backgorundColour;
        }

        public virtual void Draw(bool isDialogue = false)
        {

        }
    }
}




    