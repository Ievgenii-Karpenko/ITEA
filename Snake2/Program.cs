using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static Wall wall;
        static Snake snake;
        static Point food;
        static int maxX = 100;
        static int maxY = 60;
        static int score = 0;
        static BackgroundWorker bgReadKey = new BackgroundWorker();
        static ConsoleKey pressedKey = ConsoleKey.UpArrow;
        static string saveFilePath = "SavedGame.txt";

        static void Main(string[] args)
        {
            bgReadKey.DoWork += bgReadKey_DoWork;
            //bgReadKey.RunWorkerCompleted += bgReadKey_RunWorkerCompleted;
            bgReadKey.RunWorkerAsync();

            Console.SetWindowSize(maxX + 22, maxY + 2);
            Console.SetBufferSize(maxX + 22, maxY + 2);
            Console.CursorVisible = false;

            wall = new Wall(maxX, maxY, '#');
            snake = new Snake(maxX/2, maxY/2);
            food = FoodFactory.GenerateFood(maxX, maxY, snake);

            //Draw();
            Timer t = new Timer(Draw, null, 0, 500);

            while (true)
            {//Read the pressed key
                //snake.Move(pressedKey, maxX, maxY);
            }

            Console.ReadLine();

        }



        static void ShowScore()
        {
            Console.SetCursorPosition(maxX + 3, 2);
            Console.Write($"Score: {score}");
        }

        static void GameOver()
        {
            Console.SetCursorPosition(maxX/2, maxY/2);
            Console.WriteLine("Game over!");
        }

        static void Save(Snake snake, Point food, int foodCounter)
        {
            Console.Clear();

            using (StreamWriter sw = new StreamWriter(saveFilePath, false, Encoding.Default))
            {
                string stringToWrite = "s";
                foreach (var item in snake.snake)
                {
                    stringToWrite += "," + item.X + ":" + item.Y;
                }
                sw.WriteLine(stringToWrite);

                stringToWrite = "f," + food.X + ":" + food.Y;
                sw.WriteLine(stringToWrite);

                stringToWrite = "c," + foodCounter;
                sw.WriteLine(stringToWrite);

                sw.Close();
            }

            //Game.Close();

        }

        static void LoadGame()
        {
            Console.Clear();
            wall = new Wall(x, y, '#');
            string[] lines = File.ReadAllLines(saveFilePath);
            foreach (var line in lines)
            {
                switch (line[0])
                {
                    case 's':
                        snake = new Snake(line);
                        break;
                    case 'f':
                        int foodX = Convert.ToInt32(line.Split(',')[1].Split(':')[0]);
                        int foodY = Convert.ToInt32(line.Split(',')[1].Split(':')[1]);
                        foodFactory = new FoodFactory();
                        foodFactory.CreateFood(foodX, foodY, '@');
                        break;
                    case 'c':
                        foodCounter = Convert.ToInt32(line.Split(',')[1]);
                        break;
                }
            }
            time = new Timer(Loop, null, 0, 300);
        }


        static void Draw()
        {
            while (true)
            {
                Console.Clear();
                wall.Draw();
                food.Draw();
                ShowScore();

                if (!snake.Move(pressedKey, maxX, maxY, food))
                {
                    
                    GameOver();
                    return;
                }

                snake.Draw();
                Thread.Sleep(300);
            }
        }

        private static void bgReadKey_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            { 
                pressedKey = Console.ReadKey().Key;
            }
        }
    }
}


// 1. Зробити окренимий енум для напряму руху
// 2. Прибирати їду і генерувати нову
// 3. Зробити інкремент score при з"їданні

//-------------
// 1. Add menu for load and new game
// 2. Implement save and load of snake, food, score to file -- use help menu

// Snake: {1,2} {1,3} ... {2,5}
// Food: {1,2}
// Score: 123