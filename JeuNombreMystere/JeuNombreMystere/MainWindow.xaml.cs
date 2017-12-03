using System;
using System.Windows;
using ClasseMetier;
using JeuNombreMystere.UcGestionJoueurs;
using JeuNombreMystere.UcGestionPartie;

namespace JeuNombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ListeJoueur listeJoueur;
        UcGererJoueurs gererJoueurs;
        UcGererPartie ucGererPartie;
        UcIdentifier ucIdentifier;
  
        public MainWindow()
        {
            this.listeJoueur = new ListeJoueur();
            this.listeJoueur.load();
            InitializeComponent();
            this.gererJoueurs = new UcGererJoueurs(this.listeJoueur);            
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.listeJoueur.save();
        }

        private void nouveauJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.ajouterJoueur();
        }

        private void Demarrer_Click(object sender, RoutedEventArgs e)
        {
            FenetreIdentification fenetreIdentification = new FenetreIdentification(this.listeJoueur);
            fenetreIdentification.Owner = this;
            fenetreIdentification.Show();
        }
        public void LancerPartie(FenetreIdentification fenetreIdentification, Joueur joueur)
        {
            fenetreIdentification.Close();
            ucGererPartie = new UcGererPartie(joueur);
            this.ucGererPartie.demarrerPartie();
        }
        private void visualiserJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.visualiserJoueur();
        }
    }
}
