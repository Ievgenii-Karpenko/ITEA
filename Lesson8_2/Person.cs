using System;

namespace Lesson8_2
{
    public struct Person: IPerson, IEquatable<Person>
    {
        public string _name { get; set; } // Structs are sealed
        public int _age;
        private double _weight;

        //public Person()
        //{

        //}

        public Person(int age, string name)
        {
            _age = age;
            _name = name;
            _weight = 0;
        }

        public bool Equals(Person other)
        {
            return _name==other._name && _age == other._age;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
