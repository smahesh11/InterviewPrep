using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep.TreesAndGraphs
{
    public class FriendCirclesGraph
    {

        public static void main(String[] args)
        {

            char[][] friends = { "YYNN".ToCharArray(), "YYYN".ToCharArray(), "NYYN".ToCharArray(), "NNNY".ToCharArray() };
           Console.WriteLine(getFriendCircles(friends));
        }

        public static int getFriendCircles(char[][] friends)
        {

            if (friends == null || friends.Length < 1)
                return 0;

            int noOfCircles = 0;

            bool[] visited = new bool[friends.Length];

            for (int i = 0; i < visited.Length; i++)
                visited[i] = false;

            for (int i = 0; i < friends.Length; i++)
            {
                if (!visited[i])
                {
                    noOfCircles++;
                    visited[i] = true;
                    findFriends(friends, visited, i);
                }
            }

            return noOfCircles;

        }

        public static void findFriends(char[][] friends, bool[] visited, int id)
        {

            for (int i = 0; i < friends.Length; i++)
            {
                if (!visited[i] && i != id &&   friends[id][i] == 'Y')
                {
                    visited[i] = true;
                    findFriends(friends, visited, i);
                }
            }
        }

        }
    }
