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
using System.Threading;


namespace Yathzepsi
{
    public partial class Jeu : Form
    {
        Random random = new Random();
        string[] s = { "\\bin" };
        int nbLancer = 1;
        De de1 = new De();
        De de2 = new De();
        De de3 = new De();
        De de4 = new De();
        De de5 = new De();
        int subtotal = 0;
        int bonus = 0;
        int total1 = 0;
        int total2 = 0;
        int total3 = 0;
        int joueurPlaying = 1;
        int nbJoueurs = 0;
        int nbTours = 1;
        bool rolling = false;

        List<Joueur> joueurs = new List<Joueur>(); 


        public Jeu()
        {
            InitializeComponent();
            joueurs.Add(Global.joueur1);
            joueurs.Add(Global.joueur2);
            joueurs.Add(Global.joueur3);
            joueurs.Add(Global.joueur4);
            nbJoueurs = Global.nbJoueurs;
            joueurEnCours.Text = "C'est au tour de " + getNameByPosition(joueurPlaying);
            restart.Visible = false;
            initTableauScore();
        }

        private void initTableauScore()
        {
            String[] rowTitle = new String[] {"Total de 1", "Total de 2", "Total de 3", "Total de 4", "Total de 5", "Total de 6", "Total", "Si Total >= 63 alors Bonus de 35 points", "Total partie intermédiaire","","Brelan (Total des 3 dés)", "Carré (Total de 4 dés)", "Full (25 points)", "Petite Suite (30 points)", "Grande Suite (40 points)", "Yathzee (50 points)", "Chance (Total des 5 dés)", "Total 2", "Total" };

            for(int i = 0; i<18;i++)
            {
                tableauScore.Rows.Add();
                tableauScore.Rows[i].HeaderCell.Value = rowTitle[i];
            }
            for (int i = 0; i < nbJoueurs; i++)
            {
                tableauScore.Columns.Add(joueurs[i].Nom, joueurs[i].Nom);
            }

            tableauScore.Columns.RemoveAt(0);
            tableauScore.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tableauScore.RowHeadersWidth = 250;
            tableauScore.ReadOnly = true;
        }

        private Image PathPictureDice(int valeur, bool garde)
        {
            if(valeur != 0) { 
            return garde ? Image.FromFile(Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Images\\De"+valeur+"Lock.png"): Image.FromFile(Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Images\\De" + valeur + ".png");
            }
            else
            {
                return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nbLancer < 4) {
                if (!de1.Garde)
                {
                    int newValueDe1 = random.Next(1, 7);
                    ImgDe1.Image = PathPictureDice(newValueDe1, false);
                    de1.Valeur = newValueDe1;
                }
                if (!de2.Garde)
                {
                    int newValueDe2 = random.Next(1, 7);
                    ImgDe2.Image = PathPictureDice(newValueDe2, false);
                    de2.Valeur = newValueDe2;
                }
                if (!de3.Garde)
                {
                    int newValueDe3 = random.Next(1, 7);
                    ImgDe3.Image = PathPictureDice(newValueDe3, false);
                    de3.Valeur = newValueDe3;
                }
                if (!de4.Garde)
                {
                    int newValueDe4 = random.Next(1, 7);
                    ImgDe4.Image = PathPictureDice(newValueDe4, false);
                    de4.Valeur = newValueDe4;
                }
                if (!de5.Garde)
                {
                    int newValueDe5 = random.Next(1, 7);
                    ImgDe5.Image = PathPictureDice(newValueDe5, false);
                    de5.Valeur = newValueDe5;
                }
            }

            switch (nbLancer)
            {
                case 1:
                    btLancer.Text = "Lancer 2";
                    nbLancer += 1;
                    break;

                case 2:
                    btLancer.Text = "Lancer 3";
                    nbLancer += 1;
                    break;

                case 3:
                    btLancer.Text = "Plus de lancers";
                    nbLancer += 1;
                    break;
            }
        }


        private void ImgDe1_Click(object sender, EventArgs e)
        {
            if(ImgDe1.Image != null) { 
                de1.switchGarde();
                ImgDe1.Image = PathPictureDice(de1.Valeur, de1.Garde);
            }
        }

        private void ImgDe2_Click(object sender, EventArgs e)
        {
            if (ImgDe2.Image != null)
            {
                de2.switchGarde();
                ImgDe2.Image = PathPictureDice(de2.Valeur, de2.Garde);
            }
        }

        private void ImgDe3_Click(object sender, EventArgs e)
        {
            if (ImgDe3.Image != null)
            {
                de3.switchGarde();
                ImgDe3.Image = PathPictureDice(de3.Valeur, de3.Garde);
            }

        }

        private void ImgDe4_Click(object sender, EventArgs e)
        {
            if (ImgDe4.Image != null)
            {
                de4.switchGarde();
                ImgDe4.Image = PathPictureDice(de4.Valeur, de4.Garde);
            }

        }

