using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public enum Color { red, blue, green };
    public class PaintFill {

        public void Fill(Color[][] screen, Color ncolor, int row, int col)
        {
            if (screen[row][col] == ncolor)
                return;

            Fill(screen, screen[row][col], ncolor, row, col);
        }

        public bool Fill(Color[][] screen, Color ocolor, Color ncolor, int row, int col)
        {
            if (row < 0 || col < 0 || row > screen.Length - 1 || col > screen[0].Length)
                return false;

            if (screen[row][col] == ocolor)
            {
                screen[row][col] = ncolor;
                Fill(screen, screen[row][col], ncolor, row+1, col);
                Fill(screen, screen[row][col], ncolor, row-1, col);
                Fill(screen, screen[row][col], ncolor, row, col+1);
                Fill(screen, screen[row][col], ncolor, row, col-1);
            }

            return true;
        }
        
    }
}
