using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static Wall wall;
        static Snake snake;
        static int maxX = 100;
        static int maxY = 60;

        static void Main(string[] args)
        {
            

            Console.SetWindowSize(maxX + 2, maxY + 2);
            Console.SetBufferSize(maxX + 2, maxY + 2);

            wall = new Wall(maxX, maxY);
            snake = new Snake(maxX/2, maxY/2);

            Draw();
            //Timer t = new Timer(Draw, null, 0, 500);


            Console.ReadLine();
        }

        static void GameOver()
        {
            Console.SetCursorPosition(maxX/2, maxY/2);
            Console.WriteLine("Game over!");
        }

        static void Draw()
        {
            while (true)
            {
                Console.Clear();
                wall.Draw();
                snake.Draw();


                if(!snake.Move())
                {
                    GameOver();
                    return;
                }

                Thread.Sleep(200);
            }
            
        }
    }
}
