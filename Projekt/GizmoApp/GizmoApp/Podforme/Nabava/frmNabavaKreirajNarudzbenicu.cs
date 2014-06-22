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
    /// Forma za kreiranje nove narudžbenice.
    /// </summary>
    public partial class frmNabavaKreirajNarudzbenicu : Form
    {
        public frmNabavaKreirajNarudzbenicu()
        {
            InitializeComponent();
        }

        private void btnKreirajNarudzbenicu_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult odg = MessageBox.Show("Jeste li sigurni da želite kreirati novu narudžbenicu?","Obavijest",MessageBoxButtons.YesNo);
            if (odg == DialogResult.Yes)
            {
                //Ažurirati bazu (inače se baza ne treba ažurirati) i kreirati pdf (izvješće)  i spremit ga negdi
            }
            else
            {
                //Ne napravi ništ nego vrati u formu za kreiranje.
            }

        }
    }
}
