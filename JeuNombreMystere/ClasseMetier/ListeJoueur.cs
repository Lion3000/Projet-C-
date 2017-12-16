using JeuNombreMystere;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ClasseMetier
{
    public class ListeJoueur : List<Joueur>, IComparer<Joueur>
    {
        public event NotEmptyHandler notEmpty;
        public delegate void NotEmptyHandler(object sender, ListeJoueursIsNotEmptyEventArgs e);
        public ListeJoueursIsNotEmptyEventArgs e = null;

        public int Compare(Joueur x, Joueur y)
        {
            return x.CompareTo(y);
        }

        public void save()
        {
            StreamWriter sw = new StreamWriter("ListeJoueurSauvgarde.xml");

            XmlSerializer xsSubmit = new XmlSerializer(typeof(ListeJoueur));

            //Serialise l'objet en chaine de caracters et écrit un fichier de sauvegarde
            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, this);
                    sw.WriteLine(sww.ToString());
                }
            }

            sw.Close();
        }

        public new void Add(Joueur joueur)
        {
            base.Add(joueur);
            this.startListeJoueursIsNotEmptyEvent();
        }

        public void load()
        {
            try
            {
                StreamReader sr = new StreamReader("ListeJoueurSauvgarde.xml");
                string listeJoueurSauvgardeXml = "";
                //Lie la ligne dans ListeJoueurSauvgarde.xml et ajoute dans la chaine listeJoueurSauvgardeXml
                string line = sr.ReadLine();
                while (line != null)
                {
                    listeJoueurSauvgardeXml += line;
                    line = sr.ReadLine();
                }

                //Déserialise la chaine en objet et remplit l'objet actuel
                if (listeJoueurSauvgardeXml != "")
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ListeJoueur));
                    using (TextReader reader = new StringReader(listeJoueurSauvgardeXml))
                    {
                        ListeJoueur listeJoueur = (ListeJoueur)serializer.Deserialize(reader);

                        foreach (Joueur joueur in listeJoueur)
                        {
                            this.Add(joueur);
                        }
                    }
                }
                this.startListeJoueursIsNotEmptyEvent();
            }
            catch (FileNotFoundException e)
            {

            }
        }

        private void startListeJoueursIsNotEmptyEvent()
        {
            if (this.Count > 0)
            {
                if (notEmpty != null)
                {
                    e = new ListeJoueursIsNotEmptyEventArgs(this.Count);
                    notEmpty(this, e);
                }
            }
        }
    }
}
