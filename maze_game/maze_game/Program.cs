using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maze_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Box maze_area = new Box();
            maze_area.Create(new System.Drawing.Point(5, 5), new System.Drawing.Size(100, 20), ConsoleColor.White, ConsoleColor.Black);
            maze_area.Draw();

            Console.ReadLine();
        }
    }
}
