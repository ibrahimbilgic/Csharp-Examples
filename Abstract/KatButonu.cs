using System;

namespace Abstract
{
    class KatButonu:Button
    {
        public override void turnOn()
        {
            Console.WriteLine("Kat Butonu Yandi");
        }
        public override void turnOff()
        {
            Console.WriteLine("Kat butonu söndü");
        }
    }
}
