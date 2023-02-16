using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Catégorie
    {
        private string codeCategorie;
        private string libCategorie;

        public string CodeCategorie { get => codeCategorie; set => codeCategorie = value; }
        public string LibCategorie { get => libCategorie; set => libCategorie = value; }

        public Catégorie(string codeCategorie, string libCategorie)
        {
            this.codeCategorie = codeCategorie;
            this.libCategorie = libCategorie;
        }
        public override string ToString()
        {
            return "\ncode : " + this.codeCategorie + "\nlibellé : " + this.libCategorie;

        }





    }
}
