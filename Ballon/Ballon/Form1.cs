using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ballon
{
    public partial class frmBallon : Form
    {
        public frmBallon()
        {
            InitializeComponent();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            Random Alea = new Random(); // Création d'un objet Random
            // Positionnement du ballon. Les bornes utilisées avec Alea tiennent compte
            // des dimensions du formulaire et du ballon
            pctBallon.SetBounds(Alea.Next(0, this.Size.Width - pctBallon.Size.Width),
                                 Alea.Next(50, this.Size.Height - pctBallon.Size.Height),
                                 pctBallon.Size.Width,
                                 pctBallon.Size.Height);
            pctBallon.Visible = true; // Montrer le ballon
            tmrTicTac.Enabled = true; // Le mettre en mouvement
        }

        private void tmrTicTac_Tick(object sender, EventArgs e)
        {
            if (pctBallon.Location.Y > 0) // le ballon n'est pas encore arrivé en haut
                pctBallon.SetBounds(pctBallon.Location.X, pctBallon.Location.Y - 1,
                                    pctBallon.Size.Width, pctBallon.Size.Height);
            else // il est arrivé en haut
                tmrTicTac.Enabled = false;
        }

    }
}
