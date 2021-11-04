using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06.BAI1
{
    class Marketing: Staff
    {
        protected float doanhSo;
        protected float hoaHong;

        public Marketing (string name, int id, float luongCanBan, short thamNien, float doanhSo)
            : base(name, id, luongCanBan, thamNien)
        {
            this.doanhSo = doanhSo;
            TinhLuong();
        }

        public float HoaHong
        {
            get
            {
                hoaHong = 1;
                if (hoaHong < 5000000)
                    return hoaHong;
                else if (doanhSo >= 50000000 && doanhSo < 10000000)
                    return hoaHong = (float)(hoaHong + 0.05);
                else if (doanhSo < 20000000)
                    return hoaHong = (float)(hoaHong + 0.1);
                else
                    return hoaHong = (float)(hoaHong + 0.2);
            }
        }

        public float DoanhSo
        {
            get => doanhSo;
            set
            {
                if (value < 0)
                    Console.WriteLine("Khong nhan so am");
                else
                    doanhSo = value;
            }
        }

        public override void TinhLuong()
        {
            luongThucLanh = luongCanBan * HeSoLuong + doanhSo * HoaHong;
        }

        public override void XuatThongTinNV()
        {
            Console.WriteLine("Ma so {0}, Ten {1}, Luong Can Ban {2}, He So Luong {3}," +
                " Luong Thuc Lanh {4}, Tham Nien {5}, Doanh So {6}, Hoa Hong {7}",
                id, name, luongCanBan, HeSoLuong, luongThucLanh, thamNien, doanhSo, HoaHong);
        }
    }
}
