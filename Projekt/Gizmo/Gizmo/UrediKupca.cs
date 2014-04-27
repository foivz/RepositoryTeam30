using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gizmo
{
    class UrediKupca
    {
        private string txtboxNaziv { get; set; }
        private string txtboxAdresa { get; set; }
        private string txtboxOIB { get; set; }
        private string txtboxEmail { get; set; }
        private string txtboxTelefon { get; set; }
        private DataTable tblKupci { get; set; }
        private Button btnPromijeni { get; set; }
        private Button btnObrisi { get; set; }

        private void tblKupci_dblClick() { }
        private void btnPromijeni_Click() { }
        private void btnObrisi_Click() { }
    }
}
