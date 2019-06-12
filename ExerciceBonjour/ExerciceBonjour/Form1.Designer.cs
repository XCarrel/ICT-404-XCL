namespace ExerciceBonjour
{
    partial class Formulaire
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
            this.lblError = new System.Windows.Forms.Label();
            this.cmdError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(195, 64);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(53, 13);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "ERREUR";
            this.lblError.Visible = false;
            // 
            // cmdError
            // 
            this.cmdError.Location = new System.Drawing.Point(319, 148);
            this.cmdError.Name = "cmdError";
            this.cmdError.Size = new System.Drawing.Size(138, 23);
            this.cmdError.TabIndex = 1;
            this.cmdError.Text = "Montrer l\'erreur";
            this.cmdError.UseVisualStyleBackColor = true;
            this.cmdError.Click += new System.EventHandler(this.cmdError_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdError);
            this.Controls.Add(this.lblError);
            this.Name = "Formulaire";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button cmdError;
    }
}

