using System;

namespace IntsizAbs
{
    class DansToplulugu
    {
        DansEdebilenler[] danscilar = new DansEdebilenler[10];
        int eklenen = 0;

        public void dansciEkle(DansEdebilenler dansci)
        {
            danscilar[eklenen++] = dansci;
        }

        public void dansBaslasin()
        {
            for (int i = 0; i < eklenen; i++)
                danscilar[i].dansEt();
        }

    }
}
