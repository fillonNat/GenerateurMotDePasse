using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationCS
{
    static class outils
    {

        public static int DemanderNombrePositifNonNul(string question)
        {
            return DemanderNombreEntre(question, 1, int.MaxValue, "ERREUR: Le nombre doit être positif et non null.");
        }

        public static int DemanderNombreEntre(string question, int min, int max, string messagePerso = null)
        {

            int nombre = DemanderNombre(question);
            if ((nombre >= min) && (nombre <= max))
            {
                return nombre;
            }
            if (messagePerso != null)
            {
                Console.WriteLine(messagePerso);
            }
            else
            {
                Console.WriteLine("ERREUR: Vous devez entre un nombre entre " + min + " et " + max);
            }
            
            Console.WriteLine();
            return DemanderNombreEntre(question, min, max, messagePerso);  // Fonction récursive
        }
        static int DemanderNombre(string question)
        {
            int reponseInt = 0;
            while (true)
            {

                Console.Write(question);
                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    return reponseInt;
                }
                catch
                {
                    Console.WriteLine("ERREUR: Vous devez rentre un nombre");
                    Console.WriteLine();
                }
            }
        }
    }
}
