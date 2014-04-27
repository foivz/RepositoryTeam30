using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gizmo
{
    class UrediSkladiste
    {
        private int txtboxKolicina { get; set; }
        private int txtboxSektor { get; set; }
        private DataTable tblSkladiste { get; set; }
        private Button btnPotvrdi { get; set; }
        private Button btnObrisi { get; set; }

        private void tblSkladiste_dblClick() { }
        private void btnPotvrdi_Click() { }
        private void btnObrisi_Click() { }
    }
}
