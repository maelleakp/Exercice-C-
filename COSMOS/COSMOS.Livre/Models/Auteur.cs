using System;
namespace COSMOS.Livre
{
	public class Auteur
	{
		public string Nom { get; set; }

        public string Prénom { get; set; }

		public Auteur() { }

        public Auteur(string nom, string prénom)
        {
            Nom = nom;
            Prénom = prénom;
        }
    }
}

