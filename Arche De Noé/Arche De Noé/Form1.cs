using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArcheDeNoé
{
    public partial class frmNoé : Form
    {
        public frmNoé()
        {
            InitializeComponent();
        }

        private void Transfert(ref ListBox Source, ref ListBox Dest, int index)
        // Fonction pouvant être utilisée pour aller dans un sens ou dans l'autre
        {
            if ((index > Source.Items.Count) || (index < 0)) // index invalide
                return;

            Dest.Items.Add(Source.Items[index]); // Ajout de l'élément sélectionné
            Source.Items.RemoveAt(index); // Suppression de l'élément sélectionné
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            int Sel = lstListeGauche.SelectedIndex; // l'élément sélectionné
            if (Sel == -1) // Aucun animal sélectionné
                MessageBox.Show("Sélectionnez un animal");
            else
            {
                Transfert(ref lstListeGauche, ref lstListeDroite,Sel);

                // Sélectionner la position libérée
                if (Sel >= lstListeGauche.Items.Count) // L'élément transféré était le dernier
                    lstListeGauche.SelectedIndex = lstListeGauche.Items.Count - 1;
                else
                    lstListeGauche.SelectedIndex = Sel;

                // Gérer l'activation des boutons
                cmdEnlever.Enabled = true; // On a de toute façon quelquechose à droite
                if (lstListeGauche.Items.Count == 0) cmdAjouter.Enabled = false;
            }
        }

        private void cmdEnlever_Click(object sender, EventArgs e)
        {
            int Sel = lstListeDroite.SelectedIndex; // l'élément sélectionné
            if (Sel == -1)
                MessageBox.Show("Sélectionnez un animal");
            else
            {
                Transfert(ref lstListeDroite, ref lstListeGauche, Sel);

                // Sélectionner la position libérée
                if (Sel >= lstListeDroite.Items.Count) // L'élément transféré était le dernier
                    lstListeDroite.SelectedIndex = lstListeDroite.Items.Count - 1;
                else
                    lstListeDroite.SelectedIndex = Sel;

                // Gérer l'activation des boutons
                cmdAjouter.Enabled = true;// On a de toute façon quelquechose à gauche
                if (lstListeDroite.Items.Count == 0) cmdEnlever.Enabled = false;
            }
        }

        private void lstListeDroite_DoubleClick(object sender, EventArgs e)
        {
            // On se contente de faire comme si l'application démarrait
            frmNoé_Load(sender, e);
        }

        private void frmNoé_Load(object sender, EventArgs e)
        {
            // Initialisation des deux listes
            cmdAjouter.Enabled = true;
            cmdEnlever.Enabled = false;
            lstListeDroite.Items.Clear();
            lstListeGauche.Items.Clear();
            lstListeGauche.Items.Add("Araignée");
            lstListeGauche.Items.Add("Chat");
            lstListeGauche.Items.Add("Cheval");
            lstListeGauche.Items.Add("Chien");
            lstListeGauche.Items.Add("Cobra");
            lstListeGauche.Items.Add("Coccinelle");
            lstListeGauche.Items.Add("Kangourou");
            lstListeGauche.Items.Add("Perroquet");
            lstListeGauche.Items.Add("Rat");
            lstListeGauche.Items.Add("Ver de terre");
        }

    }
}
