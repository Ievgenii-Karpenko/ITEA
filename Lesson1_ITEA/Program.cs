using System;

namespace Lesson1_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string someInfo = Console.ReadLine();

            Console.WriteLine("You wrote: " + someInfo);

            int myInt = 2;
            //int myInt2;

            Console.WriteLine("The max int value is: " + int.MaxValue);
            Console.WriteLine("The size of Int: " + sizeof(int));

            float floatVar = 3.0f;
            double doubleVar = 3.0;
            double doubleVar2 = 6.0;

            char myChar = '\x654';


            double result = doubleVar2 - doubleVar;
            int summa = (int)doubleVar2 + myInt;

            byte myByte = 255;
        }
    }
}
