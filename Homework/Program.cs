using System;
using System.Collections;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("Введите номер двери от 1 до 5. Для выхода введите \"exit\": ");
                string door = Console.ReadLine();
                if (door == "exit") break;
                if (door == "1" || door == "2" || door == "3" || door == "4" || door == "5")
                {
                    int rnd = new Random().Next(1, 5);
                    if (door == rnd.ToString()) 
                    { 
                        Console.WriteLine("Вы нашли сокровище!"); 
                        continue; 
                    };
                    rnd++;
                    if (rnd > 5) 
                        rnd = 1;
                    if (door == rnd.ToString()) 
                        Console.WriteLine("Вы убиты!!!");
                    else Console.WriteLine("Пусто...");
                }
                else Console.WriteLine("Вы куда-то не туда попали. Попробуйте ещё раз.");
            } while (true);
        }
    }
}
