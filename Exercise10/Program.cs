using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleData data = new VehicleData();

            Car mustang = new Car();
          
            data.PrintVehicle(mustang);

            Bicycle trehjul = new Bicycle();

            data.PrintVehicle(trehjul);


        }
    }
}
