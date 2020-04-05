using System;

namespace Bai1
{
    class myClass
    {   class Phanso
    {
        int tuso, mauso;
            public Phanso( int x, int y)
            {
                tuso = x;
                mauso = y;
            }
        public Phanso( Phanso ob )
        {
            tuso = ob.tuso;
            mauso = ob.mauso;
        }
            public void show()
            {
                Console.WriteLine("Phan so la:{0}/{1}", tuso, mauso);
            }
    }
    
        static void Main(string[] args)
        {
            Phanso ob1 = new Phanso(2,7);
            ob1.show();
            Phanso ob2 = new Phanso(ob1);
            ob2.show();
            Console.ReadLine();
            return;
        }
    }
}
