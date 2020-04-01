using System;


namespace bai04
{

    class Program
    {
        class Phanso
        {
            int tuso;
            int mauso;

            public void checkmauso()
            {
                Console.WriteLine("Phanmauso:");
                mauso = int.Parse(Console.ReadLine());
                while (mauso == 0)
                {
                    Console.WriteLine("Phan so phai khac 0!");
                    checkmauso();
                }

            }
            public void show()
            {
                Console.WriteLine("Phanso:{0}/{1}", tuso, mauso);
            }

            public void nhap()
            {
                Console.WriteLine("Phantuso:");
                tuso = int.Parse(Console.ReadLine());
                checkmauso();
            }
            public void chuongtrinh()
            {
                nhap();
                show();

            }
        }
        static void Main(String[] args)
        {
            Phanso ob = new Phanso();
            ob.chuongtrinh();
            Console.ReadLine();
        }
    }
}