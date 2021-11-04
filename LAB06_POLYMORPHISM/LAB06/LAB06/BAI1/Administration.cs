using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06.BAI1
{
    class Administration:Staff
    {
        protected float phuCap;

        public Administration(string name, int id, float luongCanBan, short thamNien, float phuCap)
            : base(name, id, luongCanBan, thamNien)
        {
            this.phuCap = phuCap;
            TinhLuong();
        }

        public float PhuCap
        {
            get => phuCap;
            set
            {
                if (value < 0)
                    Console.WriteLine("Khong nhan so am");
                else
                    phuCap = value;
            }
        }

        public override void TinhLuong()
        {
            luongThucLanh = luongCanBan * heSoLuong + PhuCap;
        }

        public override void XuatThongTinNV()
        {
            Console.WriteLine("Ma so {0}, Ten {1}, Luong Can Ban {2}, He So Luong {3}, Luong Thuc Lanh {4}, Tham Nien {5}, Phu Cap {6}",
                id, name, luongCanBan, HeSoLuong, luongThucLanh, thamNien, phuCap);
        }
    }
}
