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

    public partial class frmNabavaPretraziDobavljaceDetalji : Form
    {
        private int idDobavljaca { get; set; }
        public frmNabavaPretraziDobavljaceDetalji(int id)
        {
            InitializeComponent();
            this.idDobavljaca = id;
        }

        private void frmNabavaPretraziDobavljaceDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Dobavljaci' table. You can move, or remove it, as needed.
            this.dobavljaciTableAdapter.FillByDobavljacId(this.gizmoDBDataSet.Dobavljaci,this.idDobavljaca);

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dobavljaciBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            this.Close();
        }

    }
}
