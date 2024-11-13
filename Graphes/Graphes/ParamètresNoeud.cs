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
    public partial class ParamètresNoeud : Form
    {
        public Color Couleur { get { return CouleurParamètreNoeud.BackColor; } }
        public int Epaisseur { get { return (int)épaisseur.Value; } }
        public String Texte { get { return textBox1.Text; } }

        public ParamètresNoeud(Color c, int e, String t)
        {
            InitializeComponent();
            CouleurParamètreNoeud.BackColor = c;
            épaisseur.Value = e;
            textBox1.Text = t;
        }

        private void CouleurParamètreNoeud_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            boitecouleur.ShowDialog();
            CouleurParamètreNoeud.BackColor = boitecouleur.Color;
        }

        private void OkboutonNoeud_Click(object sender, EventArgs e)
        {

        }

        private void ChangerNom(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
