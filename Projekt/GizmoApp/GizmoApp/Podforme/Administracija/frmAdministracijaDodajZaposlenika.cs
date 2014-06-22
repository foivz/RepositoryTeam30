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
            
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.gizmoDBDataSet.Zaposlenik);
            zaposlenikBindingSource.AddNew();

        }

        private void btnSpremi_MouseUp(object sender, MouseEventArgs e)
        {
            createNewZaposlenik();
            
        }

        /// <summary>
        /// Provjerava unos podataka i kreira novog zaposlenika.
        /// Uspjesan unos otvora uredivanje zaposlenika.
        /// </summary>
        private void createNewZaposlenik()
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
        }
    }
}
