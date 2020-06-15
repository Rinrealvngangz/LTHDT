using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OnThi_LTHDT
{
    public class QuanLyGV : GiaoVien 
    {
        Dictionary<string, GiaoVien> ListGV = new Dictionary<string, GiaoVien>();

        public void DocFiletxt(string path)
        {

            GiaoVien gv = new GiaoVien();

            ListGV = gv.DocFile(path);

            foreach (KeyValuePair<string, GiaoVien> itemsgv in ListGV)
            {
                Console.WriteLine(itemsgv.Value.Ho);
                Console.WriteLine(itemsgv.Value.Ten);
                Console.WriteLine(itemsgv.Value.MaSo);
                Console.WriteLine(itemsgv.Value.ID);
                Console.WriteLine(itemsgv.Value.boMon);

            }
            Console.WriteLine("Doc File Success");
        }

        public void NhapGv()
        {
            string ho, Ten, maso, id, BoMon;
            do
            {
                Console.Clear();
                Console.Write("Nhap Ho Giao vien : ");
                ho = Console.ReadLine();
                Console.Write("Nhap Ten Giao vien : ");
                Ten = Console.ReadLine();
                Console.WriteLine("Nhap Ma So Giao vien:");
                maso = Console.ReadLine();
                Console.WriteLine("Nhap ID:");
                id = Console.ReadLine();
                Console.WriteLine("Nhap Bo Mon:");
                BoMon = Console.ReadLine();
                GiaoVien gv = new GiaoVien(ho, Ten, maso, id, BoMon);
                ListGV.Add(gv.MaSo, gv);
                //Them Giao vien vao Dictionary(key,GiaoVien)
                // key Kiem tra báo trùng sẽ báo lỗi, key ở đây sẽ là MaSo
                Console.WriteLine("Ban co muon them gv ko(c/k)?");

            } while (Console.ReadKey().KeyChar != 'k');
        }
        public void XuatGV()
        {
            Console.Clear();
            Console.WriteLine("Danh sach Giao vien");
            foreach (KeyValuePair<string, GiaoVien> gv in ListGV)
            {
                Console.WriteLine(gv.Value);
                Console.WriteLine();
            }

        }
        public void GhiFiletxt(string path)
        {
            GiaoVien gv = new GiaoVien();
            if (gv.GhiFile(ListGV, path) == true)
                Console.WriteLine("ghi file success");
            else
                Console.WriteLine("Fail");
        }

        public void TimKiemTheoHoTen(string hoTen)
        {
            int dem = 0;
            foreach (KeyValuePair<string, GiaoVien> gv in ListGV)
            {

                if (gv.Value.HoTen == hoTen)
                {
                    dem++;
                }
            }
            if (dem != 0)
            {
                Console.WriteLine("Co " + dem + " giao vien " + hoTen + " trong Danh sach");
            }
            else
                Console.WriteLine("Khong Co Giao Vien " + hoTen);
        }
        public void TimKiemTheoTen(string Ten)
        {
            int dem = 0;
            foreach (KeyValuePair<string, GiaoVien> gv in ListGV)
            {

                if (gv.Value.Ten == Ten)
                {
                    dem++;
                }
            }
            if (dem != 0)
            {
                Console.WriteLine("Co " + dem + " giao vien " + Ten + " trong Danh sach");
            }
            else
                Console.WriteLine("Khong Co Giao Vien " + Ten);
        }

        public void TimKiemTheoMS(string MS)
        {
            int dem = 0;
            string ten = "";
            foreach (KeyValuePair<string, GiaoVien> gv in ListGV)
            {

                if (gv.Value.MaSo == MS)
                {
                    dem++;
                    ten = gv.Value.Ten;
                }
            }
            if (dem != 0)
            {
                Console.WriteLine("Co " + dem + " giao vien co ma so " + MS + " trong Danh sach ten " + ten);
            }
            else
                Console.WriteLine("Khong Co Giao Vien co ma so :" + MS);
        }

        private string TimMS(string maso)
        {

            string masoXoa = "";
            foreach (KeyValuePair<string, GiaoVien> gv in ListGV)
            {

                if (gv.Value.MaSo == maso)
                {
                    masoXoa = maso;
                }
            }
            return masoXoa;
        }
        public void XoaTheoMaSo(string maso)
        {
            ListGV.Remove(TimMS(maso));
            Console.WriteLine("Delete success");
        }
    

    
    }

   
}
