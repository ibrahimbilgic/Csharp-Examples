using System;

namespace IntLiMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            //ISesVerebilenler nesne=new ISesVerebilenler();
            Koro koromuz=new Koro();
            koromuz.sanatciEkle(new Kedi());
            koromuz.sanatciEkle(new Kopek());
            koromuz.sanatciEkle(new Insan());
            koromuz.koroSoylesin();

            DansToplulugu dt = new DansToplulugu();
            dt.dansciEkle(new Insan());
            //IDansEdebilenler d = new Insan();

            dt.dansBaslasin();

        }
    }
}
