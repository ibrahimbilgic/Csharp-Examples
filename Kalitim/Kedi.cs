using System;

namespace Kalitim
{
    class Kedi:Varlik
    {
        public string turu;
        public Kedi(){
            Console.WriteLine("Kedisi nesnesi olustu..");
        }
        public void fareYakala(){
             //yas = 4;
            //agirlik = 3;
            //privDegisken = 1;
            protDegisken=0;
        }
        public new void sesVer(){
            Console.WriteLine("Miyavv");
        }
        public override void yuru()
        {
            Console.WriteLine("Kedi gibi yuruyorum..");
        }
    }
}
