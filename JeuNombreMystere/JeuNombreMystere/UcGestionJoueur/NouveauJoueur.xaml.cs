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

namespace JeuNombreMystere.UcGestionJoueur
{
    /// <summary>
    /// Logique d'interaction pour NouveauJoueur.xaml
    /// </summary>
    public partial class NouveauJoueur : Window
    {
        public NouveauJoueur()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Joueur " + Prenom.Text + Nom.Text + " a été ajouté", "Confirmation", MessageBoxButton.OK, MessageBoxImage.Question);
        }
    }
}
