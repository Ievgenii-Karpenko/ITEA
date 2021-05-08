using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10_ITEA
{
    class DevideByZeroException : IDisposable
    {
        public string MyMessage = "dfsdf ";
        // NetworkConnector 

        public DevideByZeroException(string message, string myMessage) //: base(message)
        {
            MyMessage = myMessage;
           // new NetworkConnector
        }

        public void Dispose()
        {
            ///NetworkConnector.Close()
        }
    }
}
