using System;

namespace KeThua_Hinhtron
{
    class Hinhtron
    {
        protected double r;
        protected double S;
        protected double Pi;
        public Hinhtron(double bankinh)
        {
            r = bankinh;
            Pi = 3.14;
            S = 0;
        }

       
        public static double SHT(double bankinh)
        {
            Hinhtron ht = new Hinhtron(bankinh);
            ht.S = (ht.r * ht.r) * ht.Pi;
            return ht.S;
        }

        public void xuat()
        {
            Console.WriteLine("Dien tich hinh tron :{0}", SHT(3));
        }
    }
    class Hinhcau:Hinhtron
        {
       
        public Hinhcau(double bankinh):base(bankinh)
        {
            
        }

        public static double SHC(double bankinh)
        {
            Hinhcau hc = new Hinhcau(bankinh);
                  hc.S =  SHT(bankinh)*4 ;
            return hc.S;
        }
        public static double THC(double bankinh)
        {
            Hinhcau hc = new Hinhcau(bankinh);
            hc.S = SHT(bankinh) * 3;
            return hc.S;
        }
        public new void xuat()
        {
            base.xuat();
            Console.WriteLine("Dien tich hinh cau :{0}", SHC(2));
            Console.WriteLine("The tich hinh cau :{0}", THC(2));
           
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Hinhcau hc = new Hinhcau(5);

            hc.xuat();
          
        }
    }
}
