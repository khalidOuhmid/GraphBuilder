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
    public partial class FeuilleDessin : Form
    {
        List<Noeud> noeuds;
        List<Noeud> noeudstmp;
        List<Trait> traits;
        List<Trait> traitstmp;
        List<Trait> traitasupp;
         Noeud sélection;
        Boolean enMouvement = false;
        Boolean enDessinTrait = false;
        int epaisseur = 1;
        Color couleur = Color.Black;
        String Texte = "Noeud";

        public FeuilleDessin()
        {
            InitializeComponent();
            noeuds = new List<Noeud>();
            traits = new List<Trait>();
            traitstmp = new List<Trait>();
            noeudstmp = new List<Noeud>();
            traitasupp = new List<Trait>();

        }

        private void FeuilleDessin_Paint(object sender, PaintEventArgs e)
        {

            ;
            foreach (Noeud n in noeuds)
            {
                n.Dessine(e.Graphics);
            }

            foreach (Trait t in traits)
            {
                    t.Dessine(e.Graphics);

            }
            foreach(Trait t in traitstmp)
            {
                t.DessineTemp(e.Graphics);
            }
            foreach(Noeud n in noeudstmp)
            {
                n.Dessine(e.Graphics);
            }


        }
        private void remplirListNoeud(MouseEventArgs e )
        {
            Noeud n = new Noeud
            {
                Couleur = couleur,
                Position = e.Location,
                Taille = new Size(20, 20),
                Epaisseur = epaisseur

            };
            noeuds.Add(n);
            Refresh();
           
        }
        private void remplirListNoeudAvecTrait(MouseEventArgs e )
        {
            Noeud n = new Noeud
            {
                Couleur = couleur,
                Position = e.Location,
                Taille = new Size(20, 20),
                Epaisseur = epaisseur

            };
            Trait trait = new Trait
            {
                Source = sélection,
                Destination = n
            };
            trait.tmp = false;
            traits.Add(trait);

            noeuds.Add(n);

            Refresh();

        }
        private void remplirListNoeudTmp(MouseEventArgs e)
        {
            noeudstmp.Clear();
            Noeud n = new Noeud
            {
                Couleur = Color.DarkRed,
                Position = e.Location,
                Taille = new Size(20, 20),
                Epaisseur = epaisseur
            };

            noeudstmp.Add(n);
            Refresh();
        }
        /*
         * 
         * Méthode qui gère la séléction 
         */
            private Noeud Sélection(Point p)
        {
            Noeud res = null;
            int i = 0;
            while (res == null && i < noeuds.Count)
            {
                if (noeuds[i].Contient(p))
                {
                    res = noeuds[i];
                }
                i++;

            }
            return res;
        }

        /**
         * Méthode executé au moment du click vers le bas
         * elle permet de créer un noeud, d'afficher le menu contextuel et 
         * de gérer le déplacement quand un noeud est séléctioné
         */
        private void FeuilleDessin_MouseDown(object sender, MouseEventArgs e)
        {
            sélection = Sélection(e.Location);
            if (déplacement.Checked)
            {
                enMouvement = sélection != null;
            }
            else
            {
                if (e.Button == MouseButtons.Left && !noeuds.Contains(sélection))
                {
                    remplirListNoeud(e);
                }
                else if (e.Button == MouseButtons.Right && sélection != null)
                {
                    ContextMenuStrip cm = new ContextMenuStrip();
                     foreach(string libel in new string[] { "Supprimer", "Modifier"})
                    {
                        ToolStripMenuItem élément = new ToolStripMenuItem(libel);
                        élément.Click += new EventHandler(Elément_Click);
                        cm.Items.Add(élément);
                    }
                    cm.Show(this, e.Location);
                    
                }
                else if ( e.Button != MouseButtons.Right )
                {
                    enDessinTrait = true;

                }
            }
            
        }

        /*
         * 
         * Méthode qui gère les bouttons modifier et supprimer du menu textuel 
         * qui apparait au moment d'un clique droit
         */
        private void Elément_Click(object sender,EventArgs e)
        {
            ToolStripMenuItem tm = (ToolStripMenuItem)sender;
            switch (tm.Text)
            {
                case "Modifier":
                    ParamètresNoeud paramNoeud = new ParamètresNoeud(sélection.Couleur, sélection.Epaisseur, sélection.Texte);
                    if (sélection != null)
                    {
                        if (paramNoeud.ShowDialog() == DialogResult.OK)
                        {
                            int index = noeuds.IndexOf(sélection);
                            sélection.Couleur = paramNoeud.Couleur;
                            sélection.Epaisseur = paramNoeud.Epaisseur;
                            sélection.Texte = paramNoeud.Texte;
                            Refresh();
                        }
                    }
                    break;
                case "Supprimer":
                    traitasupp.Clear();
                    
                    foreach (Trait t in traits)
                    {
                        if (t.Destination == sélection || t.Source == sélection)
                        {
                            traitasupp.Add(t);
                        }

                    }
                    foreach (Trait t in traitasupp)
                    {
                        traits.Remove(t);
                    }
                    noeuds.Remove(sélection);
                    Refresh();
                    break;

            }
        }

        private void FeuilleDessin_MouseMove(object sender, MouseEventArgs e)
        {
            if (enMouvement)
            {
                sélection.Déplace(e.Location);
                Refresh();

            }
            if ( enDessinTrait)
            {
                Noeud n = new Noeud
                {
                    Couleur = Color.Pink,
                    Position = e.Location,
                    Taille = new Size(20, 20)

                };
                Noeud fin = n;
                if (fin != null && !fin.Equals(sélection))
                {
                    remplirListNoeudTmp(e);
                    Trait trait = new Trait
                    {
                        Source = sélection,
                        Destination = fin
                        
                    };
                    traitstmp.Clear();
                    trait.tmp = true;
                    traitstmp.Add(trait);
                    Refresh();
                }
            }
        }
 


        private void FeuilleDessin_MouseUp(object sender, MouseEventArgs e)
        {
            enMouvement = false;
            traitstmp.Clear();
            noeudstmp.Clear();   
            if (enDessinTrait)
            {
                Noeud fin = Sélection(e.Location);
                if (fin != null && !fin.Equals(sélection))
                {
                    Trait trait = new Trait
                    {
                        Source = sélection,
                        Destination = fin
                    };
                    trait.tmp = false;
                    traits.Add(trait);
                }
                else
                {
                    remplirListNoeudAvecTrait(e);
                }
                
                enDessinTrait = false;
                Refresh();
            }

           
            

        }
        public void DessineTraitTemp(Graphics g, MouseEventArgs e)
        {
            g.DrawLine(Pens.Black, sélection.Position, e.Location);
        }

        private void FeuilleDessin_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
        }

        private void BouttonBouger(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void ReduireClick(object sender, EventArgs e)
        {
            epaisseur--;
        }

        private void AgrandirClick(object sender, EventArgs e)
        {
            epaisseur++;
        }

        private void BouttonCouleur(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            couleur = colorDialog1.Color;
        }

        private void BouttonParam_click(object sender, EventArgs e)
        {
           
            ParamètresNoeud paramNoeud = new ParamètresNoeud(sélection.Couleur, sélection.Epaisseur, sélection.Texte);
            if (sélection != null)
            {
                if (paramNoeud.ShowDialog() == DialogResult.OK)
                {
                    int index = noeuds.IndexOf(sélection);
                    sélection.Couleur = paramNoeud.Couleur;
                    sélection.Epaisseur = paramNoeud.Epaisseur;
                    sélection.Texte = paramNoeud.Texte;
                    Refresh();
                }
            }
        }

       

        private void petitmenu_Opening(object sender, CancelEventArgs e)
        {

        }

        private void BouttonSuppTouut(object sender, EventArgs e)
        {
            traits.Clear();
            noeuds.Clear();
            Refresh();
        }
    }
}
