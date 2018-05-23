using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Salon_real
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        public static MySqlConnection cn;
        DataSet resultados = new DataSet();
        DataView mifiltro;
        //Leemos los datos para buscar en el dataGrid
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "SERVER=localhost;DATABASE=salon;UID=root;PASSWORD=;";
                cn = new MySqlConnection(cadena);
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Load
        private void Principal_Load(object sender, EventArgs e)
        {
            cn = new MySqlConnection();
            cn.ConnectionString = "SERVER=localhost;DATABASE=salon;UID=root;PASSWORD=;";
            try
            {
                cn.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            cargar_dataGrid();
        }
        //Cargar DataGrid de elementos
        void cargar_dataGrid()
        {
            while (dataGridView1.RowCount > 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            this.leer_datos("select * from infres", ref resultados, "infres");
            this.mifiltro = ((DataTable)resultados.Tables["infres"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
        }
        //Actualizar Fecha y hora
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToLongTimeString();
            fecha.Text = System.DateTime.Now.ToString("dd/MM/yyyy");
            actualizar.Text = "";
        }

        private void iniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                MessageBox.Show("Tu cuenta como administrador ya esta abierta");
            }
            else
            {
                Seguridad s = new Seguridad();
                this.Hide();
                if (s.ShowDialog() == DialogResult.OK)
                {
                    cargar_dataGrid();
                }
                else
                {
                }
            }
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblusuario.Text = "_";
            lbl_ciusuario.Text = "_";
            lblcargo.Text = "_";
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reservarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Reserva r = new Reserva();
                if (r.ShowDialog() == DialogResult.OK)
                {
                    cargar_dataGrid();
                }
                else
                {

                }
                cargar_dataGrid();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = textBox1.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(id_cliente LIKE '*" + palabra + "*')";
                }
                else
                {
                    salida_datos += "and (id_cliente LIKE '*" + palabra + "*')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Alquiler a = new Alquiler();
                int filaseleccionada = dataGridView1.CurrentRow.Index;
                a.id_reserva.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
                if (a.ShowDialog() == DialogResult.OK)
                {
                    cargar_dataGrid();
                }
                else
                {

                }
                cargar_dataGrid();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void controlDeSalonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Control_Salones c = new Control_Salones();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Control_Empleados ce = new Control_Empleados();
                ce.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void controlDeInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Control_Insumos c = new Control_Insumos();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }


        }

        private void controlDeVajilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Control_Vajillas c = new Control_Vajillas();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void generarReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Reporte_reservas_canceladas r = new Reporte_reservas_canceladas();
                r.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void reporteClientesConMasReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Reporte_clientes_frecuentes r = new Reporte_clientes_frecuentes();
                r.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void reporteReservasAlquiladasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Reporte_reservas_alquiladas r = new Reporte_reservas_alquiladas();
                r.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }

        private void verificarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lblcargo.Text == "Administrador")
            {
                Clientes c = new Clientes();
                c.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor inicie cesion como administrador");
            }

        }


    }
}
