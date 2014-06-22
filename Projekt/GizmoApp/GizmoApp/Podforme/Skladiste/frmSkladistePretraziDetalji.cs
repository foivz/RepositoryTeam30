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
    /// <summary>
    /// Forma za uređivanje sektora skladišta koji je odabran dvoklikom na formi Skladište pretraži.
    /// </summary>
    public partial class frmSkladistePretraziDetalji : Form
    {
        private int idSkladista { get; set; }

        private string kapacitet { get; set; }

        public frmSkladistePretraziDetalji(int id)
        {
            InitializeComponent();
            this.idSkladista = id;

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            if (isChanged())
            {
                DialogResult odg = MessageBox.Show("Promjenjeni su podaci. Želite li ih spremiti", "Upozorenje", MessageBoxButtons.YesNo);
                if (odg == DialogResult.Yes) btnSpremi_Click(sender, e);
                else this.Close();
            }
            this.Close();
        }

        private void frmSkladistePretraziDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Sektor_skladista' table. You can move, or remove it, as needed.
            this.sektor_skladistaTableAdapter.FillBySkladisteId(this.gizmoDBDataSet.Sektor_skladista, this.idSkladista);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);

            this.kapacitet = txtbxKapacitet.Text;

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sektor_skladistaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            MessageBox.Show("Promjene su uspješno spremljene.", "Obavijest");
            this.Close();
        }
        /// <summary>
        /// Funkcija provjerava jesu li podaci promijenjeni.
        /// </summary>
        /// <returns>true - ako su promijenjeni, false - ako nisu promijenjeni</returns>
        private bool isChanged()
        {
            if (this.kapacitet == txtbxKapacitet.Text)
                return false;
            return true;
        }

        
    }
}
