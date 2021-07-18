using System;

namespace Lesson4_2
{
    class Program
    {
        static private void PrintHelloMsg()
        {
            Console.WriteLine("Greetings");
        }

        static private void PrintHelloMsg(string name2 = "asd", string surname = "")
        {
            Console.WriteLine("Greetings");
            Console.WriteLine($"My name is {name2} {surname}");
        }

        static private void PrintHelloMsg(string name2) => PrintHelloMsg(name2, "");


        static void Print3Vals(string a, string b, string c) => Console.WriteLine($"{a}, {b}, {c}");

        static private void SetNumberTo5(ref int num)
        {
            num = 5;
            Console.WriteLine("num = " + num);
        }

        static private int SetNumberTo5(int num)
        {
            num *= 5;
            Console.WriteLine("num = " + num);
            return num;
        }

        static private void SetParamsTo5(out int a, out int b, out int c)
        {
            a = 5;
            b = 5;
            c = 5;
        }

        static private (int,object,int) SetParamsTo7() => (7, 8, 9);
        //{
        //    return (7, 8, 9);
        //}

        static private Tuple<int, int, int> SetParamsTo789() => new Tuple<int, int, int>(7, 8, 9);

        private static void Set2ParamsTo5(in int a, int b)
        {
            //a = 5;
            b = 5;
        }

        private static void ReadInput(int[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        private static void ReadInputParams(params int[] input)
        {
            foreach (var item in input)
            {
                Console.WriteLine(item);
            }
        }

        private static void PrintData<T>(T input)
        {
            Console.WriteLine(input);
        }

        //private static void PrintData(double input)
        //{
        //    Console.WriteLine(input);
        //}

        //private static void PrintData(string input)
        //{
        //    Console.WriteLine(input);
        //}


        static void Main(string[] args)
        {
            PrintData(4);
            PrintData(4.5);
            PrintData("44");

            //PrintData(4);
            //PrintData(4.5);
            //PrintData("44");


            int[] intArray = new int[3];
            intArray[0] = 11;
            intArray[1] = 22;
            intArray[2] = 33;

            ReadInput(intArray);
            Console.WriteLine("-----------------------");
            ReadInputParams(intArray);
            Console.WriteLine("-----------------------");

            ReadInputParams(4,5,6,7,8,9,0,123,435,333);
            Console.WriteLine("-----------------------");
            //ReadInput(5,9,8,4);

            //Console.WriteLine("Pls enter name");
            //string name = Console.ReadLine();

            //PrintHelloMsg(name);

            //PrintHelloMsg(name, "Karpenko");

            //PrintHelloMsg(surname: "Pilipenko");

            //Print3Vals(c: "this is c", a: "a-val", b: "b");

            int a;
            //Console.WriteLine("a = " + a);
            //SetNumberTo5(ref a);
            //a = SetNumberTo5(a);
            //Console.WriteLine("a = " + a);

            //int a1, b1, c1;

            //SetParamsTo5(out a1, out b1, out c1);

            //Console.WriteLine($"{a1}, {b1}, {c1}");


            //(int q, int w, int e) = SetParamsTo7();
            //Console.WriteLine(q);
            //Console.WriteLine(w);
            //Console.WriteLine(e);

            //Tuple<int, int, int> abc = SetParamsTo789();
            //Console.WriteLine(abc.Item1);
            //Console.WriteLine(abc.Item2);
            //Console.WriteLine(abc.Item3);

            Console.WriteLine("Fib num3 = " + GetFibonNumber(9999));

        }

        // 1, 1, 2, 3, 5, 8
        private static int GetFibonNumber(int num)
        {
            if (num == 1 || num == 2)
                return 1;

            return GetFibonNumber(num - 1) + GetFibonNumber(num - 2);
        }
    }
}
