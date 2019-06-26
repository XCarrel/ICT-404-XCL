using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

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
            cmdAjouter.Enabled = false;
            cmdEnlever.Enabled = false;
            lstListeDroite.Items.Clear();
            lstListeGauche.Items.Clear();

            StreamReader F = new StreamReader("C:\\Temp\\ATerre.txt");
            while (!F.EndOfStream)
            {
                string L = F.ReadLine();
                lstListeGauche.Items.Add(L);
            }
            F.Close();
            // On doit peut-être changer l'état des boutons
            if (lstListeGauche.Items.Count > 0) cmdAjouter.Enabled = true;

            F = new StreamReader("C:\\Temp\\ABord.txt");
            while (!F.EndOfStream)
            {
                string L = F.ReadLine();
                lstListeDroite.Items.Add(L);
            }
            F.Close();
            // On doit peut-être changer l'état des boutons
            if (lstListeDroite.Items.Count > 0) cmdEnlever.Enabled = true;
        }

        private void frmNoé_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ecriture liste gauche avec une boucle foreach
            StreamWriter F = new StreamWriter("C:\\Temp\\ATerre.txt");
            foreach (string E in lstListeGauche.Items)
                F.WriteLine(E);
            F.Close();

            // Ecriture liste droite avec une boucle for "standard"
            F = new StreamWriter("C:\\Temp\\ABord.txt");
            for (int i = 0; i < lstListeDroite.Items.Count; i++)
                F.WriteLine(lstListeDroite.Items[i]);
            F.Close();
        }

    }
}
