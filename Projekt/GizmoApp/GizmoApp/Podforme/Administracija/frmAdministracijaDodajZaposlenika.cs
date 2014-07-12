using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp.Podforme.Administracija
{
    /// <summary>
    /// Forma za dodavanje novog zaposlenika.
    /// </summary>
    /// 

    public partial class frmAdministracijaDodajZaposlenika : Form
    {
        /// <summary>
        /// Varijabla za kontrolu jel se radi o upisivanju ili brisanju, za telefonski broj.
        /// </summary>
        public bool upisivanje;
        /// <summary>
        /// Vaarijabla za kontorlu broja znakova telefonskog broja.
        /// </summary>
        public int duljina = 0;

        /// <summary>
        /// Forma za dodavanje zaposlenika
        /// </summary>
        public frmAdministracijaDodajZaposlenika()
        {
            InitializeComponent();
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdministracijaDodajZaposlenika_Load(object sender, EventArgs e)
        {

            slojBaze.osvjezi(this.gizmoDBDataSet.Zaposlenik, zaposlenikTableAdapter, zaposlenikBindingSource);
            slojBaze.osvjezi(this.gizmoDBDataSet.Odjel, odjelTableAdapter);
        }

        private void btnSpremi_MouseUp(object sender, MouseEventArgs e)
        {
            slojBaze.insert(zaposlenikBindingSource, tableAdapterManager, gizmoDBDataSet);
            MessageBox.Show(slojKontrole.poruka(slojBaze.uspjesno));
            if (slojBaze.uspjesno) this.Close();
        }

        private void txtbxIme_Leave(object sender, EventArgs e)
        {
            Generalno.izvrsiKontrolu(txtbxIme);
        }

        private void txtbxPrezime_Leave(object sender, EventArgs e)
        {
            Generalno.izvrsiKontrolu(txtbxPrezime);
        }

        private void txtbxOIB_Leave(object sender, EventArgs e)
        {
            Generalno.izvrsiKontrolu(txtbxOIB);
        }

        private void txtbxEmail_Leave(object sender, EventArgs e)
        {
            Generalno.izvrsiKontrolu(txtbxEmail);
        }

        private void txtbxTelefon_Leave(object sender, EventArgs e)
        {
            Generalno.izvrsiKontrolu(txtbxTelefon);
        }

        private void txtbxKorisnickoIme_Leave(object sender, EventArgs e)
        {
            Generalno.izvrsiKontrolu(txtbxKorisnickoIme);
        }
        private void txtbxTelefon_TextChanged(object sender, EventArgs e)
        {
            if (duljina < txtbxTelefon.TextLength)
            {
                upisivanje = true;
            }
            else upisivanje = false;
            if (txtbxTelefon.TextLength == 3 && upisivanje)
            {
                txtbxTelefon.Text += "-";
                txtbxTelefon.Select(txtbxTelefon.TextLength, 0);
            }
            duljina = txtbxTelefon.TextLength;
        }

    }
}
