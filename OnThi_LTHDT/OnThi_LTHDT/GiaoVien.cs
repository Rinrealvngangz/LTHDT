using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace OnThi_LTHDT
{
   public class GiaoVien : Nguoi , IODATABASE,BAOMAT
     {
        public string ID { get; set; }
        public string boMon { get; set; }

        public GiaoVien()
        {

        }
        public GiaoVien (string ho,string ten,string maso, string id,string bomon)
        {
            Ho = ho;
            Ten = ten;
            MaSo = maso;
            ID = id;
            boMon = bomon;
        }

        public override string ToString()
        {
            return base.ToString() + " "+ID +" " +boMon;
        }

       public Dictionary<string,GiaoVien> DocFile(string path) {


            Dictionary<string, GiaoVien> ListGV = new Dictionary<string, GiaoVien>();
            try
            {
                string ho,ten,maso, id, bomon;
               
                StreamReader sr = new StreamReader(path, Encoding.UTF8);
               
                string siso = sr.ReadLine();
                giaiMa(siso);
                string [] arr = {siso};
             
                for(int i=0;i< Int32.Parse(arr[0]);i++)
                {
                    GiaoVien gv = new GiaoVien();
                   ho =sr.ReadLine();
                    ten = sr.ReadLine();
                    maso = sr.ReadLine();
                    id = sr.ReadLine();
                    bomon = sr.ReadLine();
                    gv.Ho = giaiMa(ho);
                    gv.Ten = giaiMa(ten);
                    gv.MaSo = giaiMa(maso);
                    gv.ID = giaiMa(id);
                    gv.boMon = giaiMa(bomon);
                    ListGV.Add(gv.MaSo, gv);
                }
                sr.Close();
              
            }
            catch(Exception er)
            {
                throw er;
            }
            return ListGV;
        }
      public  bool GhiFile(Dictionary<string,GiaoVien> listGV, string path)
        {
            try
            {
                StreamWriter sw = new StreamWriter(path, false, Encoding.UTF8);
                sw.WriteLine(listGV.Count);
                foreach ( KeyValuePair<string,GiaoVien>gv  in listGV)
                {
                   
                     sw.WriteLine(maHoa(gv.Value.Ho));
                    sw.WriteLine(maHoa(gv.Value.Ten));
                    sw.WriteLine(maHoa(gv.Value.MaSo));
                    sw.WriteLine(maHoa(gv.Value.ID));
                    sw.WriteLine(maHoa(gv.Value.boMon));

                }
                sw.Close();
                return true;

            }catch( Exception er)
            {
                throw er;
            }
        }
      public string maHoa(string chuoiMaHoa)
        {
            int giaima;
            string chuoiDaMaHoa="";
            for(int i =0;i< chuoiMaHoa.Length;i++)
            {
                giaima = (int)chuoiMaHoa[i];
                giaima += 5;
              chuoiDaMaHoa +=  (char)giaima;
           
            }
            return chuoiDaMaHoa;
        }
     public string giaiMa(string chuoiGiaiMa)
        {
            int giaima;
            string chuoiDaGiaiMa = "";
            for (int i = 0; i < chuoiGiaiMa.Length; i++)
            {
                giaima = (int)chuoiGiaiMa[i];
                giaima -= 5;
                chuoiDaGiaiMa += (char)giaima;

            }
           
            return chuoiDaGiaiMa;
        }

    }
}
