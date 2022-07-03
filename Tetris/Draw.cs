using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tetris
{
    class Draw
    {
        const int WIDTH = 2;

        const int HEIGHT = 1;

        public int Width
        {
            get
            {
                return WIDTH;
            }
        }

        public int Height
        {
            get
            {
                return HEIGHT;
            }
        }
        public void drawRec(int xLeft, int yTop, int xRight, int yBottom, ConsoleColor Color)
        {
            for (int y = yTop; y < yBottom; y++)
            {
                for (int x = xLeft; x < xRight; x++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.BackgroundColor = Color;
                    Console.CursorVisible = false;
                    Console.Write(' ');
                }
            }
        }
    }
}
