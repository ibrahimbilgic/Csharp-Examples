using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = (int) 5.4; //explicit
            double b = a; //implicit

            Kesir k1 = new Kesir(14,2);
            b= (int)k1;

            Console.WriteLine(b);

            Kesir k2 = 7;
            k2.yaz();

            // operator overloading

            if(k1 == k2){
                Console.WriteLine("Sayılar Eşit");
            }
            else{
                Console.WriteLine("Sayılar Eşit Değil");
            }

            Kesir k3 = k1 + k2;
            k3.yaz();
        }
    }
}
