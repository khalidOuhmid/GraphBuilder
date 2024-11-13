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
    class Noeud
    {
        
        public Point Position { get; set;}

        public Size Taille { get; set; }


        public int Epaisseur { get; set; }

        public Color Couleur { get; set; } = Color.Black;

        
        public String Texte { get; set; } = "Noeud";

        
        public Point Centre
        {
            get { return new Point(Position.X + Taille.Width / 2,
                Position.Y + Taille.Height / 2);
            }
        }

        public void Dessine(Graphics g)
        {
            
            Pen p = new Pen(Couleur, Epaisseur);
            Rectangle r = new Rectangle(Position, Taille);
            g.DrawRectangle(p, r);

            SolidBrush drawBrush = new SolidBrush(Color.Black);
            Font drawFont = new Font("Arial", 16);
            g.DrawString(Texte, drawFont, drawBrush, Position.X,Position.Y+Taille.Height);
        } 
       public bool Contient(Point p)
        {
            Rectangle r = new Rectangle(Position, Taille);
            return r.Contains(p);
        }
      public void Déplace(Point e)
        {
            this.Position = e;
        }


    }
}
