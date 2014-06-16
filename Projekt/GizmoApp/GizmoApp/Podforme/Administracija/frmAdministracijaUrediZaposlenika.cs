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

    public partial class frmAdministracijaUrediZaposlenika : Form
    {
        public frmAdministracijaUrediZaposlenika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdministracijaUrediZaposlenikaDetalji forma = new frmAdministracijaUrediZaposlenikaDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
        }

        private void zaposlenikBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);

        }

        private void frmAdministracijaUrediZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Pogled' table. You can move, or remove it, as needed.
            this.pogledTableAdapter.Fill(this.gizmoDBDataSet.Pogled);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Odjel' table. You can move, or remove it, as needed.
            this.odjelTableAdapter.Fill(this.gizmoDBDataSet.Odjel);
            this.zaposlenikTableAdapter.Fill(this.gizmoDBDataSet.Zaposlenik);
        }

        private void dgvZaposlenik_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZaposlenik.RowCount > 0)
            {
                int IDodjel = int.Parse(dgvZaposlenik.CurrentRow.Cells[0].Value.ToString());

                this.odjel_has_PogledTableAdapter.FillByZaposlenikHasPogled(this.gizmoDBDataSet.Odjel_has_Pogled, IDodjel);
            }
        }


    }
}
