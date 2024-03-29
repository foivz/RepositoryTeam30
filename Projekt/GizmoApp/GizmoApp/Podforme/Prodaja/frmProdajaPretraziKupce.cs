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
    /// Forma za pretraživanje i prikaz podataka o kupci i pripadnih kupljenih knjiga od strane istog.
    /// </summary>
    public partial class frmProdajaPretraziKupce : Form
    {
        private int idKupca{get; set;}

        public frmProdajaPretraziKupce()
        {
            InitializeComponent();

        }

        private void frmProdajaPretraziKupce_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.gizmoDBDataSet.Zaposlenik);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga_has_Kupci' table. You can move, or remove it, as needed.
            this.knjiga_has_KupciTableAdapter.Fill(this.gizmoDBDataSet.Knjiga_has_Kupci);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            this.kupciTableAdapter.Fill(this.gizmoDBDataSet.Kupci);
        }


        /// <summary>
        /// Dohvaća podatke o kupljenim knjigama od strane kupca pomoću ID-a kupca.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dvgKupci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKupci.RowCount > 0)
            {
                this.idKupca = int.Parse(dgvKupci.CurrentRow.Cells[0].Value.ToString());
                this.knjiga_has_KupciTableAdapter.FillByKnjigaHasKupac(this.gizmoDBDataSet.Knjiga_has_Kupci, this.idKupca);
            }
        }

        /// <summary>
        /// Dvoklikom na kupca otvara formu za uređivanje podataka o kupcu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvKupci_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmProdajaPretraziKupceDetalji form = new frmProdajaPretraziKupceDetalji(this.idKupca);
            form.WindowState = FormWindowState.Normal;
            form.ShowDialog();
            frmProdajaPretraziKupce_Load(sender, e);
        }

        
    
    }
}
