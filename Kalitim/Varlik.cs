using System;

namespace Kalitim
{
    class Varlik
    {
        public int yas,agirlik;

        protected int protDegisken;
        protected void protetMetot(){

        }
        private int privDegisken;
        private void privMetot(){

        }
        public Varlik(){
            Console.WriteLine("Varlik nesnesi olustu..");
        }
        public virtual void yuru(){
            Console.WriteLine("Varlik gibi yuruyorum..");
            // privDegisken = 1;
            // privMetot();
            //protDegisken = 3;
        }
        public void sesVer(){
            Console.WriteLine("Varlik ses veriyorum..");
        }
    }
}
