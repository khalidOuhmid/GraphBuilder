namespace Graphes
{
    partial class FeuilleDessin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeuilleDessin));
            this.menu = new System.Windows.Forms.ToolStrip();
            this.déplacement = new System.Windows.Forms.ToolStripButton();
            this.moins = new System.Windows.Forms.ToolStripButton();
            this.plus = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.Paramètres = new System.Windows.Forms.ToolStripButton();
            this.ToutSupprimer = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.déplacement,
            this.moins,
            this.plus,
            this.toolStripButton3,
            this.Paramètres,
            this.ToutSupprimer});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "toolStrip1";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // déplacement
            // 
            this.déplacement.CheckOnClick = true;
            this.déplacement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.déplacement.Image = ((System.Drawing.Image)(resources.GetObject("déplacement.Image")));
            this.déplacement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.déplacement.Name = "déplacement";
            this.déplacement.Size = new System.Drawing.Size(23, 22);
            this.déplacement.Text = "toolStripButton1";
            this.déplacement.Click += new System.EventHandler(this.BouttonBouger);
            // 
            // moins
            // 
            this.moins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.moins.Image = ((System.Drawing.Image)(resources.GetObject("moins.Image")));
            this.moins.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(23, 22);
            this.moins.Text = "toolStripButton1";
            this.moins.Click += new System.EventHandler(this.ReduireClick);
            // 
            // plus
            // 
            this.plus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.plus.Image = ((System.Drawing.Image)(resources.GetObject("plus.Image")));
            this.plus.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(23, 22);
            this.plus.Text = "toolStripButton2";
            this.plus.Click += new System.EventHandler(this.AgrandirClick);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.BouttonCouleur);
            // 
            // Paramètres
            // 
            this.Paramètres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paramètres.Image = ((System.Drawing.Image)(resources.GetObject("Paramètres.Image")));
            this.Paramètres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paramètres.Name = "Paramètres";
            this.Paramètres.Size = new System.Drawing.Size(23, 22);
            this.Paramètres.Text = "toolStripButton4";
            this.Paramètres.Click += new System.EventHandler(this.BouttonParam_click);
            // 
            // ToutSupprimer
            // 
            this.ToutSupprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToutSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("ToutSupprimer.Image")));
            this.ToutSupprimer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToutSupprimer.Name = "ToutSupprimer";
            this.ToutSupprimer.Size = new System.Drawing.Size(23, 22);
            this.ToutSupprimer.Text = "toolStripButton1";
            this.ToutSupprimer.Click += new System.EventHandler(this.BouttonSuppTouut);
            // 
            // FeuilleDessin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
            this.Name = "FeuilleDessin";
            this.ShowInTaskbar = false;
            this.Text = "Premier Dessin";
            this.Load += new System.EventHandler(this.FeuilleDessin_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FeuilleDessin_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FeuilleDessin_MouseUp);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripButton déplacement;
        private System.Windows.Forms.ToolStripButton moins;
        private System.Windows.Forms.ToolStripButton plus;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton Paramètres;
        private System.Windows.Forms.ToolStripButton ToutSupprimer;
    }
}

