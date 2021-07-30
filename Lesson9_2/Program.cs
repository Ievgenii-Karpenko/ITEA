using System;
using System.Threading;

namespace Lesson9_2
{
    class Program
    {
        static object sync = new object();
        static void Main(string[] args)
        {
            try 
            {
                // var connection = new Connect();
                // connection.Download();

                double res = Div(5, 2);
                //var a = int.Parse("dfsd");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("This is FormatException");
                Console.WriteLine(ex.Message);
            }
            catch (DivisionByZeroException ex)
            {
                Console.WriteLine(ex.OperandName + " was zero");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception was handled!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //connection.Close();
                Console.WriteLine("Inside Finally");
            }


            lock(sync)
            {

            }

            try 
            { 
                Monitor.Enter(sync);
            }
            finally
            { 
                Monitor.Exit(sync);
            }


            Console.WriteLine("Hello World!");
        }

        static double Div(double num1, double num2)
        {
            if (num2 == 0)
                throw new DivisionByZeroException("Division by zero is forbidden!", nameof(num2));

            return num1 / num2;
        }
    }

    class DivisionByZeroException : Exception
    {
        public string OperandName;

        public DivisionByZeroException (string message, string operandName) : base(message)
        {
            OperandName = operandName;
        }
    }
}
