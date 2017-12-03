using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JeuNombreMystere.UcGestionPartie
{
    /// <summary>
    /// Logique d'interaction pour FenetreVictoire.xaml
    /// </summary>
    public partial class FenetreVictoire : Window
    {
        public FenetreVictoire(Partie partie)
        {
            InitializeComponent();
            meilleurScore.Content = "Meilleur score: " + partie.Joueur.MeilleurScore;
            Score.Content = "Score : " + partie.NbPropositions;
            nombrePartieJouees.Content = "Nombre de parties jouées : " + partie.Joueur.NbPartiesJouees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
