using System;

/*namespace Bai6
{
    class Program
    {
        public class myclass
        {
            int a;
            int tuso, mauso;

            public myclass(int x)
            {
                a = x;
            }

           
            public void show()
            {
                Console.WriteLine("Gia tri a la:{0}", a);
            }

            static void Main(string[] args)
            {
                myclass ob = new myclass(10);
                ob.show();
                Console.ReadLine();
                return;
            }

        }

    }
}*/

namespace Bai6
{
    class Program
    {
        public class Phanso
        {
            
            int tuso, mauso;

            public Phanso(int x,int y)
            {
                tuso = x;
                mauso = y;
            }


            public void show()
            {
                Console.WriteLine("Phan so la:{0}/{1}", tuso,mauso);
            }

            static void Main(string[] args)
            {
                Phanso ob = new Phanso(10,1);
                ob.show();
                Console.ReadLine();
                return;
            }

        }

    }
}

