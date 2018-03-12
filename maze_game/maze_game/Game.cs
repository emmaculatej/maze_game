using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    class Game
    {
        public bool IsRunning { get; set; }

        public void GameInitialisation()
        {
            IsRunning = true;
        }

        public void GameLoop()
        {
            while (IsRunning)
            {

            }
        }
    }
}
