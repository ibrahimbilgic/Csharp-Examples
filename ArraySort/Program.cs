using System;

namespace ArraySort
{
    ///ARRAY SORT///
    class Program
    {
        static void Main(string[] args)
        {
            //int[] dizi = new int[] { -2, 3, 0, 5, 20, 1, -10 };
            /*string[] dizi = new string[] { "ayse", "ali", "ahmet", "mehmet", "deniz", "lale" };
            Console.WriteLine("Siralama Öncesi");
            for (int i = 0; i < dizi.Length; i++)
                Console.WriteLine(dizi[i]);

            Array.Sort(dizi);
            Console.WriteLine("Siralama Sonrası");
            for (int i = 0; i < dizi.Length; i++)
                Console.WriteLine(dizi[i]);
                */

            Personel[] dizi = new Personel[5];
            dizi[0] = new Personel(105,"ayten","bilgic");
            dizi[1] = new Personel(100,"mehmet","bilgic");
            dizi[2] = new Personel(102,"ibrahim","bilgic");
            dizi[3] = new Personel(111,"zehra","bilgic");
            dizi[4] = new Personel(103,"isim","tamlaması");

            for(int i = 0; i<5 ;i++){
                dizi[i].yaz();
            }
            Array.Sort(dizi);

                Console.WriteLine("\nSiralama sonrasi\n");
                for(int i = 0;i<5;i++){
                    dizi[i].yaz();
                }
        }
    }
}
