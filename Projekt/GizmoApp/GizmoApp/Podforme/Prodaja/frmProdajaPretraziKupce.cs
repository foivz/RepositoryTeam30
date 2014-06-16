using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp.Podforme.Prodaja
{
    public partial class frmProdajaPretraziKupce : Form
    {
        public frmProdajaPretraziKupce()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdajaPretraziKupceDetalji form = new frmProdajaPretraziKupceDetalji();
            form.WindowState = FormWindowState.Normal;
            form.Show();
        }

        private void kupciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kupciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);

        }

        private void frmProdajaPretraziKupce_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga_has_Dobavljaci' table. You can move, or remove it, as needed.
            this.knjiga_has_DobavljaciTableAdapter.Fill(this.gizmoDBDataSet.Knjiga_has_Dobavljaci);
            this.kupciTableAdapter.Fill(this.gizmoDBDataSet.Kupci);
        }

        private void kupciDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKupci.RowCount > 0)
            {
                int IDkupci = int.Parse(dgvKupci.CurrentRow.Cells[0].Value.ToString());
                this.knjiga_has_KupciTableAdapter.FillByKnjigaHasKupac(this.gizmoDBDataSet.Knjiga_has_Kupci, IDkupci);
            }
        }

    
    }
}
