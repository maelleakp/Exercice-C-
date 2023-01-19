// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

var Adherents = new COSMOS.Livre.DataBase().ImportAdherent();
/*for (int i = 0; i < Adherents.Count; i++)
{
    Console.WriteLine(Adherents[i].Name + "-" + Adherents[i].Id + "-" + Adherents[i].Adresse.Rue + "-" + Adherents[i].Adresse.Ville);
}*/

#region Adhérent
// Création du tableau de 10 adhérents
//string[] Adherents = new string[10];


// Ajouter un utilisateur : méthode add(name)
void Add(string name)
{
    for (int i = 0; i < Adherents.Count; i++)
    {
        if (Adherents[i] == null)
        {
            Adherents[i].Name = name;
            break;
        }
    }
}

// Voir si l'utilisateur existe : méthode getbyname(name)-- > bool
bool GetUserByName(string name)
{
    for (int i = 0; i < Adherents.Count; i++)
    {
        if (name != null && Adherents[i].Name == name)
        {
            return true;
        }  
    }
    return false;
}

// Récupérer les éléments du tableau : méthode getall(name)
void GetAllUser ()
{
    for (int i = 0; i < Adherents.Count; i++)
    {
        Console.WriteLine((i+1) + "-" + Adherents[i].Name);
    }
}

// Metre à jour un nom du tableau : update(name)
bool UpdateUser (string name, string newName)
{
    var nameExist = GetUserByName(name);
    if (nameExist)
    {
        for (int i = 0; i < Adherents.Count; i++)
        {
            if (Adherents[i].Name == name)
            {
                Adherents[i].Name = newName;
                return true;
            }
        }
    }
    return false;
}

// Supprimer un élément du tableau : méthode delete(name)
bool DeleteUser (string deleteName)
{
    var nameExist = GetUserByName(deleteName);
    if (nameExist)
    {
        for (int i = 0; i < Adherents.Count; i++)
        {
            if (Adherents[i].Name == deleteName)
            {
                Adherents[i].Name = null;
                return true;
            }
        }
    }
    return false;
}
#endregion

#region Livre
// Création du tableau de 10 livres
string[] Livre = new string[10];


// Ajouter un livre
void AddBook(string name)
{
    for (int i = 0; i < Livre.Length; i++)
    {
        if (Livre[i] == null)
        {
            Livre[i] = name;
            break;
        }
    }
}

// Voir si le livre existe
bool GetUserByBook(string name)
{
    for (int i = 0; i < Livre.Length; i++)
    {
        if (name != null && Livre[i] == name)
        {
            return true;
        }
    }
    return false;
}

// Récupérer les éléments du tableau
void GetAllBook()
{
    for (int i = 0; i < Livre.Length; i++)
    {
        Console.WriteLine((i+1) + "-" + Livre[i]);
    }
}

// Metre à jour un nom de livre du tableau
bool UpdateBook(string book, string newBook)
{
    var bookExist = GetUserByBook(book);
    if (bookExist)
    {
        for (int i = 0; i < Livre.Length; i++)
        {
            if (Livre[i] == book)
            {
                Livre[i] = newBook;
                return true;
            }
        }
    }
    return false;
}

// Supprimer un élément du tableau : méthode delete(name)
bool DeleteBook(string deleteBook)
{
    var bookExist = GetUserByBook(deleteBook);
    if (bookExist)
    {
        for (int i = 0; i < Livre.Length; i++)
        {
            if (Livre[i] == deleteBook)
            {
                Livre[i] = null;
            }
            break;
        }
        return true;
    }
    return false;
}
#endregion

#region Menu
string[] TabAccueil = new string[] { "1.Gestion des adhérents", "2.Gestion des livres", "3.Gestion des emprunts", "4.Quitter le programme" };

string[] TabMenu1 = new string[] { "a.Ajouter, modifier ou supprimer un adhérent", "b.Afficher la liste des adhérents par ordre alphabétique", "c.Rechercher un adhérent par son nom et affiche l'enregistrement correspond", "d.Retour menu principal" };
string[] TabMenu2 = new string[] { "a.Ajouter, modifier ou supprimer un livre", "b.Afficher la liste des livres par ordre alphabétique", "c.Rechercher le titre d'un livre et affiche l'enregistrement correspond", "d.Retour menu principal" };
string[] TabMenu3 = new string[] { "a.Emprunter un livre", "b.Afficher la liste des livres empruntés", "c.Rendre un livre", "d.Afficher la liste des emprunts", "e.Retour menu principal" };
string[] TabMenu4 = new string[] { "1 : Ajouter", "2 : Modifier", "3 : Supprimer" };


AfficheTab(TabAccueil);

string choix = Console.ReadLine();

void AfficheTab(string[] tab)
{
    for (int i = 0; i < tab.Length; i++)
    {
        Console.WriteLine(tab[i]);
    }

}

