using System;

namespace KitapOdunc
{
    class Kitap
    {
        public string adi,yazari;
        public int oduncKitapSayisi=0;
        public void oduncVer(){
            // Console.WriteLine(yazari + " tarafindan yazilan " + adi + " isimli kitap odunc verildi");
            oduncKitapSayisi++;
            Console.WriteLine("odunc kitap sayisi: "+oduncKitapSayisi);
        }
        public static void statikMetot(){
            Console.WriteLine("Ben bir statik metotum!");
             //adi = "Hacı Murat";
            //statik üyeler nesneleri bireysel olarak değil, sınıfın geneli ilgilendirir
            //sınıf ismi üzerinden cagrilirlar
            //statik metotların içerisinde nonstatik degiken kullanilamaz, 
            //sadece statik değisken kullanılabilir
            //nonstatik metotlar hem statik hem nonstatik degiskenleri kullanabilirler
        }
    }
}
