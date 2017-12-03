using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    public class ListeJoueur : List<Joueur>, IComparer<Joueur>
    {
        public int Compare(Joueur x, Joueur y)
        {
            return x.CompareTo(y);
        }
    }
}
