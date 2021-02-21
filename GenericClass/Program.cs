using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Islemler<int> d = new GenericClass.Islemler<int>();
            d.Ekle(3);
            d.Ekle(5);
            d.Ekle(10);

            Islemler<string> d2 = new GenericClass.Islemler<string>();
            d2.Ekle("ibrahim");
            d2.Ekle("zehra");
            d2.Ekle("bilgic");

            /*Islemler<Kitap> d3 = new Islemler<Kitap>();
            //d3.Ekle(new Kitap());
            Kitap k2 = new Kitap();
            k2.adi = "İnsancıklar";
            d3.Ekle(k2);*/

        }
    }
}
