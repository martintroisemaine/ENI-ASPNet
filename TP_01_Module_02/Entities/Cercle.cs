using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01_Module_02.Entities
{
    class Cercle : Forme
    {
        private int rayon;

        public int Rayon
        {
            get { return rayon; }
            set { rayon = value; }
        }

        public Cercle()
        {

        }

        public Cercle(int rayon)
        {
            this.rayon = rayon;
        }

        public float getPerimetre()
        {
            return 2 * (float)Math.PI * this.Rayon;
        }

        public float getAire()
        {
            return (float)((double)Math.PI * Math.Pow((double)this.Rayon, 2));
        }

        public override string ToString()
        {
            return "Cercle de rayon " + this.Rayon +
                Environment.NewLine + "Aire = " + this.getAire() +
                Environment.NewLine + "Périmètre = " + this.getPerimetre() + Environment.NewLine;
        }
    }
}
