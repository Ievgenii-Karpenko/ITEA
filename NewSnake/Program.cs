using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewSnake
{
    public class Item
    {
        public int X;
        public int Y;
        public char Ch;

    }

    public class Walls
    {
        public List<Item> WallItems = new List<Item>();

        public Walls(int maxX, int maxY)
        {

        }

        public void Draw()
        {
            foreach (var item in Walls)
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
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 60);
            Console.CursorVisible = false;
            walls = new Walls(30, 60);

            Snake snake = new Snake();

            Timer timer = new Timer(Draw, null, 100, 500);

            while(true)
            {
                var key = Console.ReadKey();
                snake.SetDirection(key);
            }

            Console.ReadLine();
        }

        static void Draw(object state)
        {
            Console.Clear();
            Console.SetCursorPosition(x++,y++);
            snake.Draw();
            walls.Draw();
            food.Draw();
        }
    }
}
