using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Vehicle_4
{
    class VehicleManagement
    {
        static void Main()
        {
            VehicleInnerCity[] vehicleInners = new VehicleInnerCity[20];
            VehicleOutsideCity[] vehicleOutsides = new VehicleOutsideCity[20];

            byte i;
            for (i = 0; i < 2; i++)
            {
                vehicleInners[i] = new VehicleInnerCity();
                vehicleInners[i].Input();
            }
            i = 0;
            int sum = 0;
            while (vehicleInners[i] != null)
            {
                sum += vehicleInners[i].Revenue;
                i++;
            }

            Console.WriteLine(sum);
        }
    }
}
