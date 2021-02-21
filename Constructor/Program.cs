using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a=new int();
            //Console.WriteLine(a);
            //bool b=new bool();
            //Zaman z4;
            //Console.WriteLine(b);
            Zaman z1 = new Zaman(3,5,2007);
            z1.zamaniYaz();
            Zaman z2 = new Zaman();
            z2.zamaniYaz();
            //Zaman z3 = new Zaman();

        }
    }
}
