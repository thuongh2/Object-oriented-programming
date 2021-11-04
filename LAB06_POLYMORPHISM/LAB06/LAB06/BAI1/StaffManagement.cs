using System;
using System.Collections.Generic;
using System.Text;

namespace LAB06.BAI1
{
    class StaffManagement
    {
        private Staff[] staffs;
        private byte index;
        private const string OPTION = "-1";

        public StaffManagement()
        {
            staffs = new Staff[100];
            index = 0;
        }

        static void Main()
        {
            StaffManagement test = new StaffManagement();

            string option = OPTION;
            do
            {
                Console.Write("Your choice (1 - Input Marketing, 2 - Input Administration, -1 - Finish): ");
                option = Console.ReadLine();
                test.NhapDS(option);
            }
            while (option != OPTION);

            for (byte i=0; i< test.index; i++)
            {
                test.staffs[i].XuatThongTinNV();
            }
            
            Staff max = test.staffs[0];
            for (byte i = 0; i < test.index; i++)
            {
                for (byte j = (byte)(i + 1); j < test.index; j++)
                {
                    if (test.staffs[i].LuongThucLanh > test.staffs[j].LuongThucLanh)
                        max = test.staffs[i];
                }
            }
            Console.WriteLine("Nhan vien co doanh so cao nhat: ");
            max.XuatThongTinNV();

            float sum = 0;
            for (byte i = 0; i < test.index; i++)
            {
                sum += test.staffs[i].LuongThucLanh;
            }

            Console.WriteLine("Luong trung binh cua ca cong ty: {0}", sum / test.index);

        }

        private void NhapChiTiet (ref string name, ref int id, ref float luongCoBan, ref short thamNien)
        {
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            Console.Write("Nhap id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Nhap luong can ban: ");
            luongCoBan = float.Parse(Console.ReadLine());
            Console.Write("Nhap Tham Nien: ");
            thamNien = short.Parse(Console.ReadLine());
        }

        private void NhapDS(string option)
        {
            string name = "";
            int id = 0;
            float luongCanBan=0;
            short thamNien=0;
            switch (option)
            {
                case "1":
                    NhapChiTiet(ref name, ref id, ref luongCanBan, ref thamNien);
                    Console.Write("Nhap doanh so: ");
                    float doanhSo = float.Parse(Console.ReadLine());
                    staffs[index++] = new Marketing(name, id, luongCanBan, thamNien, doanhSo);
                    break;
                case "2":
                    NhapChiTiet(ref name, ref  id, ref  luongCanBan, ref thamNien);
                    Console.Write("Nhap phu cap: ");
                    float phuCap = float.Parse(Console.ReadLine());
                    staffs[index++] = new Administration(name, id, luongCanBan, thamNien, phuCap);
                    break;
                default:
                    if (option != OPTION)
                    {
                        Console.WriteLine("Invalid");
                    }

                    break;
            }
        }
    }
}
