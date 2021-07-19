using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewSnake
{
    class Program
    {
        static int x = 0;
        static int y = 0;
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 60);
            Console.CursorVisible = false;
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
            wall.Draw();
            food.Draw();
        }
    }
}
