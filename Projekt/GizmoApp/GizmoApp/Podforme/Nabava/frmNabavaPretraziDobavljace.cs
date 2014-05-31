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
    }
}
