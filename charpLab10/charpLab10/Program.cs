using System;
using System.Collections.Generic;

namespace charpLab10
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
    }

    public class Garage
    {
        public List<Car> Cars { get; set; } = new List<Car>();
    }

    public class Washer
    {
        public void Wash(Car car)
        {
            Console.WriteLine($"Washing {car.Color} {car.Model}");
        }
    }

    public class Program
    {
        public delegate void WashCars(Car car);

        static void Main(string[] args)
        {
            Car car1 = new Car { Model = "Toyota", Color = "Blue" };
            Car car2 = new Car { Model = "Honda", Color = "Red" };

            Garage garage = new Garage();
            garage.Cars.Add(car1);
            garage.Cars.Add(car2);

            Washer washer = new Washer();

            WashCars washCars = new WashCars(washer.Wash);

            foreach (var car in garage.Cars)
            {
                washCars(car);
            }
        }
    }
}
