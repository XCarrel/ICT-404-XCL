using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        String Choix = ""; // Contient le dernier choix qui a été effectué par l'utilisateur

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            int index; // pour parcourir la liste

            if (Choix == "") // Aucun choix n'a été fait avant cet appel
                MessageBox.Show("Faites un choix d'abord");
            else
            {
                // Vérifier s'il est déjà dans la liste
                for (index = 0; index < lstChoix.Items.Count; index++)
                    if (lstChoix.Items[index] == Choix)
                    {
                        MessageBox.Show("Cet élément est déjà dans la liste!");
                        return; // sortie immédiate
                    }
                // Ajout à la liste
                lstChoix.Items.Add(Choix);
                // Mise à jour du compteur
                lblNombre.Text = lstChoix.Items.Count.ToString() + " élément(s) dans la liste";
            }
        }

        private void cboDropDown_TextChanged(object sender, EventArgs e)
        {
            Choix = cboDropDown.Text;
        }

        private void cboSimple_TextChanged(object sender, EventArgs e)
        {
            Choix = cboSimple.Text;
        }

        private void cboDropdownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Choix = cboDropdownList.Text;
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lstChoix.SelectedIndex == -1)
                MessageBox.Show("Sélectionnez un élément à supprimer");
            else
            {
                lstChoix.Items.Remove(lstChoix.SelectedItem);
                // Mise à jour du compteur
                lblNombre.Text = lstChoix.Items.Count.ToString() + " élément(s) dans la liste";
            }
        }

        private void cmdEffacer_Click(object sender, EventArgs e)
        {
            lstChoix.Items.Clear();
            // Mise à jour du compteur
            lblNombre.Text = lstChoix.Items.Count.ToString() + " élément(s) dans la liste";
        }

        private void cmdQuitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment quitter ?",
                                "Quitter",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

    }
}