        private void ImgDe5_Click(object sender, EventArgs e)
        {
            if (ImgDe5.Image != null)
            {
                de5.switchGarde();
                ImgDe5.Image = PathPictureDice(de5.Valeur, de5.Garde);
            }
        }

        private string getNameByPosition(int position)
        {
            foreach (Joueur joueur in joueurs)
            {
                if(position == joueur.Position)
                {
                    return joueur.Nom;
                }
            }
            return null;
        }

        private void tableauScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(nbLancer != 1) { 

                int[] resultats = { de1.Valeur, de2.Valeur, de3.Valeur, de4.Valeur, de5.Valeur };
                int columnIndex = tableauScore.CurrentCell.ColumnIndex;
                int rowIndex = tableauScore.CurrentCell.RowIndex;
                subtotal = 0;
                total1 = 0;
                total2 = 0;
                total3 = 0;
                if (joueurPlaying == columnIndex + 1 && (0 <= rowIndex && rowIndex <= 5 || 10 <= rowIndex && rowIndex <= 16))
                {


                    if (tableauScore[columnIndex, rowIndex].Value == null)
                    {
                        switch (rowIndex)
                        {
                            case 0:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreTotal1(resultats);
                                break;
                            case 1:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreTotal2(resultats);
                                break;
                            case 2:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreTotal3(resultats);
                                break;
                            case 3:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreTotal4(resultats);
                                break;
                            case 4:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreTotal5(resultats);
                                break;
                            case 5:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreTotal6(resultats);
                                break;

                            case 10:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreBrelan(resultats);
                                break;

                            case 11:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreCarre(resultats);
                                break;

                            case 12:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreFull(resultats);
                                break;

                            case 13:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScorePetiteSuite(resultats);
                                break;

                            case 14:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreLargeSuite(resultats);
                                break;

                            case 15:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreYathzee(resultats, nbLancer);
                                break;

                            case 16:
                                tableauScore[columnIndex, rowIndex].Value = Score.getScoreChance(resultats);
                                break;


                        }

                        for (int i = 0; i < 6; i++)
                        {
                            subtotal += Convert.ToInt32(tableauScore[columnIndex, i].Value);
                        }

                        tableauScore[columnIndex, 6].Value = subtotal;
                        if (subtotal >= 63)
                        {
                            tableauScore[columnIndex, 7].Value = 35;
                            bonus = 35;
                        }
                        else
                        {
                            tableauScore[columnIndex, 7].Value = 0;
                        }

                        total1 = subtotal + bonus;
                        tableauScore[columnIndex, 8].Value = total1;





                        total2 = 0;
                        for (int i = 10; i < 17; i++)
                        {
                            total2 += Convert.ToInt32(tableauScore[columnIndex, i].Value);
                        }
                        tableauScore[columnIndex, 17].Value = total2;



                        total3 = total1 + total2;
                        tableauScore[columnIndex, 18].Value = total3;

                        de1.Garde = false;
                        de1.Valeur = 0;
                        ImgDe1.Image = PathPictureDice(de1.Valeur, de1.Garde);

                        de2.Garde = false;
                        de2.Valeur = 0;
                        ImgDe2.Image = PathPictureDice(de2.Valeur, de2.Garde);

                        de3.Garde = false;
                        de3.Valeur = 0;
                        ImgDe3.Image = PathPictureDice(de3.Valeur, de3.Garde);

                        de4.Garde = false;
                        de4.Valeur = 0;
                        ImgDe4.Image = PathPictureDice(de4.Valeur, de4.Garde);

                        de5.Garde = false;
                        de5.Valeur = 0;
                        ImgDe5.Image = PathPictureDice(de5.Valeur, de5.Garde);


                        btLancer.Text = "Lancer 1";
                        nbLancer = 1;

                        if (joueurPlaying != nbJoueurs)
                        {
                            joueurPlaying += 1;
                            joueurEnCours.Text = "C'est au tour de " + getNameByPosition(joueurPlaying);

                        }
                        else
                        {
                            joueurPlaying = 1;
                            if(nbTours == 13)
                            {
                                joueurEnCours.Text = "Fin";
                                int maxScore = 0;
                                int playerWinning = 0;
                                for (int i = 1; i <= nbJoueurs; i++)
                                {
                                    if (Convert.ToInt32(tableauScore[i-1, 18].Value) > maxScore)
                                    {
                                        maxScore = Convert.ToInt32(tableauScore[i-1, 18].Value);
                                        playerWinning = i;
                                    }
                                }
                                joueurEnCours.Text = "Félicitation à " + getNameByPosition(playerWinning) + " pour avoir gagné la partie avec " + maxScore + " points";

                                btLancer.Visible = false;
                                restart.Visible = true;


                            }
                            else
                            {
                                nbTours += 1;
                                joueurEnCours.Text = "C'est au tour de " + getNameByPosition(joueurPlaying);

                            }
                        }


                    }
                }
            }

        }

        private void restart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
