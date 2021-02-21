using System;

namespace Singleton
{
    class Baglanti
    {
        private Baglanti(){
            //sürekli nesne üretimini engellemek için oluşturuldu..
        
        }

        static Baglanti baglanti;
        static Baglanti(){
            //bir defaya mahsus nesne üretmek için..
            baglanti = new Baglanti();
        }

        public static Baglanti baglantiDonder(){
            //static const. olusturdugu baglantı nesnesini dondermek
            return baglanti;
        }

    }
}
