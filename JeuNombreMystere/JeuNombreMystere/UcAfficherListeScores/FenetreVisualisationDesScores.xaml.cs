using ClasseMetier;
using System.Windows;


namespace JeuNombreMystere.UcAfficherListeScores
{
    /// <summary>
    /// Logique d'interaction pour FenetreVisualisationDesScores.xaml
    /// </summary>
    public partial class FenetreVisualisationDesScores : Window
    {
        private ListeJoueur listeJoueursActifs;
        public FenetreVisualisationDesScores(ListeJoueur listeJoueursActifs)
        {
            this.listeJoueursActifs = listeJoueursActifs;
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            listeJoueursParticipants.ItemsSource = this.listeJoueursActifs;
        }
    }
}
