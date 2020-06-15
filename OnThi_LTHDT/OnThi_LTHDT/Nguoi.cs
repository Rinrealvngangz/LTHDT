using System;
using System.Collections.Generic;
using System.Text;

namespace OnThi_LTHDT
{
    interface IODATABASE
    {
        bool GhiFile(Dictionary<string, GiaoVien> listGV, string path);
        Dictionary<string ,GiaoVien> DocFile(string path);
    }
    interface BAOMAT
    {
        string maHoa(string chuoiMaHoa);
        string giaiMa(string chuoiGiaiMa);
    }
    public class Nguoi
    {
    
        public string Ho { get; set; }
        public string Ten { get; set; }
        public string MaSo { get; set; }
      
        public string HoTen { get => Ho +" "+ Ten; }

        public override string ToString()
        {
            return HoTen +" " +MaSo ;
        }


    }
}
