using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewSnake
{
    interface IDraw
    {
        void Draw();
    }

    public class Item : IDraw
    {
        public int X;
        public int Y;
        public char Ch;

        public Item(int x, int y, char ch)
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

    public class Walls : IDraw
    {
        public List<Item> WallItems = new List<Item>();

        public Walls(int maxX, int maxY)
        {

        }

        public void Draw()
        {
            foreach (var item in WallItems)
            {
                Console.SetCursorPosition(item.X, item.Y);
                Console.Write(item.Ch);
            }
        }
    }

    class Program
    {
        static int x = 0;
        static int y = 0;
        static Walls walls;
        static Snake snake;

        static void Main(string[] args)
        {
            int consoleWidth = 70;
            int consoleHeight = 50;

            Console.SetWindowSize(consoleWidth, consoleHeight);
            Console.CursorVisible = false;
            walls = new Walls(consoleWidth, consoleHeight);
            snake = new Snake(consoleWidth / 2, consoleHeight / 2);

            Timer timer = new Timer(Draw, null, 100, 500);

            while(true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                snake.SetDirection(key.Key);
            }

            Console.ReadLine();
        }

        static void Draw(object state)
        {
            Console.Clear();

            snake.Move();

            snake.Draw();
            walls.Draw();
            //food.Draw();
        }
    }
}
