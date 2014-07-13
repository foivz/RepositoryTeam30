using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp.Podforme.Nabava
{
    /// <summary>
    /// Forma za pretraživanje i prikaz dobavljača i informacija o nabavljenim knjigama od strane istog.
    /// </summary>
    public partial class frmNabavaPretraziDobavljace : Form
    {
        private int idDobavljac { get; set; }
        public frmNabavaPretraziDobavljace()
        {
            InitializeComponent();
        }
   

        private void frmNabavaPretraziDobavljace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.gizmoDBDataSet.Zaposlenik);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga_has_Dobavljaci' table. You can move, or remove it, as needed.
            this.knjiga_has_DobavljaciTableAdapter.Fill(this.gizmoDBDataSet.Knjiga_has_Dobavljaci);
            this.dobavljaciTableAdapter.Fill(this.gizmoDBDataSet.Dobavljaci);
        }

        /// <summary>
        /// Na selekciju dobavljaca dohvaća podatke o isporučenim knjigama pomoću ID-a dobavljaća.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDobavljaci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDobavljaci.RowCount > 0)
            {
                this.idDobavljac = int.Parse(dgvDobavljaci.CurrentRow.Cells[0].Value.ToString());
                this.knjiga_has_DobavljaciTableAdapter.FillByKnjigaHasDobavljaci(this.gizmoDBDataSet.Knjiga_has_Dobavljaci, this.idDobavljac);
            }
        }

        /// <summary>
        /// Dvoklikom na dobavljaća otvara se forma koja omogućuje uređivanje istog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDobavljaci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmNabavaPretraziDobavljaceDetalji forma = new frmNabavaPretraziDobavljaceDetalji(this.idDobavljac);
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
            frmNabavaPretraziDobavljace_Load(sender, e);
        }
    }
}
