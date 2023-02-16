using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Catégorie cat1 = new Catégorie("6969", "indépendant");
            Console.WriteLine(cat1);
            Catégorie cat2 = new Catégorie("7070", "salarié");
            Console.WriteLine(cat2);

            Service ser1 = new Service("National");
            Service ser2 = new Service("International");

            Commercial com1 = new Commercial("Pichon", "Cedric", 2002, cat1, ser1);
            Console.WriteLine(com1);
            Commercial com2 = new Commercial("Pichon", "Enzo", 2000, cat2, ser2);
            Console.WriteLine(com2);
            Commercial com3 = new Commercial("Kaka", "Raul", 1960, cat1, ser1);

            ser1.AjouterCom(com1);
            ser1.AjouterCom(com2);
            ser1.AjouterCom(com3);
            ser2.AjouterCom(com1);
            ser2.AjouterCom(com2);
            ser2.AjouterCom(com3);

            Console.WriteLine("\nvoici les infos du commercial :" + com1);
            Console.WriteLine(com1.Compare(com2));

            ser1.afficherCommerciaux();















        }
    }
}
