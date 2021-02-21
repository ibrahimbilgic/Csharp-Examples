using System;

namespace Donusum
{
    class Kesir
    {
        public int pay,payda;

        public Kesir(int p,int pd){
            pay = p;
            payda = pd;
        }

        public void yaz(){
            Console.WriteLine("{0} / {1}",pay,payda);
        }

        public static explicit operator int(Kesir kesirNesnesi){
            int sonuc = kesirNesnesi.pay / kesirNesnesi.payda;
            return sonuc;

        }

        public static implicit operator Kesir(int a){
            Kesir sonuc = new Kesir(a,1);
            return sonuc;
        }
    }
}