void AfficheTabWithCondition(string[] tab, string condition, string choix)
{
    for (int i = 0; i < tab.Length; i++)
    {
        if (choix == condition)
        {
            Console.WriteLine(tab[i]);
        }
    }
}

string DemandeChoix(string message)
{
    Console.WriteLine(message);
    string choix = Console.ReadLine();
    return choix;
}

void ExecuteMenu(string[] tab1)
{
    AfficheTab(tab1);
    var choix2 = DemandeChoix("Faites votre choix dans ce menu :");
    if (tab1 == TabMenu1)
    {
        switch (choix2)
        {
            case "a":
                commandeUser(choix2);
                break;
            case "b":
                commandeUser(choix2);
                break;
            case "c":
                commandeUser(choix2);
                break;
            case "d":
                AfficheTab(TabAccueil);
                break;
        }
    }

    else if (tab1 == TabMenu2)
    {
        switch (choix2)
        {
            case "a":
                commandeBook(choix2);
                break;
            case "b":
                commandeBook(choix2);
                break;
            case "c":
                commandeBook(choix2);
                break;
            case "d":
                AfficheTab(TabAccueil);
                break;
        }
    }

    else
    {
        switch (choix2)
        {
            case "a":
                //commandeEmprunt(choix2);
                break;
            case "b":
                //commandeEmprunt(choix2);
                break;
            case "c":
                //commandeEmprunt(choix2);
                break;
            case "d":
                AfficheTab(TabAccueil);
                break;
        }
    }
}

while (choix != "1" || choix != "2" || choix != "3" || choix != "4")
{
    switch (choix)
    {
        case "1":
            ExecuteMenu(TabMenu1);
            break;
        case "2":
            ExecuteMenu(TabMenu2);
            break;
        case "3":
            ExecuteMenu(TabMenu3);
            break;
        case "4":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Rentrez une valeur valide !");
            break;
    }
    choix = Console.ReadLine();
}
#endregion

#region Commun
void commandeUser(string choix)
{
    if (choix == "a")
    {
        AfficheTab(TabMenu4);
        var choix2 = DemandeChoix("Faites votre choix dans ce menu : ");
        switch (choix2)
        {
            case "1":
                var addName = DemandeChoix("Entrer le nom à ajouter : ");
                Add(addName);
                Console.WriteLine("Ajout effectué !");
                AfficheTab(TabMenu1);
                break;

            case "2":
                var updateName = DemandeChoix("Entrer le nom à modifier : ");
                var newName = DemandeChoix("Entrer le nouveau nom : ");
                UpdateUser(updateName, newName);
                Console.WriteLine("Modification effectuée !");
                AfficheTab(TabMenu1);
                break;

            case "3":
                var deleteName = DemandeChoix("Entrer le nom à supprimer : ");
                DeleteUser(deleteName);
                Console.WriteLine("Suppression effectuée !");
                AfficheTab(TabMenu1);
                break;
        }
    }

    else if (choix == "b")
    {
        GetAllUser();
        AfficheTab(TabMenu1);
    }

    else
    {
        var myName = DemandeChoix("Entrer le nom à rechercher :");
        bool trouver = GetUserByName(myName);
        if (trouver == true)
        {
            Console.WriteLine("Vous êtes dans la liste des adhérents");
            AfficheTab(TabMenu1);
        }
        else
        {
            Console.WriteLine("Vous n'êtes pas dans la liste des adhérents");
            AfficheTab(TabMenu1);
        }
    }
}

void commandeBook(string choix)
{
    if (choix == "a")
    {
        AfficheTab(TabMenu4);
        var choix2 = DemandeChoix("Faites votre choix dans ce menu : ");
        switch (choix2)
        {
            case "1":
                var addBook = DemandeChoix("Entrer le nom du livre à ajouter : ");
                AddBook(addBook);
                Console.WriteLine("Ajout effectué !");
                AfficheTab(TabMenu2);
                break;

            case "2":
                var updateBook = DemandeChoix("Entrer le nom du livre à modifier : ");
                var newBook = DemandeChoix("Entrer le nouveau nom du livre : ");
                UpdateBook(updateBook, newBook);
                Console.WriteLine("Modification effectuée !");
                AfficheTab(TabMenu2);
                break;

            case "3":
                var deleteBook = DemandeChoix("Entrer le nom du livre à supprimer : ");
                DeleteBook(deleteBook);
                Console.WriteLine("Suppression effectuée !");
                AfficheTab(TabMenu2);
                break;
        }
    }

    else if (choix == "b")
    {
        GetAllBook();
        AfficheTab(TabMenu2);
    }

    else
    {
        var myBook = DemandeChoix("Entrer le nom du livre à rechercher :");
        bool trouver = GetUserByBook(myBook);
        if (trouver == true)
        {
            Console.WriteLine("Le livre est dans la liste.");
            AfficheTab(TabMenu2);
        }
        else
        {
            Console.WriteLine("Le livre n'est pas dans la liste.");
            AfficheTab(TabMenu2);
        }
    }
}
#endregion