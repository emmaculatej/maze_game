using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    public class DialogueBox : Shapes
    {
        Box textBox = new Box();
        string Title;

        public override void Create(Point position, Size size, ConsoleColor foregroundColour, ConsoleColor backgorundColour, string title = "")
        {
            Title = title;

            textBox.Create(position, size, foregroundColour, backgorundColour);

            if (Title.Length >= textBox.ShapeSize.Width)
            {
                textBox.ShapeSize = new Size(Title.Length + 4, textBox.ShapeSize.Height);
            }
        }

        public override void Draw(bool isDialogue = true)
        {
            textBox.Draw(isDialogue);

            Console.SetCursorPosition(textBox.ShapePosition.X + 1, textBox.ShapePosition.Y + 2);

            for (int width = 0; width < textBox.ShapeSize.Width - 2; width++)
            {
                Console.Write("=");
            }

            Console.SetCursorPosition(textBox.ShapePosition.X + 2, textBox.ShapePosition.Y + 1);
            Console.Write(Title);
        }
    }
}
