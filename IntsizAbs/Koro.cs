using System;

namespace IntsizAbs
{
    class Koro
    {
        SesVerebilenler[] sanatcilar = new SesVerebilenler[5];
        int eklenen = 0;
        public void sanatciEkle(SesVerebilenler sanatci)
        {
            sanatcilar[eklenen++] = sanatci;
        }

        public void koroSoylesin()
        {
            for (int i = 0; i < eklenen; i++)
                sanatcilar[i].SesVer();
        }

    }
}