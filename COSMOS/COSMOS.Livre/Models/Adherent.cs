using System;
namespace COSMOS.Livre
{
	public class Adherent : Entity
	{
		public Adresse Adresse { get; set; }

		public string Name { get; set; }

		public int NbLivre { get; set; }

		// Création d'un constructeur : méthode qui permet de créer une nouvelle instance
		public Adherent() { }

        public Adherent(int id, string name, Adresse adresse)
		{
			Id = id;
			Name = name;
			Adresse = adresse;
		}
    }
}
