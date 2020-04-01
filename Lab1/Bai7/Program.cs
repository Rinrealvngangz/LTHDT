using System;

namespace Bai7
{
    class Program
    {
        public class Phanso
        {

            int tuso, mauso;

            public Phanso()
            {
                tuso = 0;
                mauso = 1;
            }

            public Phanso(int x)
            {
                tuso = x;
                mauso = 1;
            }
            public Phanso(int x, int y)
            {
                tuso = x;
                mauso = y;
            }


            public void show()
            {
                Console.WriteLine("Phan so la:{0}/{1}", tuso, mauso);
            }

            static void Main(string[] args)
            {
                Phanso ob = new Phanso();
                ob.show();

                Phanso ob1 = new Phanso(1);
                ob1.show();

                Phanso ob2 = new Phanso(10, 1);
                ob2.show();
                Console.ReadLine();
                return;
            }

        }

    }
}

