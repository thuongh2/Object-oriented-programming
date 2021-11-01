using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class Vehicle
    {
        private string name;
        private string nameVehicle;
        private int capacityVehicle;
        private int price;
        private float tax;

        public Vehicle()
        {
            this.name = "Unknow";
            this.nameVehicle = "Unknow";
            this.capacityVehicle = 0;
            this.price = 0;
        }

        public Vehicle(string name, string nameVehicle, int capacityVehicle, int price)
        {
            this.name = name;
            this.nameVehicle = nameVehicle;
            this.capacityVehicle = capacityVehicle;
            this.price = price;
        }

        public float Tax
        {
            get
            {
                if (capacityVehicle < 100)
                    return (float)(price * 0.01);
                else if (capacityVehicle <= 200)
                    return (float)(price * 0.03);
                else
                    return (float)(price * 0.05);
            }
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length != 0)
                    name = value;
                else
                    name = "Khong biet";
            }
        }

        public string NameVehicle
        {
            get => nameVehicle;
            set
            {
                if (value.Length != 0)
                    nameVehicle = value;
                else
                    nameVehicle = "Khong biet";
            }
        }

        public int CapacityVehicle
        {
            get => capacityVehicle;
            set
            {
                if (value > 0)
                    capacityVehicle = value;
                else
                    capacityVehicle = 0;
            }
        }

        public int Price
        {
            get => price;
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0;
            }
        }

        public void HienThongTin ()
        {
            Console.WriteLine("Ten chu xe {0}, Ten loai xe {1}, Dung tich xe {2} cc, Tri gia xe {3} VND, Thue truoc ba {4}", name, nameVehicle, CapacityVehicle, price, Tax);
        }
    }
}
