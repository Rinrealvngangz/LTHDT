using System;

namespace DaThuc
{
    class DaThuc
    {
        int Bac;
        int[] Heso = new int[100];      
        bool kiemtra = false;
        int HS;
        int[] mangoper = new int[100];


        public void NhapDaThuc()
        {
         
            do
            {
                Console.WriteLine("Nhap Bac Da Thuc:");
                kiemtra = Int32.TryParse(Console.ReadLine(), out Bac);
                if (!kiemtra)
                {
                    Console.WriteLine("Khong nhap chu: ");

                }
            } while (!kiemtra); //bac 3
            for (int i =Bac;i>=0;i--)  //0 ,1,2,3
            {
               
                do
                {
                    Console.Write("Nhap co so:");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out HS);
                    if (!kiemtra)
                    {
                        Console.WriteLine("Khong nhap chu: ");

                    }
                } while (!kiemtra);
               
                Heso[i] = HS;
               
            }
                 
        }
        public static DaThuc operator +(DaThuc a, DaThuc b )
        {

            DaThuc c =new DaThuc();
            c.Heso[0] = a.Heso[0] + b.Heso[0];
            c.Heso[2] = a.Heso[2] + b.Heso[2];
            c.Heso[1] = a.Heso[1] + b.Heso[1];
            c.Heso[3] = a.Heso[3] + b.Heso[3];

            return c;
        }
        public static DaThuc operator -(DaThuc a, DaThuc b)
        {

            DaThuc c = new DaThuc();

            c.Heso[0] = a.Heso[0] - b.Heso[0];
            c.Heso[2] = a.Heso[2] - b.Heso[2];
            c.Heso[1] = a.Heso[1] - b.Heso[1];
            c.Heso[3] = a.Heso[3] - b.Heso[3];


            return c;
        }
        public  DaThuc CongDaThuc(DaThuc a)
        {
            DaThuc c = new DaThuc();

            c.Heso[0] = a.Heso[0] + Heso[0];
            c.Heso[1] = a.Heso[1] + Heso[1];
            c.Heso[2] = a.Heso[2] + Heso[2];
            c.Heso[3] = a.Heso[3] + Heso[3];
            return c;
        }
        public DaThuc TruDaThuc(DaThuc a)
        {

            DaThuc c = new DaThuc();

            c.Heso[0] = a.Heso[0] - Heso[0];
            c.Heso[1] = a.Heso[1] - Heso[1];
            c.Heso[2] = a.Heso[2] - Heso[2];
            c.Heso[3] = a.Heso[3] - Heso[3];
            return c;
        }
        public void xuatDaThuc()
        {
           
            
            if(Bac == 3)
            {
                Console.WriteLine("{0}x^{1} + {2}x^{3} + {4}x^{5} +{6}", Heso[3], Bac, Heso[2], --Bac,
              Heso[1], --Bac, Heso[0]);
            }
            else if((Bac ==2) || (Heso[3] == 0))
            {
                Console.WriteLine("{0}x^{1} + {2}x^{3} + {4}", Heso[2], Bac, Heso[1], --Bac,Heso[0]);
            }
            else
            Console.WriteLine("{0}x^{1} + {2}x^{3} + {4}x^{5} +{6}", Heso[3], Bac, Heso[2], --Bac,
             Heso[1], --Bac, Heso[0]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DaThuc a = new DaThuc();
            DaThuc c = new DaThuc();
            DaThuc d = new DaThuc();
            Console.WriteLine(" Da thuc 1:");
            a.NhapDaThuc();
            a.xuatDaThuc();
            DaThuc b = new DaThuc();
            Console.WriteLine(" Da thuc 2:");
            b.NhapDaThuc();
            b.xuatDaThuc();
            //Console.WriteLine("Toan tu Cong 2 da thuc");
            //c = a + b;
            //c.xuatDaThuc();
            //Console.WriteLine(" Toan tu Tru 2 da thuc");
            //d = a  -b;
            //d.xuatDaThuc();
            Console.WriteLine("Phuong Thuc Cong : ");
            c = a.CongDaThuc(b);
            c.xuatDaThuc();

            Console.WriteLine("---------------");
            Console.WriteLine("Phuong Thuc Tru : ");
            c = a.TruDaThuc(b);
            c.xuatDaThuc();
        }
    }
}
