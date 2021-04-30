using Lesson6_ITEA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_ITEA
{
    abstract class Shape
    {
        public abstract void Draw();
        public virtual int GetSquare()
        {
            return 0;
        }

        public int GetPerim()
        {
            return 0;
        }

        public abstract Position CentrPoint { get; set; }
    }
}
