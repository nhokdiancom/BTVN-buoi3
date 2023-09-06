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
            Console.WriteLine("MSSV\t Hoten \t\t\t\t diemlt\t diemth\t diemtb ");
            Console.WriteLine("{0} \t {1} \t\t\t\t {2} \t {3} \t {4}\n",MaSV,Hoten,DLT,DTH,DTB(DLT,DTH));
        }
        public double DTB(float DLT, float DTH) {
            return (DLT + DTH) / 2;
        }
    }
}
