using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ClassSinhVien;
using QuanLySinhVien;
namespace LopSinhVien
{
   
    class Lop
    {
        string[] SV;
        int siSo;
        SinhVien[] dssv;
        public Lop()
        {
            siSo = 0;          
            dssv = new  SinhVien[100];
        }
       
        public void ThemSinhVien(Lop b)
        {
           
            string ho, TenDem, Ten;
            int maso;
           
            do
            {
                Console.Clear();
                Console.WriteLine("Nhap Ho,ten dem va ten sinh vien : ");
                ho = Console.ReadLine();
                TenDem = Console.ReadLine();
                Ten = Console.ReadLine();
                Console.WriteLine("Nhap Ma sinh vien");
                maso = Int32.Parse(Console.ReadLine());
                SinhVien a = new SinhVien(ho, TenDem, Ten, maso);
                b.dssv[b.siSo] = a;
                b.siSo++;
                Console.WriteLine("Ban co muon them Sv ko (c/k)?");
               
            } while (Console.ReadKey().KeyChar!='k');
            
        }
        public void XuatSV(Lop b)
        {
            int i;
            Console.Clear();
            Console.WriteLine("Danh sach Sinh vien" );
            for (i = 0; i < b.siSo; i++)
            {
                Console.WriteLine(b.dssv[i].HoSV +" " + b.dssv[i].TenDemSV + " " + b.dssv[i].TenSV + " " + b.dssv[i].MaSV);
            }
            Console.WriteLine("Si so lop hoc:{0} ", b.siSo + " sinh vien");
                         
        }
        public void timkiemSV(Lop b,string hoten)
        {  
            int i;
            int dem = 0;
            for (i = 0; i < b.siSo; i++)
            {

                if (b.dssv[i].HoSV + b.dssv[i].TenDemSV + b.dssv[i].TenSV == hoten || b.dssv[i].HoSV + " " + b.dssv[i].TenDemSV + " " + b.dssv[i].TenSV == hoten)
                {
                    dem++;
                    Console.WriteLine("Co {0}: Sinh vien {1} trong ds",dem,hoten );
                            
                }          
            }
              if(dem==0)
                Console.WriteLine("Khong co Sinh vien co ten:{0}", hoten);
        }
        public void timkiemSVtheoTen(Lop b, string ten)
        {
            int dem = 0;
            int i;
            for (i = 0; i < b.siSo; i++)
            {

                if ( b.dssv[i].TenSV == ten)
                {
                    dem++;
                    Console.Write("Co {0}: Sinh vien {1} trong ds", dem,ten+" ");
                   
                }
             
            }
            if (dem == 0)
                Console.WriteLine("Khong co Sinh vien co ten:{0}", ten);

        }
        public void timkiemSVtheoMS(Lop b, int MS)
        {
            int i;
            int dem = 0;
            for (i = 0; i < b.siSo; i++)
            {

                if (b.dssv[i].MaSV == MS )
                {
                    dem++;
                    Console.Write("Co {0}: Sinh vien Co MS {1} trong ds", dem,MS + " ");
                    
                }     
            }
            if (dem == 0)
                Console.WriteLine("Khong co Sinh vien co MS:{0}", MS);
        }

        public void BosungSV(Lop b)
        {

            string ho, TenDem, Ten;
            int maso;

            do
            {
                Console.Clear();
                Console.WriteLine("Nhap Ho,ten dem va ten sinh vien : ");
                ho = Console.ReadLine();
                TenDem = Console.ReadLine();
                Ten = Console.ReadLine();
                Console.WriteLine("Nhap Ma sinh vien");
                maso = Int32.Parse(Console.ReadLine());
                SinhVien a = new SinhVien(ho, TenDem, Ten, maso);
                b.dssv[b.siSo] = a;
                b.siSo++;
                Console.WriteLine("Ban co muon them Sv ko (c/k)?");

            } while (Console.ReadKey().KeyChar != 'k');

        }

        public void BoSVtheoMS(Lop b, int MS)
        {       
            int i,j;
            for (i = 0; i < b.siSo; i++)//0
            {
                for (j = i + 1; j < b.siSo + 1; j++)//1

                    if ( MS == b.dssv[i].MaSV )//0    
                    {
                        b.dssv[j - 1] = b.dssv[j];
                        b.siSo--;
                    }
            }                  
        }
        
    }
}
