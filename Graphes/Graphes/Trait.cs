using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphes
{
    internal class Trait
    {
        public Noeud Source { get; set; }
        public Noeud Destination { get; set; }

        public Boolean tmp;

        public void Dessine(Graphics g)
        {
            g.DrawLine(Pens.Black, Source.Centre, Destination.Centre);
        }
        public void DessineTemp(Graphics g)
        {

            g.DrawLine(Pens.DarkRed, Source.Centre, Destination.Centre);

        }




    }
}
