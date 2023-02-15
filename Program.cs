using System;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            Commercial com1 = new Commercial("Pichon", "Cedric", 2002);
            Console.WriteLine(com1);
            Commercial com2 = new Commercial("Rakoto", "Enzo", 2000);
            Console.WriteLine(com2);
            Commercial com3 = new Commercial("Kaka", "Raul", 1960);

            Catégorie cat1 = new Catégorie("6969", "indépendant");
            Console.WriteLine(cat1);
            Catégorie cat2 = new Catégorie("7070", "salarié");
            Console.WriteLine(cat2);









        }
    }
}
