using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class BigRig : Vehicle, IVehicle
    {
        public BigRig() { }

        public int NumberOfWheels = 6;
        public void Drive()
        {
            Console.WriteLine($"You start up the Big Rig, hit the gas pedal, and the {NumberOfWheels} wheels propel you forward!");
        }
    }

}
