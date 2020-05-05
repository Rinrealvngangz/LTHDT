using System;
using ClassSinhVien;
using LopSinhVien;
namespace QuanLySinhVien
{
   
        class Program
    {
        static void Main(string[] args)
        {
            int MS;
            string hoten,ten;
            Lop a = new Lop();
            Console.WriteLine("Nhap Sinh vien");
            a.ThemSinhVien(a);
            a.XuatSV(a);
             Console.WriteLine("Nhap Ho va ten SV can tim:");
             hoten = Console.ReadLine();
             a.timkiemSV(a, hoten);
            Console.WriteLine("Nhap ten SV can tim:");
            ten = Console.ReadLine();
            a.timkiemSVtheoTen(a, ten);
            Console.WriteLine();

            Console.WriteLine("Nhap ten MSSV can tim:");
            MS = Int32.Parse(Console.ReadLine());
            a.timkiemSVtheoMS(a, MS);

            // Console.WriteLine("Bo sung Them Sinh vien");
            //  a.BosungSV(a);
            //  Console.WriteLine("DS sau khi Bo sung ");
            //a.XuatSV(a);

            Console.WriteLine();
            Console.WriteLine("Xoa SV theo mssv:");
            MS = Int32.Parse(Console.ReadLine());
            a.BoSVtheoMS(a, MS);
            a.XuatSV(a);
            Console.ReadLine();
        }
    }
}
