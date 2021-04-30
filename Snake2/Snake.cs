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
        private char ch = 'o';
        private Point head;
        private ConsoleKey direction = ConsoleKey.UpArrow;

        public Snake(int x, int y)
        {
            for (int i = 0; i < 3; i++)
            {
                Point p = new Point(x, y + i, ch);
                snake.Add(p);
            }
            head = snake[0];
        }

        public void Draw()
        {
            foreach (var item in snake)
            {
                item.Draw();
            }
        }

        public bool Move(ConsoleKey direction, int maxX, int maxY, Point food)
        {
            if (0 >= head.Y || head.Y >= maxY || 0 >= head.X || head.X >= maxX)
                return false;

            int tmpX = head.X;
            int tmpY = head.Y;
            bool directionChanged = false;
            
            switch (direction)
            {
                case ConsoleKey.UpArrow:
                    if(this.direction != ConsoleKey.DownArrow)
                    {
                        directionChanged = true;
                        tmpX = head.X;
                        tmpY = head.Y - 1;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (this.direction != ConsoleKey.UpArrow)
                    {
                        directionChanged = true;
                        tmpX = head.X;
                        tmpY = head.Y + 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (this.direction != ConsoleKey.LeftArrow)
                    {
                        directionChanged = true;
                        tmpX = head.X + 1;
                        tmpY = head.Y;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (this.direction != ConsoleKey.RightArrow)
                    {
                        directionChanged = true;
                        tmpX = head.X - 1;
                        tmpY = head.Y;
                    }
                    break;
            }

            int tailX = snake[snake.Count - 1].X;
            int tailY = snake[snake.Count - 1].Y;

            for (int i = snake.Count - 1; i > 0; i--)
            {
                snake[i].X = snake[i - 1].X;
                snake[i].Y = snake[i - 1].Y;
            }
            head.X = tmpX;
            head.Y = tmpY;

            if (tmpX == food.X && tmpY == food.Y)
            {
                snake.Add(new Point(tailX, tailY, ch));
            }

            if (directionChanged)
            {
                this.direction = direction;
            }

            return true;
        }
    }
}
