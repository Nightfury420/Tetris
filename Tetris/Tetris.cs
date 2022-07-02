using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tetris
{
    class Tetris
    {
        private Cell cell ;

        public void Run()
        {
            var readKeys = new Task(ReadKeys);

            var animation = new Task(Animation);

            readKeys.Start();

            animation.Start();

            var tasks = new[] { readKeys };

            Task.WaitAll(tasks);

            Console.CancelKeyPress += (sender, e) =>
            {
                Environment.Exit(0);
            };

        }

        public Tetris()
        {
            cell = new Cell(ConsoleColor.Black, ConsoleColor.DarkYellow);
        }
        private void ReadKeys()
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            while (!Console.KeyAvailable && key.Key != ConsoleKey.Escape)
            {
                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        cell.X = cell.X - 1;
                        break;

                    case ConsoleKey.RightArrow:
                        cell.X = cell.X + 1;
                        break;

                    case ConsoleKey.UpArrow:
                        cell.Rotate();
                        break;

                    case ConsoleKey.DownArrow:
                        cell.Y = cell.Y + 3;
                        break;
                }
            }

            return;
        }

        private void Animation()
        {
            cell.Draw();

            for (; ; )
            {
                Thread.Sleep(1000);

                cell.Y = cell.Y + 1;
            }
        }

        
    }
}
