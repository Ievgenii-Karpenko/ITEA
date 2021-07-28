using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7_2
{
    public interface IShape
    {
        int GetPerimeter();
        void Draw();
        int Square { get; set; }

        //int Perimeter;
    }


    public abstract class Shape : IShape
    {
        public abstract int GetPerimeter();

        public virtual void Draw()
        {
            Console.WriteLine("Can not draw abstract shape");
        }

        public int Square { get; set; } = 0;
    }

    public sealed class Triange : Shape
    {
        public override int GetPerimeter()
        {
            return 3;
        }

        public override void Draw()
        {
            Console.WriteLine("This is Triange");
        }
    }

    //public class Triange2 : Triange
    //{
    //}

    public class Circle : Shape
    {
        public Circle()
        {
            Square = 4;
        }

        public override int GetPerimeter()
        {
            return 5;
        }

        public override void Draw()
        {
            Console.WriteLine("This is Circle");
        }
    }
}
