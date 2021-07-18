using System;

namespace Lesson3_ITEA
{
    class Program
    {
        int a;
        static int b;
        static void Main(string[] args)
        {

            //int b = 16;
            //Console.WriteLine(Convert.ToString(b, 16));
            // DZ -- show in custom format

            //object o1 = null;
            //int a2 = 0;

            //double d1 = 15.0;
            //string abc = "abc";

            //int int1 = (int)d1;
            //int int2 = d1 as int;



        //label1:

            Console.WriteLine("After label1");


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

        //goto label1;

            for (int i = 0, j = 10; i< 10; i++, j--)
            {
                // code
            }

            for (int i = 0; i <= 10; i++)
            {
                if (i == 5)
                    continue;

                Console.WriteLine($"{i}-th operation from FOR");
            }

            Console.WriteLine("-----------------------");

            for (int i =10; i >= 0; i--)
            {
                Console.WriteLine($"{i}-th operation from FOR");
            }
            Console.WriteLine("-----------------------");

            string myString = "myString";

            for (int i = 0; i < myString.Length; i++)
            {
                Console.WriteLine($"Char at position {i} = " + myString[i]);
            }

            Console.WriteLine("-----------------------");

            foreach (var letter in myString)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
