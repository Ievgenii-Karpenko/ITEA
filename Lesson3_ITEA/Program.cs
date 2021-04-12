using System;

namespace Lesson3_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {

            int counter = 0;
            while (true)
            {
                Console.WriteLine($"Hello World! {counter}");
                counter++;

                if (counter == 20)
                    break;
            }

            do
            {
                Console.WriteLine("Hello from second cycle");
                counter++;
            }
            while (false);

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine($"{i}-th operation from FOR");
            }

            Console.WriteLine("-----------------------");

            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine($"{i}-th operation from FOR");
            }
            Console.WriteLine("-----------------------");

            string myString = "myString";

            for (int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine(myString[i]);
            }

            Console.WriteLine("-----------------------");

            foreach (char letter in myString)
            {
                Console.WriteLine(letter);
            }

            int height = 100;
            int width = 50;
            Console.SetWindowSize(height, width);
        }
    }
}
