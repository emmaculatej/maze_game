using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    class Game
    {
        MainMenu MainMenu = new MainMenu();
        public bool IsRunning { get; set; }

        public void GameInitialisation()
        {
            MainMenu.Init();
            IsRunning = true;
        }

        public void GameLoop()
        {
            while (IsRunning)
            {
                MainMenu.menu.Draw();
                MainMenu.Update();
            }
        }
    }
}
