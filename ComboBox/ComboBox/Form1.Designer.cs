namespace ComboBox
{
    partial class Form1
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
            this.cboDropDown = new System.Windows.Forms.ComboBox();
            this.cboSimple = new System.Windows.Forms.ComboBox();
            this.cboDropdownList = new System.Windows.Forms.ComboBox();
            this.lstChoix = new System.Windows.Forms.ListBox();
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdEffacer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboDropDown
            // 
            this.cboDropDown.FormattingEnabled = true;
            this.cboDropDown.Items.AddRange(new object[] {
            "Bleu",
            "Vert",
            "Jaune",
            "Rouge",
            "Orange"});
            this.cboDropDown.Location = new System.Drawing.Point(32, 36);
            this.cboDropDown.Name = "cboDropDown";
            this.cboDropDown.Size = new System.Drawing.Size(121, 21);
            this.cboDropDown.TabIndex = 0;
            this.cboDropDown.TextChanged += new System.EventHandler(this.cboDropDown_TextChanged);
            // 
            // cboSimple
            // 
            this.cboSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboSimple.FormattingEnabled = true;
            this.cboSimple.Items.AddRange(new object[] {
            "Rond",
            "Carré",
            "Hexagonal",
            "Trapézoïdal",
            "Rectangulaire"});
            this.cboSimple.Location = new System.Drawing.Point(32, 94);
            this.cboSimple.Name = "cboSimple";
            this.cboSimple.Size = new System.Drawing.Size(121, 150);
            this.cboSimple.TabIndex = 1;
            this.cboSimple.TextChanged += new System.EventHandler(this.cboSimple_TextChanged);
            // 
            // cboDropdownList
            // 
            this.cboDropdownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDropdownList.FormattingEnabled = true;
            this.cboDropdownList.Items.AddRange(new object[] {
            "Plat",
            "Enfoncé",
            "Ondulé",
            "Relevé"});
            this.cboDropdownList.Location = new System.Drawing.Point(32, 263);
            this.cboDropdownList.Name = "cboDropdownList";
            this.cboDropdownList.Size = new System.Drawing.Size(121, 21);
            this.cboDropdownList.TabIndex = 2;
            this.cboDropdownList.SelectedIndexChanged += new System.EventHandler(this.cboDropdownList_SelectedIndexChanged);
            // 
            // lstChoix
            // 
            this.lstChoix.FormattingEnabled = true;
            this.lstChoix.Location = new System.Drawing.Point(334, 34);
            this.lstChoix.Name = "lstChoix";
            this.lstChoix.Size = new System.Drawing.Size(120, 173);
            this.lstChoix.TabIndex = 3;
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.Location = new System.Drawing.Point(200, 34);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(75, 23);
            this.cmdAjouter.TabIndex = 4;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(200, 90);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(75, 23);
            this.cmdSupprimer.TabIndex = 5;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            this.cmdSupprimer.Click += new System.EventHandler(this.cmdSupprimer_Click);
            // 
            // cmdEffacer
            // 
            this.cmdEffacer.Location = new System.Drawing.Point(200, 146);
            this.cmdEffacer.Name = "cmdEffacer";
            this.cmdEffacer.Size = new System.Drawing.Size(75, 23);
            this.cmdEffacer.TabIndex = 6;
            this.cmdEffacer.Text = "Effacer";
            this.cmdEffacer.UseVisualStyleBackColor = true;
            this.cmdEffacer.Click += new System.EventHandler(this.cmdEffacer_Click);
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(200, 202);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(75, 23);
            this.cmdQuitter.TabIndex = 7;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            this.cmdQuitter.Click += new System.EventHandler(this.cmdQuitter_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(331, 214);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 13);
            this.lblNombre.TabIndex = 8;
            this.lblNombre.Text = "0 élément(s) dans la liste";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dropdown";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Simple";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "DropdownList";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(329, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Choix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 298);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdEffacer);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdAjouter);
            this.Controls.Add(this.lstChoix);
            this.Controls.Add(this.cboDropdownList);
            this.Controls.Add(this.cboSimple);
            this.Controls.Add(this.cboDropDown);
            this.Name = "Form1";
            this.Text = "Combobox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDropDown;
        private System.Windows.Forms.ComboBox cboSimple;
        private System.Windows.Forms.ComboBox cboDropdownList;
        private System.Windows.Forms.ListBox lstChoix;
        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdEffacer;
        private System.Windows.Forms.Button cmdQuitter;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

