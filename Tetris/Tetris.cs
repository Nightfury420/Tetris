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
        private Board board;

        public void Run()
        {
            board.drawBoard();

            var readKeys = new Task(ReadKeys);

            var animation = new Task(Animation);

            cell.Draw();
            readKeys.Start();

            //animation.Start();

            var tasks = new[] { readKeys };

            Task.WaitAll(tasks);

            Console.CancelKeyPress += (sender, e) =>
            {
                Environment.Exit(0);
            };

        }

        public Tetris()
        {
            cell = new Cell(ConsoleColor.Black, ConsoleColor.DarkRed);
            board = new Board(ConsoleColor.Black, ConsoleColor.DarkBlue);
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
                        int i, j;
                        for(j = 0; j < 3; j++)
                        {
                            for (i = 0; i < 3; i++)
                                if (cell.cell[i, j] == 1)
                                    break;
                            if (i < 3)
                                break;
                        }
                        cell.X = cell.X - 1;
                        break;

                    case ConsoleKey.RightArrow:
                        for (j = 2; j >= 0; j--)
                        {
                            for (i = 0; i < 3; i++)
                                if (cell.cell[i, j] == 1)
                                    break;
                            if (i < 3)
                                break;
                        }
                        cell.X = cell.X + 1;
                        break;

                    case ConsoleKey.UpArrow:
                        cell.Rotate();
                        break;

                    case ConsoleKey.DownArrow:
                        for (i = 2; i >= 0; i--)
                        {
                            for (j = 0; j < 3; j++)
                                if (cell.cell[i, j] == 1)
                                    break;
                            if (j < 3)
                                break;
                        }
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
