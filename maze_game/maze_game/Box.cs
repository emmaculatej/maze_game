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
            }
        }
    }
}
