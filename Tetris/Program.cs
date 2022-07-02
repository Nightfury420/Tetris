using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Tetris
{
    class Cell
    {
        private int[,] cell = new int[3, 3];

        private int x, y;

        private ConsoleColor bg,fg;

        public void Draw() 
        {
            Console.BackgroundColor = bg;

            Console.ForegroundColor = fg;

            Draw_();
        }

        public void Clear() 
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Draw_();
        }

        private void Draw_()
        {
            int y_ = y;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x + j, y_);
                    Console.Write("{0}", cell[i, j] == 0 ? ' ' : '*');
                }
                y_++;
            }
        }

        public int size;

        public int sideWay;

        private int[,] GetCell(int idx)
        {
            ArrayList DefaultCell = new ArrayList();

            size = 0;

            sideWay = 0;

            DefaultCell.Add(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });

            DefaultCell.Add(new int[,] { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } });

            DefaultCell.Add(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } });

            DefaultCell.Add(new int[,] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } });

            DefaultCell.Add(new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } });

            DefaultCell.Add(new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 0, 0 } });

            switch(idx)
            {
                case 0:
                    sideWay = 3;
                    size = 3;
                    break;

                case 1:
                    sideWay = 3;
                    size = 3;
                    break;

                case 2:
                    sideWay = 1;
                    size = 1;
                    break;

                case 3:
                    sideWay = 3;
                    size = 3;
                    break;

                case 4:
                    sideWay = 1;
                    size = 3;
                    break;

                case 5:
                    size = 3;
                    sideWay = 2;
                    break;
            }    

            return (int[,])DefaultCell[idx];
        }

        private int[,] NextCell()
        {
            int maxCell = 6;

            Random rando = new Random();

            return GetCell(rando.Next(maxCell));

        }

        public int Y
        {
            set
            {
                Clear();

                y = value;

                Draw();
            }

            get 
            { 
                return y; 
            }

        }

        public int X
        {
            set
            {
                Clear();

                x = value;

                Draw();
            }

            get
            {
                return x;
            }

        }

        public void Move() 
        { 

        }

        public Cell(ConsoleColor bg, ConsoleColor fg)
        {
            cell = new int[3, 3];
            x = 6;
            y = 0;
            this.bg = bg;
            this.fg = fg;

            cell = NextCell();
            
        }

        



    }
    internal class Program
    {
        private static int[,] board = 
        {
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 1 },
             { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 , 2, 2 }
        };

        private static void DrawBoard()
        {
            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    if (board[i, j] == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("|");
                    }

                    else if (board[i, j] == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("-");
                    }

                    else if (board[i, j] == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            return;
        }

        static Cell cell = new Cell(ConsoleColor.Black, ConsoleColor.DarkYellow);

        static void Main(string[] args)
        {
            DrawBoard();

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

            Thread.Sleep(1000);

            cell.Clear();

        }

        private static void ReadKeys()
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
                        break;

                    case ConsoleKey.DownArrow:
                        cell.Y = cell.Y + 3;
                        break;
                }
            }

            return;
        }

        private static void Animation()
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
