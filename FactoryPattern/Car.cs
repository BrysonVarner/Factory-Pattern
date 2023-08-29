using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : Vehicle, IVehicle
    {
        public Car() { }

        public int NumberOfWheels = 4;
        public void Drive()
        {
            Console.WriteLine($"You start up the car, put it in gear, hit the gas pedal, and the {NumberOfWheels} wheels propel you forward!");
        }
    }
}
