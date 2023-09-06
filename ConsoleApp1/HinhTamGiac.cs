using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HinhTamGiac
    {
        float ma, mb, mc;

        public float Ma
        {
            get
            {
                if (ma <= 0 || ma + mb > mc && ma + mc > mb && mb + mc > ma)
                    return 0;
                else return 1;
            }
            set => ma = value;
        }
        public float Mb
        {
            get
            {
                if (mb <= 0 || ma + mb > mc && ma + mc > mb && mb + mc > ma)
                    return 0;
                else return 1;
            }
            set => mb = value;
        }
        public float Mc
        {
            get
            {
                if (mc <= 0 || ma + mb > mc && ma + mc > mb && mb + mc > ma)
                    return 0;
                else return 1;
            }
            set => mc = value;
        }
        public HinhTamGiac(float ma, float mb, float mc)
        {
            this.ma = ma;
            this.mb = mb;
            this.mc = mc;
        }
        public HinhTamGiac()
        {
            ma = 0;
            mb = 0;
            mc = 0;
        }
        public void Nhap()
        {
            Console.WriteLine("Moi nhap gia tri cua canh tam giac MA:");
            ma = float.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap gia tri cua canh tam giac MB:");
            mb = float.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap gia tri cua canh tam giac MC:");
            mc = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("ma\tmb\tmc");
            Console.WriteLine("{0}\t{1}\t{2} \t\t\t\t\t",ma,mb,mc);
            Console.Write("Loai Tam giac:");
            LoaiTG(ma, mb, mc);
            Console.WriteLine("CV = {0}\nDT = {1}", CV(ma, mb, mc), DT(ma, mb, mc));
        }
        public double CV(float ma,float mb, float mc) {
            return ma + mb + mc;
        }
        public double DT(float ma, float mb, float mc)
        {
            double p = (ma + mb + mc) / 2.0;
            return Math.Truncate((Math.Sqrt(p*(p-ma)*(p-mb)*(p-mc))) *100 )/100;
        }
        public void LoaiTG(float ma,float mb, float mc) {
            if (ma == mb|| ma == mc) {
                Console.WriteLine("Tam giac Deu");
            }
            else if (ma == mb || mb == mc || mc == ma) {
                Console.WriteLine("Tam giac Can");
            }
            else
            {
                Console.WriteLine("Tam giac binh thuong");
            }
        }
    }
}
