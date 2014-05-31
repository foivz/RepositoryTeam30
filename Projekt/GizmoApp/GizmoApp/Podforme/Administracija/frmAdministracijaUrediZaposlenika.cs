using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp.Podforme.Administracija
{

    public partial class frmAdministracijaUrediZaposlenika : Form
    {
        public frmAdministracijaUrediZaposlenika()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAdministracijaUrediZaposlenikaDetalji forma = new frmAdministracijaUrediZaposlenikaDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
        }
    }
}
