using System;

namespace ArraySort
{
    class Personel:IComparable
    {
       public int sicilNo;
       public string adi,soyadi;

       public Personel(int sn, string a, string s){
           sicilNo = sn;
           adi = a;
           soyadi = s;

       }
       public void yaz(){
           Console.WriteLine("{0}: {1} {2}",sicilNo,adi,soyadi);
       }
       public int CompareTo(object o){
           // Compare edebilmesi için neyin kıyas kabul edileceği belirtildi...
           Personel p = (Personel) o;
           return sicilNo.CompareTo(p.sicilNo);
       }
    }
}
