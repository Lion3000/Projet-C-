using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere.UcGestionPartie
{
    class UcIdentifier
    {
        public UcIdentifier()
        {
        }

        public bool doIt(ListeJoueur listeJoueur, Joueur joueur)
        {
            foreach (Joueur currentJoueur in listeJoueur)
            {
                if (currentJoueur.Equals(joueur))
                    return true;
            }
            return false;
        }
    }
}
