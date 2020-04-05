using System;

namespace Bai2
{
    class Program
    {

        class myclass
        {
            private static int i;

            public void seti(int n) { i = n; }
            public int geti() { return i; }
        }
        static void Main(string[] args)
        {
            myclass ob1 = new myclass();
            myclass ob2 = new myclass();
            ob1.seti(10);
            Console.WriteLine("Gia tri ob1:{0}", ob1.geti());
            Console.WriteLine("Gia tri ob2:{0}", ob2.geti());
            Console.ReadLine();
        }
                 
    }
}
// Tại vì geti() là phương thức trong lớp myclass ,trước đó ob1 dùng phương phương thức seti(); tham số n gắn = i;
// nên phương thức geti() lưu giá trị i; nên ob2.geti() cũng cho kết quả là 10;
