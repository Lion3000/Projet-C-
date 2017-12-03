using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    public class Partie
    {
        private Joueur joueur;        
        private uint nombreMystere, nbPropositions;

        public Partie(Joueur joueur)
        {
            this.Joueur = joueur;
            this.genererNombreMystere();
            this.NbPropositions = 0;
        }

        public Joueur Joueur { get => joueur; set => joueur = value; }
        public uint NombreMystere { get => nombreMystere; set => nombreMystere = value; }
        public uint NbPropositions { get => nbPropositions; set => nbPropositions = value; }

        private void genererNombreMystere()
        {
            Random random = new Random();      
            this.NombreMystere = (uint)random.Next(1, 1000);
        }
    }
}
