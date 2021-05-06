using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public char Ch { get; set; }

        public static bool operator == (Point a, Point b) =>
                (a.X == b.X && a.Y == b.Y);
        public static bool operator != (Point a, Point b) =>
                (a.X != b.X || a.Y != b.Y);

        public Point(int x, int y, char ch)
        {
            X = x;
            Y = y;
            Ch = ch;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X,Y);
            Console.Write(Ch);
        }
    }
}
