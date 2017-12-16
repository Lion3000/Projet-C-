using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere.UcGestionJoueurs
{
    public class UcGererJoueurs
    {

        public void visualiserJoueur(MainWindow mainWindow)
        {
            FenetreVisualisationDesJoueurs fenetreListeDesJoueurs = new FenetreVisualisationDesJoueurs();
            fenetreListeDesJoueurs.Owner = mainWindow;
            fenetreListeDesJoueurs.Show();
        }

        public void ajouterJoueur(MainWindow mainWindow)
        {
            FenetreAjoutNouveauJoueur fenetreAjoutNouveauJoueur = new FenetreAjoutNouveauJoueur();
            fenetreAjoutNouveauJoueur.Owner = mainWindow;
            fenetreAjoutNouveauJoueur.Show();
        }
    }
}
