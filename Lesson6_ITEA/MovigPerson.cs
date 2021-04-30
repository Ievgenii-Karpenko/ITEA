using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_ITEA
{
    public sealed class MovigPerson : Person
    {
        Position CurrentPos;

        public MovigPerson(string name, int age, double weight, Position position) : base(name, age, weight)
        {
            Console.WriteLine("------- C-tor MovigPerson -------");
            CurrentPos = position;
        }

        public void MoveFromtoPosition(Position newPostion)
        {
            //... position
            CurrentPos = newPostion;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Curent position: {CurrentPos}");
        }

        public void MovingMethod()
        {
            Console.WriteLine("MovingMethod");
        }

       
    }

    public class StaticPerson : Person
    {
        Position CurrentPos;
        public bool isStatic = true;

        public StaticPerson(string name, int age, double weight, Position position) : base(name, age, weight)
        {
            Console.WriteLine("------- C-tor StaticPerson -------");
            CurrentPos = position;
        }

        public new void ShowInfo()
        {
            Console.WriteLine($"Curent position: {CurrentPos}");
        }
    }

    //public class SuperMovingPerson : MovigPerson
    //{
    //    public SuperMovingPerson(string name, int age, double weight, Position position) : base(name, age, weight, position)
    //    {
    //        Console.WriteLine("------- C-tor SuperMovingPerson -------");
    //    }


    //    public override void ShowInfo()
    //    {
    //        base.ShowInfo();
    //    }
    //}

    public class Position 
    {
        public int positionX = 0;
        public int positionY = 0;

        public Position() { }

        public Position(int x, int y)
        {
            positionX = x;
            positionY = y;
        }

        public override string ToString()
        {
            return $"X = {positionX}, Y = {positionY}";
        }
    }

}
