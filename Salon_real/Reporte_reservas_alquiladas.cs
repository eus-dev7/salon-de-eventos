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
    public partial class Reporte_reservas_alquiladas : Form
    {
        public Reporte_reservas_alquiladas()
        {
            InitializeComponent();
        }

        private void Reporte_reservas_alquiladas_Load(object sender, EventArgs e)
        {
            Reporte1 r = new Reporte1();
            crystalReportViewer1.ReportSource = r;
        }
    }
}
