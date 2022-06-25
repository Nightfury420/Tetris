using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
           
        }

        private int[,] DefaultCell1()
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
        }



        private int[,] GetCell(int idx)
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
        }

        private int[,] NextCell()
        {
            int maxCell = 6;

            Random rando = new Random();

            return GetCell(rando.Next(maxCell) + 1);

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
            private static int[,] board = 
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
            };


        static void Main(string[] args)
        {

            Cell cell = new Cell(ConsoleColor.Black, ConsoleColor.DarkYellow);
            cell.Draw();

            Console.ForegroundColor = ConsoleColor.Black;
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


       



    }  
}
