using System;

namespace Proporty
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1= new Ogrenci();
            //o1.yas = 10;

            bool s = o1.yasAta(10);
            Console.WriteLine(o1.yasDonder());
            o1.dYiliAta(2012);
            Console.WriteLine(o1.yasDonder());

            Ogrenci2 o2 = new Ogrenci2();
            o2.PYas = 10;
            Console.WriteLine(o2.PYas);
            o2.PDYili = 1987;
            Console.WriteLine(o2.PYas);
            Console.WriteLine(o2.Pgano);

        }
    }
}
