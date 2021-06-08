using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzepsiBiblio
{
    public class De
    {
        int valeur;
        bool garde;

        public De()
        {

        }


        public De(int valeurInt)
        {
            valeur = valeurInt;
        }

        public int Valeur
        {
            get { return valeur; }

            set { valeur = value; }
        }

        public bool Garde
        {
            get { return garde; }

            set { garde = value; }
        }

        public void switchGarde()
        {
            this.garde = !this.garde;
        }


    }
}
