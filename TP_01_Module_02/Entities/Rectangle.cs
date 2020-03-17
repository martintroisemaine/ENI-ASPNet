using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01_Module_02.Entities
{
    class Rectangle : Forme
    {
        private int longueur;
        private int largeur;

        public int Longueur
        {
            get { return longueur; }
            set { longueur = value; }
        }

        public int Largeur
        {
            get { return largeur; }
            set { largeur = value; }
        }

        public Rectangle()
        {

        }

        public Rectangle(int longueur, int largeur)
        {
            this.longueur = longueur;
            this.largeur = largeur;
        }

        public int getPerimetre()
        {
            return (this.Largeur + this.Longueur) * 2;
        }

        public int getAire()
        {
            return (this.Largeur * this.Longueur);
        }

        public override string ToString()
        {
            return "Rectangle de longueur=" + this.Longueur + " et largeur=" + this.Largeur +
                Environment.NewLine + "Aire = " + this.getAire() +
                Environment.NewLine + "Périmètre = " + this.getPerimetre() + Environment.NewLine;
        }
    }
}
