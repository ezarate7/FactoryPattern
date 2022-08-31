using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory : IVehicle
    {
        public static IVehicle GetVehicle(string tireNum)
        {
            int tires = Convert.ToInt32(tireNum);
            if (tires > 4)
                return new Motorcycle();
            else
                return new Car();

        }

    }
}





