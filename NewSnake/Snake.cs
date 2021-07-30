using System;
using System.Collections.Generic;

namespace NewSnake
{
    public enum Direction
    {
        Up, Down, Left, Right
    }

    public class Snake : IDraw
    {
        private List<Item> snake = new List<Item>();
        private char snakeChar = 'O';

        public Direction Direction = Direction.Left;

        public Snake(int x, int y)
        {
            snake.Add(new Item(x, y, snakeChar));
            snake.Add(new Item(x + 1, y, snakeChar));
            snake.Add(new Item(x + 2, y, snakeChar));
        }

        public void Move()
        {
            switch (Direction)
            {
                case Direction.Up:
                    foreach (var item in snake)
                    {
                        item.Y--;
                    }
                    break;
                case Direction.Down:
                    break;
                case Direction.Left:
                    foreach (var item in snake)
                    {
                        item.X--;
                    }
                    break;
                case Direction.Right:
                    break;
                default:
                    break;
            }
        }

        public void Draw()
        {
            foreach (var item in snake)
            {
                item.Draw();
            }
        }

        internal void SetDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    Direction = Direction.Up;
                    break;
                default:
                    break;
            }
        }
    }
}