using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class ToaDoXY
    {
        public int x;
        public int y;
        public string TenTD;
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public string _TenTD { get => TenTD; set => TenTD = value; }
        public ToaDoXY(int x,int y, string TenTD) {
            this.x = x;
            this.y = y;
            this.TenTD = TenTD;
        }
        public ToaDoXY() {
            int x = 1;
            int y = 1;
            string TenTD = "abc" ;
        }
        public void Nhap() {
            Console.WriteLine("Moi nhap ten toa do:");
            TenTD = Console.ReadLine();
            Console.WriteLine("Moi nhap toa do x:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Moi nhap toa do y:");
            y = int.Parse(Console.ReadLine());
        }
        public void Xuat() {
            Console.WriteLine("Ten toa do: {0}",TenTD);
            Console.WriteLine("Toa do x: {0} \n Toa do y: {1} \n ", x, y);
        }
    }
}
