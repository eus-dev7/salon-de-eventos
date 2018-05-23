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
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private Conexion obDatos;

        private void Reserva_Load(object sender, EventArgs e)
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
            cargardata();
            dataGridView1.ReadOnly = true;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "Desabilitado";
            }
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.CustomFormat = "H:mm";
            dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.CustomFormat = "H:mm";
            dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        }

        void cargardata()
        {
            obDatos = new Conexion();
            obDatos.consultar("select * from salon", "salon");
            this.dataGridView1.DataSource = obDatos.ds.Tables["salon"];
            this.dataGridView1.Refresh();

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select ci,nombre,apellidos,telefono from cliente where ci='" + textBox1.Text + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = reader[1].ToString();
                    textBox3.Text = reader[2].ToString();
                    textBox4.Text = reader[3].ToString();
                }
                else
                {

                }
                reader.Close();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Lenar todos los datos requeridos");
            }
            else
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select ci,nombre,apellidos,telefono from cliente where ci='" + textBox1.Text + "'";
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {

                }
                else
                {
                    obDatos = new Conexion();
                    string cli = "insert into cliente(ci,nombre,apellidos,telefono) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                    if (obDatos.insertar(cli))
                    {
                        MessageBox.Show("Registro insertado");
                    }
                    else
                    {
                        MessageBox.Show("error al insertar");
                    }
                }
                reader.Close();
                string idre = "";
                MySqlCommand com = new MySqlCommand();
                com.CommandText = "select max(id) from reserva ";
                com.Connection = cn;
                MySqlDataReader leer;
                leer = com.ExecuteReader();
                if (leer.Read())
                {
                    idre = Convert.ToString(Convert.ToInt32(leer[0].ToString()) + 1);
                    idres.Text = idre;
                }
                else
                {

                }
                leer.Close();
                obDatos = new Conexion();
                string bol = "insert into reserva(id,evento,fecha_res,hora_i,hora_f,num_personas,id_empleado,id_cliente,para_fecha,hasta_fecha,garantia) values(" + idres.Text + ",'" + textBox5.Text + "',curdate(),'" + dateTimePicker3.Text + "','" + dateTimePicker4.Text + "'," + textBox8.Text + ",'" + lbl_ciusuario.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'," + textBox9.Text + ")";
                if (obDatos.insertar(bol))
                {
                }
                else
                {
                }
                for (int x = 0; x < dataGridView1.Rows.Count - 1; x++)
                {
                    if (dataGridView1.Rows[x].Cells[0].Value.ToString() == "Reservado")
                    {
                        obDatos = new Conexion();
                        string sa = "insert into res_salon(id_reserva,id_salon) values(" + idres.Text + ",'" + dataGridView1.Rows[x].Cells[1].Value.ToString() + "')";
                        if (obDatos.insertar(sa))
                        {
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                    }
                }
                Principal p = new Principal();
                this.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
            MySqlCommand com = new MySqlCommand();
            com.CommandText = "select * from reserva where para_fecha='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
            com.Connection = cn;
            MySqlDataReader leer;
            leer = com.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Atencion ya exixte una reserva para la fecha " + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
            leer.Close();
            if (dateTimePicker1.Value < DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = dataGridView1.CurrentRow.Index;
            try
            {
                if (dataGridView1.Rows[filaseleccionada].Cells[0].Value.ToString() == "Reservado")
                {
                    dataGridView1.Rows[filaseleccionada].Cells[0].Value = "Desabilitado";
                }
                else
                {
                    dataGridView1.Rows[filaseleccionada].Cells[0].Value = "Reservado";
                }
            }
            catch
            { 
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dateTimePicker2.Value) < Convert.ToDateTime(dateTimePicker1.Value))
            {
                dateTimePicker2.Value = Convert.ToDateTime(dateTimePicker1.Value);
            }
            else
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
