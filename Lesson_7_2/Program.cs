using Lesson6_2;
using System;
using System.Collections.Generic;

namespace Lesson_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape tr1 = new Triange();
            //Shape sh1 = new Shape();
            IShape tr2 = new Triange();
            IShape c1 = new Circle();

            List<IShape> shapes = new List<IShape>() { tr1, tr2, c1};

            IPerson p1 = new Person();
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.Age);

            IWorker p2 = (IWorker)p1;
            Console.WriteLine(p2.Proffesion);


            IWorker p3 = new HardWorker();

            List<IWorker> s = new List<IWorker>() { p2, p3 };
            foreach (var item in s)
            {
                Console.WriteLine(item.Proffesion);
            }


            //Worker w1 = new Worker("W_NAME", "Surname", 8, 54);

            //Console.WriteLine(w1.ShowInfo());

            //Employee e1 = new Employee();
            //e1.Name = "Kevin";
            //e1.Age = 25;
            //e1.Position = "Developer";
            ////e1._name = "";
            ////e1.Surname = "Smith";

            //Console.WriteLine(e1.Age);
            //Console.WriteLine(e1.ShowInfo());
            //e1.ShowSlary();

            //Person p1 = new Person("John", "Adison", 45, 78.2);

            //List<Person> persons = new List<Person>();
            //persons.Add(e1);
            //persons.Add(p1);
            //persons.Add(w1);

            //Console.WriteLine("-------------------------------");
            //foreach (var item in persons)
            //{
            //    Console.WriteLine(item.ShowInfo());

            //    //if (item is Employee)
            //    //{
            //    //    ((Employee)item).ShowSlary();
            //    //}

            //    //Employee empl = item as Employee;
            //    //if (empl != null)
            //    //{
            //    //    empl.ShowSlary();
            //    //}

            //    //if (item is Employee empl2)
            //    //{
            //    //    empl2.ShowSlary();
            //    //}
            //}


            //Nullable
            {
                //int a = 0;

                //int? a1 = null;

                //if(a1.HasValue)
                //{
                //    Console.WriteLine("a1 has value:" + a1.Value);
                //}

                //Console.WriteLine("a1 has value:" + a1);

                //Console.WriteLine("a1 has value:" + a1.Value);
            }
        }
    }
}
