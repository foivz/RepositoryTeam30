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
    /// Forma za uređivanje podataka o dobavljaču, odabranom dvoklikom sa forme Pretraži dobavljače.
    /// </summary>
    public partial class frmNabavaPretraziDobavljaceDetalji : Form
    {
        private int idDobavljaca { get; set; }

        private string naziv { get; set; }
        private string adresa { get; set; }
        private string oib { get; set; }
        private string telefon { get; set; }
        private string email { get; set; }

        public frmNabavaPretraziDobavljaceDetalji(int id)
        {
            InitializeComponent();
            this.idDobavljaca = id;

            
        }

        private void frmNabavaPretraziDobavljaceDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.FillByDobavljacId(this.gizmoDBDataSet.Dobavljaci,this.idDobavljaca);

            this.naziv = txtbxNaziv.Text;
            this.adresa = txtbxAdresa.Text;
            this.oib = txtbxOIB.Text;
            this.telefon = txtbxTelefon.Text;
            this.email = txtbxEmail.Text;
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

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dobavljaciBindingSource.EndEdit();
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
            if (this.naziv == txtbxNaziv.Text && this.adresa == txtbxAdresa.Text && this.oib == txtbxOIB.Text && this.telefon == txtbxTelefon.Text && this.email == txtbxEmail.Text)
                return false;
            return true;
        }

    }
}
