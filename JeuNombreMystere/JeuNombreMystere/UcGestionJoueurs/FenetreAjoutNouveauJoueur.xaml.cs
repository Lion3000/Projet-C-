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

namespace JeuNombreMystere.UcGestionJoueurs
{
    /// <summary>
    /// Logique d'interaction pour FenetreAjoutNouveauJoueur.xaml
    /// </summary>
    public partial class FenetreAjoutNouveauJoueur : Window
    {
        private ListeJoueur listeJoueurs;
        public FenetreAjoutNouveauJoueur(ListeJoueur listeJoueurs)
        {
            this.listeJoueurs = listeJoueurs;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(Login.Text != "" && Nom.Text != "")
            {
                this.listeJoueurs.Add(new Joueur(Nom.Text, Login.Text));
                MessageBox.Show("Joueur " + Nom.Text + " " + Login.Text + " ajouté !", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Question);
                this.Close();
            }
            else
            {
                MessageBox.Show("Formulaire incomplet, veuillez réessayer", "Retry", MessageBoxButton.OK, MessageBoxImage.Question);
            }

        }
    }
}
