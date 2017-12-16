using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere
{
    public class ListeJoueursIsNotEmptyEventArgs: EventArgs
    {
        private int nbJoueurs;

        public ListeJoueursIsNotEmptyEventArgs(int nbJoueurs)
        {
            this.NbJoueurs = nbJoueurs;
        }

        public int NbJoueurs { get => nbJoueurs; set => nbJoueurs = value; }
    }
}
