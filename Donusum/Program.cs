using System;

namespace Donusum
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 5.4;
            int b = (int) a; // explicit donusum..

            short s = 6;
            b = s; //implicit donusum...

            Console.WriteLine(sizeof(short) +"bit");
            Console.WriteLine(sizeof(int)+"bit");
            Console.WriteLine(sizeof(double)+"bit");

            Console.WriteLine("\n");

            Kesir k1 = new Kesir(5,4);
            k1.yaz(); 
            int a2 = (int)k1;
            Console.WriteLine(a2);
            Kesir k2 = 3;
            k2.yaz();
        }
    }
}
