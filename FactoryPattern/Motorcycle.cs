using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : Vehicle, IVehicle
    {
        public Motorcycle() { }

        public int NumberOfWheels = 2;

        public void Drive()
        {
            Console.WriteLine($"You start up the motorcycle, hit the throttle, and the {NumberOfWheels} wheels propel you forward!");
        }
    }
}
