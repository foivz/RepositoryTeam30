using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp.Podforme.Skladiste
{
    public partial class frmSkladistePretrazi : Form
    {
        public frmSkladistePretrazi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSkladistePretraziDetalji forma = new frmSkladistePretraziDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
        }

        private void sektor_skladistaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sektor_skladistaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);

        }

        private void frmSkladistePretrazi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            this.sektor_skladistaTableAdapter.Fill(this.gizmoDBDataSet.Sektor_skladista);

        }

        private void dgvSektorSkladista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSektorSkladista.RowCount > 0)
            {
                int SkladisteID = int.Parse(dgvSektorSkladista.CurrentRow.Cells[0].Value.ToString());

                this.knjiga_has_Sektor_skladistaTableAdapter.FillBySektor_skladista_idSektor_skladista(this.gizmoDBDataSet.Knjiga_has_Sektor_skladista,SkladisteID);

                txtbxKapacitetSektora.Text = dgvSektorSkladista.CurrentRow.Cells[1].Value.ToString();

                int kolicina = 0;

                for (int i = 0; i < dgvKnjigaHasSektorSkladista.RowCount; i++)
                {
                    kolicina += int.Parse(dgvKnjigaHasSektorSkladista.Rows[i].Cells[2].Value.ToString());
                }

                txtbxKolicinaNaSektoru.Text = kolicina.ToString();               

                txtbxSlobodno.Text = (int.Parse(dgvSektorSkladista.CurrentRow.Cells[1].Value.ToString()) - kolicina).ToString();

                if ((int.Parse(dgvSektorSkladista.CurrentRow.Cells[1].Value.ToString()) - kolicina) > 50)
                {
                    txtbxSlobodno.BackColor = Color.LightGreen;
                }
                else
                {
                    txtbxSlobodno.BackColor = Color.Orange;
                }
            }
        }
    }
}
