using System;

namespace Lesson8_2
{
    public interface IPerson: IEquatable<Person>
    {
        string _name { get; set; }
    }

}
