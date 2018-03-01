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
        public virtual void Create(Point position, Size size, ConsoleColor foregroundColour, ConsoleColor backgorundColour)
        {
            ShapePosition = position;
            ShapeSize = size;
            ForegroundColour = foregroundColour;
            BackgroundColour = backgorundColour;
        }

        public virtual void Draw()
        {

        }
    }

    public class Box : Shapes
    {
        public override void Draw()
        {
            Console.ForegroundColor = ForegroundColour;
            Console.BackgroundColor = BackgroundColour;

            for(int width = 0; width < ShapeSize.Width; width++)
            {
                for(int height = 0; height < ShapeSize.Height; height++)
                {
                    Console.SetCursorPosition(ShapePosition.X + width, ShapePosition.Y + height);

                    if( (width == 0 || width == ShapeSize.Width - 1) && (height > 0 && height < ShapeSize.Height - 1))
                    {
                        Console.Write("|");
                    }
                    else if ((width > 0 && width < ShapeSize.Width - 1) && (height == 0 || height == ShapeSize.Height - 1))
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
