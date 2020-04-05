using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace bai3
{
    class Program
    {
        class Tienich
        {
           
           public static int  a,b;
           public static double kq;
           public static int m;

            static double Luythua()
            {

                kq = Math.Pow(a, m);//method tinh luy thua
                return kq;
            }
            static int UCLN()
            {
                while (a != 0 && b != 0)
                {
                    if (a > b) a = a - b;
                    else b = b - a;

                }
                if (a == 0)
                    return b;
                else return a;
            }
            static int BCNN()
            {
                int tich = a * b;
                int result;
                result = UCLN();
                return tich / result;
            }

            public void set_luythua(int number,int bac)
            {
                 a =number;
                m = bac;
                show_luyThua();
            }
            public void show_luyThua()
            {
                Console.WriteLine("Luy Thua :{0}", Luythua());
            }

            public void UocchungLN(int x,int y)
            {
                a = x;
                b = y;
                Console.WriteLine("UCLN :{0}", UCLN());
            }
            public void BoichungNN(int x, int y)
            {
                a = x;
                b = y;
                Console.WriteLine("BCLN :{0}", BCNN());
            }
        } 
            
        static void Main(string[] args)
        {
           Tienich ob = new Tienich();
           ob.set_luythua(2, 2);
           ob.UocchungLN(24, 16);
           ob.BoichungNN(10, 12);
            Console.ReadLine();
        }
    }
}
