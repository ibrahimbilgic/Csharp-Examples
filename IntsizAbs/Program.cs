using System;

namespace IntsizAbs
{
    class Program
    {
        static void Main(string[] args)
        {
            Koro  koromuz = new Koro();
            Kedi kd1 = new Kedi();

            koromuz.sanatciEkle(kd1);
            koromuz.sanatciEkle(new Kedi());
            koromuz.sanatciEkle(new Kopek());
            koromuz.sanatciEkle(new Kopek());
            koromuz.sanatciEkle(new Insan());

            koromuz.koroSoylesin();

            DansToplulugu dt = new DansToplulugu();
            dt.dansciEkle(new Robot());

            dt.dansBaslasin();

        }
    }
}
