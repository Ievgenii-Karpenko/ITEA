using System;
using System.IO;

namespace Lesson10_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {

            // Singleton aaa = new Singleton();

            Singleton aaa = Singleton.GetInstance();


            //{ 
            //    int[] ar = new int[5];

            //    Console.WriteLine("Before catch");
            //}
            //try
            //{
            //    //Console.WriteLine(ar[5]);
            //    Console.WriteLine("Inside try");
            //    //FileStream sfs = new FileStream();
            //    //...
            //    // Exc
            //    //..
            //    var res = CallDevide(0, 4);

            //    Console.WriteLine($"Result: {res}");
            //}
            ////catch (FileNotFoundException ex)
            ////{
            ////    Console.WriteLine($"We catched an FileNotFoundException: {ex.Message}");
            ////}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine($"We catched an IndexOutOfRangeException: {ex.Message}");
            //}
            //catch (DevideByZeroException ex)
            //{
            //    Console.WriteLine($"We catched: {ex.Message}");
            //    Console.WriteLine($"MyMessage: {ex.MyMessage}");
            //}
            //catch
            //{
            //    Console.WriteLine($"We catched:");
            //}
            //finally
            //{
            //    Console.WriteLine("Inside finally");
            //    //sfs.Close();
            //}

            Console.WriteLine("After catch");

            //using(DevideByZeroException connector = new DevideByZeroException())
            //{
            //    //...
            //    //...
            //}

        }

        static int CallDevide(int num1, int num2)
        {
            try
            {
                return Devide(num1, num2);
            }
            catch (ArgumentException ex ) when (num1 == 0)
            {
                Console.WriteLine($"We catched in CallDevide: {ex.Message}");
                throw;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"We catched in CallDevide: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        static int Devide(int number1, int num2)
        {
            //if(num2 == 0)
            //{
            //    //Console.WriteLine("Divide by zero is restricted");
            //    throw new DevideByZeroException("Divide by zero is restricted", "Another data");
            //}
            //if(number1 == 0)
            //{
            //    throw new ArgumentException("Divide by zero is restricted", nameof(number1)); // "num1"
            //}

            return number1 / num2;
        }

    }
}
