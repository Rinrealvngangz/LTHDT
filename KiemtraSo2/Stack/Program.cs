using System;

namespace Stack
{
    class Program
    {
        public class Stack
        {

            int[] stack;
            int p;

            // Khoi tao stack
            public Stack(int n)
            {
                stack = new int[n];
                p = -1;

            }

            public static bool kiemtraStackRong(int p)
            {

                bool check = false;

                if (p == -1)
                {
                    return check = true;
                }
                else
                    return check;
            }
            public static bool kiemtraStackDay(Stack a)
            {

                bool check = true;

                if (a.p >= a.stack.Length)
                {
                    return check;
                }
                else
                    return check = false;
            }
            //check stack rong ? day
            public void kiemtraStack(Stack a)
            {

                if (kiemtraStackRong(a.p) == true)
                {
                    Console.WriteLine("Stack Rong!");
                }

                else if (kiemtraStackDay(a) == true)
                {
                    Console.WriteLine("Stack Day!");
                }

            }
            // them 1 phan tu
            public void PushMotPhanTu(int pt)
            {

                p++;
                stack[p] = pt;

            }
            //lay ra 1 phan tu
            public void PopMotPhanTu(Stack a)
            {
                Stack b = new Stack(10);//stack chua kq 
                int kq;
                do
                {
                    kq = a.stack[a.p--];
                    b.PushMotPhanTu(kq);

                } while (a.p >= 0);
                b.xuatStack();
            }

            public void thucThi(int so, int soCanDoi)
            {
                int sodu;
                do
                {
                    sodu = so % soCanDoi;//1 ,0,1
                    so = so / soCanDoi;//2,1,0
                    PushMotPhanTu(sodu);
                } while (so > 0);
            }

            public void doiCoSo(int so, Stack a, int soCanDoi)
            {

                thucThi(so, soCanDoi);
                PopMotPhanTu(a);
            }
            public void xuatStack()
            {
                int i;
                Console.Write("So sau khi doi: ");
                for (i = 0; i <= p; i++)
                {
                    if (stack[i] == 10)
                    {
                        Console.Write("A");
                    }
                    else if (stack[i] == 11)
                    {
                        Console.Write("B");
                    }
                    else if (stack[i] == 12)
                    {
                        Console.Write("C");
                    }
                    else if (stack[i] == 13)
                    {
                        Console.Write("D");
                    }
                    else if (stack[i] == 14)
                    {
                        Console.Write("E");
                    }
                    else if (stack[i] == 15)
                    {
                        Console.Write("F");
                    }
                    else
                        Console.Write(stack[i]);
                }
                Console.WriteLine();
            }

            public void xuatmenu()
            {
                Console.WriteLine("======Chuong Trinh Doi Co so=======");
                Console.WriteLine("0:Phim 0 ket thuc chuong trinh");
                Console.WriteLine("1:Doi Co so");
            }
            public int Chonmenu()
            {

                int stt;
                bool kiemtra = false;

                for (; ; )
                {

                    Console.WriteLine("Nhap chuc nang 1: ");
                    do
                    {
                        kiemtra = Int32.TryParse(Console.ReadLine(), out stt);
                        if (!kiemtra)
                        {
                            Console.Write("khong nhap chu  : ");
                        }
                    } while (!kiemtra);
                    if (0 <= stt && stt <= 1)
                        break;
                }
                return stt;
            }
            public void xulymenu(int somenu)
            {

                int soCanDoi;
                bool kiemtra = false;
                int so;
                Stack a = new Stack(100);
                switch (somenu)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine(" ket thuc chuong trinh");
                        Environment.Exit(0);
                        break;
                    case 1:

                        Console.Clear();
                        a.kiemtraStack(a);
                        Console.Write("Nhap so thap phan can doi : ");
                        do
                        {
                            kiemtra = Int32.TryParse(Console.ReadLine(), out so);
                            if (!kiemtra)
                            {
                                Console.Write("khong nhap chu  : ");
                            }
                        } while (!kiemtra);
                        Console.Write("Nhap he so muon doi : ");
                        do
                        {
                            kiemtra = Int32.TryParse(Console.ReadLine(), out soCanDoi);
                            if (!kiemtra)
                            {
                                Console.Write("khong nhap chu  : ");
                            }
                        } while (!kiemtra);
                        a.doiCoSo(so, a, soCanDoi);
                        break;
                }
            }

        }
        static void Main(string[] args)
        {
            int somenu;
            Stack a = new Stack(100);

            do
            {
                Console.Clear();
                a.xuatmenu();
                somenu = a.Chonmenu();
                a.xulymenu(somenu);

            } while (somenu > 0);
            Console.ReadLine();
        }
    }
    }


