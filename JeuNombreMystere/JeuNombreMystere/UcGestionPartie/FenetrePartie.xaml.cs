using ClasseMetier;
using System;

using System.Windows;

namespace JeuNombreMystere.UcGestionPartie
{
    /// <summary>
    /// Logique d'interaction pour FenetrePartie.xaml
    /// </summary>
    public partial class FenetrePartie : Window
    {
        private Partie partie;
        public event VictoireEventHandler Victoire;
        public delegate void VictoireEventHandler(object sender, VictoireEventArgs e);
        public VictoireEventArgs e = null;

        public FenetrePartie(Partie partie)
        {
            this.partie = partie;
            InitializeComponent();
        }

        private void valider_Click(object sender, RoutedEventArgs e)
        {
            this.partie.NbPropositions++;
            if (Convert.ToUInt32(nombreSaisi.Text) == this.partie.NombreMystere)
            {
                if (Victoire != null)
                {
                    if (this.partie.Joueur.MeilleurScore > this.partie.NbPropositions || this.partie.Joueur.MeilleurScore == 0)
                        this.partie.Joueur.MeilleurScore = this.partie.NbPropositions;
                    this.e = new VictoireEventArgs(this.partie);
                    Victoire(this, this.e);
                }
            }
            else
                info.Content = (Convert.ToUInt32(nombreSaisi.Text) < this.partie.NombreMystere) ? "Le nombre mystère est plus grand que "+ nombreSaisi.Text + " !" : "Le nombre mystère est plus petit que " + nombreSaisi.Text + " !";
        }
    }
}
