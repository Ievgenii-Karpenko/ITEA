using System;
using System.Text;

namespace Lesson1_ITEA
{
    class Program
    {
        static int A = 123;

        const double PI = 3.14;
        //const double PI2;
        readonly int ABC;

        static void Main(string[] args)
        {
            //string name;
            //name = "Anatoliy";

            //Console.WriteLine(name);

            //string name2 = "Ievgenii";

            //Console.WriteLine("Enter your name:");
            //string someInfo = Console.ReadLine();

            //Console.WriteLine("You wrote: " + someInfo);

            //Console.OutputEncoding = Encoding.ASCII;

            //PI = 2;
            //ABC = 5;

            int myInt = 2;
            Int32 i2 = 2;
            System.Int64 asd = 46;

            string data = "The max int value is: " + int.MaxValue;

            Console.WriteLine(data);
            Console.WriteLine("The size of Int: " + sizeof(int));

            { 
                float floatVar = 3.0f + myInt;
                double doubleVar = 4.123 + A;
                double doubleVar2 = 6.5;
                float f1 = (float)doubleVar;

                {
                    Console.WriteLine(doubleVar);
                }
            }
            { 
                double doubleVar = 4.123 + A;
            }

            string myStr = "abcd";
            string myStr2 = "a";

            char myChar1 = 'a';
            char myChar2 = '\x654';
            char myChar3 = '\\';
            char myChar4 = '\'';

            Console.WriteLine("My name\\nis\\tIevgenii");


            double result = doubleVar2 / doubleVar;

            Console.WriteLine($"Result = {result}");

            double summa = doubleVar2 + myInt; // 8.5

            //String.Format(...)  -  $""

            Console.WriteLine(string.Format("summa = {0:#.###} -- {1}", result, summa));
            Console.WriteLine($"summa = {result:#.###} -- {summa}");

            byte myByte = 255;
            myByte++;
            myByte++;
            myByte++;// myByte = myByte + 1;

            Console.WriteLine($"myByte = {myByte}");

            decimal myDec = 123456789;
        }


        // Format double output
    }
}
