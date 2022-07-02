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

        private ConsoleColor bg, fg;

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

        private int[,] GetCell(int idx)
        {
            ArrayList DefaultCell = new ArrayList();

            DefaultCell.Add(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });

            DefaultCell.Add(new int[,] { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } });

            DefaultCell.Add(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } });

            DefaultCell.Add(new int[,] { { 0, 1, 1 }, { 0, 0, 1 }, { 0, 0, 1 } });

            DefaultCell.Add(new int[,] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } });

            DefaultCell.Add(new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } });

            DefaultCell.Add(new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 0, 0 } });

            return (int[,])DefaultCell[idx];
        }

        private int[,] NextCell()
        {
            int maxCell = 7;

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

        public void Rotate()
        {
            const int N = 3;
            int[,] tmp = new int[3, 3];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    tmp[j, N - 1 - i] = cell[i, j];
                }
            }

            cell = tmp;

            Draw();
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
}
