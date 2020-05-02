using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string chuoi1;
            string chuoi2;
            string chuoi3;
            Console.WriteLine("Nhap chuoi 1: ");
            chuoi1 = Console.ReadLine();
            Console.WriteLine("Nhap chuoi 2: ");
            chuoi2 = Console.ReadLine();
            Console.WriteLine("So sanh 2 chuoi");

            if(chuoi1.Length == chuoi2.Length)
            {
                Console.WriteLine("hai chuoi = nhau");
            }
            else if(chuoi1.Length > chuoi2.Length)
            {
                Console.WriteLine(" chuoi1 > chuoi2");
            }
            else
                Console.WriteLine(" chuoi1 < chuoi2");
            Console.WriteLine("Noi 2 chuoi ");
          chuoi3 =  string.Concat(chuoi1,  chuoi2);
            Console.WriteLine("kq:{0} ",chuoi3);
            Console.WriteLine("Thay 'a' thanh 'b' ");
            chuoi3 = chuoi3.Replace("a", "b");
            Console.WriteLine("kq :{0}",chuoi3);
            Console.WriteLine("Doi chu Hoa");
           
            Console.WriteLine("kq:{0}", chuoi3.ToUpper());
            Console.ReadLine();
        }
    }
}
