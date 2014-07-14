using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GizmoApp
{
   class slojKontrole
    {

        public static bool ispravno = true;

        public static void dodjeliKontrolu(string ime, string vrijednost)
        {
            if (vrijednost.Length > 0)
            {
                switch (ime)
                {
                    case "txtbxIme":
                    case "txtbxPrezime": imePrezime(vrijednost); break;
                    case "txtbxOIB": oib(vrijednost); break;
                    case "txtbxEmail": email(vrijednost); break;
                    case "txtbxTelefon": telefon(vrijednost); break;
                    case "txtbxKorisnickoIme": korisnicko(vrijednost); break;
                }
            }
        }
        public static void imePrezime(string vrijednost)
        {
            ispravno = true;
            if (imaBroj(vrijednost)) postaviKrivo(Greske.ErrorCodes.greska1);

            if (prvoVelikoSlovo(vrijednost) == false)
            {
                postaviKrivo(Greske.ErrorCodes.greska2);
            }
            
        }

        public static void oib(string vrijednost)
        {
            ispravno = true;
            if (nijeBroj(vrijednost)) postaviKrivo(Greske.ErrorCodes.greska3);
            if (vrijednost.Length < 11) postaviKrivo(Greske.ErrorCodes.greska4);
            
        }
        public static void email(string vrijednost)
        {
            ispravno = true;
            int pronadjenEt = -1;
            int pronadjenaTocka = -1;
            for (int i = 0; i < vrijednost.Length; i++)
            {
                if (vrijednost[i] == '@') pronadjenEt = i;
                if (vrijednost[i] == '.') pronadjenaTocka = i;

            }
            if (pronadjenEt == -1) postaviKrivo(Greske.ErrorCodes.greska5);
            if (pronadjenaTocka == -1) postaviKrivo(Greske.ErrorCodes.greska6);
            if (pronadjenaTocka < pronadjenEt) postaviKrivo(Greske.ErrorCodes.greska7);
            if (pronadjenEt + 1 == pronadjenaTocka || pronadjenaTocka + 1 == pronadjenEt) postaviKrivo(Greske.ErrorCodes.greska8);

        }

        public static void telefon(string vrijednost)
        {
            ispravno = true;
            if (vrijednost.Length != 7) postaviKrivo(Greske.ErrorCodes.greska9);
            if (imaSlovo(vrijednost) == false)
            {
                for (int i = 0; i < vrijednost.Length; i++)
                {
                    if (vrijednost[i] == '-') continue;
                    if (vrijednost[i] < '0' || vrijednost[i] > '9')
                    {
                        postaviKrivo(Greske.ErrorCodes.greska10);
                        break;
                    }
                }
            }
            else postaviKrivo(Greske.ErrorCodes.greska11);


        }

        public static string poruka(bool status)
        {
            if (status)
            {
                return "Unos je uspješan.";
            }
            else return "Unos nije uspješan.";
        }

        public static void korisnicko(string vrijednost)
        {
            ispravno = true;
            for (int i = 0; i < vrijednost.Length; i++)
            {
                if (vrijednost[i] >= '0' && vrijednost[i] <= '9' && i == 0) postaviKrivo(Greske.ErrorCodes.greska13);
                if (vrijednost[i] == ' ')
                {
                    postaviKrivo(Greske.ErrorCodes.greska12);
                    break;
                }
            }
        }
       
        public static bool imaBroj(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] >= '0' && txt[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool nijeBroj(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] < '0' || txt[i] > '9')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool imaSlovo(string txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                if ((txt[i] >= 'A' && txt[i] <= 'Z') || (txt[i] >= 'a' && txt[i] <= 'z'))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool prvoVelikoSlovo(string txt)
        {
            if (txt[0] >= 'A' && txt[0] <= 'Z') return true;
            else return false;
        }

        public static void postaviKrivo(Greske.ErrorCodes greska)
        {
            ispravno = false;
            Greske.kod = Greske.kod | greska;
        }
    }
}
