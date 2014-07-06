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

        public static bool ispravno;
        public static int zastavica;

        public static void dodjeliKontrolu(TextBox txt)
        {
            if (txt.TextLength > 0)
            {
                switch (txt.Name)
                {
                    case "txtbxIme":
                    case "txtbxPrezime": imePrezime(txt); break;
                    case "txtbxOIB": oib(txt); break;
                    case "txtbxEmail": email(txt); break;
                    case "txtbxTelefon": telefon(txt); break;
                    case "txtbxKorisnickoIme": korisnicko(txt); break;
                }
            }
        }
        public static void imePrezime(TextBox txt)
        {
            ispravno = true;
            if (imaBroj(txt)) postaviKrivo(1);

            if (ispravno == true)
            {
                if (prvoVelikoSlovo(txt) == false)
                {
                    postaviKrivo(2);
                }
            }

            if (ispravno == false)
            {
                zacrveni(txt);

                switch (zastavica)
                {
                    case 1: MessageBox.Show("Ime i prezime mora imati samo slova.", "Upozorenje"); break;
                    case 2: MessageBox.Show("Ime i prezime mora imati prvo slovo veliko.", "Upozorenje"); break;
                }

                fokusiraj(txt);
            }
        }

        public static void oib(TextBox txt)
        {
            ispravno = true;
            if (nijeBroj(txt)) postaviKrivo(1);
            if (ispravno == true)
            {
                if (txt.TextLength < 11) postaviKrivo(2);
            }

            if (ispravno == false)
            {
                zacrveni(txt);
                switch (zastavica)
                {
                    case 1: MessageBox.Show("OIB sadrži samo brojeve.", "Upozorenje"); break;
                    case 2: MessageBox.Show("OIB sadrži točno 11 brojeva.", "Upozorenje"); break;
                }
                fokusiraj(txt);
            }
            
        }
        public static void email(TextBox txt)
        {
            ispravno = true;
            if (ispravanMail(txt) == false) postaviKrivo(1);

            if (ispravno == false)
            {
                zacrveni(txt);
                switch (zastavica)
                {
                    case 1: MessageBox.Show("Email nije ispravan! Mora sadržavati barem jedan znak '@' i jednu točku.", "Upozorenje"); break;

                }
                fokusiraj(txt);
            }
        }

        public static void telefon(TextBox txt)
        {
            ispravno = true;
            if (txt.TextLength != 7) ispravno = false;
            if (imaSlovo(txt) == false && ispravno == true)
            {
                for (int i = 0; i < txt.TextLength; i++)
                {
                    if(txt.Text[i] == '-') continue;
                    if(txt.Text[i] < '0' || txt.Text[i] >'9')
                    {
                        ispravno = false;
                        break;
                    }
                }
                if (txt.Text[3] != '-' && ispravno == true) ispravno = false;
            }
            else ispravno = false;

            if (ispravno == false)
            {
                zacrveni(txt);
                MessageBox.Show("Format telefonskog broja je 000-000 gdje 0 predstavlja broj od 0 do 9","Upozorenje");
                fokusiraj(txt);
            }
        }

        public static void korisnicko(TextBox txt)
        {
            ispravno = true;
            for (int i = 0; i < txt.TextLength; i++)
            {
                if (txt.Text[i] == ' ')
                {
                    ispravno = false;
                    break;
                }
            }

            if (ispravno == false)
            {
                zacrveni(txt);
                MessageBox.Show("Korisničko ime ne smije imati razmak.", "Upozorenje");
                fokusiraj(txt);
            }
        }

        public static bool ispravanMail(TextBox txt)
        {
            bool status = false;

            for (int i = 0; i < txt.TextLength; i++)
            {
                if( i > 0  && txt.Text[i-1] == '@' && status == true) status = false;
     
                if (txt.Text[i] == '@' || txt.Text[i] == '.')
                {
                    status = true;
                    if (txt.Text[i] == '.') break;
                }
                if (txt.Text[i] == '@' && i == txt.TextLength - 1) status = false;
            }

            return status;
        }
        public static void zacrveni(TextBox txt)
        {
            txt.ForeColor = Color.Red;
        }
        public static void fokusiraj(TextBox txt)
        {
            txt.Focus();
            txt.SelectAll();
            txt.ForeColor = Color.Black;
        }
        public static bool imaBroj(TextBox txt)
        {
            for (int i = 0; i < txt.TextLength; i++)
            {
                if (txt.Text[i] >= '0' && txt.Text[i] <= '9')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool nijeBroj(TextBox txt)
        {
            for (int i = 0; i < txt.TextLength; i++)
            {
                if (txt.Text[i] < '0' || txt.Text[i] > '9')
                {
                    return true;
                }
            }
            return false;
        }
        public static bool imaSlovo(TextBox txt)
        {
            for (int i = 0; i < txt.TextLength; i++)
            {
                if ((txt.Text[i] >= 'A' && txt.Text[i] <= 'Z') || (txt.Text[i] >= 'a' && txt.Text[i] <= 'z'))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool prvoVelikoSlovo(TextBox txt)
        {
            if (txt.Text[0] >= 'A' && txt.Text[0] <= 'Z') return true;
            else return false;
        }
        public static void postaviKrivo(int broj)
        {
            ispravno = false;
            zastavica = broj;
        }
    }
}
