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
    public partial class frmProdajaPretraziKupceDetalji : Form
    {
        public bool promjena { get; set; }
        private int idKupca { get; set; }
        public bool uredi { get; set; }

        private string naziv;
        private string oib;
        private string adresa;
        private string telefon;
        private string email;

        public frmProdajaPretraziKupceDetalji(int id)
        {
            InitializeComponent();
            this.idKupca = id;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            /*bool stanje = isChanged();
            if (stanje) MessageBox.Show("Promijenili ste neke podatke. Želite li ");
            else */this.Close();

        }

        private void frmProdajaPretraziKupceDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Kupci' table. You can move, or remove it, as needed.
            this.kupciTableAdapter.FillByKupacId(this.gizmoDBDataSet.Kupci, idKupca);

            this.naziv = this.txtNaziv.Text;
            this.adresa = this.txtAdresa.Text;
            this.oib = this.txtOIB.Text;
            this.telefon = this.txtTelefon.Text;
            this.email = this.txtEmail.Text;

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kupciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            this.Close();
        }

        private bool isChanged()
        {
            if (this.naziv == this.txtNaziv.Text && this.adresa == this.txtAdresa.Text && this.oib == this.txtOIB.Text && this.telefon == this.txtTelefon.Text && this.email == this.txtEmail.Text)
            {
               return false;
            }
            else return true;
        }
    }
}
