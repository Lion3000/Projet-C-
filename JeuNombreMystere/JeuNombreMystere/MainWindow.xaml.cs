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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClasseMetier;
using JeuNombreMystere.UcGestionJoueurs;

namespace JeuNombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         private ListeJoueur listJoueur;
        UcGererJoueurs gererJoueurs;
        public MainWindow()
        {
            //this.listJoueur.load();
            InitializeComponent();
            gererJoueurs = new UcGererJoueurs(listJoueur);
        }
        
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            //this.listJoueur.load();
        }

        private void nouveauJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.ajouterJoueur();
        }
    }
}
