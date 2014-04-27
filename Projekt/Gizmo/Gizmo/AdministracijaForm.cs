using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gizmo
{
    class AdministracijaForm : GeneralnaForma
    {
        private int idZaposlenika { get; set; }

        public AdministracijaForm()
        {
           UrediZaposlenika uredi = new UrediZaposlenika();
           DodajZaposlenika dodaj = new DodajZaposlenika();
        }

        public void Aplikacija_Click() { }
        private void Aministracija_Click() { }
        public void Pomoc_Click() { }

        public void btnAplikacija_CLick() { }

        public void btnIzvjesca_Click()
        {
           IzvjescaForm izvjesce = new IzvjescaForm();
        }

        public void btnPomoc_Click() { }
    }
}
