using System;
using System.Collections.Generic;
using System.Text;

namespace GesttionnaireDeProduits
{
    public class Produit
    {
        public string Nom
        {
            get;
            set;
        }

        public decimal Prix
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Nom + " " + Prix.ToString() + "€";
        }



    }
}
