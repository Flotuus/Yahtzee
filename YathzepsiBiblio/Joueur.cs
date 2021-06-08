using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzepsiBiblio
{
    public class Joueur
    {
        String nom;
        int position;
        bool isPlaying = false;

        public Joueur(String nomString,int positionInt)
        {
            nom = nomString;
            position = positionInt;
        }

        public String Nom {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public int Position
        {
            get
            {
                return position;
            }

        }
        public int IsPlaying
        {
            get
            {
                return IsPlaying;
            }

        }

        public void switchIsPlaying()
        {
            this.isPlaying = !this.isPlaying;
        }


    }
}
