using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// Application ListeDeCourses: permet de créer et imprimer une liste de courses
// Auteur: X. Carrel
// Date: 12.11.2013

namespace ListeCourses
{
    public partial class frmCourses : Form
    {
        public frmCourses()
        {
            InitializeComponent();
        }

        private void frmCourses_Load(object sender, EventArgs e)
        {
            // Initialisation de la liste d'articles
            cboArticle.Items.Add("Pain");
            cboArticle.Items.Add("Beurre");
            cboArticle.Items.Add("Lait");
            cboArticle.Items.Add("Confiture");
            cboArticle.Items.Add("Fromage");
            cboArticle.Items.Add("Oeufs");
            cboArticle.Items.Add("Farine");
            cboArticle.Items.Add("Sucre");
            cboArticle.Items.Add("Viande");
        }

        private void cmdAjouter_Click(object sender, EventArgs e)
        {
            int quantité;

            if (cboArticle.Text == "") // Pas d'article sélectionné
            {
                MessageBox.Show("Sélectionnez un article");
                return;
            }

            if (int.TryParse(txtQuantité.Text, out quantité)) // Le champ est bien numérique
            {
                lstCourses.Items.Add(cboArticle.Text + ": " + quantité.ToString());
                // On n'efface l'article que s'il avait été sélectionné (et pas édité)
                if (cboArticle.SelectedIndex != -1) cboArticle.Items.Remove(cboArticle.SelectedItem);
                // Remise à zéro des champs
                cboArticle.Text = "";
                txtQuantité.Text = "";
            }
            else // Champ non numérique ou vide
                MessageBox.Show("Introduisez une quantité");
        }

        private void cmdSupprimer_Click(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex == -1) // Pas d'article sélectionné
                MessageBox.Show("Sélectionnez un article à supprimer");
            else
                lstCourses.Items.Remove(lstCourses.SelectedItem);
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimer");
        }


    }
}
