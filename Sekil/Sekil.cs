using System;

namespace Sekil
{
    class Sekil
    {
        public virtual void Ciz(){
            Console.WriteLine("Sekil cizildi");

        }
    }
    class Daire:Sekil{
        public new void Ciz(){
            Console.WriteLine("Daire Cizildi");
        
        }
    }
    class Ucgen:Sekil{

    }
    class Kare:Sekil{
        public override void Ciz()
        {
            Console.WriteLine("Kare Cizildi");
        }
    }
}
