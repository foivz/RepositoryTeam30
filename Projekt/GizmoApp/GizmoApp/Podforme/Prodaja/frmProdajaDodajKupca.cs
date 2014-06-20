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
    
    public partial class frmProdajaDodajKupca : Form
    {
        public frmProdajaDodajKupca()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProdajaDodajKupca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Kupci' table. You can move, or remove it, as needed.
            this.kupciTableAdapter.Fill(this.gizmoDBDataSet.Kupci);
            kupciBindingSource.AddNew();

        }

        private void btnSpremi_MouseUp(object sender, MouseEventArgs e)
        {
            createNewKupac();
            
        }

        /// <summary>
        /// Provjerava unos podataka i služi za unos novog kupca.
        /// </summary>
        private void createNewKupac()
        {
            this.Validate();
            try
            {
                this.kupciBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
                MessageBox.Show("Uspjesan unos kupca.");
                this.Close();

                Podforme.Prodaja.frmProdajaPretraziKupce frmProdajaPretraziKupce = new Podforme.Prodaja.frmProdajaPretraziKupce();
                frmProdajaPretraziKupce.WindowState = FormWindowState.Normal;
                frmProdajaPretraziKupce.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Nepravilan unos podatka!");   
                //MessageBox.Show(error.ToString());
            }             
        }

        


    }
}
