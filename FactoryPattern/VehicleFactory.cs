using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(int wheelCount)
        {            
            switch (wheelCount) 
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                case 6:
                    return new BigRig();
                default:
                    return new Car();
            }
        }
    }
}
