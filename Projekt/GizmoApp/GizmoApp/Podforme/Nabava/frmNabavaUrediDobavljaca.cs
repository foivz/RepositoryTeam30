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


    public partial class frmNabavaUrediDobavljaca : Form
    {
        public frmNabavaUrediDobavljaca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNabavaUrediDobavljacaDetalji forma = new frmNabavaUrediDobavljacaDetalji();
            forma.WindowState = FormWindowState.Normal;
            forma.ShowDialog();
           
        }
    }
}
