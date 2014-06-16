﻿using System;
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

    public partial class frmNabavaPretraziDobavljace : Form
    {
        public frmNabavaPretraziDobavljace()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNabavaPretraziDobavljaceDetalji forma = new frmNabavaPretraziDobavljaceDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
        }

        private void dobavljaciBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dobavljaciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);

        }

        private void frmNabavaPretraziDobavljace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga_has_Dobavljaci' table. You can move, or remove it, as needed.
            this.knjiga_has_DobavljaciTableAdapter.Fill(this.gizmoDBDataSet.Knjiga_has_Dobavljaci);
            this.dobavljaciTableAdapter.Fill(this.gizmoDBDataSet.Dobavljaci);
        }

        private void dgvDobavljaci_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDobavljaci.RowCount > 0)
            {
                int IDdobavljaci = int.Parse(dgvDobavljaci.CurrentRow.Cells[0].Value.ToString());
                this.knjiga_has_DobavljaciTableAdapter.FillByKnjigaHasDobavljaci(this.gizmoDBDataSet.Knjiga_has_Dobavljaci, IDdobavljaci);
            }
        }
    }
}
