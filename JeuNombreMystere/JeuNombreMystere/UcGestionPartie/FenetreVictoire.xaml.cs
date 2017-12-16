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
using System.Windows.Media.Animation;
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
            Storyboard sb = this.FindResource("PlayAnimation") as Storyboard;
            Storyboard.SetTarget(sb, this.victoire); 
            sb.Begin();
            Storyboard sb2 = this.FindResource("PlayAnimation2") as Storyboard;
            sb2.Begin();
            this.meilleurScore.Content = "Meilleur score: " + partie.Joueur.MeilleurScore;
            this.Score.Content = "Score : " + partie.NbPropositions;
            this.nombrePartieJouees.Content = "Nombre de parties jouées : " + partie.Joueur.NbPartiesJouees;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
