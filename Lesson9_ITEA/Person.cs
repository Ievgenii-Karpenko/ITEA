using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_ITEA
{

    public enum WeekDays
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wensday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
    }

    struct Person : ICloneable
    {
        public string Name;// = "asdas";
        public int Age;

        public const int AdultYear = 18;

        //public Person()
        //{

        //}

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }


        public void PrintName()
        {
            Console.WriteLine($"Person name: {Name}");
        }
    }


    class PersonClass
    {
        public string Name;// = "asdas";
        public int Age;

        public PersonClass()
        {

        }

        public void PrintDay(WeekDays day)
        {
            switch (day)
            {
                case WeekDays.Sunday:
                    Console.WriteLine("Sunday");
                    break;
                case WeekDays.Monday:
                    break;
                case WeekDays.Tuesday:
                    break;
                case WeekDays.Wensday:
                    break;
                case WeekDays.Thursday:
                    break;
                case WeekDays.Friday:
                    break;
                case WeekDays.Saturday:
                    break;
                default:
                    break;
            }
        }

        public PersonClass(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void PrintName()
        {
            Console.WriteLine($"Person name: {Name}");
        }
    }
}
