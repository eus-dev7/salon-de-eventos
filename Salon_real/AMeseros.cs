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
    public partial class AMeseros : Form
    {
        public AMeseros()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private Conexion obDatos;
        private void AMeseros_Load(object sender, EventArgs e)
        {
            //Constructor de la conexion.
            cn = new MySqlConnection();
            //Definir la cadena de coneccion.
            cn.ConnectionString = "SERVER=localhost;DATABASE=salon;UID=root;PASSWORD=;";
            //Abrir la conexion.
            try
            {
                cn.Open();
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
            buttonsoff();
            cargardata();
            cal_costo();
        }
        void buttonsoff()
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }
        void cargardata()
        {
            obDatos = new Conexion();
            obDatos.consultar("select ci,nombre,apellidos,cargo,telefono,sueldo as cobro_por_hora from empleado where cargo='Mesero'", "empleado");
            this.dataGridView1.DataSource = obDatos.ds.Tables["empleado"];
            this.dataGridView1.Refresh();

            obDatos.consultar("select e.ci,e.nombre,e.apellidos,e.cargo,e.sueldo as cobro_por_hora from empleado e,alq_empleado ae where e.ci=ae.id_empleado and ae.id_alquiler=" + id_alquiler.Text + "", "empleado");
            this.dataGridView2.DataSource = obDatos.ds.Tables["empleado"];
            this.dataGridView2.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = dataGridView1.CurrentRow.Index;
            id_vajilla.Text = dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString();
            nombre.Text = dataGridView1.Rows[filaseleccionada].Cells[1].Value.ToString();
            string x = "";
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString() == dataGridView2.Rows[i].Cells[0].Value.ToString())
                {
                    x = "y";
                }
            }
            if (x != "y")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            string alq = "insert into alq_empleado(id_alquiler,id_empleado) values(" + id_alquiler.Text + ",'" + id_vajilla.Text + "')";
            if (obDatos.insertar(alq))
            {
            }
            else
            {
            }
            buttonsoff();
            cargardata();
            cal_costo();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = dataGridView2.CurrentRow.Index;
            eli.Text = dataGridView2.Rows[filaseleccionada].Cells[0].Value.ToString();
            button2.Enabled = true;
        }


        void cal_costo()
        {
            double s = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                s = s + (Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value.ToString())*Convert.ToInt32(horas.Text));
            }
            costo_total.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            if (obDatos.eliminar("alq_empleado", "id_alquiler = " + id_alquiler.Text + " and id_empleado='" + eli.Text + "'"))
            {
                MessageBox.Show("Registro eliminado");
            }
            else
            {
                MessageBox.Show("error al eliminar");
            }
            buttonsoff();
            cargardata();
            cal_costo();
        }
    }
}
