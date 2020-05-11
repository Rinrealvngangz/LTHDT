using System;
using System.Collections.Generic;
using System.Text;
using namespaceSinhvien;
using System.IO;
namespace NamespaceLopHoc
{
    class LopHoc : IODataBase
    {
      protected  Sinhvien[] dssv;

       protected int _siso;

       
        public LopHoc()
        {
            _siso = 0;
            dssv = new Sinhvien[100];
        }

        public int Siso { get => _siso; }

        public void themSV(LopHoc CTK42)
        {
            string hodem, ten, mssv;
            do
            {
                Console.Clear();
                Console.WriteLine("Nhap Ho va Ten , MSSV: ");
                hodem = Console.ReadLine();
                ten = Console.ReadLine();
                mssv = Console.ReadLine();
                Sinhvien ctk42 = new Sinhvien(hodem, ten, mssv);
               
                dssv[Siso] = ctk42;
                _siso++;
                Console.WriteLine("Ban co muon them Sv ko (c/k)?");
            } while (Console.ReadKey().KeyChar != 'k');
        }
        public void timkiemSV( string hoten)
        {
            int i;
            int dem = 0;
            for (i = 0; i < Siso; i++)
            {

                if (dssv[i].HovaTen == hoten)
                {
                    dem++;
                   

                }
            }
            if(dem !=0)
            Console.WriteLine("Co {0}: Sinh vien {1} trong ds", dem, hoten);
            if (dem == 0)
                Console.WriteLine("Khong co Sinh vien co ten:{0}", hoten);
        }

        public void timkiemSVtheoTen(string ten)
        {
            int i;
            int dem = 0;
            for (i = 0; i < Siso; i++)
            {

                if (dssv[i].Ten1 ==ten)
                {
                    dem++;
                }
            }
            if (dem != 0)
                Console.WriteLine("Co {0}: Sinh vien {1} trong ds", dem, ten);
            if (dem == 0)
                Console.WriteLine("Khong co Sinh vien co ten:{0}",ten);
        }

        public void timkiemSVtheoMS(string MS)
        {
            int i;
            string hoten="";
            int dem = 0;
            for (i = 0; i < Siso; i++)
            {

                if (MS == dssv[i].Maso1)
                {
                    dem++;
                    hoten = dssv[i].HovaTen;
                }
            }
           
            if (dem != 0)
                Console.WriteLine("Co {0}: Sinh vien co Ma so {1} trong ds ten:{2} ", dem, MS,hoten);
            if (dem == 0)
                Console.WriteLine("Khong co Sinh vien co MS:{0}", MS);
        }
        public void ReadFile(string FileName)
        {
            FileStream file;
            string HoDem, Ten, ID,Lop,MSSV;
           
            file = new FileStream(FileName, FileMode.Open);
            StreamReader sr = new StreamReader(file);

           string SiSo = sr.ReadLine();

            _siso = Int32.Parse(SiSo);

            dssv = new Sinhvien[_siso];
              
            for(int i =0; i<_siso;i++)
            {
                ID = sr.ReadLine();
                MSSV = sr.ReadLine();
                HoDem = sr.ReadLine();
                Ten = sr.ReadLine();
                Lop = sr.ReadLine();
                Sinhvien SV = new Sinhvien(HoDem, Ten, MSSV, ID, Lop);
                dssv[i] = SV;

            }
            sr.Close();
            file.Close();
        }
       public void WriteFile(string fileName)
        {
            FileStream file = new FileStream(fileName, FileMode.OpenOrCreate);

            StreamWriter sw = new StreamWriter(file);

            for (int i = 0; i < _siso; i++)
            {
                sw.Write(dssv[i].Id1);
                sw.Write(dssv[i].Maso1);    
                sw.Write(dssv[i].HoDem1);   
                sw.Write(dssv[i].Ten1);
                sw.Write(dssv[i].Lop1);
            }
            Console.WriteLine("Success");
            sw.Close();
            file.Close();
        }
       
        public void XuatDSSV()
        {      
               for (int i = 0; i < _siso; i++)
                {
                    Console.WriteLine("Sinh vien thu {0}", i + 1);
                    Console.WriteLine("ID: {0}\nMSSV: {1}\nHo va Ten: {2} \nLop: {3}\n",dssv[i].Id1 ,dssv[i].Maso1,dssv[i].HovaTen,dssv[i].Lop1);
               
                }      
        }

    }
}
