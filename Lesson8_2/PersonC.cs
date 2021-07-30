using System;

namespace Lesson8_2
{
    public class PersonC : IEquatable<PersonC>
    {
        public string _name; // Structs are sealed
        public int _age = 8;

        public PersonC()
        {
        }

        public PersonC(int age, string name)
        {
            _age = age;
            _name = name;
        }

        static public PersonC operator + (PersonC p1, PersonC p2)
        {
            return new PersonC() { _name=p1._name, _age = p1._age + p2._age };
        }

        static public PersonC operator +(PersonC p1, Person p2)
        {
            return new PersonC() { _name = p1._name, _age = p1._age + p2._age };
        }

        static public bool operator <(PersonC p1, PersonC p2)
        {
            return p1._age < p2._age;
        }

        static public bool operator >(PersonC p1, PersonC p2)
        {
            return p1._age > p2._age;
        }

        static public bool operator ==(PersonC p1, PersonC p2)
        {
            return p1._age == p2._age;
        }

        static public bool operator !=(PersonC p1, PersonC p2)
        {
            return p1._age == p2._age;
        }

        static public bool operator true(PersonC p1)
        {
            return p1._age > 0;
        }

        static public bool operator false(PersonC p1)
        {
            return p1._age < 0;
        }

        public bool Equals(PersonC other)
        {
            return this == other;
        }
    }

}
