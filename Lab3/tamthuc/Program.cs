using System;

namespace lab3
{
    class Program
    {
        class tamThuc
        {
            int a;
            int b;
            int c;
            int tamthuc1;
            int tamthuc2;
            bool kiemtra = false;
            public tamThuc()
            {
                a = 0;
                b = 0;
                c = 0;
            }

            public tamThuc(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public tamThuc(tamThuc ob)
            {
                a = ob.a;
                b = ob.b;
                c = ob.c;
            }


            public void nhapA()
            {

                Console.WriteLine("Nhap a :");
                kiemtra = Int32.TryParse(Console.ReadLine(), out a);
                if (!kiemtra) checkA();
            }
            public void nhapB()
            {
                Console.WriteLine("Nhap b :");
                kiemtra = Int32.TryParse(Console.ReadLine(), out b);
                if (!kiemtra) checkB();
            }
            public void nhapC()
            {
                Console.WriteLine("Nhap c :");
                kiemtra = Int32.TryParse(Console.ReadLine(), out c);
                if (!kiemtra) checkC();
            }

            public void checkA()
            {

                while (!kiemtra)
                {
                    Console.WriteLine("Khong duoc nhap chu ");
                    nhapA();
                }
            }
            public void checkB()
            {
                while (!kiemtra)
                {
                    Console.WriteLine("Khong duoc nhap chu ");
                    nhapB();
                }
            }
            public void checkC()
            {
                while (!kiemtra)
                {
                    Console.WriteLine("Khong duoc nhap chu ");
                    nhapC();
                }
            }
            public void nhap()
            {
                nhapA();
                nhapB();
                nhapC();
            }
            public void xuat()
            {
                
                if (a == 0)
                {
                    Console.WriteLine("Tam thuc: {0}x + {1}", b, c);
                }
                else if (b == 0)
                {
                    Console.WriteLine("Tam thuc: {0}x^2 + {1}", a, c);
                }
                else if (c == 0)
                {
                    Console.WriteLine("Tam thuc: {0}x^2 + {1}x", a, b);
                }
             
                else

                    Console.WriteLine("Tam thuc: {0}x^2 + {1}x + {2}", a, b, c);

            }
            public void xuatnhan()
            {
                Console.WriteLine("Tam thuc: {0}x^4 + {1}x^2 + {2}", a, b, c);
            }

            public static tamThuc operator +(tamThuc ob, tamThuc ob1)
            {
                int x = ob.a + ob1.a;
                int y = ob.b + ob1.b;
                int z = ob.c + ob1.c;

                return new tamThuc(x, y, z);
            }
            public static tamThuc operator -(tamThuc ob, tamThuc ob1)
            {
                int x, y, z;

                if (ob.a < ob1.a)
                {
                    x = ob1.a - ob.a;
                }
                else
                    x = ob.a - ob1.a;

                if (ob.b < ob1.b)
                {
                    y = ob1.b - ob.b;
                }
                else
                    y = ob.b - ob1.b;

                if (ob.c < ob1.c)
                {
                    z = ob1.c - ob.c;
                }
                else
                    z = ob.c - ob1.c;


                return new tamThuc(x, y, z);
            }
            public static tamThuc operator *(tamThuc ob, tamThuc ob1)
            {
                int x = ob.a * ob1.a;
                int y = ob.b * ob1.b;
                int z = ob.c * ob1.c;
                return new tamThuc(x, y, z);
            }
            public static tamThuc operator ++(tamThuc ob)
            {
                return new tamThuc(ob.a,ob.b,ob.c + 1) ;
            }
            public static bool operator ==(tamThuc ob, tamThuc ob1)
            {
                return (ob.a == ob1.a) && (ob.b == ob1.b) && (ob.c == ob1.c);

            }
            public static bool operator !=(tamThuc ob, tamThuc ob1)
            
                //return (ob.a != ob1.a) && (ob.b != ob1.b) && (ob.c != ob1.c);
                => !(ob.a == ob1.a) && !(ob.b == ob1.b) && !(ob.c == ob1.c); 
            
            public static bool kiemtraso(int num)
            {

                if (99 < num && num < 999)
                    return true;
                else
                    return false;
            }
        
           
          public static implicit operator tamThuc(int num)
            {
                int j, k, l;
                
                if (kiemtraso(num) == false)
                throw (new InvalidCastException());
             
                j = num / 100;
                    k = (num % 100) / 10;
                    l = num % 10;
                return new tamThuc(j,k,l);
            }
            public static explicit operator bool(tamThuc ob)
            {              
              return (((ob.b)*(ob.b)) - (4 * (ob.a * ob.c)))>=0;           
            }

        }
       
            static void Main(string[] args)
        {
            int so;
            tamThuc kq = new tamThuc();
            tamThuc cong =new tamThuc();
            tamThuc tru = new tamThuc();
            tamThuc ob = new tamThuc();
            ob.nhap();
            ob.xuat();
            Console.WriteLine("............");
            tamThuc ob1 = new tamThuc();
            ob1.nhap();
            ob1.xuat();
            Console.WriteLine("............");
            Console.WriteLine("Tong hai tam thuc:");
             cong =  ob + ob1;
            cong.xuat();
            Console.WriteLine("............");
            Console.WriteLine("Tru hai tam thuc:");
            tru = ob - ob1;
            tru.xuat();
            Console.WriteLine("............");
            Console.WriteLine("cong tam thuc voi so :");
            so = Int32.Parse(Console.ReadLine());
            kq = ob + so;
            kq.xuat();
            Console.WriteLine("............");
            Console.WriteLine("Kiem tra phuong trinh co nghiem:");
            Console.WriteLine("............");
            if ((bool)ob)     
                Console.WriteLine(" phuong trinh co nghiem");      
            else
                Console.WriteLine(" phuong trinh khong co nghiem");
            Console.WriteLine("............");
            Console.WriteLine("Nhan hai tam thuc:");
            kq = ob * ob1;           
            kq.xuatnhan();
            Console.WriteLine("............");
            Console.WriteLine("Tam thuc cong 1:");
            kq = ++ob;
            kq.xuat();
            Console.WriteLine("............");
            Console.WriteLine("So sanh 2 tam thuc ob vs ob1 :");
            Console.WriteLine("ob == ob1 ? {0}", ob == ob1);
            Console.WriteLine("ob != ob1 ? {0}", ob != ob1);

            Console.ReadLine();
           
        }
    }
}
