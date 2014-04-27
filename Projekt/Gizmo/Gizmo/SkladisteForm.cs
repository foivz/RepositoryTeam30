using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gizmo
{
    class SkladisteForm : GeneralnaForma
    {
        private int idZaposlenik { get; set; }
        private Button btnAplikacija { get; set; }
        private Button btnSkladiste { get; set; }
        private Button btnIzvjesca { get; set; }
        private Button btnPomoc { get; set; }


        public SkladisteForm()
        {
          PretraziSkladiste pretraga = new PretraziSkladiste();
          UrediSkladiste  uredi = new UrediSkladiste();

        }


        public void btnAplikacija_CLick() { }

        public void btnIzvjesca_Click()
        {
           IzvjescaForm izvjesce = new IzvjescaForm();
        }

        public void btnPomoc_Click() { }
        private void btnSkladiste_Click() { }
    }
}
