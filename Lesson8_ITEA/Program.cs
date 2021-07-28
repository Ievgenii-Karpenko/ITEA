using Lesson8_ITEA___;
using System;

namespace Lesson8_ITEA___
{
    public static class StringHelper
    {
        public static int GetCharCount(this string str, char ch)
        {
            int res = 0;
            foreach (var item in str)
            {
                if (item == ch)
                    res++;
            }
            return res;
        }
    }
}

namespace Lesson8_ITEA
{

    public class A
    {
        public static int A_st_field { get; set; }
        public int A_field { get; set; }

        static A()
        {
            Console.WriteLine("Inside STATIC C-TOR");
            A_st_field = 6;
        }

        public A()
        {
            Console.WriteLine("Inside common C-TOR");
            A_field = 3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(A.A_st_field);

            A a = new A();
            Console.WriteLine(a.A_field);

            //double cos = Math.Sin(180);

            string str = "asdrggf";
            var chars = str.GetCharCount('g');
            Console.WriteLine($"Count of 'g' = {chars}");

            //MyClass myObj = new MyClass();

            //int diff = MyClass.Diff(5, 6);
            //MyCalc.Diff(4, 5);

            //MyNonStaticCalc ccc = new MyNonStaticCalc();
            Console.WriteLine(MyNonStaticCalc.StaticName);

            //MyNonStaticCalc o = new MyNonStaticCalc();
            //o.Name
        }
    }
}
