using System;
using System.Collections.Generic;
using System.Text;

namespace LAB04
{
    class ListCD
    {
        private CD[] list= new CD [50];
        private int countCD;
        private int priceCD;

        public int CountCD
        {
            get
            {
                byte i = 0;
                while (list[i] != null)
                {
                    i++;
                }
                countCD = i;
                return countCD;
            }
        }
        public int PriceCD
        {
            get
            {
                int sumPrice=0;
                byte i = 0;
                while (list[i] != null)
                {
                    sumPrice += list[i].Price;
                    i++;
                }
                priceCD = sumPrice;
                return priceCD;

            }
        }

        public void ThemCD(CD temp)
        {
            if (countCD == 50)
            {
                Console.WriteLine("List full");
                return;
            }
            for (byte i=0; i< countCD; i++)
            {
                if (list[i]!= null && temp.ID == list[i].ID)
                {
                    Console.WriteLine("ID da ton tai vui long nhap lai");
                    return;
                }
            }
            list[countCD] = temp;
            countCD += 1;
        }

        public void SepTheoGiaTien()
        {
            byte min = 0;
            for (byte i = 0; i < countCD-1; i++)
            {
                min = i;
                for (byte j= (byte)(i + 1); j< countCD; j++)
                {
                    if (list[j].Price < list[min].Price)
                        min = j;
                }
                CD temp = list[min];
                list[min] = list[i];
                list[i] = temp;
            }
        }

        public void SapXepTheoTuaDe()
        {
            byte min = 0;
            for (byte i = 0; i < countCD - 1; i++)
            {
                min = i;
                for (byte j = (byte)(i + 1); j < countCD; j++)
                {
                    if (list[j].Title.CompareTo(list[min].Title)==1)
                        min = j;
                }
                CD temp = list[min];
                list[min] = list[i];
                list[i] = temp;

            }
        }

        public void XuatDS()
        {
            for (byte i = 0; i < countCD; i++)
            {
                list[i].ToStringCD();
            }
        }
    }

}
