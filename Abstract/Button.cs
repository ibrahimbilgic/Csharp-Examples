using System;

namespace Abstract
{
    abstract class Button
    {
       abstract public void turnOn();
       abstract public void turnOff();

       //abstract public int prop {get; set;}

       public void deneme(){
           Console.WriteLine("Deneme");
       }
       //abstract ogeler cocuk sinif tarafından mutlaka tamamlanırlar
        //abstract ogesi olan bir sinifin taniminin basina da abstract yazilmalidir
        //abstract siniflardan yapici metot ile nesne türetilemez
        //bu siniflar miras birakmak üzere tanımlanırlar.

    }
}
