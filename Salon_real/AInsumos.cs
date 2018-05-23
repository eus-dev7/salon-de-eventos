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
    public partial class AInsumos : Form
    {
        public AInsumos()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private Conexion obDatos;
        private void AInsumos_Load(object sender, EventArgs e)
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
            button3.Enabled = false;
        }
        void cargardata()
        {
            obDatos = new Conexion();
            obDatos.consultar("select id, nombre,cantidad,costo_alq as costo_alquiler, costo_res as costo_repocicion, descripcion,color from insumo", "insumo");
            this.dataGridView1.DataSource = obDatos.ds.Tables["insumo"];
            this.dataGridView1.Refresh();

            obDatos.consultar("select i.id,i.nombre,ai.cantidad as cantidad,i.costo_alq as costo_alquiler,i.descripcion from insumo i,alq_insumo ai where i.id=ai.id_insumo and ai.id_alquiler=" + id_alquiler.Text + "", "insumo");
            this.dataGridView2.DataSource = obDatos.ds.Tables["insumo"];
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
            if (textBox1.Text == "")
            {
                MessageBox.Show("ingreser una cantidad a alquilar");
            }
            else
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select cantidad from insumo where id='" + id_vajilla.Text + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    if (Convert.ToInt32(textBox1.Text) <= Convert.ToInt32(reader[0].ToString()))
                    {
                        obDatos = new Conexion();
                        string alq = "insert into alq_insumo(id_alquiler,id_insumo,cantidad) values(" + id_alquiler.Text + ",'" + id_vajilla.Text + "'," + textBox1.Text + ")";
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
                    else
                    {
                        MessageBox.Show("Lo siento la cantidad tiene que ser menor a:" + reader[0].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }
                reader.Close();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = dataGridView2.CurrentRow.Index;
            eli.Text = dataGridView2.Rows[filaseleccionada].Cells[0].Value.ToString();
            cant_res.Text = dataGridView2.Rows[filaseleccionada].Cells[2].Value.ToString();
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cant_res.Text == "")
            {
                MessageBox.Show("ingrese una cantidad a modificar");
            }
            else
            {
                obDatos = new Conexion();
                string campos = "cantidad=" + cant_res.Text;
                if (obDatos.actualizar("alq_insumo", campos, " id_alquiler = " + id_alquiler.Text + " and id_insumo='" + eli.Text + "'"))
                {

                }
                else
                {
                }
                cargardata();
                buttonsoff();
                cal_costo();
            }
        }
        void cal_costo()
        {
            double s = 0;
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                s = s + (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value.ToString()) * Convert.ToDouble(dataGridView2.Rows[i].Cells[3].Value.ToString()));
            }
            costo_total.Text = Convert.ToString(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            if (obDatos.eliminar("alq_insumo", "id_alquiler = " + id_alquiler.Text + " and id_insumo='" + eli.Text + "'"))
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void cant_res_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

    }
}
