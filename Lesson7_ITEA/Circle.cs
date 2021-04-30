using Lesson6_ITEA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_ITEA
{
    class Circle : Shape
    {
        public override Position CentrPoint { get; set; } = new Position(0,0);

        public override void Draw()
        {
            Console.WriteLine($"Center Point: {CentrPoint}");
            Console.WriteLine("Drawing the circle");
        }

        public int GetRadius()
        {
            return 10;
        }
    }

    class Square : Shape
    {
        public override Position CentrPoint { get; set; } = new Position(0, 0);

        public override void Draw()
        {
            Console.WriteLine($"Center Point: {CentrPoint}");
            Console.WriteLine("Drawing the Square");
        }
    }

    class Triangel : Shape
    {
        public override Position CentrPoint { get; set; } = new Position(0, 0);

        public override void Draw()
        {
            Console.WriteLine($"Center Point: {CentrPoint}");
            Console.WriteLine("Drawing the Triangel");
        }
    }
}
