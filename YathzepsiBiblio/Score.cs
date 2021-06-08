using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YathzepsiBiblio
{
    public class Score
    {
        public static int getScoreTotal1(int[] resultats)
        {
            int points = 0;
            foreach(int valeur in resultats)
            {
                if (valeur == 1)
                {
                    points += 1;
                }
            }
            return points;
        }

        public static int getScoreTotal2(int[] resultats)
        {
            int points = 0;
            foreach (int valeur in resultats)
            {
                if (valeur == 2)
                {
                    points += 2;
                }
            }
            return points;
        }

        public static int getScoreTotal3(int[] resultats)
        {
            int points = 0;
            foreach (int valeur in resultats)
            {
                if (valeur == 3)
                {
                    points += 3;
                }
            }
            return points;
        }

        public static int getScoreTotal4(int[] resultats)
        {
            int points = 0;
            foreach (int valeur in resultats)
            {
                if (valeur == 4)
                {
                    points += 4;
                }
            }
            return points;
        }

        public static int getScoreTotal5(int[] resultats)
        {
            int points = 0;
            foreach (int valeur in resultats)
            {
                if (valeur == 5)
                {
                    points += 5;
                }
            }
            return points;
        }

        public static int getScoreTotal6(int[] resultats)
        {
            int points = 0;
            foreach (int valeur in resultats)
            {
                if (valeur == 6)
                {
                    points += 6;
                }
            }
            return points;
        }

        public static int getScoreBrelan(int[] resultats)
        {
            Array.Sort(resultats);
            int points = 0;
            if(resultats[0] == resultats[2] || resultats[1] == resultats[3] || resultats[2] == resultats[4]) {
                points += resultats[2] * 3;
            }
            
            return points;
        }

        public static int getScoreCarre(int[] resultats)
        {
            Array.Sort(resultats);
            int points = 0;
            if(resultats[0] == resultats[3] || resultats[1] == resultats[4]){
                points += resultats[2] * 4;
            }
            return points;
        }

        public static int getScoreFull(int[] resultats)
        {
            Array.Sort(resultats);
            int points = 0;
            if ((getScoreBrelan(resultats) != 0 && resultats[0] == resultats[1])&&(getScoreBrelan(resultats) != 0 && resultats[3] == resultats[4]))
            {
                points += 25;
            }
            return points;
        }

        public static int getScorePetiteSuite(int[] resultats)
        {
            Array.Sort(resultats);
            int points = 0;
            int suite = 0;
            int suiteMax = 0;
            for(int i = 0; i < 4; i++)
            {
                if(resultats[i] == resultats[i + 1]) // premet de retirer les doubles
                {
                    resultats[i] = -1;
                    Array.Sort(resultats);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                if(resultats[i] == resultats[i + 1] - 1)
                {
                    suite += 1;
                    if(suite > suiteMax)
                    {
                        suiteMax = suite;
                    }
                }
                else
                {
                    suite = 0;
                }
            }

            if(suiteMax >= 3)
            {
                points += 30;
            }

            return points;
        }

        public static int getScoreLargeSuite(int[] resultats)
        {
            Array.Sort(resultats);
            int points = 0;
            int suite = 0;
            for (int i = 0; i < 4; i++)
            {
                if (resultats[i] == resultats[i + 1] - 1)
                {
                    suite += 1;
                }
            }

            if(suite >= 4)
            {
                points += 40;
            }


            return points;
        }

        public static int getScoreYathzee(int[] resultats, int nbLancer)
        {
            Array.Sort(resultats);
            int points = 0;
            if(resultats[0] == resultats[4] && nbLancer != 1)
            {
                points += 50;
            }
            return points;
        }

        public static int getScoreChance(int[] resultats)
        {
            int points = 0;
            foreach (int valeur in resultats)
            {
                points += valeur;
            }
            return points;
        }
    }
}
