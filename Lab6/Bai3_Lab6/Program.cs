using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bai3_Lab6
{
    class Program
    {
        struct Sohang
        {
            public int Hs;
            public int Mu;
        };
        public class Dathuc
        {
            int Sopt;
            Sohang[] DT;
            public Dathuc()
            {
                Sopt = 0;
                DT = new Sohang[100];
            }
            public void ThemSohang(int Heso, int Somu)
            {
                DT[Sopt].Hs = Heso;
                DT[Sopt].Mu = Somu;
                Sopt++;
            }
            public void NhapDaThuc()
            {
                int Heso;
                int Somu;
                do
                {
                    Console.WriteLine("Nhap vao he so va so mu , khi ket thuc nhap hs = 0 ");
                    Heso = Int32.Parse(Console.ReadLine());
                    Somu = Int32.Parse(Console.ReadLine());
                    if (Heso != 0)
                    {
                        ThemSohang(Heso, Somu);
                    }
                } while (Heso != 0);
            }
            public static Dathuc operator +(Dathuc T1 , Dathuc T2)
            {
                
                Dathuc T3 = new Dathuc();
                if(T1.Sopt > T2.Sopt)
                {
                    T3.Sopt = T1.Sopt;
                }
                else
                    T3.Sopt = T2.Sopt;

                for (int i=0; i< T3.Sopt;i++)
                {
                    T3.DT[i].Hs = T1.DT[i].Hs + T2.DT[i].Hs;
                    T3.DT[i].Mu = T1.DT[i].Mu + T2.DT[i].Mu;
                }
              
                return T3;
            }
            public static Dathuc operator -(Dathuc T1, Dathuc T2)
            {

                Dathuc T3 = new Dathuc();
                if (T1.Sopt > T2.Sopt)
                {
                    T3.Sopt = T1.Sopt;
                }
                else
                    T3.Sopt = T2.Sopt;

                for (int i = 0; i < T3.Sopt; i++)
                {
                    T3.DT[i].Hs = T1.DT[i].Hs - T2.DT[i].Hs;
                    if(T1.DT[i].Mu> T2.DT[i].Mu)
                    {
                        T3.DT[i].Mu = T1.DT[i].Mu - T2.DT[i].Mu;
                    }else
                        T3.DT[i].Mu = T2.DT[i].Mu - T1.DT[i].Mu;
                }

                return T3;
            }
            public void XuatDaThuc()
            {
                Console.WriteLine("Da Thuc :");
                for (int i = 0; i < Sopt; i++)
            Console.Write("{0}X ^{1} + ", DT[i].Hs, DT[i].Mu);
            }

        }
        static void Main(string[] args)
        {
            Dathuc T1 = new Dathuc();
            Console.WriteLine("--------");
            T1.NhapDaThuc();
            T1.XuatDaThuc();
          
            Dathuc T2 = new Dathuc();
            T2.NhapDaThuc();
            T2.XuatDaThuc();
            Console.WriteLine("--------");
            Console.WriteLine("Toan tu cong :");
            Dathuc T3 = new Dathuc();
            T3 = T2 + T1;
            T3.XuatDaThuc();
            Console.WriteLine("--------");
            Console.WriteLine("Toan tu tru :");
            Dathuc T4 = new Dathuc();
            T4 = T2 - T1;
            T4.XuatDaThuc();
            Console.ReadLine();
        }
    }
}
