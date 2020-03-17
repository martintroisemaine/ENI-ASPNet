using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01_Module_02.Entities
{
    class Carre : Forme
    {
        private int longueur;

        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public Carre()
        {

        }

        public Carre(int longueur)
        {
            this.longueur = longueur;
        }

        public int getPerimetre()
        {
            return this.Longueur * 4;
        }

        public int getAire()
        {
            return (int)Math.Pow((double)this.Longueur, 2);
        }

        public override string ToString()
        {
            return "Carre de côté=" + this.Longueur +
                Environment.NewLine + "Aire = " + this.getAire() +
                Environment.NewLine + "Périmètre = " + this.getPerimetre() + Environment.NewLine;
        }
    }
}
