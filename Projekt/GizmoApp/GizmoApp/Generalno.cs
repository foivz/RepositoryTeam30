using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp
{
    class Generalno
    {
        public static Dictionary<string, Dictionary<string, string>> lista;


        public static void dohvatiPodatke(Form forma)
        {
            lista = new Dictionary<string, Dictionary<string, string>>();
            foreach (Control item in forma.Controls.OfType<TextBox>())
            {
                Dictionary<string, string> podlista = new Dictionary<string, string>();
                podlista.Add(item.GetType().ToString(), item.Text);
                lista.Add(item.Name, podlista);
            }
        }
        public static Dictionary<string, string> dohvatiPodatak(Control kontrola)
        {
            Dictionary<string, string> informacije = new Dictionary<string, string>();

            informacije["naziv"] = kontrola.Name;
            informacije["vrijednost"] = kontrola.Text;

            return informacije;
        }
        public static void izvrsiKontrolu(Control kontrola)
        {
            Dictionary<string, string> podaci = dohvatiPodatak(kontrola);
            string naziv = podaci["naziv"];
            string vrijednost = podaci["vrijednost"];

            slojKontrole.dodjeliKontrolu(naziv, vrijednost);
            if (slojKontrole.ispravno == false && vrijednost.Length > 0)
            {
                Generalno.zacrveni(kontrola);
                MessageBox.Show(Greske.porukaGreske(Greske.kod), "Upozorenje");
                Generalno.fokusiraj(kontrola);
                Greske.kod = 0;
            }

        }
        public static void zacrveni(Control txt)
        {
            txt.ForeColor = Color.Red;
        }
        public static void fokusiraj(Control kontrola)
        {
            kontrola.Focus();
            if (getTipKontrole(kontrola) == "TextBox") ((TextBox)kontrola).SelectAll();
            kontrola.ForeColor = Color.Black;
        }
        public static string getTipKontrole(Control kontrola)
        {
            string[] niz = kontrola.GetType().ToString().Split('.');
            return niz[niz.Length - 1];
        }
    }
}
