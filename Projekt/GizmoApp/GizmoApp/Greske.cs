using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GizmoApp
{
    class Greske
    {
        public static ErrorCodes kod = 0;

        public enum ErrorCodes
        {
            greska1 = 1 << 0,
            greska2 = 1 << 1,
            greska3 = 1 << 2,
            greska4 = 1 << 3,
            greska5 = 1 << 4,
            greska6 = 1 << 5,
            greska7 = 1 << 6,
            greska8 = 1 << 7,
            greska9 = 1 << 8,
            greska10 = 1 << 9,
            greska11 = 1 << 10,
            greska12 = 1 << 11,
            greska13 = 1 << 12
        }

        public static string porukaGreske(ErrorCodes kod)
        {
           string poruka = "Errors:\n\n";
           
                if(kod.HasFlag(ErrorCodes.greska1)) poruka += "Name and surname must contain letters only.\n";
                if(kod.HasFlag(ErrorCodes.greska2)) poruka += "Name and surname must have a capital letter.\n";
                if(kod.HasFlag(ErrorCodes.greska3)) poruka += "OIB must contain numbers only.\n";
                if(kod.HasFlag(ErrorCodes.greska4)) poruka += "OIB must contan 11 letters.\n";
                if(kod.HasFlag(ErrorCodes.greska5)) poruka += "E-mail address must contain one '@' sign.\n";
                if(kod.HasFlag(ErrorCodes.greska6)) poruka += "E-mail address must contain one '.' sign. \n";
                if(kod.HasFlag(ErrorCodes.greska7)) poruka += "The '@' sign must be followed by '.' sign, not vice versa.\n";
                if(kod.HasFlag(ErrorCodes.greska8)) poruka += "Between '@' and '.' signs must be at least one letter.\n";
                if(kod.HasFlag(ErrorCodes.greska9)) poruka += "The phone number must contain 6 digits.\n";
                if(kod.HasFlag(ErrorCodes.greska10)) poruka += "The phone number must not contain any other characters but numbers.\n";
                if(kod.HasFlag(ErrorCodes.greska11)) poruka += "The phone number must not contain letters.\n";
                if(kod.HasFlag(ErrorCodes.greska12)) poruka += "Username must not contain a blank space.\n";
                if(kod.HasFlag(ErrorCodes.greska13)) poruka += "Username must not begin with a number.\n";
           
            return poruka;
        }
    }
}
