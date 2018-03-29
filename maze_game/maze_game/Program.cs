using System;
using System.Collections.Generic;
using System.Drawing;

namespace maze_game
{
    class Program
    {
        static void Main(string[] args)
        {

            // Introduction to the Game
            DialogueBox mazeIntroduction = new DialogueBox();
            mazeIntroduction.Create(new Point(1, 1), new Size(14, 14), ConsoleColor.White, ConsoleColor.Black, "Welcome to the Maze!");
            mazeIntroduction.Draw();


            //Box maze_area = new Box();
            //maze_area.Create(new Point(5, 5), new Size(100, 20), ConsoleColor.White, ConsoleColor.Black);
            //maze_area.Draw();

            List<string> items = new List<string>() {"Item1", "Item2", "Item3"};

            UserMenu menu = new UserMenu();
            menu.Create(items, new Point(5, 5), "Main Menu");
            while (true)
            {
                menu.Draw();

                if (menu.Update())
                {
                    Console.Write("Get Ready...");
                    break;
                }
            }
             
            Console.ReadLine();
        }
    }
}