using System;

namespace Sekil
{
    class Program
    {
        static void Main(string[] args)
        {
            Sekil[] sekiller = new Sekil[5];
            sekiller[0] = new Sekil();
            sekiller[1] = new Daire();
            sekiller[2] = new Ucgen();
            sekiller[3] = new Kare();
            sekiller[4] = new Daire();

            for(int i = 0;i<5;i++){
                sekiller[i].Ciz();
            }
        }
    }
}
