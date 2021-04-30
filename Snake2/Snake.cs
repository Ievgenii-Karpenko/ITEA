using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class Snake
    {
        private List<Point> snake = new List<Point>();
        //private Point head;

        public Snake(int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                Point p = new Point(x, y + i, 'o');
                snake.Add(p);
            }
        }

        public void Draw()
        {
            foreach (var item in snake)
            {
                item.Draw();
            }
        }

        public bool Move()
        {
            // Direction UP
            //Point tail = snake[snake.Count - 1];
            //Point head = snake[0];
            //tail.X = head.X;
            //tail.Y = head.Y - 1;

            foreach (var item in snake)
            {
                if(item.Y == 0)
                {
                    return false;
                }
                item.Y--;
            }

            return true;
        }
    }
}
