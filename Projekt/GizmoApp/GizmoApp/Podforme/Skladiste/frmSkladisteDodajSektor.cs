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
    /// Forma za dodavanje novog sektora skladišta određenog kapaciteta.
    /// </summary>
    public partial class frmSkladisteDodajSektor : Form
    {
        public frmSkladisteDodajSektor()
        {
            InitializeComponent();
        }

        private void frmSkladisteDodajSektor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Sektor_skladista' table. You can move, or remove it, as needed.
            this.sektor_skladistaTableAdapter.Fill(this.gizmoDBDataSet.Sektor_skladista);
            sektor_skladistaBindingSource.AddNew();
        }     

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtbxKapacitet.Text) > 0)
            {
                createNewSektor();
            }
            else
            {
                MessageBox.Show("Kapacitet ne može biti negativan");
            }
        }

        /// <summary>
        /// Provjerava unos podataka i služi za unos novog sektora skladišta.
        /// </summary>
        private void createNewSektor()
        {
            this.Validate();
            try
            {
                this.sektor_skladistaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
                MessageBox.Show("Uspješan unos novog sektora.");
                this.Close();

                Podforme.Skladiste.frmSkladistePretrazi frmSkladistePretrazi = new Podforme.Skladiste.frmSkladistePretrazi();
                frmSkladistePretrazi.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Nepravilan unos podatka!");
            }
        }
    }

}
