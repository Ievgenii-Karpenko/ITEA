using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_ITEA
{
    public class Person
    {
        static int personCount = 0;
        //private string Name;
        private double Weight = 50;


        const double PI = 3.14;
        readonly int myReadonly;

        private int _age;
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0 || value > 120)
                    return;

                _age = value;
            }
        }

        public string Name { get; private set; } = "Unknown";

        public int BirthYear => 2021 - Age;


        public Person()
        {
        }

        public Person(string name, int age, double weight)
        {
            Console.WriteLine("------- C-tor Person -------");
            this.Name = name;
            this._age = age;
            this.Weight = weight;
        }

        /// <summary>
        /// Constructs the object
        /// </summary>
        /// <param name="name">Name of the person</param>
        public Person(string name)
        {
            Name = name;
            _age = 15;
            Weight = 66;
        }

        /// <summary>
        /// Shows info about our object
        /// </summary>
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Age {_age + personCount}, Weight: {Weight}");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Inside static method" + personCount);
        }
    }
}
