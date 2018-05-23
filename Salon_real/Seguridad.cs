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
    public partial class Seguridad : Form
    {
        public Seguridad()
        {
            InitializeComponent();
        }
        public static MySqlConnection cn;
        private void Seguridad_Load(object sender, EventArgs e)
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Ingrese los datos completos...!");
            }
            else
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandText = "select ci,nombre,apellidos,contraseña,cargo from empleado where ci=" + textBox1.Text;
                comando.Connection = cn;
                MySqlDataReader reader;
                reader = comando.ExecuteReader();
                if (reader.Read())
                {
                    if (textBox1.Text == reader[0].ToString() && textBox2.Text == reader[3].ToString())
                    {
                        MessageBox.Show("Acceso aceptado");
                        Principal Form_Vend = new Principal();
                        Form_Vend.lblusuario.Text = reader[1].ToString() + " " + reader[2].ToString();
                        Form_Vend.lbl_ciusuario.Text = reader[0].ToString();
                        Form_Vend.lblcargo.Text = reader[4].ToString();
                        this.Hide();
                        Form_Vend.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Acceso denegado...!!!");
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Acceso denegado....!!!");
                }
                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            this.Hide();
            p.ShowDialog();
        }
    }
}
