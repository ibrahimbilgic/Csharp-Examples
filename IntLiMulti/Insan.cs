using System;

namespace IntLiMulti
{
    class Insan:ISesVerebilenler,IDansEdebilenler
    {
        public void sesVer(){
            Console.WriteLine("DoReMiFaSolLaSiDo");
        }
        public void dansEt(){
            Console.WriteLine("O zaman danss");
        }
    }
}
