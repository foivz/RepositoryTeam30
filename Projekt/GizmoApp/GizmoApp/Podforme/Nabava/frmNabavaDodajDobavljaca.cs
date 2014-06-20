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

    public partial class frmNabavaDodajDobavljaca : Form
    {
        public frmNabavaDodajDobavljaca()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNabavaDodajDobavljaca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.Fill(this.gizmoDBDataSet.Dobavljaci);
            dobavljaciBindingSource.AddNew();

        }

        private void btnSpremi_MouseUp(object sender, MouseEventArgs e)
        {
            createNewDobavljac();
            
        }

        /// <summary>
        /// Provjerava unos podataka i kreira novog dobavljaca.
        /// Uspjesan unos otvora pretrazivanje dobavljaca.
        /// </summary>
        private void createNewDobavljac()
        {
            this.Validate();
            try
            {
                this.dobavljaciBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
                MessageBox.Show("Uspjesan unos dobavljaca.");
                this.Close();

                Podforme.Nabava.frmNabavaPretraziDobavljace frmNabavaPretraziDobavljace = new Podforme.Nabava.frmNabavaPretraziDobavljace();
                frmNabavaPretraziDobavljace.WindowState = FormWindowState.Normal;
                frmNabavaPretraziDobavljace.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Nepravilan unos podatka!");
                //MessageBox.Show(error.ToString());
            }
        }
    }
}
