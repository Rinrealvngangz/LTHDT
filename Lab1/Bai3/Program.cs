
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai03
{
    class Program
    {
        class myHCN
        {
            int chieudai;
            int chieurong;

            public void set_dai_rong()
            {
                Console.WriteLine("Nhap Chieu Dai:");
                chieudai = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap Chieu rong:");
                chieurong = int.Parse(Console.ReadLine());

            }
            public int dientich_HCN()
            {
                return chieudai * chieurong;
            }
            public int chuvi_HCN()
            {

                return (chieudai + chieurong) / 2;
            }
            static void Main(String[] args)
            {
                myHCN S_HCN = new myHCN();

                S_HCN.set_dai_rong();

                Console.WriteLine("Dien tich HCN :{0}", S_HCN.dientich_HCN());
                Console.WriteLine("Chu vi HCN:{0}", S_HCN.chuvi_HCN());
            }
        }
    }
}
