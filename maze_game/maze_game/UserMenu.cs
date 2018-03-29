using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    class UserMenu
    {
        DialogueBox UserMenuBox;

        private Point position;
        public Size MenuSize;
        public List<string> MenuItems { get; private set; }
        public int SelectedIndex { get; private set; }

        public Point Position
        {
            get { return position; }
            set
            {
                position = value;
                UserMenuBox.UpdatePosition(value);
            }
        }
        public String Title { get; private set; }

        public ConsoleColor BorderColour { get; set; }
        public ConsoleColor TextColour { get; set; }
        public ConsoleColor SelectedColour { get; set; }

        private ConsoleKeyInfo KeyInput;

        public void Create(List<String> items, Point position,string title, int selected = 0,
            ConsoleColor borderColour = ConsoleColor.Yellow, ConsoleColor textColour = ConsoleColor.Gray,
            ConsoleColor selectedColour = ConsoleColor.Blue)
        {
            MenuItems = items;
            SelectedIndex = selected;
            Position = position;
            Title = title;

            BorderColour = borderColour;
            TextColour = textColour;
            SelectedColour = selectedColour;

            UserMenuBox = new DialogueBox();
            int maxWidth = title.Length;
            foreach (string item in items)
            {
                if (item.Length > maxWidth)
                {
                    maxWidth = item.Length;
                }
            }

            MenuSize = new Size(maxWidth + 4, items.Count + 4);
            UserMenuBox.Create(position, MenuSize, borderColour, ConsoleColor.Black, title);

        }


        public bool Update()
        {
            KeyInput = Console.ReadKey(true);

            switch (KeyInput.Key)
            {
                case ConsoleKey.UpArrow:
                {
                    SelectedIndex = (SelectedIndex > 0 ? SelectedIndex -= 1 : MenuItems.Count - 1);
                    return false;
                }
                case ConsoleKey.DownArrow:
                {
                    SelectedIndex = (SelectedIndex < MenuItems.Count - 1 ? SelectedIndex += 1 : 0);
                    return false;
                }
                case ConsoleKey.Enter:
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }

        public void Draw()
        {
            UserMenuBox.Draw();

            for (int i = 0; i < MenuItems.Count; i++)
            {
                Console.SetCursorPosition(Position.X + 2, Position.Y + 3 + i);
                if (i == SelectedIndex)
                {
                    Console.ForegroundColor = SelectedColour;
                }
                else
                {
                    Console.ForegroundColor = TextColour;
                }

                Console.Write(MenuItems[i]);
            }
        }
    }
}
