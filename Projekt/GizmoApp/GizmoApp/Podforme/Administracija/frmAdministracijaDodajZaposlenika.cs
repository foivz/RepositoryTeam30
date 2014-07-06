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
    public partial class frmAdministracijaDodajZaposlenika : Form
    {
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

            slojBaze.osvjeziNovo(this.gizmoDBDataSet.Zaposlenik, zaposlenikTableAdapter, zaposlenikBindingSource);
        }

        private void btnSpremi_MouseUp(object sender, MouseEventArgs e)
        {
            slojBaze.insert(this, zaposlenikBindingSource, tableAdapterManager, gizmoDBDataSet);
            
        }

        private void txtbxIme_Leave(object sender, EventArgs e)
        {
            slojKontrole.dodjeliKontrolu(txtbxIme);
        }

        private void txtbxPrezime_Leave(object sender, EventArgs e)
        {
            slojKontrole.dodjeliKontrolu(txtbxPrezime);
        }

        private void txtbxOIB_Leave(object sender, EventArgs e)
        {
            slojKontrole.dodjeliKontrolu(txtbxOIB);
        }

        private void txtbxEmail_Leave(object sender, EventArgs e)
        {
            slojKontrole.dodjeliKontrolu(txtbxEmail);
        }

        private void txtbxTelefon_Leave(object sender, EventArgs e)
        {
            slojKontrole.dodjeliKontrolu(txtbxTelefon);
        }

        private void txtbxKorisnickoIme_Leave(object sender, EventArgs e)
        {
            slojKontrole.dodjeliKontrolu(txtbxKorisnickoIme);
        }

        private void fillByOdjelToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.zaposlenikTableAdapter.FillByOdjel(this.gizmoDBDataSet.Zaposlenik);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

       

        /// <summary>
        /// Provjerava unos podataka i kreira novog zaposlenika.
        /// Uspjesan unos otvora uredivanje zaposlenika.
        /// </summary>
      /*  private void createNewZaposlenik()
        {
            this.Validate();
            try
            {
                this.zaposlenikBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
                MessageBox.Show("Uspjesan unos zaposlenika.");
                this.Close();

                Podforme.Administracija.frmAdministracijaUrediZaposlenika frmAdministracijaUrediZaposlenika = new Podforme.Administracija.frmAdministracijaUrediZaposlenika();
                frmAdministracijaUrediZaposlenika.WindowState = FormWindowState.Normal;
                frmAdministracijaUrediZaposlenika.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Nepravilan unos podatka!");
                //MessageBox.Show(error.ToString());
            }
        }*/
    }
}
