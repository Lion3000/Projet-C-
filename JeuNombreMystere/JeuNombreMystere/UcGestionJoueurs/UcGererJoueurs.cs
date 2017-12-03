﻿using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere.UcGestionJoueurs
{
    public class UcGererJoueurs
    {
        private ListeJoueur listeJoueurs;
        public UcGererJoueurs(ListeJoueur listeJoueurs)
        {
            this.listeJoueurs = listeJoueurs;
        }

        public void visualiserJoueur()
        {
            FenetreVisualisationDesJoueurs fenetreListeDesJoueurs = new FenetreVisualisationDesJoueurs(this.listeJoueurs);
            fenetreListeDesJoueurs.Show();
        }

        public void ajouterJoueur()
        {
            FenetreAjoutNouveauJoueur fenetreAjoutNouveauJoueur = new FenetreAjoutNouveauJoueur(this.listeJoueurs);
            fenetreAjoutNouveauJoueur.Show();
        }
    }
}