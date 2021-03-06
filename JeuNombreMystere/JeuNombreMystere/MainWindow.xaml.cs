﻿using System;
using System.Windows;
using ClasseMetier;
using System.Windows.Input;

namespace JeuNombreMystere
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ListeJoueur listeJoueur;
        private UcGestionJoueurs.UcGererJoueurs gererJoueurs;
        private UcAfficherListeScores.UcAfficherListeScores afficherListeScores;
        private UcGestionPartie.UcGererPartie ucGererPartie;

        public ListeJoueur ListeJoueur { get => listeJoueur; set => listeJoueur = value; }

        public MainWindow()
        {
            this.ListeJoueur = new ListeJoueur();
            InitializeComponent();
            DataContext = new MacroDataContext(this);
            this.subscribe(this.ListeJoueur);
            this.ListeJoueur.load();            
           
            this.gererJoueurs = new UcGestionJoueurs.UcGererJoueurs();
            this.afficherListeScores = new UcAfficherListeScores.UcAfficherListeScores();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            this.ListeJoueur.save();
        }

        public void nouveauJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.ajouterJoueur(this);
        }

        public void Demarrer_Click(object sender, RoutedEventArgs e)
        {
            UcGestionPartie.FenetreIdentification fenetreIdentification = new UcGestionPartie.FenetreIdentification(this.listeJoueur);
            fenetreIdentification.Owner = this;
            fenetreIdentification.Show();
        }
        public void LancerPartie(UcGestionPartie.FenetreIdentification fenetreIdentification, Joueur joueur)
        {
            fenetreIdentification.Close();
            ucGererPartie = new UcGestionPartie.UcGererPartie(joueur);
            this.ucGererPartie.demarrerPartie();
        }
        private void visualiserJoueur_Click(object sender, RoutedEventArgs e)
        {
            this.gererJoueurs.visualiserJoueur(this);
        }

        public void quitter_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public void tableauScore_Click(object sender, RoutedEventArgs e)
        {
            afficherListeScores.doIt(this);
        }
        public void subscribe(ListeJoueur listeJoueur)
        {
            listeJoueur.notEmpty += new ListeJoueur.NotEmptyHandler(onListeJoueurNotEmpty);
        }
        public void onListeJoueurNotEmpty(object sender, ListeJoueursIsNotEmptyEventArgs e)
        {
            tableauScore.IsEnabled = true;
            Demarrer.IsEnabled = true;
            visualiserJoueur.IsEnabled = true;
        }

    }

}
