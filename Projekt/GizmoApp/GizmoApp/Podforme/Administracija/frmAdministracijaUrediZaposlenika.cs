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
    /// Forma za prikaz, pretraživanje i mogućnost brisanja zaposlenika.
    /// </summary>
    public partial class frmAdministracijaUrediZaposlenika : Form
    {
        private int idZaposlenik { get; set; }
        public frmAdministracijaUrediZaposlenika()
        {
            InitializeComponent();
        }

        private void frmAdministracijaUrediZaposlenika_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Pogled' table. You can move, or remove it, as needed.
            this.pogledTableAdapter.Fill(this.gizmoDBDataSet.Pogled);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Odjel' table. You can move, or remove it, as needed.
            this.odjelTableAdapter.Fill(this.gizmoDBDataSet.Odjel);
            this.zaposlenikTableAdapter.Fill(this.gizmoDBDataSet.Zaposlenik);
        }

        /// <summary>
        /// Na selekciju zaposlenika dohvaća podatke o njegovom odjelu preko ID-a odjela.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvZaposlenik_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvZaposlenik.RowCount > 0)
            {
                int IDodjel = int.Parse(dgvZaposlenik.CurrentRow.Cells[0].Value.ToString());
                this.idZaposlenik = int.Parse(dgvZaposlenik.CurrentRow.Cells[1].Value.ToString());
                this.odjel_has_PogledTableAdapter.FillByZaposlenikHasPogled(this.gizmoDBDataSet.Odjel_has_Pogled, IDodjel);
            }
        }

        /// <summary>
        /// Na dvoklik pojedinog zaposlenika otvara novu formu za uredivanje tog zaposlenika.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvZaposlenik_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmAdministracijaUrediZaposlenikaDetalji forma = new frmAdministracijaUrediZaposlenikaDetalji(this.idZaposlenik);
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
            frmAdministracijaUrediZaposlenika_Load(sender, e);
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jest li sigurni da želite obrisati odabranog zaposlenika?", "Upozorenje", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.zaposlenikTableAdapter.DeleteZaposlenikId(this.idZaposlenik);
            frmAdministracijaUrediZaposlenika_Load(sender, e);
        }


    }
}
