using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    public class Box : Shapes
    {
        public override void Draw(bool isDialogue = false)
        {
            Console.ForegroundColor = ForegroundColour;
            Console.BackgroundColor = BackgroundColour;

            for (int width = 0; width < ShapeSize.Width; width++)
            {
                for (int height = 0; height < ShapeSize.Height; height++)
                {
                    // Isn't a better name for width and height x and y? 
                    // I am guessing its some form of coordinate system
                    DrawCell(width, height, isDialogue);
                }
            }
        }

        private void DrawCell(int width, int height, bool isDialogue) {
            Console.SetCursorPosition(ShapePosition.X + width, ShapePosition.Y + height);
            if (width == 0 && height == 0)
            {
                Console.Write("╔");
            }
            else if (width == ShapeSize.Width - 1 && height == 0)
            {
                Console.Write("╗");
            }
            else if (width == 0 && height == ShapeSize.Height - 1)
            {
                Console.Write("╚");
            }
            else if (width == ShapeSize.Width - 1 && height == ShapeSize.Height - 1)
            {
                Console.Write("╝");
            }
            else if ((width == 0 || width == ShapeSize.Width - 1) && (height > 0 && height < ShapeSize.Height - 1))
            {
                if (isDialogue)
                {
                    DrawDialog();
                }
                else
                {
                    Console.Write("║");
                }
            }
            else if ((width > 0 && width < ShapeSize.Width - 1) && (height == 0 || height == ShapeSize.Height - 1))
            {
                Console.Write("=");
            }
            else
            {
                Console.Write(" ");
            }
        }

        private void DrawDialog() {
            if (height == 2)
            {
                if (width == 0)
                {
                    Console.Write("╠");
                }
                else if (width == ShapeSize.Width - 1)
                {
                    Console.Write("╣");
                }
            }
            else
            {
                Console.Write("|");
            }
        }
    }
}
