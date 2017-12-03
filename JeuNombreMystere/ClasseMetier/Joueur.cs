using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseMetier
{
    public class Joueur : IComparable<Joueur>
    {
        private string nom, login;
        private uint nbPartiesJouees, meilleurScore, score;

        public Joueur(string nom, string login, uint nbPartiesJouees = 0, uint meilleurScore = 0, uint score = 0)
        {
            Nom = nom;
            Login = login;
            NbPartiesJouees = nbPartiesJouees;
            MeilleurScore = meilleurScore;
            Score = score;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Login { get => login; set => login = value; }
        public uint NbPartiesJouees { get => nbPartiesJouees; set => nbPartiesJouees = value; }
        public uint MeilleurScore { get => meilleurScore; set => meilleurScore = value; }
        public uint Score { get => score; set => score = value; }

        public int CompareTo(Joueur other)
        {
            return this.Score.CompareTo(other.Score);
        }
    }
}
