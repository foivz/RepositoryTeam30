using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gizmo
{
    class ProdajaForm : GeneralnaForma
    {
        private int idZaposlenik { get; set; }
        private Button btnAplikacija { get; set; }
        private Button btnProdaja { get; set; }
        private Button btnIzvjesca { get; set; }
        private Button btnPomoc { get; set; }

        public ProdajaForm()
        {
          PretragaKupca  pretraga = new PretragaKupca();
          DodajKupca  dodaj = new DodajKupca();
          UrediKupca  uredi = new UrediKupca();
          List<KreiranjeOtpremnice> narudzbenice = new List<KreiranjeOtpremnice>();

        }


        public void btnAplikacija_CLick() { }

        public void btnIzvjesca_Click()
        {
          IzvjescaForm izvjesce = new IzvjescaForm();
        }

        public void btnPomoc_Click() { }
        private void btnProdaja_Click() { }
    }
}
