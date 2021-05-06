using System;
using System.Collections;
using System.Collections.Generic;

namespace Lesson9_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pers = new Person();
            Console.WriteLine("Name: " + pers.Name);
            Console.WriteLine("Age: " + pers.Age);


            Person pers2;
            pers2.Name = "pers2";
            pers2.Age = 22;
            Console.WriteLine("Name: " + pers2.Name);
            Console.WriteLine("Age: " + pers2.Age);

            PersonClass persCl2;
            persCl2.Name = "pers2";
            persCl2.Age = 22;
            Console.WriteLine("Name: " + persCl2.Name);
            Console.WriteLine("Age: " + persCl2.Age);

            Person pers3 = new Person() { Name = "123" };
            GetPersonNameE(pers3);
            Console.WriteLine(pers3.Name);

            //Console.WriteLine("-------------");

            //PersonClass persC = new PersonClass() { Name = "123" };
            //GetPersonName(persC);
            //Console.WriteLine(persC.Name);

            //object p3 = (object)pers3;

            //foreach (var item in pers3)
            //{
            //    Console.WriteLine(item);
            //}

            //GetPersonNameE(pers3);

            List<ICloneable> pList = new List<ICloneable>();
            pList.Add(pers3);
        }

        static void GetPersonNameE(ICloneable p_o)
        {
            p_o.Clone();
            Person p = (Person)p_o;
            p.Name = "ABC";
            Console.WriteLine(p.Name);
        }

        static List<ICloneable> Get10Clones(ICloneable p_o)
        {
            List<ICloneable> s = new List<ICloneable>();
            for (int i = 0; i < 10; i++)
            {
                s.Add((ICloneable)p_o.Clone());
            }

            return s;
        }

        static void GetPersonName(Person p)
        {
            p.Name = "ABC";
            Console.WriteLine(p.Name);
        }

        static void GetPersonName(PersonClass p)
        {
            p.Name = "ABC";
            Console.WriteLine(p.Name);
        }
    }
}
