using System;
using System.Windows;
using ClasseMetier;


namespace JeuNombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ListeJoueur listeJoueur;
        private UcGestionJoueurs.UcGererJoueurs gererJoueurs;
        private UcAfficherListeScores.UcAfficherListeScores afficherListeScores;

        public ListeJoueur ListeJoueur { get => listeJoueur; set => listeJoueur = value; }

        public MainWindow()
        {
            this.ListeJoueur = new ListeJoueur();
            this.ListeJoueur.load();

            InitializeComponent();
            this.gererJoueurs = new UcGestionJoueurs.UcGererJoueurs();
            this.afficherListeScores = new UcAfficherListeScores.UcAfficherListeScores();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.ListeJoueur.save();
        }

        private void nouveauJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.ajouterJoueur(this);
        }

        private void Demarrer_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void visualiserJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.visualiserJoueur(this);
        }

        private void quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void tableauScore_Click(object sender, RoutedEventArgs e)
        {
            afficherListeScores.doIt(this);
        }
    }
}
