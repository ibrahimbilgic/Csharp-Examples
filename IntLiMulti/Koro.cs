using System;

namespace IntLiMulti
{
    class Koro
    {
        ISesVerebilenler[] sanatcilar =new ISesVerebilenler[10];
        int eklenen = 0;

        public void sanatciEkle(ISesVerebilenler sanatci){
            sanatcilar[eklenen++] = sanatci;
        }
        public void koroSoylesin(){
            for(int i = 0;i<eklenen;i++){
                sanatcilar[i].sesVer();
            }
        }
    }
}
