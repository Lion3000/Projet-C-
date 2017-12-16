using ClasseMetier;
using System.Windows;

namespace JeuNombreMystere.UcGestionPartie
{
    /// <summary>
    /// Logique d'interaction pour FenetreIdentification.xaml
    /// </summary>
    public partial class FenetreIdentification : Window
    {
        private ListeJoueur listeJoueur;
        public FenetreIdentification(ListeJoueur listeJoueur)
        {
            this.listeJoueur = listeJoueur;
            InitializeComponent();
        }

        private void Jouer_Click(object sender, RoutedEventArgs e)
        {
            if(Login.Text != "" && Nom.Text != "")
            {
                bool joueurExistant = false;
                MainWindow w = (MainWindow)Owner;
                foreach (Joueur currentJoueur in this.listeJoueur)
                {
                    if (currentJoueur.Equals(new Joueur(Nom.Text, Login.Text)))
                    {
                        w.LancerPartie(this, currentJoueur);
                        joueurExistant = true;
                    }                    
                }
                if (!joueurExistant)
                    MessageBox.Show("Joueur Inconnu, vérifiez la saisie ou créez un nouveau joueur", "Retry", MessageBoxButton.OK, MessageBoxImage.Question);
            }
            else
                MessageBox.Show("Joueur Inconnu, vérifiez la saisie ou créez un nouveau joueur", "Retry", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
