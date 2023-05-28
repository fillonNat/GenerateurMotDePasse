using System;
using FormationCS;


namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int NB_MOT_PASSE = 10;
            // 1- Demander la longueur du mot de passe (DemanderNombre) int longeur
            int longueurMotDePasse = outils.DemanderNombrePositifNonNul("Longeur du mot de passe : ");
            string question = "Vous voulez un mot de passe avec: \n1- Uniquement avec des carctères en minuscules\n2- Des carctères minuscules et majuscules\n" +
                "3- Des carctères et des chiffres\n4- Carctères, chiffres et caractères spéciaux.\nVotre Choix :  ";
            int styleMotDePasse = outils.DemanderNombreEntre(question, 1, 5);
            // 2- alphabet 
            // 3- comment choisir un caractère aléatoire
            // 

            string minuscules = "abcdefghijklmnopqrstuvwxyz";
            string majuscules = minuscules.ToUpper();
            string chiffres = "0123456789";
            string caractereSpeciaux = "!#$%?&+-*";
            string alphabet = "";
            switch (styleMotDePasse)
            {
                case 1: alphabet = minuscules; break;
                case 2: alphabet = minuscules + majuscules; break;
                case 3: alphabet = minuscules + majuscules + chiffres; break;
                case 4: alphabet = minuscules + majuscules + chiffres + caractereSpeciaux; break;
                default: break;
            }

            int longueurAlphabet = alphabet.Length;
            string motDePasse = "";
            Random rand = new Random();

            // boucler pour créer plusieurs mots de passe
            for (int j = 0; j < NB_MOT_PASSE; j++)
            {
                //boucler sur longueurMotDePasse
                for (int i = 0; i < longueurMotDePasse; i++) 
                {
                    int index = rand.Next(0, longueurAlphabet);
                    motDePasse += alphabet[index];
                }

                Console.WriteLine("Votre mot de passe : " + motDePasse);
                motDePasse = "";
            }
        }
    }
}