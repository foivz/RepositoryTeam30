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

        private string ime { get; set; }
        private string prezime { get; set; }
        private string OIB { get; set; }
        private string adresa { get; set; }
        private string email { get; set; }
        private string telefon { get; set; }
        private string korisnicko { get; set; }
        private string lozinka { get; set; }
        private string odjel { get; set; }

        public frmAdministracijaUrediZaposlenikaDetalji(int id)
        {
            InitializeComponent();
            this.idZaposlenika = id;

            

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

        private void frmAdministracijaUrediZaposlenikaDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Odjel' table. You can move, or remove it, as needed.
            this.odjelTableAdapter.Fill(this.gizmoDBDataSet.Odjel);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.FillByZaposlenikId(this.gizmoDBDataSet.Zaposlenik, this.idZaposlenika);


            this.ime = txtbxIme.Text;
            this.prezime = txtbxPrezime.Text;
            this.OIB = txtbxOIB.Text;
            this.adresa = txtbxAdresa.Text;
            this.email = txtbxEmail.Text;
            this.telefon = txtbxTelefon.Text;
            this.korisnicko = txtbxKorisnickoIme.Text;
            this.lozinka = txtbxLozinka.Text;
            this.odjel = txtbxOdjel.Text;
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zaposlenikBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            MessageBox.Show("Promjene su uspješno spremljene.","Obavijest");
            this.Close();
        }
        /// <summary>
        /// Funkcija provjerava jesu li podaci promijenjeni.
        /// </summary>
        /// <returns>true - ako su promijenjeni, false - ako nisu promijenjeni</returns>
        private bool isChanged()
        {
            if (this.ime == txtbxIme.Text && this.prezime == txtbxPrezime.Text && this.OIB == txtbxOIB.Text && this.adresa == txtbxAdresa.Text && this.email == txtbxEmail.Text && this.telefon == txtbxTelefon.Text && this.korisnicko == txtbxKorisnickoIme.Text && this.lozinka == txtbxLozinka.Text && this.odjel == txtbxOdjel.Text)
                return false;
            else return true;
        }
    }
}
