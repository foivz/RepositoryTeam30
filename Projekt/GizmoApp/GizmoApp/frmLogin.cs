using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Prijava()
        {
            GizmoApp.Program.prijava = true;

            string korime = txtboxKorisnickoIme.Text.ToString();
            string lozinka = txtboxLozinka.Text.ToString();

            MessageBox.Show("Korime: " + korime + "\n" + "Lozinka: " + lozinka);

            //provjera login podataka, zatim close
            this.Close();
        }

        private void btnPrijaviSe_MouseUp(object sender, MouseEventArgs e)
        {

            Prijava();
        }

        private void txtboxKorisnickoIme_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prijava();
            }
        }

        private void txtboxLozinka_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prijava();
            }
        }
                
    }
}
