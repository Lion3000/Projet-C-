using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere.UcGestionJoueurs
{
    class UcGererPartie
    {
        private Partie partie;

        UcGererPartie(Joueur joueur)
        {
            this.partie = new Partie(joueur);
        }
    }
}
