using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    public interface IWorker
    {
        string Proffesion { get; set; }
    }


    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
    }


    public class HardWorker : IWorker
    {
        public string Proffesion { get; set; }
        public bool IsHardWorker = true;
    }

    public partial class Person : IPerson, IWorker
    {
        protected string _name = "Noname";
        private int _age = 0;
        private double _weight;

        public const string BIO_CLASS = "Homo Sapiens";
        public readonly string BioClass2;// = "Homo Sapiens";

        public static int Pupulation = 0;

        public string Proffesion { get; set; }

        public static void ShowPopulation()
        {
            Console.WriteLine($"Population = {Pupulation}");
            //Console.WriteLine($"Name = {Name}");
        }

        public void ShowPopulation2()
        {
            Console.WriteLine($"Population = {Pupulation}");
            Console.WriteLine($"Name = {Name}");
        }

        public string Name
        {
            get 
            {
                return _name;
            }
            set
            {
                if (value == "")
                    _name = "Noname";
                else
                    _name = value;
            }
        }

        public string Surname { get; private set; } = "Unknown";

        public int Age //(int value)
        {
            get => _age;
            set { _age = value; }
        }

        public double Weight
        {
            get => _weight;
            set { _weight = value; }
        }

        public int GetYearOfBirth { get => DateTime.Now.Year - _age; }
        //public int GetYearOfBirth => DateTime.Now.Year - _age;


        //public string GetName()
        //{
        //    return _name;
        //}
        //public void SetName(string val)
        //{
        //    if (val == "")
        //        _name = "Noname";
        //    else
        //        _name = val;
        //}

        public Person()
        {
            Console.WriteLine("PERSON C-TOR");

            BioClass2 = "Homo Sapiens Sapiens";
            Pupulation++;
        }

        public Person(string name)
        {
            _name = name;
            Pupulation++;
        }

        public Person(string Name, string surname, int age, double weight = 90)
        {
            this._name = Name;
            Surname = surname;
            _age = age;
            _weight = weight;
            Pupulation++;
        }

        public virtual string ShowInfo()
        {
            return $"Name: {_name}, surname: {Surname}, age: {_age}, weight: {_weight}";
        }
    }
}
