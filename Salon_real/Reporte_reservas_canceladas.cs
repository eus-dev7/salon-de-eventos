using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salon_real
{
    public partial class Reporte_reservas_canceladas : Form
    {
        public Reporte_reservas_canceladas()
        {
            InitializeComponent();
        }

        private void Reporte_reservas_canceladas_Load(object sender, EventArgs e)
        {
            Reporte1 r = new Reporte1();
            crystalReportViewer1.ReportSource = r;
        }
    }
}
