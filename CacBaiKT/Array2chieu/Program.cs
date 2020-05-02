using System;

namespace Array
{
    class Program
    {
        public class maTran
        {
            int sum = 0;
            int h, c;
            int[,] array;
            bool kiemtra = false;
            bool check = false;
            public maTran(int h, int c)
            {
                this.h = h;
                this.c = c;
                array = new int[h, c];
            }
            public maTran(int num)
            {
                this.h = num;
                this.c = num;
                array = new int[h, c];
            }

            public void check_hang()
            {
                do
                {
                    Console.WriteLine("Nhap lai so hang :");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out h);

                } while (!kiemtra);
            }
            public void check_cot()
            {
                do
                {
                    Console.WriteLine("Nhap lai so cot :");
                    kiemtra = Int32.TryParse(Console.ReadLine(), out c);

                } while (!kiemtra);
            }
            public void nhapHangCot()
            {
                Console.WriteLine("Nhap hang :");
                kiemtra = Int32.TryParse(Console.ReadLine(), out h);
                if (!kiemtra) check_hang();
                Console.WriteLine("Nhap cot :");
                kiemtra = Int32.TryParse(Console.ReadLine(), out c);
                if (!kiemtra) check_cot();
            }
            public void nhapMaTran()
            {
                int i, j;

                for (i = 0; i < h; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        do
                        {
                            Console.Write("array:[{0}] [{1}]: ", i, j);
                            kiemtra = Int32.TryParse(Console.ReadLine(), out array[i, j]);

                        } while (!kiemtra);

                    }
                }
            }

            public void xuat_Ma_Tran()
            {
                int i, j;
                Console.WriteLine("Mang sau khi nhap :");
                for (i = 0; i < h; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                        Console.Write(array[i, j]);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }

            public static maTran operator +(maTran T1, maTran T2)
            {
                int i, j;
                int H, C;

                maTran T3;

                if (T1.c > T2.c && T1.h > T2.h)
                {
                    C = T1.c;
                    H = T1.h;
                }
                else if (T1.c < T2.c && T1.h < T2.h)
                {
                    C = T2.c;
                    H = T2.h;
                }
                if (T1.h > T2.h && T1.c < T2.c)
                {
                    C = T2.c;
                    H = T1.h;
                }
                else
                {
                    C = T1.c;
                    H = T2.h;
                }

                T3 = new maTran(H, C);

                for (i = 0; i < H; i++)
                {
                    for (j = 0; j < C; j++)
                    {
                        T3.array[i, j] = T1.array[i, j] + T2.array[i, j];
                    }
                }
                return T3;
            }

            public static maTran operator -(maTran T1, maTran T2)
            {

                int i, j;
                int H, C;

                maTran T3;

                if (T1.c > T2.c && T1.h > T2.h)
                {
                    C = T1.c;
                    H = T1.h;
                }
                else if (T1.c < T2.c && T1.h < T2.h)
                {
                    C = T2.c;
                    H = T2.h;
                }
                if (T1.h > T2.h && T1.c < T2.c)
                {
                    C = T2.c;
                    H = T1.h;
                }
                else
                {
                    C = T1.c;
                    H = T2.h;
                }
                T3 = new maTran(H, C);

                for (i = 0; i < H; i++)
                {
                    for (j = 0; j < C; j++)
                    {
                        T3.array[i, j] = Math.Abs(T1.array[i, j] - T2.array[i, j]);
                    }
                }
                return T3;
            }

            public static maTran operator *(maTran T1, maTran T2)
            {
                int i, j;
                int H, C;
                //  int sum =0;
                maTran T3;
                H = T1.h;
                C = T1.c;
                T3 = new maTran(H, C);
                for (i = 0; i < H; i++)
                {
                    for (j = 0; j < C; j++)
                    {
                        T3.array[i, j] = (T1.array[i, j] * T2.array[i, j]);
                    }
                    //  T3.array[i, j] = sum;
                }
                return T3;
            }

            public void chuyenVi(ref maTran T1)
            {
                int[,] array1 = new int[T1.h, T1.c];//mang phu
                for (int i = 0; i < T1.h; i++)
                {
                    for (int j = 0; j < T1.c; j++)
                    {
                        array1[i, j] = T1.array[j, i];
                        Console.Write(array1[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
            }
            public static bool operator !=(maTran T1, maTran T2)
            {
                bool  check = false;
                int i, j;
               
                    for (i = 0; i < T1.h; i++)
                    {
                        for (j = 0; j < T2.c; j++)
                        {
                            if (T1.array[i, j] != T2.array[i, j])
                                check = true;
                        }
                    }
                return check ;
            }
            public static bool operator ==(maTran T1, maTran T2)
            {
                bool check = false;
              
                int i, j;
               
                    for (i = 0; i < T1.h; i++)
                    {
                        for (j = 0; j < T2.c; j++)
                        {
                            if (T1.array[i, j] == T2.array[i, j])
                                check = true;
                        }
                    }
                return check;
            }

            public void tongDuongCheoChinh(maTran T1)
            {
                
                int i, j;
                for (i = 0; i < h; i++)
                {
                    for (j = 0; j < c; j++)
                    {
                     
                        if (i == j) sum = sum + T1.array[i, j];
                    }
                }
                Console.WriteLine("Tong duong cheo chinh ma tran vuong:{0}",sum);
            }
            public void matrandoixung(maTran T4)
            {
                maTran T2 = new maTran(3, 3);
                  T4.chuyenVi(ref T4);
                maTran T3 = new maTran(3, 3);
                if ( T3 == T4 )
                {
                    Console.WriteLine("ma tran doi xung");
                }                
                else
                {
                    Console.WriteLine("khong phai  doi xung");
                }
            }
            static void Main(string[] args)
            {
                maTran arr1 = new maTran(3, 3);
                maTran arr3 = new maTran(3, 3);
                maTran arr = new maTran(4);
                maTran arr2 = new maTran(6, 7);
                //  Console.WriteLine("Chuyen vi ma tran:");
                // arr.chuyenVi();
                arr.nhapHangCot();
                arr.nhapMaTran();
                arr.xuat_Ma_Tran();
                Console.WriteLine("..........");
                arr2.nhapHangCot();
                arr2.nhapMaTran();
                arr2.xuat_Ma_Tran();
                Console.WriteLine("..........");
                //Console.WriteLine("Cong hai ma tran: ");
                //arr3 = arr + arr2;
                //arr3.xuat_Ma_Tran();
                Console.WriteLine("..........");
                //Console.WriteLine("Tru hai ma tran: ");
                //  arr3 = arr - arr2;
                //  arr3.xuat_Ma_Tran();

                //Console.WriteLine("Nhan hai ma tran: ");
                // arr3 = arr * arr2;
                // arr3.xuat_Ma_Tran();
                //Console.WriteLine("Chuyen vi ma tran: ");
                //arr.chuyenVi(ref arr);
                Console.WriteLine("ma tran arr == ma tran arr2 ? {0}", arr == arr2);
                Console.WriteLine("ma tran arr != ma tran arr2 ? {0}", arr != arr2);
                Console.WriteLine("..........");
                Console.WriteLine("Tong duong cheo chinh ma tran vuong: ");
                Console.WriteLine("nhap ma tran vuong: ");
                arr1.nhapHangCot();
                arr1.nhapMaTran();
                arr1.xuat_Ma_Tran();
                arr3.tongDuongCheoChinh(arr1);

                Console.WriteLine(" ma tran doi xung : ");
                arr1.matrandoixung(arr2);

                Console.ReadLine();
            }

        }
    }
}

