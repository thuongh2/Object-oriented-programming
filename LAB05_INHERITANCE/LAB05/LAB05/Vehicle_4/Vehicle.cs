using System;
using System.Collections.Generic;
using System.Text;

namespace LAB05.Vehicle_4
{
    class Vehicle
    {
        private int id;
        private string driverName;
        private string carNumber;
        private int reveneu;

        public int Reveneu { get => reveneu; }

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap ho va ten tai xe: ");
            driverName = Console.ReadLine();  
            Console.Write("Nhap so xe: ");
            carNumber = Console.ReadLine();
            Console.Write("Nhap doanh thu: ");
            reveneu = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Output()
        {
            Console.Write("{0} - {1} - {2} - {3}", id, driverName, carNumber, reveneu);
        }
    }
}
