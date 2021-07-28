using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson8_2
{
    public enum DayOfWeek
    {
        Mon = 1,
        Tue = 2,
        Wed = 33,
        Thu = 55,
        Fri = 66,
        Sut = 77,
        Sun
    }

    public enum HumanInfo
    {
        NotSet = 0,
        IsPretty = 1,
        IsTall = 2,
        IsClever = 4,
        IsMarried = 8,
        IsAlive = 16
    }

    public class Week
    {
        public const int NumberOfDays = 7;
        public DayOfWeek CurrentDay { get; set; }
    }

    public class Human
    {
        public HumanInfo Info;
    }


    class Program
    {
        public static bool IsHumanAlive(HumanInfo info)
        {
            bool res = (HumanInfo.IsAlive & info) != 0;
            return res;
        }

        static void Main(string[] args)
        {
            Human h = new Human();
            h.Info = HumanInfo.IsPretty | HumanInfo.IsAlive;



            //Week w1 = new Week();
            //w1.CurrentDay = DayOfWeek.Sut;

            //Console.WriteLine((int)DayOfWeek.Sut);
            //Console.WriteLine((DayOfWeek)3);

            if (Enum.TryParse(typeof(DayOfWeek), "Sut", out object res))
            {
                var result = (DayOfWeek)res;
            }

            //switch (w1.CurrentDay)
            //{
            //    case DayOfWeek.Mon:
            //    case DayOfWeek.Tue:
            //    case DayOfWeek.Wed:
            //        Console.WriteLine("This is work day");
            //        break;
            //    case DayOfWeek.Sut:
            //    case DayOfWeek.Sun:
            //        Console.WriteLine("This is holyday");
            //        break;
            //    default:
            //        Console.WriteLine("Wrong day");
            //        break;
            //}


            //Person p1 = new Person() { _name = "John", _age = 35};
            //Person p2 = new Person() { _name = "Mark" };
            //Person p3 = new Person() { _name = "Mark" };

            //HashSet<Person> h = new HashSet<Person>() { p1, p2, p3};
            //h.First()._age = 40;

            //bool areaEqual = p1.Equals(p2);
            ////PersonC p2 = new PersonC();

            //GetPersonName(p1);
        }

        static string GetPersonName(Person p)
        {
            return p._name;
        }

        static string GetPersonName(IPerson p)
        {
            return p._name;
        }
    }

}
