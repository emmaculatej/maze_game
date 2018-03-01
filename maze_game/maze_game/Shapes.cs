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

    public class Box : Shapes
    {
        public override void Draw(bool isDialogue = false)
        {
            Console.ForegroundColor = ForegroundColour;
            Console.BackgroundColor = BackgroundColour;

            for(int width = 0; width < ShapeSize.Width; width++)
            {
                for(int height = 0; height < ShapeSize.Height; height++)
                {
                    Console.SetCursorPosition(ShapePosition.X + width, ShapePosition.Y + height);
                    if(width == 0 && height == 0)
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
                    else if( (width == 0 || width == ShapeSize.Width - 1) && (height > 0 && height < ShapeSize.Height - 1))
                    {
                        if (isDialogue)
                        {
                            if(height == 2)
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

    public class DialogueBox : Shapes
    {
        Box textbox = new Box();
        string Title;

        public override void Create(Point position, Size size, ConsoleColor foregroundColour, ConsoleColor backgorundColour, string title = "")
        {
            Title = title;

            textbox.Create(position, size, foregroundColour, backgorundColour);

            if (Title.Length >= textbox.ShapeSize.Width)
            {
                textbox.ShapeSize = new Size(Title.Length + 4, textbox.ShapeSize.Height);
            }
        }

        public override void Draw(bool isDialogue = true)
        {
            textbox.Draw(isDialogue);

            Console.SetCursorPosition(textbox.ShapePosition.X + 1, textbox.ShapePosition.Y + 2);

            for(int width = 0; width < textbox.ShapeSize.Width - 2; width++)
            {
                Console.Write("=");
            }

            Console.SetCursorPosition(textbox.ShapePosition.X + 2, textbox.ShapePosition.Y + 1);
            Console.Write(Title);
        }
    }
}
