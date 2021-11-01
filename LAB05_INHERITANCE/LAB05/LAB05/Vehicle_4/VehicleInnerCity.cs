using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Vehicle_4
{
    class VehicleInnerCity:Vehicle
    {
        private int kmNumber;
        private int routeNumber;

        public VehicleInnerCity()
        {

        }

        public override void Input()
        {
            base.Input();
            Console.Write("So km di duoc: ");
            kmNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("So tuyen: ");
            routeNumber = Convert.ToInt32(Console.ReadLine());
        }

        public override void Output()
        {
            base.Output();
            Console.Write(" - {0} - {1}", kmNumber, routeNumber);
        }

        public int Revenue
        {
            get => base.Reveneu;
        }
    }
}
