using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace maze_game
{
    class Program
    {
        static void Main(string[] args)
        {

            // Introduction to the Game
            DialogueBox maze_introduction = new DialogueBox();
            maze_introduction.Create(new Point(1, 1), new Size(10, 10), ConsoleColor.White, ConsoleColor.Black, "Welcome to the Maze!");
            maze_introduction.Draw();


            //Box maze_area = new Box();
            //maze_area.Create(new Point(5, 5), new Size(100, 20), ConsoleColor.White, ConsoleColor.Black);
            //maze_area.Draw();

            Console.ReadLine();
        }
    }
}
