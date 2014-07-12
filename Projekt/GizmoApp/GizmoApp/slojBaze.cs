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
        public static bool uspjesno;
        public static void osvjezi(GizmoDBDataSet.ZaposlenikDataTable tablica, ZaposlenikTableAdapter adapter)
        {
            adapter.Fill(tablica);
        }
        public static void osvjezi(GizmoDBDataSet.OdjelDataTable tablica, OdjelTableAdapter adapter)
        {
            adapter.Fill(tablica);
        }
        public static void osvjezi(GizmoDBDataSet.ZaposlenikDataTable tablica, ZaposlenikTableAdapter adapter, BindingSource bs)
        {
            adapter.Fill(tablica);
            bs.AddNew();
        }
        public static void insert(BindingSource bs, TableAdapterManager adapter, GizmoDBDataSet ds)
        {
            try
            {
                bs.EndEdit();
                adapter.UpdateAll(ds);
                uspjesno = true;
            }
            catch (Exception error)
            {
                uspjesno = false;
            }
        }
    }
}
