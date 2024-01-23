using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src
{
    public class Personne
    {
        private string nom;
        private string prenom;

        public Personne(string unNom, string unPrenom)
        {
           this.nom = unNom;
           this.prenom = unPrenom;  
        }

        public string Infos()
        {
            return nom + " " + prenom + " ";
        }

    }
}