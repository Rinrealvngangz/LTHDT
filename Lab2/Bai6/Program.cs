using System;

namespace Bai6
{
    class program
    {
        public class PhanSo
        {
            int tuso;
            int mauso;
            public PhanSo()
            { //hàm constructor có 2 tham số
                tuso = 0;
                mauso = 1;
            }
            public PhanSo(int x)
            { //hàm constructor có 2 tham số
                tuso = x;
                mauso = 1;
            }
            public PhanSo(int x, int y)
            { //hàm constructor có 2 tham số
                tuso = x;
                mauso = y;
            }
            public void show()
            {
                Console.WriteLine("Phan so: {0}/{1}", tuso, mauso);
            }
            public PhanSo(PhanSo ob)
            {
                tuso = ob.tuso;
                mauso = ob.mauso;
            }
            public PhanSo Cong(PhanSo ob)
            {
                int TS = tuso * ob.mauso + mauso * ob.tuso;
                int MS = mauso * ob.mauso;
                return new PhanSo(TS, MS);
            }
            public PhanSo Tru(PhanSo ob)
            {
                int TS = tuso * ob.mauso - mauso * ob.tuso;
                int MS = mauso * ob.mauso;
                return new PhanSo(TS, MS);
            }
            public PhanSo Nhan(PhanSo ob)
            {
                int TS = tuso * ob.tuso;
                int MS = mauso * ob.mauso;
                return new PhanSo(TS, MS);
            }
            public PhanSo Chia(PhanSo ob)
            {
                int TS = tuso * ob.mauso;
                int MS = mauso * ob.tuso;
                return new PhanSo(TS, MS);
            }
        }

        static void Main(string[] args)
        {
            PhanSo p1 = new PhanSo();
            p1.show(); Console.WriteLine();
            PhanSo p2 = new PhanSo(5, 6);
            p2.show(); Console.WriteLine();

            Console.WriteLine("Nhap tu so: ");
            int TS = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap mau so: ");
            int MS = int.Parse(Console.ReadLine());

            PhanSo p3 = new PhanSo(TS, MS);
            p3.show(); Console.WriteLine();

            p1 = p2.Cong(p3);
            p1.show();
            p1 = p2.Tru(p3);
            p1.show();
            p1 = p2.Nhan(p3);
            p1.show();
            p1 = p2.Chia(p3);
            p1.show();
            Console.ReadLine();
            return;
        }
    }
}