using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_ITEA
{
    class DevideByZeroException : Exception
    {
        public string MyMessage = "dfsdf ";

        public DevideByZeroException(string message, string myMessage) : base(message)
        {
            MyMessage = myMessage;
        }
    }
}
