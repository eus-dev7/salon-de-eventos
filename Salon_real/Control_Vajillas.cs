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
    public partial class Control_Vajillas : Form
    {
        public Control_Vajillas()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private MessageBoxButtons aceptar;
        Conexion obDatos;
        DataSet resultados = new DataSet();
        DataView mifiltro;
        private void Control_Vajillas_Load(object sender, EventArgs e)
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
            button3.Visible = false;
            cargar_dataGrid();
            vaciar();
        }
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
        void cargar_dataGrid()
        {
            while (dataGridView1.RowCount > 1)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
            this.leer_datos("select * from vajilla", ref resultados, "vajilla");
            this.mifiltro = ((DataTable)resultados.Tables["vajilla"]).DefaultView;
            this.dataGridView1.DataSource = mifiltro;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = textBox1.Text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(nombre LIKE '*" + palabra + "*')";
                }
                else
                {
                    salida_datos += "and (nombre LIKE '*" + palabra + "*')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = dataGridView1.CurrentRow.Index;
            id.Text = Convert.ToString(dataGridView1.Rows[filaseleccionada].Cells[0].Value);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select id,nombre,cant_total,costo_alq,costo_res,descripcion from vajilla where id='" + id.Text + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                id.Enabled = false;
                nombre.Text = reader[1].ToString();
                cantidad.Text = reader[2].ToString();
                costo_alq.Text = reader[3].ToString();
                costo_rep.Text = reader[4].ToString();
                descripcion.Text = reader[5].ToString();
            }
            else
            {
                MessageBox.Show("el vajilla" + reader[1].ToString() + " no existe");

            }
            reader.Close();
            button3.Visible = true;
        }
        void vaciar()
        {
            id.Text = "";
            nombre.Text = "";
            cantidad.Text = "";
            costo_alq.Text = "";
            costo_rep.Text = "";
            descripcion.Text = "";
            id.Enabled = false;
            int d = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString()) > d)
                {
                    d = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                }
                else
                {
                }
            }
            id.Text = Convert.ToString(d + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            if (id.Text == "" || nombre.Text == "" || cantidad.Text == "" || costo_alq.Text == "" || costo_rep.Text == "" || descripcion.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos requeridos");
            }
            else
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select id,nombre,cant_total,costo_alq,costo_res,descripcion from vajilla where id='" + id.Text + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string campos = "nombre='" + nombre.Text + "',cant_total=" + cantidad.Text + ",costo_alq=" + costo_alq.Text + ",costo_res=" + costo_rep.Text + ",descripcion='" + descripcion.Text + "'";
                    if (obDatos.actualizar("vajilla", campos, " id = '" + id.Text + "'"))
                    {

                    }
                    else
                    {
                    }
                }
                else
                {
                    obDatos = new Conexion();
                    string cli = "insert into vajilla(id,nombre,cant_total,costo_alq,costo_res,descripcion) values('" + id.Text + "','" + nombre.Text + "'," + cantidad.Text + "," + costo_alq.Text + "," + costo_rep.Text + ",'" + descripcion.Text + "')";
                    if (obDatos.insertar(cli))
                    {
                    }
                    else
                    {
                    }
                }
                vaciar();
                cargar_dataGrid();
                reader.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button3.Visible = false;

            vaciar();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            if (obDatos.eliminar("vajilla", "id = '" + id.Text + "'"))
            {
                MessageBox.Show("Registro eliminado");
            }
            else
            {
                MessageBox.Show("error al eliminar");
            }

            cargar_dataGrid();
            button3.Visible = false;
            vaciar();
        }

    }
}
