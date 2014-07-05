using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GizmoApp.GizmoDBDataSetTableAdapters;
using GizmoApp.Podforme;
using System.Data;
using System.ComponentModel;
using System.Windows.Forms;

namespace GizmoApp
{
    class slojBaze
    {
        public static void osvjezi(GizmoDBDataSet.ZaposlenikDataTable tablica, ZaposlenikTableAdapter adapter)
        {
            adapter.Fill(tablica);
        }
        public static void osvjeziNovo(GizmoDBDataSet.ZaposlenikDataTable tablica, ZaposlenikTableAdapter adapter, BindingSource bs)
        {
            adapter.Fill(tablica);
            bs.AddNew();
        }
        public static void insert(Podforme.Administracija.frmAdministracijaDodajZaposlenika frm, BindingSource bs, TableAdapterManager adapter, GizmoDBDataSet ds)
        {
            frm.Validate();
            try
            {
                bs.EndEdit();
                adapter.UpdateAll(ds);
                MessageBox.Show("Uspjesan unos zaposlenika.");
                frm.Close();

                Podforme.Administracija.frmAdministracijaUrediZaposlenika frmAdministracijaUrediZaposlenika = new Podforme.Administracija.frmAdministracijaUrediZaposlenika();
                frmAdministracijaUrediZaposlenika.WindowState = FormWindowState.Normal;
                frmAdministracijaUrediZaposlenika.ShowDialog();
            }
            catch (Exception error)
            {
                MessageBox.Show("Nepravilan unos podatka!");
            }
        }
    }
}
