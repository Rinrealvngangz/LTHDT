using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace namespaceSinhvien
{
    interface IODataBase
    {
        void ReadFile(string fileName);
        void WriteFile(string fileName);
    }

    interface BaoMat
    {
        void MaHoa();
        void GiaiMa();
    }
    class Nguoi
    {
        protected string _HoDem;
        protected string _Ten;
        protected string _Maso;

        public string HoDem1 { get => _HoDem; set => _HoDem = value; }
        public string Ten1 { get => _Ten; set => _Ten = value; }
        public string Maso1 { get => _Maso; set => _Maso = value; }

        public string HovaTen { get => _HoDem +" " + _Ten; }

    }
    class Sinhvien : Nguoi
    {
        string Lop;
        string Id;
        public string Lop1 { get => Lop; set => Lop = value; }
        public string Id1 { get => Id; set => Id = value; }

        public Sinhvien(string HodemSV, string TenSV, string mssv, string id, string lop)
        {
            _HoDem = HodemSV;
            _Ten = TenSV;
            _Maso = mssv;
            Lop1 = lop;
            Id1 = id;
        }

        public Sinhvien(string HodemSV, string TenSV, string mssv)
        {
            _HoDem = HodemSV;
            _Ten = TenSV;
            _Maso = mssv;

        }

    }
}