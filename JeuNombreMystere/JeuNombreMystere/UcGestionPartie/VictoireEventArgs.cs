using ClasseMetier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuNombreMystere.UcGestionPartie
{
    public class VictoireEventArgs : EventArgs
    {
        private Partie partie;

        public VictoireEventArgs(Partie partie)
        {
            this.Partie = partie;
        }

        public Partie Partie { get => partie; set => partie = value; }
    }
}
