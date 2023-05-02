using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_NET_Libraries.JSONReader.car
{
    internal class CarPrinter
    {
        public static void printCar(Car car)
        {
            Console.WriteLine(car.Id);
            Console.WriteLine(car.Name);
            Console.WriteLine(car.Brand);
            Console.WriteLine(" ");
        }

        public static void printCars(List<Car> cars)
        {
            foreach (var car in cars)
            {
                printCar(car);
            }
        }
    }
}
