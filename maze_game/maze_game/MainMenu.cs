using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    class MainMenu
    {
        private UserMenu menu;

        public List<string> MenuItems { get; private set; }

        public void Init()
        {
            menu = new UserMenu();
            MenuItems = new List<string> {"New Game", "Load Game", "Credits", "Exit"};

            menu.Create(MenuItems, new Point(0,0), "Main Menu" );

            int x = (Console.WindowWidth / 2) - (menu.MenuSize.Width / 2);
            int y = (Console.WindowHeight / 2) - (menu.MenuSize.Height / 2);

            menu.Position = new Point(x,y);
        }

        public void Update()
        {
            if (menu.Update())
            {
                switch (menu.SelectedIndex)
                {
                    case (0):
                    // New Game
                        break;
                    case (1):
                    // Load Game
                        break;
                    case (2):
                    // Credits
                        break;
                    case (3):
                        // Exit
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
