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
    public partial class frmSkladistePretraziDetalji : Form
    {
        private int idSkladista { get; set; }
        public frmSkladistePretraziDetalji(int id)
        {
            InitializeComponent();
            this.idSkladista = id;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSkladistePretraziDetalji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Sektor_skladista' table. You can move, or remove it, as needed.
            this.sektor_skladistaTableAdapter.FillBySkladisteId(this.gizmoDBDataSet.Sektor_skladista, this.idSkladista);
            // TODO: This line of code loads data into the 'gizmoDBDataSet.Knjiga' table. You can move, or remove it, as needed.
            this.knjigaTableAdapter.Fill(this.gizmoDBDataSet.Knjiga);

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sektor_skladistaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gizmoDBDataSet);
            this.Close();
        }

        
    }
}
