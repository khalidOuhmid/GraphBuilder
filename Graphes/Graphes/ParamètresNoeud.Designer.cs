namespace Graphes
{
    partial class ParamètresNoeud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OkboutonNoeud = new System.Windows.Forms.Button();
            this.CancelBoutonNoeud = new System.Windows.Forms.Button();
            this.épaisseur = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CouleurParamètreNoeud = new System.Windows.Forms.LinkLabel();
            this.boitecouleur = new System.Windows.Forms.ColorDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TexteDuNoeud = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.épaisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // OkboutonNoeud
            // 
            this.OkboutonNoeud.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkboutonNoeud.Location = new System.Drawing.Point(206, 34);
            this.OkboutonNoeud.Name = "OkboutonNoeud";
            this.OkboutonNoeud.Size = new System.Drawing.Size(75, 23);
            this.OkboutonNoeud.TabIndex = 0;
            this.OkboutonNoeud.Text = "OK";
            this.OkboutonNoeud.UseVisualStyleBackColor = true;
            this.OkboutonNoeud.Click += new System.EventHandler(this.OkboutonNoeud_Click);
            // 
            // CancelBoutonNoeud
            // 
            this.CancelBoutonNoeud.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBoutonNoeud.Location = new System.Drawing.Point(206, 85);
            this.CancelBoutonNoeud.Name = "CancelBoutonNoeud";
            this.CancelBoutonNoeud.Size = new System.Drawing.Size(75, 23);
            this.CancelBoutonNoeud.TabIndex = 1;
            this.CancelBoutonNoeud.Text = "Annuler";
            this.CancelBoutonNoeud.UseVisualStyleBackColor = true;
            // 
            // épaisseur
            // 
            this.épaisseur.Location = new System.Drawing.Point(72, 40);
            this.épaisseur.Name = "épaisseur";
            this.épaisseur.Size = new System.Drawing.Size(60, 20);
            this.épaisseur.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Epaisseur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Couleur";
            // 
            // CouleurParamètreNoeud
            // 
            this.CouleurParamètreNoeud.AutoSize = true;
            this.CouleurParamètreNoeud.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CouleurParamètreNoeud.Location = new System.Drawing.Point(82, 70);
            this.CouleurParamètreNoeud.Name = "CouleurParamètreNoeud";
            this.CouleurParamètreNoeud.Size = new System.Drawing.Size(34, 13);
            this.CouleurParamètreNoeud.TabIndex = 5;
            this.CouleurParamètreNoeud.TabStop = true;
            this.CouleurParamètreNoeud.Text = "         ";
            this.CouleurParamètreNoeud.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CouleurParamètreNoeud_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.ChangerNom);
            // 
            // TexteDuNoeud
            // 
            this.TexteDuNoeud.AutoSize = true;
            this.TexteDuNoeud.Location = new System.Drawing.Point(13, 110);
            this.TexteDuNoeud.Name = "TexteDuNoeud";
            this.TexteDuNoeud.Size = new System.Drawing.Size(34, 13);
            this.TexteDuNoeud.TabIndex = 7;
            this.TexteDuNoeud.Text = "Texte";
            this.TexteDuNoeud.Click += new System.EventHandler(this.label3_Click);
            // 
            // ParamètresNoeud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 139);
            this.Controls.Add(this.TexteDuNoeud);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CouleurParamètreNoeud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.épaisseur);
            this.Controls.Add(this.CancelBoutonNoeud);
            this.Controls.Add(this.OkboutonNoeud);
            this.Name = "ParamètresNoeud";
            this.Text = "ParamètresNoeud";
            ((System.ComponentModel.ISupportInitialize)(this.épaisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkboutonNoeud;
        private System.Windows.Forms.Button CancelBoutonNoeud;
        private System.Windows.Forms.NumericUpDown épaisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel CouleurParamètreNoeud;
        private System.Windows.Forms.ColorDialog boitecouleur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label TexteDuNoeud;
    }
}