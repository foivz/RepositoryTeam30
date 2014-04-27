using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gizmo
{
    class UrediZaposlenika
    {
        private string txtboxIme { get; set; }
        private string txtboxPrezime { get; set; }
        private string txtboxOIB { get; set; }
        private string txtboxEmail { get; set; }
        private string txtboxTelefon { get; set; }
        private string txtboxKorIme { get; set; }
        private string txtboxLozinka { get; set; }
        private int txtboxOdjel { get; set; }
        private DataTable tblZaposlenici { get; set; }
        private Button btnPromijeni { get; set; }
        private Button btnObrisi { get; set; }

        private void tblZaposlenici_dblClick() { }
        private void btnPromijeni_Click() { }
        private void btnObrisi_Click() { }
    }
}
