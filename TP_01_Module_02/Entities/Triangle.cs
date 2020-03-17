using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_01_Module_02.Entities
{
    class Triangle : Forme
    {
        private int a;
        private int b;
        private int c;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle()
        {

        }

        public Triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int getPerimetre()
        {
            return this.A + this.B + this.C;
        }

        public float getAire()
        {
            int p = this.getPerimetre() / 2;
            return (float)Math.Sqrt((double)(p * (p - this.A) * (p - this.B) * (p - this.C)));
        }

        public override string ToString()
        {
            return "Triangle de côté A=" + this.A + ", B=" + this.B + ", C=" + this.C +
                Environment.NewLine + "Aire = " + this.getAire() +
                Environment.NewLine + "Périmètre = " + this.getPerimetre() + Environment.NewLine;
        }
    }
}
