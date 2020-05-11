using System;
using NamespaceLopHoc;
using namespaceSinhvien;
namespace QuanLySinhVien_Ver1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            LopHoc CTK42 = new LopHoc();
            string hoten,ten,MS;
            string fileName = "c:\\DATA\\DSSVCTK42.txt";
            string WriteName = "c:\\DATA\\InDSSV.txt";

            //CTK42.themSV(CTK42);
            //CTK42.XuatDSSV();
            CTK42.ReadFile(fileName);
            CTK42.XuatDSSV();
            Console.Write("WriteData: ");
            CTK42.WriteFile(WriteName);
            Console.WriteLine("Nhap ho va ten sinh vien can tim");
            hoten = Console.ReadLine();
            CTK42.timkiemSV(hoten);

            Console.WriteLine("Nhap ten sinh vien can tim");
            ten = Console.ReadLine();
            CTK42.timkiemSVtheoTen(ten);

            Console.WriteLine("Nhap MS sinh vien can tim");
            MS = Console.ReadLine();
            CTK42.timkiemSVtheoMS(MS);
          
            Console.ReadLine();
        }
    }
}
