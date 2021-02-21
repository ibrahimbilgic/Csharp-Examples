using System;

namespace C_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            AdresDefteri defterim = new AdresDefteri();
            defterim.Ekle("ibrahim","Bilgiç","536","Aydın");
            defterim.Ekle("Zehra","Bilgiç","537","Söke");

            int indis = defterim.Bul("Zehra","Bilgiç");
            Console.WriteLine("Bulunan indis: "+indis);

            string veri = defterim.veriUret();
            Raporlama raporUret = new Raporlama();
            raporUret.printReport(veri);

            int sonuc = defterim.Sil("ibrahim","Bilgiç");
            if(sonuc == -1){
                Console.WriteLine("Silinemedi");
            }
            else{
                Console.WriteLine("Silindi: "+sonuc);
            }
            
            veri = defterim.veriUret();
            raporUret.printReport(veri);

        }
    }
}
