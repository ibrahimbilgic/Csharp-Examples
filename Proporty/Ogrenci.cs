using System;

namespace Proporty
{
    class Ogrenci
    {
        private int dYili,yas;
        public bool yasAta(int y){
            bool sonuc = false;

            if(y>=18 && y<100){
                yas = y;
                dYili = DateTime.Now.Year - yas;
                sonuc = true;
            }
            return sonuc;
        }

        public int yasDonder(){
            return yas;
        }
        public void dYiliAta(int dy){
            if(dy<=DateTime.Now.Year){
                dYili = dy;
                yas = DateTime.Now.Year - dy;

            }
        }
        public int dYiliDonder(){
            return dYili;
        }
    }
}
