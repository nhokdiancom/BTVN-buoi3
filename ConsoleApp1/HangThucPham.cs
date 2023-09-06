using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HangThucPham
    {
        string MH;
        string TenHang;
        double DG;
        int ngay, thang, nam;
        DateTime NSX = new DateTime(2015, 12, 25);
        DateTime HSD = new DateTime(2016, 12, 25);
        public string _MH { get => MH; set => MH = value; }
        public string _TenHang { get => TenHang; set => TenHang = value; }
        public double _DG { get => DG; set => DG = value; }
        public DateTime _NSX { get=> NSX; set => NSX = value; }
        public DateTime _HSD { get => HSD; set => HSD = value; }

        public HangThucPham(string MH,string TenHang,double DG) {
            this.MH = MH;
            this.TenHang = TenHang;
            this.DG = DG;
        }
        public HangThucPham() {
            MH = "123abc";
            TenHang = "xxx";
            DG = 0;
        }
        public void Nhap() {
            Console.WriteLine("Moi nhap Ma hang:");
            MH = Console.ReadLine();
            Console.WriteLine("Moi nhap Ten hang:");
            TenHang = Console.ReadLine();
            Console.WriteLine("Moi nhap Don gia:");
            DG = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap Ngay san xuat:");
            string NSX = Console.ReadLine();
            Console.WriteLine("Moi nhap Hang su dung:");
            string HSD = Console.ReadLine();
        }
        public void Xuat()
        {
            Console.WriteLine("Ma hang\t\tTen hang\t\tDon Gia\t\t\tNSX\t\t\tHSD");
            Console.WriteLine("{0}{1}{2}{3}{4}",MH,TenHang,DG,NSX,HSD);
        }
    }
}
