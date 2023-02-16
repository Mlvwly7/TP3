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
        private Catégorie catcom;
        private Service service;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public int AnneeNaissance { get => anneeNaissance; set => anneeNaissance = value; }
        internal Catégorie Catcom { get => catcom; set => catcom = value; }
        internal Service Service { get => service; set => service = value; }

        public Commercial(string nom, string prenom, int anneeNaissance, Catégorie catcom, Service service)
        {   this.Nom = nom;
            this.Prenom = prenom;
            this.AnneeNaissance = anneeNaissance;
            this.Catcom = catcom;
            this.Service = service;
            this.Service.AjouterCom(this);
        }
        public Commercial()
        {
                
        }
        public int calculAge()
        {
            int diff = DateTime.Now.Year - anneeNaissance;
            return diff;
        }

        public override string ToString()
        {
            return "\nnom : " + this.nom + "\nprenom : " + this.prenom + "\nAnnée de naissance : " + this.anneeNaissance + catcom.ToString();

        }

        public string Compare(Commercial c)
        {
            string message;
            if (this.Nom == c.Nom)
            {
                message = "\nLes deux commerciaux ont le même nom de famille";
            }
            else
            {
                message = "\nLes deux commerciaux n'ont pas le même nom de famille";
            }
            return message;


        }




    }
}
