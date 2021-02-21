using System;

namespace Constructor
{
    class Zaman
    {
        public int gun,ay,yil;

        public void zamaniYaz(){
            Console.WriteLine("{0}:{1}:{2}",gun,ay,yil);

        }

        public Zaman(int g,int a,int y){
            gun=g;
            ay=y;
            yil=y;
            Console.WriteLine("parametreli constr. calisti");
        }
        public Zaman(DateTime tarih){
            gun = tarih.Day;
            ay = tarih.Month;
            yil = tarih.Year;
        }
        static Zaman(){
            //statik constructor önünde erişim seviyesi belirtilmez
            //statik constructor parametre almaz
            Console.WriteLine("statik const. calisti");
            //statik const. bir defaya mahsus olarak çalıştı
            //bütün const.lardan önce çalıştı
            //nesne türetilmeden çalışmaz
        }
    }
}
