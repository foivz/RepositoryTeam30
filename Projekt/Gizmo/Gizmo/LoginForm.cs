using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gizmo
{
    class LoginForm
    {
        public string korIme { get; set; }
        public string lozinka { get; set; }

        public LoginForm()
        {
            GeneralnaForma opcenita = new GeneralnaForma();
        }

        public void btnLogin_Click();
    }
}
