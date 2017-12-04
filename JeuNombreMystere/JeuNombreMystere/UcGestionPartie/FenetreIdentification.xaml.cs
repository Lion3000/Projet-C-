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
                MainWindow w = (MainWindow)Owner;
                //UcIdentifier ucIdentifier = new UcIdentifier();
                foreach (Joueur currentJoueur in this.listeJoueur)
                {
                    if (currentJoueur.Equals(new Joueur(Nom.Text, Login.Text)))
                        w.LancerPartie(this, currentJoueur);
                }
            }
            else
            {
                MessageBox.Show("Joueur Inconnu, vérifiez la saisie ou créez un nouveau joueur", "Retry", MessageBoxButton.OK, MessageBoxImage.Question);
            }
        }
    }
}
