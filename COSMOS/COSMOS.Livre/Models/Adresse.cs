using System;
namespace COSMOS.Livre
{
	public class Adresse
	{
		public int Code { get; set; }

        public string Ville { get; set; }

        public string Rue { get; set; }

        public Adresse(int code, string ville, string rue)
        {
            Code = code;
            Ville = ville;
            Rue = rue;
        }

    }
}

