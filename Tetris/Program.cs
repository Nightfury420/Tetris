using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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

        static void Main(string[] args)
        {
       


            int x = 5;

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
            } while (true);




        }



    
    }
