using ClasseMetier;
using System;

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
