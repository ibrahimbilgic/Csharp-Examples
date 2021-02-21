using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var compositeGraphic = new CompositeGraphic();
            var compositeGraphic1 = new CompositeGraphic();
            var compositeGraphic2 = new CompositeGraphic();

            //Composite Graphic 1 Grafiğe ekle
            compositeGraphic.Ekle(yeni Elips());
            //composite Graphic 2 Grafiğe ekle
            compositeGraphic2.AddRange(yeni Elips(),yeni Elips());

            //1 Graifk compositeGraphic1 ve ekle compositeGraphic
            compositeGraphic.AddRange(yeni Elips(),compositeGraphic1,compositeGraphic2);

            //Prints the complete graphic
            compositeGraphic.Print();
            Console.ReadLine();
        }
    }
}
