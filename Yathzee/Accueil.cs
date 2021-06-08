using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YathzepsiBiblio;

namespace Yathzepsi
{
    public partial class Accueil : Form
    {
        int nbJoueurs = 0;
        List<Joueur> joueurs = new List<Joueur>();

        public Accueil()
        {
            InitializeComponent();
            playerName2.Visible = false;
            playerName3.Visible = false;
            playerName4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nbJoueurs != 0)
            {
                switch (nbJoueurs)
                {
                    case 4:
                        Global.joueur4 = new Joueur(playerName4.Text,4);
                        goto case 3;

                    case 3:
                        Global.joueur3 = new Joueur(playerName3.Text,3);
                        goto case 2;

                    case 2:
                        Global.joueur2 = new Joueur(playerName2.Text,2);
                        goto case 1;

                    case 1:
                        Global.joueur1 = new Joueur(playerName1.Text,1);
                        break;
                }
                Global.nbJoueurs = nbJoueurs;
                Jeu jeu = new Jeu();
                this.Hide();
                jeu.ShowDialog();
                this.Show();
            }
            else
            {
                presentation.Text = "Veuillez entrer au moins un nom";
            }
        }

        private void playerName1_TextChanged(object sender, EventArgs e)
        {
            if (playerName1.Text.Equals(""))
            {
                playerName2.Text = "";
                playerName3.Text = "";
                playerName4.Text = "";
                playerName2.Visible = false;
                playerName3.Visible = false;
                playerName4.Visible = false;
                nbJoueurs = 0;
            }
            else
            {
                playerName2.Visible = true;
                nbJoueurs = 1;
            }


        }

        private void playerName2_TextChanged(object sender, EventArgs e)
        {
            if (playerName2.Text.Equals(""))
            {
                playerName3.Text = "";
                playerName4.Text = "";
                playerName3.Visible = false;
                playerName4.Visible = false;
                nbJoueurs = 1;
            }
            else
            {
                playerName3.Visible = true;
                nbJoueurs = 2;
            }

        }

        private void playerName3_TextChanged(object sender, EventArgs e)
        {
            if (playerName3.Text.Equals(""))
            {
                playerName4.Text = "";
                playerName4.Visible = false;
                nbJoueurs = 2;
            }
            else
            {
                playerName4.Visible = true;
                nbJoueurs = 3;
            }

        }

        private void playerName4_TextChanged(object sender, EventArgs e)
        {
            if (playerName3.Text.Equals(""))
            {
                nbJoueurs = 3;
                    }
            else
            {
                nbJoueurs = 4;
            
            }
        }
    }
}
