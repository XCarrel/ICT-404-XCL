namespace Pizza_Fichier
{
    partial class frmPizza
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
            this.grpPate = new System.Windows.Forms.GroupBox();
            this.optEpaisse = new System.Windows.Forms.RadioButton();
            this.optNormale = new System.Windows.Forms.RadioButton();
            this.optFine = new System.Windows.Forms.RadioButton();
            this.optExtraFine = new System.Windows.Forms.RadioButton();
            this.chkAnchois = new System.Windows.Forms.CheckBox();
            this.chkCapres = new System.Windows.Forms.CheckBox();
            this.chkJambon = new System.Windows.Forms.CheckBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.txtTable = new System.Windows.Forms.TextBox();
            this.cmdCommander = new System.Windows.Forms.Button();
            this.chkCrevettes = new System.Windows.Forms.CheckBox();
            this.grpMozza = new System.Windows.Forms.GroupBox();
            this.optMozzBuff = new System.Windows.Forms.RadioButton();
            this.optMozzMaigre = new System.Windows.Forms.RadioButton();
            this.optMozzNorm = new System.Windows.Forms.RadioButton();
            this.lblRépertoire = new System.Windows.Forms.Label();
            this.cmdRépertoire = new System.Windows.Forms.Button();
            this.txtRépertoire = new System.Windows.Forms.TextBox();
            this.grpPate.SuspendLayout();
            this.grpMozza.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPate
            // 
            this.grpPate.Controls.Add(this.optEpaisse);
            this.grpPate.Controls.Add(this.optNormale);
            this.grpPate.Controls.Add(this.optFine);
            this.grpPate.Controls.Add(this.optExtraFine);
            this.grpPate.Location = new System.Drawing.Point(27, 28);
            this.grpPate.Name = "grpPate";
            this.grpPate.Size = new System.Drawing.Size(96, 116);
            this.grpPate.TabIndex = 0;
            this.grpPate.TabStop = false;
            this.grpPate.Text = "Pâte";
            // 
            // optEpaisse
            // 
            this.optEpaisse.AutoSize = true;
            this.optEpaisse.Location = new System.Drawing.Point(6, 88);
            this.optEpaisse.Name = "optEpaisse";
            this.optEpaisse.Size = new System.Drawing.Size(62, 17);
            this.optEpaisse.TabIndex = 3;
            this.optEpaisse.TabStop = true;
            this.optEpaisse.Text = "Epaisse";
            this.optEpaisse.UseVisualStyleBackColor = true;
            // 
            // optNormale
            // 
            this.optNormale.AutoSize = true;
            this.optNormale.Checked = true;
            this.optNormale.Location = new System.Drawing.Point(6, 65);
            this.optNormale.Name = "optNormale";
            this.optNormale.Size = new System.Drawing.Size(64, 17);
            this.optNormale.TabIndex = 2;
            this.optNormale.TabStop = true;
            this.optNormale.Text = "Normale";
            this.optNormale.UseVisualStyleBackColor = true;
            // 
            // optFine
            // 
            this.optFine.AutoSize = true;
            this.optFine.Location = new System.Drawing.Point(6, 42);
            this.optFine.Name = "optFine";
            this.optFine.Size = new System.Drawing.Size(45, 17);
            this.optFine.TabIndex = 1;
            this.optFine.TabStop = true;
            this.optFine.Text = "Fine";
            this.optFine.UseVisualStyleBackColor = true;
            // 
            // optExtraFine
            // 
            this.optExtraFine.AutoSize = true;
            this.optExtraFine.Location = new System.Drawing.Point(6, 18);
            this.optExtraFine.Name = "optExtraFine";
            this.optExtraFine.Size = new System.Drawing.Size(69, 17);
            this.optExtraFine.TabIndex = 0;
            this.optExtraFine.TabStop = true;
            this.optExtraFine.Text = "Extra-fine";
            this.optExtraFine.UseVisualStyleBackColor = true;
            // 
            // chkAnchois
            // 
            this.chkAnchois.AutoSize = true;
            this.chkAnchois.Location = new System.Drawing.Point(255, 47);
            this.chkAnchois.Name = "chkAnchois";
            this.chkAnchois.Size = new System.Drawing.Size(64, 17);
            this.chkAnchois.TabIndex = 1;
            this.chkAnchois.Text = "Anchois";
            this.chkAnchois.UseVisualStyleBackColor = true;
            // 
            // chkCapres
            // 
            this.chkCapres.AutoSize = true;
            this.chkCapres.Location = new System.Drawing.Point(255, 70);
            this.chkCapres.Name = "chkCapres";
            this.chkCapres.Size = new System.Drawing.Size(59, 17);
            this.chkCapres.TabIndex = 2;
            this.chkCapres.Text = "Câpres";
            this.chkCapres.UseVisualStyleBackColor = true;
            // 
            // chkJambon
            // 
            this.chkJambon.AutoSize = true;
            this.chkJambon.Location = new System.Drawing.Point(255, 94);
            this.chkJambon.Name = "chkJambon";
            this.chkJambon.Size = new System.Drawing.Size(63, 17);
            this.chkJambon.TabIndex = 3;
            this.chkJambon.Text = "Jambon";
            this.chkJambon.UseVisualStyleBackColor = true;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(24, 9);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 13);
            this.lblTable.TabIndex = 4;
            this.lblTable.Text = "Table";
            // 
            // txtTable
            // 
            this.txtTable.Location = new System.Drawing.Point(64, 6);
            this.txtTable.Name = "txtTable";
            this.txtTable.Size = new System.Drawing.Size(30, 20);
            this.txtTable.TabIndex = 6;
            // 
            // cmdCommander
            // 
            this.cmdCommander.Location = new System.Drawing.Point(135, 150);
            this.cmdCommander.Name = "cmdCommander";
            this.cmdCommander.Size = new System.Drawing.Size(79, 23);
            this.cmdCommander.TabIndex = 7;
            this.cmdCommander.Text = "Commander";
            this.cmdCommander.UseVisualStyleBackColor = true;
            this.cmdCommander.Click += new System.EventHandler(this.cmdCommander_Click);
            // 
            // chkCrevettes
            // 
            this.chkCrevettes.AutoSize = true;
            this.chkCrevettes.Location = new System.Drawing.Point(255, 117);
            this.chkCrevettes.Name = "chkCrevettes";
            this.chkCrevettes.Size = new System.Drawing.Size(71, 17);
            this.chkCrevettes.TabIndex = 10;
            this.chkCrevettes.Text = "Crevettes";
            this.chkCrevettes.UseVisualStyleBackColor = true;
            // 
            // grpMozza
            // 
            this.grpMozza.Controls.Add(this.optMozzBuff);
            this.grpMozza.Controls.Add(this.optMozzMaigre);
            this.grpMozza.Controls.Add(this.optMozzNorm);
            this.grpMozza.Location = new System.Drawing.Point(129, 28);
            this.grpMozza.Name = "grpMozza";
            this.grpMozza.Size = new System.Drawing.Size(96, 116);
            this.grpMozza.TabIndex = 11;
            this.grpMozza.TabStop = false;
            this.grpMozza.Text = "Mozzarella";
            // 
            // optMozzBuff
            // 
            this.optMozzBuff.AutoSize = true;
            this.optMozzBuff.Location = new System.Drawing.Point(6, 65);
            this.optMozzBuff.Name = "optMozzBuff";
            this.optMozzBuff.Size = new System.Drawing.Size(70, 17);
            this.optMozzBuff.TabIndex = 2;
            this.optMozzBuff.Text = "Bufflonne";
            this.optMozzBuff.UseVisualStyleBackColor = true;
            // 
            // optMozzMaigre
            // 
            this.optMozzMaigre.AutoSize = true;
            this.optMozzMaigre.Location = new System.Drawing.Point(6, 42);
            this.optMozzMaigre.Name = "optMozzMaigre";
            this.optMozzMaigre.Size = new System.Drawing.Size(57, 17);
            this.optMozzMaigre.TabIndex = 1;
            this.optMozzMaigre.Text = "Maigre";
            this.optMozzMaigre.UseVisualStyleBackColor = true;
            // 
            // optMozzNorm
            // 
            this.optMozzNorm.AutoSize = true;
            this.optMozzNorm.Checked = true;
            this.optMozzNorm.Location = new System.Drawing.Point(6, 19);
            this.optMozzNorm.Name = "optMozzNorm";
            this.optMozzNorm.Size = new System.Drawing.Size(64, 17);
            this.optMozzNorm.TabIndex = 0;
            this.optMozzNorm.TabStop = true;
            this.optMozzNorm.Text = "Normale";
            this.optMozzNorm.UseVisualStyleBackColor = true;
            // 
            // lblRépertoire
            // 
            this.lblRépertoire.AutoSize = true;
            this.lblRépertoire.Location = new System.Drawing.Point(67, 192);
            this.lblRépertoire.Name = "lblRépertoire";
            this.lblRépertoire.Size = new System.Drawing.Size(59, 13);
            this.lblRépertoire.TabIndex = 12;
            this.lblRépertoire.Text = "Répertoire:";
            // 
            // cmdRépertoire
            // 
            this.cmdRépertoire.Location = new System.Drawing.Point(11, 187);
            this.cmdRépertoire.Name = "cmdRépertoire";
            this.cmdRépertoire.Size = new System.Drawing.Size(56, 23);
            this.cmdRépertoire.TabIndex = 13;
            this.cmdRépertoire.Text = "Changer";
            this.cmdRépertoire.UseVisualStyleBackColor = true;
            this.cmdRépertoire.Click += new System.EventHandler(this.cmdRépertoire_Click);
            // 
            // txtRépertoire
            // 
            this.txtRépertoire.Location = new System.Drawing.Point(125, 190);
            this.txtRépertoire.Name = "txtRépertoire";
            this.txtRépertoire.Size = new System.Drawing.Size(230, 20);
            this.txtRépertoire.TabIndex = 14;
            // 
            // frmPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 221);
            this.Controls.Add(this.txtRépertoire);
            this.Controls.Add(this.cmdRépertoire);
            this.Controls.Add(this.lblRépertoire);
            this.Controls.Add(this.grpMozza);
            this.Controls.Add(this.chkCrevettes);
            this.Controls.Add(this.cmdCommander);
            this.Controls.Add(this.txtTable);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.chkJambon);
            this.Controls.Add(this.chkCapres);
            this.Controls.Add(this.chkAnchois);
            this.Controls.Add(this.grpPate);
            this.Name = "frmPizza";
            this.Text = "Pizza";
            this.grpPate.ResumeLayout(false);
            this.grpPate.PerformLayout();
            this.grpMozza.ResumeLayout(false);
            this.grpMozza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPate;
        private System.Windows.Forms.RadioButton optEpaisse;
        private System.Windows.Forms.RadioButton optNormale;
        private System.Windows.Forms.RadioButton optFine;
        private System.Windows.Forms.RadioButton optExtraFine;
        private System.Windows.Forms.CheckBox chkAnchois;
        private System.Windows.Forms.CheckBox chkCapres;
        private System.Windows.Forms.CheckBox chkJambon;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.TextBox txtTable;
        private System.Windows.Forms.Button cmdCommander;
        private System.Windows.Forms.CheckBox chkCrevettes;
        private System.Windows.Forms.GroupBox grpMozza;
        private System.Windows.Forms.RadioButton optMozzBuff;
        private System.Windows.Forms.RadioButton optMozzMaigre;
        private System.Windows.Forms.RadioButton optMozzNorm;
        private System.Windows.Forms.Label lblRépertoire;
        private System.Windows.Forms.Button cmdRépertoire;
        private System.Windows.Forms.TextBox txtRépertoire;
    }
}

