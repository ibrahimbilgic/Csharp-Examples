using System;

namespace Abstract
{
    sealed class KalitimaKapaliSinif:KatButonu
    {
        public void deneme(){
            Console.WriteLine("Deneme kalitima kapali sinif");
        
        }
        //sealed classlar kalitima kapatilmiştir. Miras birakamazlar, ancak kendileri miras alabilirler
        //sealed classlardan nesne türetilebilir
    }
}
