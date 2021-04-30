using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson7_ITEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape sh1 = new Circle();
            Shape sh2 = new Square();
            Shape sh3 = new Triangel();

            List<Shape> shapes = new List<Shape>();

            shapes.Add(sh1);
            shapes.Add(sh2);
            shapes.Add(sh3);

            foreach (var item in shapes)
            {
                item.Draw();

                if (item is Circle cir)
                    cir.GetRadius();
            }

            Car car1 = new Car();
            Car car2 = new Car();
            Bus bus = new Bus();
            Bus bus2 = new Bus();
            Truck truck = new Truck();
            Truck truck2 = new Truck();

            List<ICar> cars = new List<ICar>() { car1, car2, bus, truck, truck2 };

            List<ITruckCar> truckCars = new List<ITruckCar>();
            truckCars.Add(truck);
            truckCars.Add(truck2);
            //truckCars.Add(bus);

            List<ITransport> busCars = new List<ITransport>();
            busCars.Add(bus);
            busCars.Add(bus2);

            foreach (var item in cars)
            {
                item.Accelerate();
            }

            foreach (var item in truckCars)
            {
                item.GetCapacity();
            }

            car2.Label = "Opel";
            car2.Year = 2020;
            var car3 = new Car() { Label = "BMW", Year = 2000 };

            List<Car> cars = new List<Car>() { car1, car2, car3 };
            
            Car[] carsArray = cars.ToArray();
            

            Array.Sort(carsArray, new CarPowerComparator());

            foreach (Car item in carsArray)
            {
                Console.WriteLine($"{item.Label} - {item.Year}");
            }
        }
    }
}
