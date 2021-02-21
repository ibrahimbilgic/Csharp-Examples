using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
             /*Sinif s1 = new Sinif();
            s1.a = 5;
            Sinif s2 = new Sinif();
            s2.a = 5;
            s1 = s2;
            if (s1 == s2)
                Console.WriteLine("nesneler esit");
            else
                Console.WriteLine("farkli");*/

            /*Baglanti b1 = new Baglanti();
            Baglanti b2 = new Baglanti();
            */

            Baglanti b1 = Baglanti.baglantiDonder();
            Baglanti b2 = Baglanti.baglantiDonder();
            Baglanti b3 = Baglanti.baglantiDonder();
            //Burada aynı adresi gösteren nesneler üretiliyor.


            if(b1 == b2){
                Console.WriteLine("Aynı adres/Nesneyi Gösteriyor");
            }
            else{
                Console.WriteLine("Farklı nesneler");
            }

            //Singleton Design Pattern
        }
    }
}
