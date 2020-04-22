using System;

namespace Lab4
{
    class Program
    {
        public class soPhuc
        {
            int a, b;
            bool kiemtra = false;
          


            public void kiemTraPhanThuc()
            {
                do
                {
                    Console.WriteLine("Nhap lai so a:");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out a);

                } while (!kiemtra);
            }
            public void kiemTraPhanAo()
            {
                do
                {
                    Console.WriteLine("Nhap lai so b:");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out b);

                } while (!kiemtra);
            }
            public void nhapSoPhuc()
            {
                Console.WriteLine("Nhap so a:");
                kiemtra = Int32.TryParse(Console.ReadLine(),out a);
                if (!kiemtra) kiemTraPhanThuc();
                Console.WriteLine("Nhap so b:");
                kiemtra = Int32.TryParse(Console.ReadLine(), out b);
                if (!kiemtra) kiemTraPhanAo();
            }
            public soPhuc tong(soPhuc ob1)
            {
                soPhuc ob = new soPhuc();
                ob.a = a + ob1.a;
                ob.b = b + ob1.b;
                return ob;
            }
            public soPhuc tru(soPhuc ob1)
            {
                soPhuc ob = new soPhuc();
                ob.a = a - ob1.a;
                ob.b = (b - ob1.b);//(a-c) + (b-d)i
                return ob;
            }

            public soPhuc nhan(soPhuc ob1)
            {
                soPhuc ob = new soPhuc();
                ob.a = (a * ob1.a) - (b * ob1.b);
                ob.b = (a *  ob1.b)+(b*ob1.b);
                return ob;
            }
            //public soPhuc chia(soPhuc ob1)
            //{
            //    soPhuc ob = new soPhuc();
            //    ob.a = ((a + b));
            //    ob.b = (a * ob1.b) + (b * ob1.b);
            //    return ob;
            //}

              public  void  kiemtra_ThuanAo_That(soPhuc ob)
            {
               
                if (ob.b == 0)
                {
                    Console.WriteLine("So that");
                   
                }
                else
                    Console.WriteLine("So thuan ao");
             
            }
       
            public static bool operator ==(soPhuc ob, soPhuc ob1)
            {
                bool checkSoThuc = false;
                if (ob.a == ob1.a && ob.b == ob1.b)
                    return checkSoThuc =true;

                else
                    return checkSoThuc; 
            }

            public static bool operator !=(soPhuc ob, soPhuc ob1)
            {
                bool checkSoThuc = false;
                if (ob.a != ob1.a && ob.b != ob1.b)
                    return checkSoThuc = true;

                else
                    return checkSoThuc ;
            }
            public void xuatSoPhuc()
            {
              
                Console.WriteLine("So phuc sau khi nhap:{0}+{1}i ", a, b);
            }
        }
        static void Main(string[] args)
        {
            soPhuc ob3 = new soPhuc();
            soPhuc ob = new soPhuc();
            ob.nhapSoPhuc();
            ob.xuatSoPhuc();
            soPhuc ob2 = new soPhuc();
            ob2.nhapSoPhuc();
            ob2.xuatSoPhuc();
            Console.WriteLine("Tong hai so phuc");
            ob3 =ob.tong(ob2);
           ob3.xuatSoPhuc();
            Console.WriteLine("Hieu hai so phuc");
            ob3 = ob.tru(ob2);
            ob3.xuatSoPhuc();

            Console.WriteLine("Nhan hai so phuc");
            ob3 = ob.nhan(ob2);
            ob3.xuatSoPhuc();

            Console.WriteLine("kiem tra so phuc ob: ");
            ob.kiemtra_ThuanAo_That(ob);
         
            Console.WriteLine("so phuc ob == so phuc ob2 ? {0}", ob == ob2);
            Console.WriteLine("so phuc ob != so phuc ob2 ? {0}", ob != ob2);


            Console.ReadLine();
        }
    }
}
