using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_ITEA
{
    interface ICar
    {
        void TurnWheel(bool isleft);
        void Accelerate()
        {
            Console.WriteLine("asdsad");
        }

        void SwitchGear(int gear);
        void Stop();

        //int speed { get; set; }
        //event 
    }

    interface ITruckCar
    {
        int GetCapacity();
    }

    interface ITransport
    {
        int PeopleCapacity();
        void Stop();
    }
}
