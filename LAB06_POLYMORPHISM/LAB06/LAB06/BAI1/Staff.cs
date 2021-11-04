using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06.BAI1
{
    class Staff
    {
        protected string name;
        protected int id;
        protected float luongCanBan;
        protected int heSoLuong;
        protected float luongThucLanh;
        protected short thamNien;

        public Staff(string name, int id, float luongCanBan, short thamNien)
        {
            this.name = name;
            this.id = id;
            this.luongCanBan = luongCanBan;
            this.thamNien = thamNien;
            TinhLuong();
        }

        public float LuongThucLanh { get => luongThucLanh; }
        public float HeSoLuong
        {
            get
            {
                if (thamNien < 5)
                    return heSoLuong = 1;
                return heSoLuong = thamNien / 5;
            }
        }

        public short ThamNien
        {
            set
            {
                if (value < 0)
                    Console.WriteLine("Khong nhan so am");
                else
                    thamNien = value;
            }
        }

        public virtual void TinhLuong()
        {
            luongThucLanh = luongCanBan * HeSoLuong;
        }

        public virtual void XuatThongTinNV()
        {
            Console.Write("Ma so {0}, Ten {1}, Luong Can Ban {2}, He So Luong {3}, Luong Thuc Lanh {4}, Tham Nien {5}",
                id, name, luongCanBan, HeSoLuong, luongThucLanh, thamNien);
        }

    }
}
