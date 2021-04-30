using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class Wall
    {
        private List<Point> points = new List<Point>();
        private char Ch = 'W';

        public Wall(int maxX, int maxY)
        {
            for (int i = 0; i < maxX; i++)
            {
                Point p = new Point(i, 0, Ch);
                points.Add(p);
                p = new Point(i, maxY, Ch);
                points.Add(p);
            }

            for (int i = 0; i < maxY; i++)
            {
                Point p = new Point(0, i, Ch);
                points.Add(p);
                p = new Point(maxX, i, Ch);
                points.Add(p);
            }
        }

        public void Draw()
        {
            foreach (var item in points)
            {
                item.Draw();
            }
        }

    }
}
