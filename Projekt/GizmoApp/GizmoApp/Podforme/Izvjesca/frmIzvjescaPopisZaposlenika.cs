using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;

namespace GizmoApp.Podforme.Izvjesca
{
    /// <summary>
    /// Forma za kreiranje izvješća.
    /// </summary>
    public partial class frmIzvjescaKreirajIzvjesce : Form
    {
        public frmIzvjescaKreirajIzvjesce()
        {
            InitializeComponent();

        }

        private void frmIzvjescaKreirajIzvjesce_Load(object sender, EventArgs e)
        {
            this.zaposlenikTableAdapter1.Fill(this.gizmoDBDataSet1.Zaposlenik);
            this.reportViewer1.RefreshReport();
            
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;

            byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out filenameExtension, out streamids, out warnings);
            using (FileStream fs = new FileStream("Popis zaposlenika.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }
            DialogResult rez = MessageBox.Show("PDF is created successfully. Do you want to open?","Obavijest",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (rez == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(@"C:\Users\Danijel\Desktop\Projekt\GizmoApp\GizmoApp\bin\Debug\Popis zaposlenika.pdf");
            }
        }
    }
}
