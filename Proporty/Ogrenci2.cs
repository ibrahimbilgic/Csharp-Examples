using System;

namespace Proporty
{
    class Ogrenci2
    {
        private int dYili,yas;

        public int PYas{
            get{
                return yas;
            }//değeri çağrıldığı zaman devreye girer.yasDonder metodu gibi çalışır.
            set{
                if(value>18 && value<100){
                    yas = value;
                    dYili = DateTime.Now.Year -yas;
                }

            }//dışardan bir değer atandığı zaman devreye girer. yasAta metodu gibi çalışır..
           //value isminde özel bir değişkeni vardır. Set edilen değeri tutar o1.yas=10, value=10
            
        }
        public int PDYili{
            get{
                return dYili;
            }
            set{
                if(value<=DateTime.Now.Year){
                    dYili = value;
                    yas = DateTime.Now.Year-dYili;
                }
            }
        }
        int[] notlar = new int[5] {35,45,23,100,76};

        public double Pgano{
            get{
                double ort = 0; 
                for(int i=0;i<notlar.Length;i++){
                    ort+=notlar[i];

                }
                ort = ort/notlar.Length;
                return ort;
            }
        }
    }
}
