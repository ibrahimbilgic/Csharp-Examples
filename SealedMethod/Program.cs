using System;

namespace SealedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ABCD a = new ABCD();
            //a.metot();
            
            B b = new B();
            //b.metot();

            D d = new D();
            //d.metot();

            ABCD[] dizi = new ABCD[5];
            dizi[0] = new ABCD();
            dizi[1] = new B();
            dizi[2] = new C();
            dizi[3] = new D();
            dizi[4] = new ABCD();

            for(int i=0;i<5;i++){
                dizi[i].metot();
            }
            
        }
    }
}
