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

namespace JeuNombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // private ListJoueur listJoueur;
        public MainWindow()
        {
            //this.listJoueur.load();
            InitializeComponent();
        }



        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            //this.listJoueur.load();
        }
    }
}
