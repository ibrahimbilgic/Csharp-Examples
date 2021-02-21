using System;

namespace KarmasikSayi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Toplama ve Çıkartma İşlemi için:");
            Console.WriteLine("1.Karmaşık sayının reel kısmı:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.karmaşık sayının sanal kısmı:");
            double s = Convert.ToDouble(Console.ReadLine());
            Karmasiksayi k1 = new Karmasiksayi(r,s);

            
            Console.WriteLine("2.Karmaşık sayının reel kısmı:");
            double r2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.karmaşık sayının sanal kısmı:");
            double s2 = Convert.ToDouble(Console.ReadLine());
            Karmasiksayi k2 = new Karmasiksayi(r2,s2);

            Karmasiksayi t = new Karmasiksayi(k1+k2);
            t.yaz();
            Karmasiksayi f = new Karmasiksayi(k1-k2);
            f.yaz();
            Console.Read();

        }
    }
}
