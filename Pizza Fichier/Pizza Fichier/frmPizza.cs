using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pizza_Fichier
{
    public partial class frmPizza : Form
    {
        public frmPizza()
        {
            InitializeComponent();
        }

        private void cmdCommander_Click(object sender, EventArgs e)
        {
            bool Avec = false; // Sera mis à Vrai si des garnitures sont choisies
            string NomF;       // Nom du fichier
            string Commande;   // Contenu de la commande
            StreamWriter Fich;

            // Test du numéro de table
            if (txtTable.Text == "")
            {
                MessageBox.Show("Introduisez un numéro de table");
                return; // sortie du gestionnaire d'événement
            }

            // Test de l'existence du répertoire
            if (!Directory.Exists(txtRépertoire.Text))
            {
                MessageBox.Show("Répertoire inexistant","Commande Pizza",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                return;
            }

            // Construction du nom de fichier
            NomF = "Table " + txtTable.Text.ToString() + ".txt";
            
            // Ouverture du fichier
            Fich = new StreamWriter (txtRépertoire.Text + "\\" + NomF);

            // Texte de base
            Commande = "Pâte ";
            // Pâte
            if (optEpaisse.Checked) Commande = Commande + "épaisse ";
            if (optExtraFine.Checked) Commande = Commande + "extra fine ";
            if (optNormale.Checked) Commande = Commande + "normale ";
            if (optFine.Checked) Commande = Commande + "fine ";
            // Test s'il y a au moins une garniture choisie
            if (chkJambon.Checked || chkCapres.Checked || chkAnchois.Checked || chkCrevettes.Checked)
            {
                Commande = Commande + "avec ";
                Avec = true; // se rappeler qu'une garniture au moins a été choisie
                if (chkAnchois.Checked) Commande = Commande + "anchois, ";
                if (chkCapres.Checked) Commande = Commande + "capres, ";
                if (chkJambon.Checked) Commande = Commande + "jambon, ";
                if (chkCrevettes.Checked) Commande = Commande + "crevettes, ";
                // Supprimer les deux derniers caratères car on a forcément ", " en trop à la fin
                Commande = Commande.Substring(0, Commande.Length - 2);
            }
            // Est-ce qu'une mozzarella spéciale a été sélectionnée
            if (optMozzBuff.Checked || optMozzMaigre.Checked)
            {
                // Choix du texte selon qu'il y avait une garniture ou pas
                if (Avec) Commande = Commande + " et mozzarella";
                else Commande = Commande + " avec mozzarella";
                if (optMozzBuff.Checked) Commande = Commande + " de bufflonne";
                if (optMozzMaigre.Checked) Commande = Commande + " maigre";
            }

            // Ecriture dans le fichier
            Fich.WriteLine(Commande);
            Fich.Close();
            MessageBox.Show("Commande envoyée!");
        }

        private void cmdRépertoire_Click(object sender, EventArgs e)
        {
            // Objet FolderBrowserDialog qui représente la boîte de dialogue
            FolderBrowserDialog Dossier = new FolderBrowserDialog();

            // La méthode ShowDialog ouvre la boîte et retourne une valeur qui indique
            // comment l'utilisateur a refermé la fenêtre. Si c'était "OK", alors on
            // peut reprendre le chemin choisi dans la propriété "SelectedPath"
            if (Dossier.ShowDialog() == DialogResult.OK)
                txtRépertoire.Text = Dossier.SelectedPath;
        }
    }
}
