using Lesson6_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_2
{
    class Worker : Employee
    {
        public Worker()
        {
            Console.WriteLine("Worker C-TOR");
        }

        public Worker(string name, string surname, int w_h, int age) : base(name, surname, age)
        {
            WorkingHours = w_h;
        }

        public new string ShowInfo()
        {
            return $"{Surname} - WH: {WorkingHours}";
        }

        public int WorkingHours = 0;
    }

    class Manager : Employee
    {
        public Manager()
        {
            Console.WriteLine("Manager C-TOR");
        }
    }


    public class Employee : Person
    {
        public string Position;
        public Employee()
        {
            Console.WriteLine("Employee C-TOR");
        }

        public Employee(string name, string surname, int age) : base(name, surname, age)
        {
        }

        public void ShowSlary()
        {
            Console.WriteLine(CalculateSalary() +" $");
            Console.WriteLine(_name);
        }

        private int CalculateSalary()
        {
            return Age * 10 + 1000;
        }

        public override string ShowInfo()
        {
            return $"Name: {_name}, surname: {Surname}, age: {Age}, weight: {Weight}, position: {Position}";
        }
    }
}
