using System;

namespace LAB04
{
    class VehicleManagement
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Hoai Thuong", "Future", 125, 34000000);
            Vehicle v2 = new Vehicle();
            Vehicle v3 = new Vehicle();

            v2.Name = "";
            v2.NameVehicle = "";
            v2.CapacityVehicle = -10;
            v3.Price = -100000000;

            v3.Name = "Hoai Thuong 1";
            v3.NameVehicle = "SH";
            v3.CapacityVehicle = 150;
            v3.Price = 100000000;

            Console.WriteLine("Bang tien thue truoc ba");
            Console.WriteLine("Xe 1: {0}",v1.Tax);
            Console.WriteLine("Xe 2: {0}", v2.Tax);
            Console.WriteLine("Xe 3: {0}", v3.Tax);

            Console.WriteLine("Tong thue truoc ba thu cua ca ba xe: {0}", v1.Tax + v2.Tax + v3.Tax);

            v1.HienThongTin();
            v2.HienThongTin();
            v3.HienThongTin();
        }
    }
}
