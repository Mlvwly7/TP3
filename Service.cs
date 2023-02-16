using System;
using System.Collections.Generic;
using System.Text;

namespace TP3
{
    class Service
    {
        private string nomservice;
        private Commercial[] commerciaux;
        private int effectif;

        public string Nomservice { get => nomservice; set => nomservice = value; }
        public int Effectif { get => effectif; set => effectif = value; }
        internal Commercial[] Comerciaux { get => commerciaux; set => commerciaux = value; }

        public Service(string nomservice)
        {
            this.nomservice = nomservice;
            this.commerciaux = new Commercial[10];
            this.effectif = 0;
        }

        internal void AjouterCom(Commercial c)
        {
            commerciaux[effectif] = c;
            effectif++;
        }

        public void afficherCommerciaux()
        {
            Console.WriteLine("\nListe des commerciaux pour le service " + this.nomservice);
            foreach (Commercial _com in this.commerciaux) if (_com != null) Console.WriteLine("\n" + _com);
        }

        public void plusAge()
        {
            int _max = 0;
            Commercial _lePlusAge = new Commercial();
            foreach (Commercial _com in this.commerciaux) 
            { 
                if (_com != null && _com.calculAge() > _max) 
                {
                    _max = _com.calculAge(); _lePlusAge = _com; 
                } 
            }
            Console.WriteLine("Le commercial le plus agé est " + _lePlusAge.Nom + " " + _lePlusAge.Prenom + " qui est agé de " + _lePlusAge.calculAge() + " ans");
        }

    }
}
