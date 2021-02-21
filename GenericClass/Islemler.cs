using System;

namespace GenericClass
{
    class Islemler
    {
        X[] dizi = new X[10];
        int ESay = 0 ;

        public void Ekle(X a){
            dizi[ESay] = a;
            ESay++;
        }
        public X ElemanDonder(int indis){
            return dizi[indis];
        }
    }
}
