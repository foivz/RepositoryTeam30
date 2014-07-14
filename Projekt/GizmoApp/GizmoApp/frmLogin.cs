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
    /// <summary>
    /// Forma za prijavu zaposlenika.
    /// </summary>
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Provjerava da li uneseno korisničko ime i lozinka, postoje unutar baze podataka zaposlenika.
        /// Uspješnom prijavom otvara glavnu formu.
        /// </summary>
        private void Prijava()
        {
            Program.korime = txtbxKorisnickoIme.Text.ToString();
            string lozinka = txtbxLozinka.Text.ToString();

          
            string result = this.zaposlenikTableAdapter1.Login(Program.korime, lozinka).ToString();

            if (result == "")
            {
                MessageBox.Show("Neispravno korisničko ime / lozinka!");
            }
            else
            {
                Program.prijava = true;
                this.Close();
            }
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
