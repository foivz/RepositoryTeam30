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
    /// Forma za dodavanje nove knjige u bazu podataka o knjigama.
    /// </summary>
    public partial class frmNabavaDodajKnjigu : Form
    {
        public frmNabavaDodajKnjigu()
        {
            InitializeComponent();
        }


        private void frmNabavaDodajKnjigu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Kategorija' table. You can move, or remove it, as needed.
            this.kategorijaTableAdapter.Fill(this.gizmoDBDataSet.Kategorija);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Kategorija_has_Knjiga' table. You can move, or remove it, as needed.
            this.kategorija_has_KnjigaTableAdapter.Fill(this.gizmoDBDataSet.Kategorija_has_Knjiga);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);
            knjigaBindingSource.AddNew();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            createNewKnjiga();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Provjerava unos podataka i služi za unos nove knjige.
        /// </summary>
        private void createNewKnjiga()
        {
            this.Validate();
            try
            {
                this.knjigaBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
                MessageBox.Show("Uspješan unos knjige.");
                this.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Nepravilan unos podatka!");
            }
        }
    }
}
