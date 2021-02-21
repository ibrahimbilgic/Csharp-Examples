using System;

namespace KitapOdunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap k1 = new Kitap();
            k1.adi = "Yapı(t) Söküm";
            k1.yazari = "Yalın Alpay";
            k1.oduncVer();

            Kitap k2 = new Kitap();
            k2.adi = "İnsancıklar";
            k2.yazari = "Dostoyevski";
            k2.oduncVer();

            Kitap k3 = new Kitap();
            k3.adi = "Ahlakın soykütüğü üzerine";
            k3.yazari = "Niçe";
            k3.oduncVer();

            Kitap.statikMetot();


        }
    }
}
