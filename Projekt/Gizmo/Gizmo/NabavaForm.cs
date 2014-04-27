using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gizmo
{
    class NabavaForm : GeneralnaForma
    {
        private int idZaposlenik { get; set; }
        private Button btnAplikacija { get; set; }
        private Button btnNabava { get; set; }
        private Button btnIzvjesca { get; set; }
        private Button btnPomoc { get; set; }


        public NabavaForm()
        {
            PretragaDobavljaca pretraga = new PretragaDobavljaca();
            DodajDobavljaca dodaj = new DodajDobavljaca();
            UrediDobavljaca uredi = new UrediDobavljaca();
            List<KreiranjeNarudzbenice> narudzbenice = new List<KreiranjeNarudzbenice>();

        }


        public void btnAplikacija_CLick() { }

        public void btnIzvjesca_Click()
        {
            IzvjescaForm izvjesce = new IzvjescaForm();
        }

        public void btnPomoc_Click() { }
        private void btnNabava_Click() { }
    }
}
