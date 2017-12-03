using System;
using System.Windows;
using ClasseMetier;
using JeuNombreMystere.UcGestionJoueurs;

namespace JeuNombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ListeJoueur listeJoueur;
        UcGererJoueurs gererJoueurs;
  
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
            
        }

        private void visualiserJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.visualiserJoueur();
        }

        private void quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tableauScore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
