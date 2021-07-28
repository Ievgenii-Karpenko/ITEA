using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7_ITEA
{
    class CarMarkComparator : IComparer<Car>
    {
        public int Compare(Car x, Car y)
        {
            return 0 - x.Mark.CompareTo(y.Mark);
        }
    }

    //class CarPowerComparator : IComparer<Car>
    //{
    //    public int Compare(Car x, Car y)
    //    {
    //        return x.CompareTo(y);
    //    }
    //}

    class Car : ICar, IComparable<Car>//, IEnumerable
    {
        public string Mark = "Mersedes";
        public int Year = 1990;
 

        public void Accelerate()
        {
            Console.WriteLine("Accelerate");
        }

        public int CompareTo(Car other)
        {
            if (this.Year < other.Year)
                return -1;
            else if (this.Year > other.Year)
                return 1;
            else
                return 0;
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }

        public void SwitchGear(int gear)
        {
            Console.WriteLine($"SwitchGear to {gear}");
        }

        public void TurnWheel(bool isleft)
        {
            Console.WriteLine($"Turn {isleft : \"left\" : \"right\"}");
        }
    }

    class Truck : ICar//, ITruckCar
    {
        public int GetCapacity()
        {
            throw new NotImplementedException();
        }
        public void Accelerate()
        {
            Console.WriteLine("Accelerate Truck");
        }

        public void Stop()
        {
            Console.WriteLine("Stop Truck");
        }

        public void SwitchGear(int gear)
        {
            Console.WriteLine($"SwitchGear to {gear} Truck");
        }

        public void TurnWheel(bool isleft)
        {
            Console.WriteLine($"Turn Truck {isleft: \"left\" : \"right\"}");
        }
    }

    class Bus : ICar, ITransport
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerate Bus");
        }

        public int PeopleCapacity()
        {
            return 25;
        }

        void ICar.Stop()
        {
            Console.WriteLine("Stop Bus from ICar");
        }

        void ITransport.Stop()
        {
            Console.WriteLine("Stop Bus from ITransport");
        }

        public void SwitchGear(int gear)
        {
            Console.WriteLine($"SwitchGear Bus to {gear}");
        }

        public void TurnWheel(bool isleft)
        {
            Console.WriteLine($"Turn Bus {isleft: \"left\" : \"right\"}");
        }
    }
}
