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
    public partial class Control_Salones : Form
    {
        public Control_Salones()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private MessageBoxButtons aceptar;
        Conexion obDatos;
        DataSet resultados = new DataSet();
        DataView mifiltro;
        private void Control_Salones_Load(object sender, EventArgs e)
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
            cargar_dataGrid();
            vaciar();
            button1.Visible = false;
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
            this.leer_datos("select * from salon", ref resultados, "salon");
            this.mifiltro = ((DataTable)resultados.Tables["salon"]).DefaultView;
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
                    salida_datos = "(id LIKE '*" + palabra + "*')";
                }
                else
                {
                    salida_datos += "and (id LIKE '*" + palabra + "*')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
            int filaseleccionada = dataGridView1.CurrentRow.Index;
            id.Text = Convert.ToString(dataGridView1.Rows[filaseleccionada].Cells[0].Value);
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select id,nombre,cantidad,costo from salon where id='" + id.Text + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            try
            {
                if (reader.Read())
                {
                    id.Enabled = false;
                    nombre.Text = reader[1].ToString();
                    cantidad.Text = reader[2].ToString();
                    costo.Text = reader[3].ToString();
                }
                else
                {
                    MessageBox.Show("este salon " + reader[0].ToString() + " no existe");

                }
            }
            catch
            { }
            reader.Close();
            button1.Visible = true;
        }
        void vaciar()
        {
            id.Text = "";
            nombre.Text = "";
            cantidad.Text = "";
            costo.Text = "";
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
            if (id.Text == "" || nombre.Text == "" || cantidad.Text == "" || costo.Text == "")
            {
                MessageBox.Show("Ingrese todos los datos requeridos");
            }
            else
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select id,nombre,cantidad,costo from salon where id='" + id.Text + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    string campos = "nombre='" + nombre.Text + "',cantidad=" + cantidad.Text + ",costo=" + costo.Text + "";
                    if (obDatos.actualizar("salon", campos, " id = '" + id.Text + "'"))
                    {

                    }
                    else
                    {
                    }
                }
                else
                {
                    obDatos = new Conexion();
                    string cli = "insert into salon(id,nombre,cantidad,costo) values('" + id.Text + "','" + nombre.Text + "'," + cantidad.Text + "," + costo.Text + ")";
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

        private void button3_Click(object sender, EventArgs e)
        {

            vaciar();
            button1.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select id_salon from res_salon where id_salon='" + id.Text + "'";
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("No se puede eliminar un salon reservado...");
            }
            else
            {

                obDatos = new Conexion();
                if (obDatos.eliminar("salon", "id = '" + id.Text + "'"))
                {
                    MessageBox.Show("Registro eliminado");
                }
                else
                {
                    MessageBox.Show("error al eliminar");
                }

                cargar_dataGrid();
                button1.Visible = false;
                vaciar();
            }
            reader.Close();

        }

    }
}
