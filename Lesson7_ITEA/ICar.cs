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
        void Accelerate();
        void SwitchGear(int gear);
        void Stop();
    }

    interface ITruckCar
    {
        int GetCapacity();
    }

    interface ITransport
    {
        int PeopleCapacity();
    }
}
