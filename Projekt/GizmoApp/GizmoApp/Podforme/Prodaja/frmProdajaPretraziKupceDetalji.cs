﻿using System;
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
    /// <summary>
    /// Forma za izmjenu podataka o kupcu odabranom dvoklikom sa forme Pretrazi Kupce.
    /// </summary>
    public partial class frmProdajaPretraziKupceDetalji : Form
    {

        private int idKupca { get; set; }
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

        private void frmProdajaPretraziKupceDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Kupci' table. You can move, or remove it, as needed.
            this.kupciTableAdapter.FillByKupacId(this.gizmoDBDataSet.Kupci, idKupca);

            this.naziv = this.txtbxNaziv.Text;
            this.adresa = this.txtbxAdresa.Text;
            this.oib = this.txtbxOIB.Text;
            this.telefon = this.txtbxTelefon.Text;
            this.email = this.txtbxEmail.Text;

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
            this.kupciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            MessageBox.Show("Promjene su uspješno spremljene.", "Obavijest");
            this.Close();
        }

        private bool isChanged()
        {
            if (this.naziv == this.txtbxNaziv.Text && this.adresa == this.txtbxAdresa.Text && this.oib == this.txtbxOIB.Text && this.telefon == this.txtbxTelefon.Text && this.email == this.txtbxEmail.Text)
            {
               return false;
            }
            else return true;
        }

       
    }
}
