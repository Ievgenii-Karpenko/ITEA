using System;

namespace Lesson4_ITEA
{
    class Program
    {
        static void PrintHelloMsg()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("My name is Yevhenii");
        }

        static void Main(string[] args)
        {




            string name = "Default";
            name = GetNameFromParams(args: args, name: name);

            Console.WriteLine($"hello {name}");

            Console.WriteLine("Size of args is: " + args.Length);

            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                arr[i] = i * 3;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"The vale of {i}-th = {arr[i]}");
            }

            Console.WriteLine($"The vale of {6}-th = {arr[6]}");


            Console.WriteLine("Hello World!");
            SayHello("Ivegenii");
            SayHello("Iryna");
            SayHello("Ivegenii", "Iryna");
            SayHello2("Petro");
            int summa = Sum(10, 7);
            Console.WriteLine($"Sum result = {summa}");
            Console.WriteLine($"Diff result = {Diff(10, 7)}");

            int a = 10;
            Console.WriteLine($"a = {a}");
            Add5(ref a);
            Console.WriteLine($"Result: {a}");

            Mult(5, 5, out int multResult);
            Console.WriteLine($"MultResult = {multResult}");

            //int[] arr = new[] { 1, 2, 4 };
            int res = AddMany("Ievgenii", arr);
            Console.WriteLine("Result: " + res);
            res = AddMany("Sam", 50);
            Console.WriteLine("Result: " + res);
            res = AddMany("Andriy", 5, 10, 20, 30);
            Console.WriteLine("Result: " + res);

            Console.WriteLine($"Max uint = {long.MaxValue}");
            for (long i = 0; i < 2000; i++)
            {
                long facts = Factorial(i);
                Console.WriteLine($"{i}! =\t{facts}");
            }

            long fact = Factorial(1000000);
            Console.WriteLine($"10000! =\t{fact}");

            for (int i = 2; i < 10; i++)
            {
                for (int y = 1; y < 10; y++)
                {
                    Console.WriteLine($"{i}*{y} = {i * y}");
                }
                Console.WriteLine();
            }

        }

        private static string GetNameFromParams(string[] args, string name)
        {
            if (args != null)
            {
                foreach (var item in args)
                {
                    if (item.StartsWith("name="))
                    {
                        name = item.Substring(5);
                    }
                }
            }

            return name;
        }

        //static void SayHello(string userName)
        //{
        //    Console.WriteLine($"Hello I'm {userName}");
        //}

        static void SayHello(string userName, string anotheruser = "Unknown")
        {
            Console.WriteLine($"Hello {anotheruser}, I'm {userName}");
        }

        static void SayHello2(string userName, string anotheruser = "Unknown", int age = 25)
        {
            Console.WriteLine($"Hello {anotheruser}, I'm {userName} and I {age} years old");
        }

        static int Sum(int num1, int num2) => num1 + num2;
        static int Diff(int num1, int num2)
        {
            return num1 - num2;
        }

        static void Mult(in int num1, int num2, out int result)
        {
            //num1 = 5; // error
            result = num1 * num2;
        }

        static void Add5(ref int num)
        {
            num = num + 5;
            Console.WriteLine($"Result from method: {num}");
        }

        static int AddMany(string name, params int[] numbers)
        {
            Console.WriteLine(name);
            int result = 0;
            foreach (var item in numbers)
            {
                result += item;
            }
            return result;
        }

        // 0! = 1
        // 3! = 2! * 3
        // 4! = 1 * 2 * 3 * 4
        // 4! = 3! * 4

        static long Factorial(long x)
        {
            if (x == 0)
                return 1;

            return x * Factorial(x - 1);
        }
    }
}
