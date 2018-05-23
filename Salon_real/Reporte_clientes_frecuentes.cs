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
    public partial class Reporte_clientes_frecuentes : Form
    {
        public Reporte_clientes_frecuentes()
        {
            InitializeComponent();
        }

        private void Reporte_clientes_frecuentes_Load(object sender, EventArgs e)
        {
            Reporte2 r = new Reporte2();
            crystalReportViewer1.ReportSource = r;
        }
    }
}
