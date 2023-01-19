using System;

namespace COSMOS.Livre
{
	public class DataBase
	{
		// Définir une liste
		public List<Adherent> AdherentTable { get; set; }

        public List<Livre> LivreTable { get; set; }

        public List<Adresse> AdresseTable { get; set; }

        public List<Auteur> AuteurTable { get; set; }

        // Créer ma liste et remplir mon tableau
        public List<Adherent> ImportAdherent()
        {
            // Initialiser sa liste
            AdherentTable = new List<Adherent>();

            // Créer une instance de la table adhérent
            var adresse = new Adresse(33140, "Bordeaux","5 rue de Laporte");
            var adh_1 = new Adherent(1, "leopold", adresse);
            var adresse2 = new Adresse(33140, "Pessac", "76 rue du Maréchal");
            var adh_2 = new Adherent(2, "loyd", adresse2);
            var adresse3 = new Adresse(33800, "Limoges", "rue des fleurs");
            var adh_3 = new Adherent(3, "maelle", adresse3);

            AdherentTable.Add(adh_1);
            AdherentTable.Add(adh_2);
            AdherentTable.Add(adh_3);


            /* Boucle pour créer une instance de la table adhérent
            for (int i = 0; i < AdherentTable.Capacity; i++)
            {
                int[] id = new int[] { 1, 2, 3 };
                string[] name = new string[] { "Loyd", "Leopold", "Corran" };
                var adh = new Adherent(id[i], name[i]);
                AdherentTable.Add(adh);
            }*/

            return AdherentTable;
        }

        List<Livre> ImportLivre()
        {
            // Initialiser sa liste
            LivreTable = new List<Livre>();

            // Créer une instance de la table adhérent
            var auteur = new Auteur();
            var liv_1 = new Livre(1, "Les misérables", auteur);
            var auteur2 = new Auteur();
            var liv_2 = new Livre(2, "Candide", auteur2);

            LivreTable.Add(liv_1);
            LivreTable.Add(liv_2);

            /* Boucle pour créer une instance de la table adhérent
            for (int i = 0; i < LivreTable.Capacity; i++)
            {
                int[] id = new int[] { 1, 2 };
                string[] name = new string[] { "Les misérables", "Candide" };
                var liv = new Livre(id[i], name[i]);
                LivreTable.Add(liv);
            }*/

            return LivreTable;
        }
    }
}

