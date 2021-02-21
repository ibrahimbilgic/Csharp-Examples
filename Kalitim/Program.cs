using System;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varlik v1 = new Varlik();
            //v1.yas = 5;
            //Kedi k1 = new Kedi();
            //k1.yas = 2;

            //Ata sinifta public olan ogeler ata siniftan, ata sinif nesnesinden, cocuk siniftan
            //ve cocuk sinif nesnesi üzerinden erişilebilir.

            //v1.privDegisken = 2;
            //k1.privDegisken = 1;
            //Ata sinifta private olan ogeler cocuk sinifa miras birakilmaz. Sadece ata sinif içinde kullanilir
            //ata sinif nesnesi, cocuk sinifin ici ve cocuk sinif nesnesi üzerinden erişilemez

            //v1.protDegisken = 0;
            //k1.protDegisken=5;

            //Ata sinifta protected olan ogeler cocuk sinifa miras birakilirlar. Ancak sadece ata sinifin
            //ve cocuk sinifin icinden erişilebilirler. Ata sinif ve cocuk sinif nesneleri üzerinden erişilemez

           // Varlik v1 = new Varlik();
            //v1.yuru();
            //v1.sesVer();


            Kedi k1 = new Kedi();
            //k1.yuru();
            //k1.sesVer();

            Varlik v2 = k1;
            //Kedi k2 = v2;//donusum operatoru olmadan dogrudan atanamaz
            v2.yuru();
            v2.sesVer();
        }
    }
}
