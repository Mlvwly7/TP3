using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Commercial
    {
        private string nom;
        private string prenom;
        private int anneeNaissance;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }

        public Commercial(string nom, string prenom, int anneeNaissance)
        {   this.nom = nom;
            this.prenom = prenom;
            this.anneeNaissance = anneeNaissance; 
        }        
        public int calculAge()
        {
            int diff = DateTime.Now.Year - anneeNaissance;
            return diff;
        }

        public override string ToString()
        {
            return "nom : " + this.nom + "\nprenom : " + this.prenom + "\nAnnée de naissance : " + this.anneeNaissance;

        }

        public void Compare(Commercial c)
        {
            string message;
            if (this.Nom == c.Nom)
            {
                message = "Les deux commerciaux ont le même nom de famille";
            }
            else
            {
                message = "Les deux commerciaux n'ont pas le même nom de famille";
            }


        }




    }
}
