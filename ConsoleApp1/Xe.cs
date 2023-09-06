using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Xe
    {
        string ChuXe;
        string LoaiXe;
        double TriGia;
        int XyLanh;

        public string _ChuXe { get => ChuXe; set => ChuXe = value; }
        public string _LoaiXe { get => LoaiXe; set => LoaiXe = value; }
        public double _TriGia { get 
            {
                if (TriGia >= 0)
                    return TriGia;
                else return 0;
            }
            set => TriGia = value; }
        public int _XyLanh { get 
            {
                if (XyLanh >= 0)
                    return XyLanh;
                else return 0;
            } 
            set => XyLanh = value; }
        public Xe(string ChuXe,string LoaiXe,double TriGia,int xylanh){
            this.ChuXe = ChuXe;
            this.LoaiXe = LoaiXe;
            this.TriGia = TriGia;
            this.XyLanh = xylanh;
        }
        public Xe() {
            ChuXe = "";
            LoaiXe = "";
            TriGia = 0.0;
            XyLanh = 0;
        }
        public void Nhap() {
            Console.WriteLine("Moi nhap ten chu xe:");
            ChuXe = Console.ReadLine();
            Console.WriteLine("Moi nhap ten loai xe:");
            LoaiXe = Console.ReadLine();
            Console.WriteLine("Moi nhap tri gia xe:");
            TriGia = double.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap dung tich xy lanh:");
            XyLanh = int.Parse(Console.ReadLine());
        }
        public double Thue(int XyLanh,double TriGia) {
            if (XyLanh < 100)
                return Math.Truncate(TriGia)/100;
            else if (XyLanh <= 200)
                return Math.Truncate(TriGia * 0.03 * 100)/100;
            else return Math.Truncate(TriGia * 0.05 * 100)/100;
        }
        public void Xuat() {
            Console.WriteLine("{0}\t\t\t{1}\t\t{2}\t\t\t{3}\t\t{4}", ChuXe, LoaiXe, XyLanh, TriGia, Thue(XyLanh, TriGia));
        }
        public void KhoangCach() {
            Console.WriteLine("Ten chu xe\t\tLoai xe\t\tDung tich\t\ttri gia \t\tthue phai nop");
            Console.WriteLine("========================================================================================================================");
        }
    }
}
