using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_ITEA
{
    class Singleton
    {
        static Singleton Instance = null;

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();

            return Instance;
        }
    }
}
