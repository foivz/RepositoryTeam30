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
    public partial class frmProdajaUrediKupca : Form
    {
        public frmProdajaUrediKupca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmProdajaUrediKupcaDetalji forma = new frmProdajaUrediKupcaDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
        }

        private void dgvPopis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
