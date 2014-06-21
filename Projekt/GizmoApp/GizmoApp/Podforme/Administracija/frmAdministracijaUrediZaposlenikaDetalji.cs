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

    public partial class frmAdministracijaUrediZaposlenikaDetalji : Form
    {
        private int idZaposlenika { get; set; }     
        public frmAdministracijaUrediZaposlenikaDetalji(int id)
        {
            InitializeComponent();
            this.idZaposlenika = id;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdministracijaUrediZaposlenikaDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Odjel' table. You can move, or remove it, as needed.
            this.odjelTableAdapter.Fill(this.gizmoDBDataSet.Odjel);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.FillByZaposlenikId(this.gizmoDBDataSet.Zaposlenik, this.idZaposlenika);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            btnOdustani_Click(sender, e);
        }
    }
}
