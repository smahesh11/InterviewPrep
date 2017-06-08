
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class RobotInGrid
    {
        public List<Point> FindPath(bool[][] maze)
        {
            if (maze.Length == 0 || maze[0].Length == 0 || maze == null)
                return null;

            List<Point> path = new List<Point>();
            HashSet<Point> failed = new HashSet<Point>();

           bool isPath= FindPath(maze, failed, path, maze.Length-1, maze[0].Length-1);

            return null;
        }

        public bool FindPath(bool[][] maze, HashSet<Point> failed, List<Point> path, int row, int col)
        {
            if (row < 0 || col < 0 || !maze[row][col])
                return false;

            Point P = new Point(row, col);

            if (failed.Contains(P))
                return false;

            bool isOrigin = false;
            if (row == 0 && col == 0)
                isOrigin = true;

            if (isOrigin || FindPath(maze, failed, path, row - 1, col) || FindPath(maze, failed, path, row, col - 1))
            {
                path.Add(P);
                return true;
            }

            failed.Add(P);

            return false;
        }
    }

    public class Point
    {
        int x; int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
