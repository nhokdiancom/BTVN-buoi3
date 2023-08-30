using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class SV
    {
        int MaSV;
        string Hoten;
        float DLT;
        float DTH;

        public int MaSV1
        {

            get {
                if (MaSV > 0)
                {
                    return MaSV;
                }
                else return 0;
            }
            
            set => MaSV = value; 
        }
        public string Hoten1 {

            get => Hoten;

            set {
                if (Hoten != null)
                    Hoten = value;
                else
                    do
                    {
                        Console.WriteLine("Moi nhap lai ten");
                    }
                    while (Hoten == null);
            } 
        }
        public float DLT1 { get => DLT; set => DLT = value; }
        public float DTH1 { get => DTH; set => DTH = value; }
        public SV(int MaSV,string Hoten,float DLT,float DTH) {
            this.MaSV = MaSV;
            this.Hoten = Hoten;
            this.DLT = DLT;
            this.DTH = DTH;
        }
        public SV() {
            MaSV = 2012;
            Hoten = "nguyen";
            DLT = 6;
            DTH = 2;
        }
        public void nhap() {
            Console.WriteLine("Moi nhap ma so sinh vien");
            MaSV = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap Ho va ten sinh vien");
            Hoten = Console.ReadLine();
            Console.WriteLine("Moi nhap Diem LT sinh vien");
            DLT = float.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap Diem TH sinh vien");
            DTH = float.Parse(Console.ReadLine());
        }
        public void xuat() {
            Console.WriteLine("MSSV:{0}",MaSV);
            Console.WriteLine("Ho va Ten:{0}", Hoten);
            Console.WriteLine("DLT:{0}", DLT);
            Console.WriteLine("DTH:{0}", DTH);
            Console.WriteLine("DTB:{0}", DTB(DLT,DTH));
        }
        public double DTB(float DLT, float DTH) {
            return (DLT + DTH) / 2;
        }
    }
}
