﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GizmoApp.Podforme.Izvjesca
{
    /// <summary>
    /// Forma za kreiranje izvješća.
    /// </summary>
    public partial class frmIzvjescaPopisZaposlenika : Form
    {
        public frmIzvjescaPopisZaposlenika()
        {
            InitializeComponent();

        }

        private void frmIzvjescaKreirajIzvjesce_Load(object sender, EventArgs e)
        {
            this.zaposlenikTableAdapter1.Fill(this.gizmoDBDataSet1.Zaposlenik);
            this.reportViewer1.RefreshReport();
            
        }
    }
}
