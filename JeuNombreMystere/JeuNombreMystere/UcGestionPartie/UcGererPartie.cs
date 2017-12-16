using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere.UcGestionPartie
{
    
    class UcGererPartie
    {
        private Joueur joueur;
        private Partie partie;
        private FenetrePartie fenetrePartie;
        public UcGererPartie(Joueur joueur)
        {
            this.joueur = joueur;
            this.partie = new Partie(this.joueur);
            fenetrePartie = new FenetrePartie(this.partie);
            this.subscribe(this.fenetrePartie);
        }

        public void demarrerPartie()
        {
            fenetrePartie.Show();            
        }

        public void onVictoire(object sender, VictoireEventArgs e)
        {
            this.partie.Joueur.NbPartiesJouees++;
            this.partie.Joueur.Score = this.partie.NbPropositions;
            fenetrePartie.Close();
            FenetreVictoire fenetreVictoire = new FenetreVictoire(this.partie);
            fenetreVictoire.Show();
        }

        public void subscribe(FenetrePartie fenetrePartie)
        {
            fenetrePartie.Victoire += new FenetrePartie.VictoireEventHandler(onVictoire);
        }
    }
}
