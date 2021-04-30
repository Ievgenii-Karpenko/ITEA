using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake2
{
    public class FoodFactory
    {
        private static char Ch = 'f';

        public static Point GenerateFood(int maxX, int maxY)
        {
            Random rnd = new Random();
            int x = rnd.Next(1, maxX);
            int y = rnd.Next(1, maxY);

            return new Point(x, y, Ch);
        }



    }
}
