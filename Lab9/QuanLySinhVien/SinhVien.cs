using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSinhVien
{
    class SinhVien
    {

        public string _Ho;
        public string _TenDem;
        public string _Ten;
        public int _Maso;
        public  string HoSV
        {
          
            get { return _Ho; }
            set { _Ho = value; }
        }

        public string TenDemSV
        {
            get { return _TenDem; }
            set { _TenDem = value; }
        }
        public string TenSV
        {
            get { return _Ten; }
            set { _Ten = value; }
        }
        public int MaSV
        {
            get { return _Maso; }
            set { _Maso = value; }
        }

        public SinhVien(string Ho, string TenDem, string Ten, int maso)
        {
            HoSV = Ho;
            TenDemSV = TenDem;
            TenSV = Ten;
            MaSV = maso;

        }

        public string HovaTenSV(SinhVien a)
        {
            string hovaten;

            hovaten = a.HoSV + " " + a.TenDemSV + " " + a.TenSV + " ";
            return hovaten;

        }
       
        public  int MaSoSV(SinhVien a)
        {
            int maso;
            maso = a._Maso;
            return maso;
        }

    }
}
