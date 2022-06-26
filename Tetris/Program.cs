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
            int y_ = y;
            Console.BackgroundColor = bg;

            Console.ForegroundColor = fg;

            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x + j, y_);
                    Console.Write("{0}", cell[i, j] == 0 ? ' ' : '*');
                }
                y_++;
            }
        }

        public void Clear() 
        {
            int y_ = y;
            Console.BackgroundColor = ConsoleColor.Black;

            Console.ForegroundColor = ConsoleColor.Black;

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

        /*private int[,] DefaultCell1()         //ARRAYLIST IS CLEARNER
        {
            int[,] cell =
            {
                { 1, 1, 1 },
                { 1, 1, 1 },
                { 1, 1, 1 }
            };

            return cell;
        }
        private int[,] DefaultCell2()
        {
            int[,] cell =
            {
                { 0, 1, 0 },
                { 1, 1, 1 },
                { 0, 0, 0 }
            };

            return cell;
        }
        private int[,] DefaultCell3()
        {
            int[,] cell =
            {
                { 0, 1, 0 },
                { 0, 1, 0 },
                { 0, 1, 0 }
            };

            return cell;
        }
        private int[,] DefaultCell4()
        {
            int[,] cell =
            {
                { 1, 0, 0 },
                { 1, 0, 0 },
                { 1, 1, 1 }
            };

            return cell;
        }
        private int[,] DefaultCell5()
        {
            int[,] cell =
            {
                { 0, 0, 0 },
                { 0, 1, 0 },
                { 0, 0, 0 }
            };

            return cell;
        }
        private int[,] DefaultCell6()
        {
            int[,] cell =
            {
                { 1, 1, 0 },
                { 0, 1, 0 },
                { 0, 1, 1 }
            };

            return cell;
        }*/

        private int[,] GetCell(int idx)
        {
            ArrayList DefaultCell = new ArrayList();

            DefaultCell.Add(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });

            DefaultCell.Add(new int[,] { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } });

            DefaultCell.Add(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } });

            DefaultCell.Add(new int[,] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } });

            DefaultCell.Add(new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } });

            DefaultCell.Add(new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 0, 0 } });

            return (int[,])DefaultCell[idx];
        }


      /*  private int[,] GetCell1(int idx)          // The old longer way
        {
            switch(idx)
            {
                case 1:
                    return DefaultCell1();
                    
                case 2:
                    return DefaultCell2();
                    
                case 3:
                    return DefaultCell3();
                    
                case 4:
                    return DefaultCell4();
                    
                case 5:
                    return DefaultCell5();
                    
                
                    
            }
            return DefaultCell6();
        }*/

        /*private int[,] NextCell1()            // This one doesn't work with ArrayList
        {
            int maxCell = 6;

            Random rando = new Random();

            return GetCell(rando.Next(maxCell) + 1);

        }*/
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
            x = 0;
            y = 0;
            this.bg = bg;
            this.fg = fg;

            cell = NextCell();
            
        }

        



    }
    internal class Program
    {
        /* private static int[,] board = 
         {
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 }
         };*/

        static Cell cell = new Cell(ConsoleColor.Black, ConsoleColor.DarkYellow);

        static void Main(string[] args)
        {
            
            cell.Draw();

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





            /*int x = 5;

            int y = 5;

            Console.BackgroundColor = ConsoleColor.Red;

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 15; j++)
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


            Console.SetCursorPosition(x, y);

            Console.WriteLine("Supreme");
            int bottom = 29;
            
            do
            {
                ConsoleKeyInfo key;

                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Escape)
                        break;

                switch (key.Key)
                {
                    case ConsoleKey.LeftArrow:
                        {
                            

                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(x, y);

                            Console.WriteLine("Supreme");

                            x--;

                            break;
                        }

                    case ConsoleKey.RightArrow:
                        {
                            

                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(x, y);

                            Console.WriteLine("Supreme");

                            x++;

                            break;
                        }

                    case ConsoleKey.UpArrow:
                        {
                            

                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(x, y);

                            Console.WriteLine("Supreme");

                            y--;

                            break;
                        }

                    case ConsoleKey.DownArrow:
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(x, y);

                            Console.WriteLine("Supreme");

                            y++;

                            break;
                        }

                }

                Console.BackgroundColor = ConsoleColor.Red;

                Console.ForegroundColor = ConsoleColor.White;


                if (x == 9)
                     x = 8;

                if (x == 0)
                    x = 1;

                if (y == bottom)
                {
                    Console.BackgroundColor = ConsoleColor.Red;

                    Console.ForegroundColor = ConsoleColor.White;

                    Console.SetCursorPosition(x, y - 1);

                    Console.WriteLine("Supreme");

                    x = 5;

                    y = 5;

                    bottom--;
                }
                
                Console.SetCursorPosition(x, y);

                Console.WriteLine("Supreme");
            } while (true);*/




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
            for (; ; )
            {
                Thread.Sleep(1000);

                cell.Y = cell.Y + 1;
            }
        }








    }
}
