using System;

namespace Lesson8_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyClass myObj = new MyClass();

            //int diff = MyClass.Diff(5, 6);
            //MyCalc.Diff(4, 5);

            //MyNonStaticCalc ccc = new MyNonStaticCalc();
            Console.WriteLine(MyNonStaticCalc.StaticName);

            //MyNonStaticCalc o = new MyNonStaticCalc();
            //o.Name

            string myString = "abbccc";

            int count = myString.GetCharCount('c');
            Console.WriteLine("Result = " + count);
        }
    }
}
