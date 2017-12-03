using ClasseMetier;

using System.Windows;

namespace JeuNombreMystere.UcAfficherListeScores
{
    class UcAfficherListeScores
    {
        public void doIt(MainWindow mainWindow)
        {
            
            ListeJoueur listeJoueursActifs = new ListeJoueur();
            foreach (Joueur joueur in mainWindow.ListeJoueur)
                if(joueur.NbPartiesJouees > 0)
                    listeJoueursActifs.Add(joueur);
            listeJoueursActifs.Sort();
            FenetreVisualisationDesScores fenetreVisualisationDesScores = new FenetreVisualisationDesScores(listeJoueursActifs);
            fenetreVisualisationDesScores.Show();
        }
    }
}
