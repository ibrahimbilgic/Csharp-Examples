using System;

namespace SealedMethod
{
    class ABCD
    {
       public virtual void metot(){
           Console.WriteLine("A'nın metotu");
       }
    }
    class B:ABCD{
        public override void metot()
        {
            Console.WriteLine("B'nin metotu");
        }
    }
    class C:B
    {
        public sealed override void metot()
        {
            Console.WriteLine("C'nin metotu");
        }
    }
    class D:C
    {
        /*
        public override void metot(){
            Console.WriteLine("D'nin metotu");
        }*/
        public new void metot(){
            Console.WriteLine("D'nin metotu");
        }
    }
}
