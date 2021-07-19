using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_2
{
    partial class Person
    {
        private string _name = "Noname";
        private int _age = 0;
        private double _weight;

        public const string BIO_CLASS = "Homo Sapiens";
        public readonly string BioClass2;// = "Homo Sapiens";

        public static int Pupulation = 0;

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

        public string Surname { get; private set; }

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
            BioClass2 = "Homo Sapiens Sapiens";
            Pupulation++;
        }

        public Person(string bioClass)
        {
            BioClass2 = bioClass;
            Pupulation++;
        }

        public Person(string Name, string surname, int age, double weight)
        {
            this._name = Name;
            Surname = surname;
            _age = age;
            _weight = weight;
            Pupulation++;
        }

        public override string ToString()
        {
            return $"Name: {_name}, surname: {Surname}, age: {_age}, weight: {_weight}";
        }
    }
}
