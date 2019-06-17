namespace ArcheDeNoé
{
    partial class frmNoé
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
            this.lstListeGauche = new System.Windows.Forms.ListBox();
            this.lstListeDroite = new System.Windows.Forms.ListBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdEnlever = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstListeGauche
            // 
            this.lstListeGauche.FormattingEnabled = true;
            this.lstListeGauche.Location = new System.Drawing.Point(23, 34);
            this.lstListeGauche.Name = "lstListeGauche";
            this.lstListeGauche.Size = new System.Drawing.Size(179, 264);
            this.lstListeGauche.Sorted = true;
            this.lstListeGauche.TabIndex = 0;
            // 
            // lstListeDroite
            // 
            this.lstListeDroite.FormattingEnabled = true;
            this.lstListeDroite.Location = new System.Drawing.Point(296, 34);
            this.lstListeDroite.Name = "lstListeDroite";
            this.lstListeDroite.Size = new System.Drawing.Size(179, 264);
            this.lstListeDroite.TabIndex = 1;
            this.lstListeDroite.DoubleClick += new System.EventHandler(this.lstListeDroite_DoubleClick);
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(210, 88);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdAjouter.TabIndex = 2;
            this.cmdAjouter.Text = "===>";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdEnlever
            // 
            this.cmdEnlever.Enabled = false;
            this.cmdEnlever.Location = new System.Drawing.Point(212, 157);
            this.cmdEnlever.Name = "cmdEnlever";
            this.cmdEnlever.Size = new System.Drawing.Size(75, 23);
            this.cmdEnlever.TabIndex = 3;
            this.cmdEnlever.Text = "<===";
            this.cmdEnlever.UseVisualStyleBackColor = true;
            this.cmdEnlever.Click += new System.EventHandler(this.cmdEnlever_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Encore à terre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "A bord";
            // 
            // frmNoé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 336);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdEnlever);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstListeDroite);
            this.Controls.Add(this.lstListeGauche);
            this.Name = "frmNoé";
            this.Text = "Arche de Noé";
            this.Load += new System.EventHandler(this.frmNoé_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstListeGauche;
        private System.Windows.Forms.ListBox lstListeDroite;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdEnlever;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

