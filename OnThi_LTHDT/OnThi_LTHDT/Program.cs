using System;

namespace OnThi_LTHDT
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "c:\\DATA\\dsgv.txt";//tao file theo duong dan
            string hoTen, ten,maso;
            QuanLyGV qlgv = new QuanLyGV();
            qlgv.DocFiletxt(path);
           Console.WriteLine("-------- Tim kiem theo Ho va Ten");
            Console.WriteLine("Nhap ho ten Giao Vien Can Tim:");
            hoTen =  Console.ReadLine();
            qlgv.TimKiemTheoHoTen(hoTen);
            Console.WriteLine("-------- Tim kiem theo Ten");
            Console.WriteLine("Nhap ten Giao Vien Can Tim:");
            ten = Console.ReadLine();
            qlgv.TimKiemTheoTen(ten);
            Console.WriteLine("-------- Tim kiem theo Ma so");
            Console.WriteLine("Nhap Ma so Giao Vien Can Tim:");
            maso = Console.ReadLine();
            qlgv.TimKiemTheoMS(maso);
            Console.WriteLine("-------- Xoa Giao Vien theo Ma so");
            Console.WriteLine("Nhap Ma so Giao Vien Can Xoa:");
            maso = Console.ReadLine();
            qlgv.XoaTheoMaSo(maso);
        
            Console.WriteLine("-------- Them Giao Vien Vao Danh Sach");
              qlgv.NhapGv();
           Console.WriteLine("-------- Xuat tat ca Giao Vien trong Danh Sach");
            qlgv.XuatGV();
            Console.WriteLine("-------- Ghi Danh sach vao file txt");

            qlgv.GhiFiletxt(path);
        }
    }
}
