using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_ITEA
{
    public static class MyCalc
    {
        //public string Name = "Unknown";

        public static string StaticName;
        public static int Sum(int num1, int num2) => num1 + num2;
        public static int Diff(int num1, int num2)
        {
            return num1 - num2;
        }

        static MyCalc()
        {
            StaticName = "164564";
        }

        public static int GetCharCount(this string ss, char ch)
        {
            int counter = 0;
            foreach (var item in ss)
            {
                if (item == ch)
                    counter++;
            }

            return counter;
        }
    }

    public class MyNonStaticCalc
    {
        public string Name = "Unknown";
        public static string StaticName;

        static MyNonStaticCalc()
        {
            StaticName = "164564";
            Console.WriteLine("Static c-tor");
        }

        public MyNonStaticCalc()
        {
            Console.WriteLine("NON Static c-tor");
        }
    }

}
