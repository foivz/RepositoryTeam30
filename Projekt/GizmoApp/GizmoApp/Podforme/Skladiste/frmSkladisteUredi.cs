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
    public partial class frmSkladisteUredi : Form
    {
        public frmSkladisteUredi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSkladisteUrediDetalji forma = new frmSkladisteUrediDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
        }
    }
}
