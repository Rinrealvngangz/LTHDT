using System;

namespace bai5
{
    class Program
    {
        public class myclass
            {
            int a;

            public myclass()
            {
                a = 10;
            }
            public void show()
            {
                Console.WriteLine("Gia tri a la:{0}", a);
            }

            static void Main(string[] args)
            {
                myclass ob = new myclass();
                ob.show();
                Console.ReadLine();
                return;
            }

        }
        
    }
}
