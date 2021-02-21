using System;

namespace IntLiMulti
{
    class DansToplulugu
    {
        IDansEdebilenler [] topluluk = new IDansEdebilenler[10];
        int eklenen = 0; 

        public void dansciEkle(IDansEdebilenler dansci){
            topluluk[eklenen++] = dansci;
    
        }
        public void dansBaslasin(){
            for(int i = 0; i<eklenen;i++){
                topluluk[i].dansEt();
            }
        }
    }
}
