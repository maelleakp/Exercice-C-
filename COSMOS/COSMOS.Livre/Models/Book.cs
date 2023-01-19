using System;
namespace COSMOS.Livre
{
	public class Livre : Entity
	{
        public Auteur Auteur { get; set; }

        public string Title { get; set; }

        public int NbAdh { get; set; }

        // Création d'un constructeur : méthode qui permet de créer une nouvelle instance
        public Livre() { }

        public Livre(Auteur auteur, string title)
        {
            Auteur = auteur;
            Title = title;
        }
    }
}

