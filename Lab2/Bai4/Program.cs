using System;

namespace Bai4
{
    class PassingByVal
    {
        static void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Trong phuong thuc swap:a={0},b={1}", a, b);
        }

        static void Main(string[] args)
        {
            int x =3 , y=4;
            Console.WriteLine("Truoc khi goi phuong thuc swap: a={0},b={1}", x, y);
            Swap(x,y);
            Console.WriteLine("Sau  khi goi phuong thuc swap: a={0},b={1}", x, y);
            Console.ReadLine();
        }
    }
}
