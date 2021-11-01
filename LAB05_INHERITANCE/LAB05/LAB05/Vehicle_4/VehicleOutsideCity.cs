using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Vehicle_4
{
    class VehicleOutsideCity: Vehicle
    {
        private int dayNumber;
        private string noiden;

        public VehicleOutsideCity()
        {

        }

        public override void Input()
        {
            base.Input();
            Console.Write("So ngay di duoc: ");
            dayNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Noi den: ");
            noiden = Console.ReadLine();
        }

        public override void Output()
        {
            base.Output();
            Console.Write(" - {0} - {1}", dayNumber, noiden);
        }

        public int Revenue
        {
            get => base.Reveneu;
        }
    }
}
