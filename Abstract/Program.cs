using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Button button = new Button();
            //button.turnOff(); hata alındı gövdesiz metot
            KatButonu kb = new KatButonu();
            Button b = kb;

            kb.turnOn();
            kb.turnOff();

            Button b2 = new KatButonu();
            Console.WriteLine("b2 nesnesi üzerine");
            b2.turnOn();
            b2.turnOff();

            KalitimaKapaliSinif ks = new KalitimaKapaliSinif();
            ks.deneme();

        }
    }
}
