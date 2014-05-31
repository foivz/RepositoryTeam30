using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void frmGlavna_Load(object sender, EventArgs e)
        {
            lblKorisnickoIme.Text = "KorisnickoIme";
        }

        private void miAplikacijaIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            this.Close();
        }
        
        // Skladiste    
        private void miSkladisteUredi_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Skladiste.frmSkladisteUredi frmSkladisteUredi = new Podforme.Skladiste.frmSkladisteUredi();
            frmSkladisteUredi.MdiParent = this;
            frmSkladisteUredi.WindowState = FormWindowState.Maximized;
            frmSkladisteUredi.Show();
        }

        private void miSkladistePretrazi_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Skladiste.frmSkladistePretrazi frmSkladistePretrazi = new Podforme.Skladiste.frmSkladistePretrazi();
            frmSkladistePretrazi.MdiParent = this;
            frmSkladistePretrazi.WindowState = FormWindowState.Maximized;
            frmSkladistePretrazi.Show();
        }

        // Prodaja
        private void miProdajaDodajKupca_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Prodaja.frmProdajaDodajKupca frmProdajaDodajKupca = new Podforme.Prodaja.frmProdajaDodajKupca();
            frmProdajaDodajKupca.WindowState = FormWindowState.Normal;
            frmProdajaDodajKupca.ShowDialog();

        }

        private void miProdajaUrediKupca_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Prodaja.frmProdajaUrediKupca frmProdajaUrediKupca = new Podforme.Prodaja.frmProdajaUrediKupca();
            frmProdajaUrediKupca.MdiParent = this;
            frmProdajaUrediKupca.WindowState = FormWindowState.Maximized;
            frmProdajaUrediKupca.Show();
        }

        private void miProdajaPretraziKupce_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Prodaja.frmProdajaPretraziKupce frmProdajaPretraziKupce = new Podforme.Prodaja.frmProdajaPretraziKupce();
            frmProdajaPretraziKupce.MdiParent = this;
            frmProdajaPretraziKupce.WindowState = FormWindowState.Maximized;
            frmProdajaPretraziKupce.Show();
        }

        private void miProdajaKreirajOtpremnicu_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Prodaja.frmProdajaKreirajOtpremnicu frmProdajaKreirajOtpremnicu = new Podforme.Prodaja.frmProdajaKreirajOtpremnicu();
            frmProdajaKreirajOtpremnicu.MdiParent = this;
            frmProdajaKreirajOtpremnicu.WindowState = FormWindowState.Maximized;
            frmProdajaKreirajOtpremnicu.Show();
        }

        // Nabava
        private void miNabavaDodajDobavljaca_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Nabava.frmNabavaDodajDobavljaca frmNabavaDodajDobavljaca = new Podforme.Nabava.frmNabavaDodajDobavljaca();
            frmNabavaDodajDobavljaca.WindowState = FormWindowState.Normal;
            frmNabavaDodajDobavljaca.ShowDialog();
        }

        private void miNabavaUrediDobavljaca_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Nabava.frmNabavaUrediDobavljaca frmNabavaUrediDobavljaca = new Podforme.Nabava.frmNabavaUrediDobavljaca();
            frmNabavaUrediDobavljaca.WindowState = FormWindowState.Maximized;
            frmNabavaUrediDobavljaca.MdiParent = this;
            frmNabavaUrediDobavljaca.Show();
        }

        private void miNabavaPretraziDobavljace_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Nabava.frmNabavaPretraziDobavljace frmNabavaPretraziDobavljace = new Podforme.Nabava.frmNabavaPretraziDobavljace();
            frmNabavaPretraziDobavljace.MdiParent = this;
            frmNabavaPretraziDobavljace.WindowState = FormWindowState.Maximized;
            frmNabavaPretraziDobavljace.Show();
        }

        private void miNabavaKreirajNarudzbenicu_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Nabava.frmNabavaKreirajNarudzbenicu frmNabavaKreirajNarudzbenicu = new Podforme.Nabava.frmNabavaKreirajNarudzbenicu();
            frmNabavaKreirajNarudzbenicu.MdiParent = this;
            frmNabavaKreirajNarudzbenicu.WindowState = FormWindowState.Maximized;
            frmNabavaKreirajNarudzbenicu.Show();
        }

        // Administracija
        private void miAdministracijaDodajZaposlenika_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Administracija.frmAdministracijaDodajZaposlenika frmAdministracijaDodajZaposlenika = new Podforme.Administracija.frmAdministracijaDodajZaposlenika();
            frmAdministracijaDodajZaposlenika.WindowState = FormWindowState.Normal;
            frmAdministracijaDodajZaposlenika.ShowDialog();
        }

        private void miAdministracijaUrediZaposlenika_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Administracija.frmAdministracijaUrediZaposlenika frmAdministracijaUrediZaposlenika = new Podforme.Administracija.frmAdministracijaUrediZaposlenika();
            frmAdministracijaUrediZaposlenika.MdiParent = this;
            frmAdministracijaUrediZaposlenika.WindowState = FormWindowState.Maximized;
            frmAdministracijaUrediZaposlenika.Show();
        }

        private void miIzvjescaKreirajIzvjesce_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Izvjesca.frmIzvjescaKreirajIzvjesce frmIzvjescaKreirajIzvjesce = new Podforme.Izvjesca.frmIzvjescaKreirajIzvjesce();
            frmIzvjescaKreirajIzvjesce.MdiParent = this;
            frmIzvjescaKreirajIzvjesce.WindowState = FormWindowState.Maximized;
            frmIzvjescaKreirajIzvjesce.Show();
        }

        private void miIzvjescaPregledIzvjesca_MouseUp(object sender, MouseEventArgs e)
        {
            Podforme.Izvjesca.frmIzvjescaPregledIzvjesca frmIzvjescaPregledIzvjesca = new Podforme.Izvjesca.frmIzvjescaPregledIzvjesca();
            frmIzvjescaPregledIzvjesca.MdiParent = this;
            frmIzvjescaPregledIzvjesca.WindowState = FormWindowState.Maximized;
            frmIzvjescaPregledIzvjesca.Show();
        }

        private void miPomocOGizmoApp_MouseUp(object sender, MouseEventArgs e)
        {
            string info = "Gizmo App version 1.0\n Služi za evidenciju bla bla bla\n Katarina Zrisnki d.o.o.";
            MessageBox.Show(info);
        }

        private void frmGlavna_MdiChildActivate(object sender, EventArgs e)
        {
            if (MdiChildren.Count() > 1)
            {
                MdiChildren.ElementAt(0).Close();
            }
        }

    }
}
