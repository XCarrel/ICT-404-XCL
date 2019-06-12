using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciceBonjour
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblError.Text = "Bonjour";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdError_Click(object sender, EventArgs e)
        {
            lblError.Visible = true;
            MessageBox.Show("ERREUR","Toto");
        }
    }
}
