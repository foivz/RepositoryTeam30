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
        private int idSkladista { get; set; }
        public frmSkladistePretrazi()
        {
            InitializeComponent();
        }

        private void frmSkladistePretrazi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            this.sektor_skladistaTableAdapter.Fill(this.gizmoDBDataSet.Sektor_skladista);

        }

        /// <summary>
        /// Dohvaća podatke o uskladištenim knjigama u određenom sektoru pomoću ID-a skladišta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSektorSkladista_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSektorSkladista.RowCount > 0)
            {
                this.idSkladista = int.Parse(dgvSektorSkladista.CurrentRow.Cells[0].Value.ToString());

                this.knjiga_has_Sektor_skladistaTableAdapter.FillBySektor_skladista_idSektor_skladista(this.gizmoDBDataSet.Knjiga_has_Sektor_skladista,this.idSkladista);

                txtbxKapacitetSektora.Text = dgvSektorSkladista.CurrentRow.Cells[1].Value.ToString();

                int kolicina = 0;

                for (int i = 0; i < dgvKnjigaHasSektorSkladista.RowCount; i++)
                {
                    kolicina += int.Parse(dgvKnjigaHasSektorSkladista.Rows[i].Cells[2].Value.ToString());
                }

                txtbxKolicinaNaSektoru.Text = kolicina.ToString();               

                txtbxSlobodno.Text = (int.Parse(dgvSektorSkladista.CurrentRow.Cells[1].Value.ToString()) - kolicina).ToString();

                upozerenjeSkladiste(kolicina);
            }
        }

        /// <summary>
        /// Provjerava popunjenost skladišta, bojom signalizira  stanje skladišta.
        /// </summary>
        /// <param name="kolicina"></param>
        private void upozerenjeSkladiste(int kolicina)
        {
            if ((int.Parse(dgvSektorSkladista.CurrentRow.Cells[1].Value.ToString()) - kolicina) > 100)
            {
                txtbxSlobodno.BackColor = Color.LightGreen;
            }
            else
            {
                txtbxSlobodno.BackColor = Color.Orange;
            }
        }

        /// <summary>
        /// Dovklikom na sektor otvara mogućnost uređivanja podataka o sektoru.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSektorSkladista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmSkladistePretraziDetalji forma = new frmSkladistePretraziDetalji(this.idSkladista);
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
            frmSkladistePretrazi_Load(sender, e);
        }

    }
}
