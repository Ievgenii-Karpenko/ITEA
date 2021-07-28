namespace Lesson8_2
{
    public class PersonC //: IEquatable
    {
        public string _name; // Structs are sealed
        public int _age = 8;
        private double _weight;

        public PersonC(int age, string name)
        {
            _age = age;
            _name = name;
            //_weight = 0;
        }
    }

}
