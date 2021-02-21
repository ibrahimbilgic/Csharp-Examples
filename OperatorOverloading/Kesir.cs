using System;

namespace OperatorOverloading
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
        public static explicit operator int(Kesir knesne){
            int sonuc = knesne.pay / knesne.payda;
            return sonuc;
        }
        public static implicit operator Kesir(int sayi){
            Kesir sonuc = new Kesir(sayi,1);
            return sonuc;
        }
        public static Kesir operator+(Kesir kn1, Kesir kn2){
            int p = kn1.pay * kn2.payda + kn2.pay * kn1.payda;
            int pd = kn1.payda * kn2.payda;

            Kesir sonuc =new Kesir(p,pd);
            return sonuc;
        }
        public static bool operator ==(Kesir kn1,Kesir kn2){
            double d1 = (double) kn1.pay / kn1.payda;
            double d2 = (double) kn2.pay / kn2.payda;

            return (d1 == d2);
        }
        public static bool operator !=(Kesir kn1,Kesir kn2){
            return !(kn1==kn2);
        }

    }
}
