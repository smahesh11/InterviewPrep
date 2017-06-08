using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.Dynamic_Programming
{
    public class TowerOfHanoi
    {
        public void main()
        {
            int n = 3;
            Tower[] towers = new Tower[3];

            for (int i = 0; i < 3; i++)
            {
                Tower tower = new Tower(i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                towers[0].Add(i);
            }           
        }
    }

    public class Tower
    {
        Stack<int> disks;
        int index;
        public Tower(int i)
        {
            disks = new Stack<int>();
            index = i;
        }

        public void Add(int disk)
        {
            if (disks.Count != 0 || disks.Peek() < disk)
                return;

            else disks.Push(disk);
        }

        public int Index()
        {
            return index;
        }

        public void MoveDisks(int n, Tower buffer, Tower destination)
        {
            MoveDisks(n - 1, destination, buffer);
            MoveTopTo(destination);
            MoveDisks(n - 1, destination, buffer);
        }

        public void MoveTopTo(Tower destination)
        {
            int topDisk = disks.Pop();
            destination.Add(topDisk);
        }
    }
}
