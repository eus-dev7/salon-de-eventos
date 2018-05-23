using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows.Forms;

namespace Salon_real
{
    public partial class Alquiler : Form
    {
        public Alquiler()
        {
            InitializeComponent();
        }
        private MySqlConnection cn;
        private Conexion obDatos;
        private void Alquiler_Load(object sender, EventArgs e)
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
            groupBox2.Visible = false;
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.CustomFormat = "H:mm";
            dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker4.ShowUpDown = true;
            dateTimePicker4.CustomFormat = "H:mm";
            dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            textBox5.Enabled = false;
            cargar_datos();
            cargar_salones();
            calcular_total();
        }
        void cargar_datos()
        {
            MySqlCommand com = new MySqlCommand();
            com.CommandText = "select evento,hora_i,hora_f,num_personas,para_fecha,hasta_fecha,garantia from reserva where id=" + id_reserva.Text;
            com.Connection = cn;
            MySqlDataReader leer;
            leer = com.ExecuteReader();
            if (leer.Read())
            {
                textBox1.Text = leer[0].ToString();
                dateTimePicker3.Text = leer[1].ToString();
                dateTimePicker4.Text = leer[2].ToString();
                textBox4.Text = leer[3].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(leer[4].ToString());
                dateTimePicker2.Value = Convert.ToDateTime(leer[5].ToString());
                textBox5.Text = leer[6].ToString();

            }
            else
            {
            }
            leer.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value;
            /*MySqlCommand com = new MySqlCommand();
            com.CommandText = "select * from reserva where para_fecha='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "'";
            com.Connection = cn;
            MySqlDataReader leer;
            leer = com.ExecuteReader();
            if (leer.Read())
            {
                MessageBox.Show("Atencion ya exixte una reserva para la fecha " + dateTimePicker1.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
            }
            leer.Close();*/
            if (dateTimePicker1.Value < DateTime.Now)
            {
                dateTimePicker1.Value = DateTime.Now;
            }
            else
            {
            }
        }
        void cargar_salones()
        {

            obDatos = new Conexion();
            obDatos.consultar("select * from salon", "salon");
            this.dataGridView1.DataSource = obDatos.ds.Tables["salon"];
            this.dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "Desabilitado";
            }
            int p = 0;
            MySqlCommand comando = new MySqlCommand();
            comando.CommandText = "select id_salon from res_salon where id_reserva=" + id_reserva.Text;
            comando.Connection = cn;
            MySqlDataReader reader;
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (reader[0].ToString() == dataGridView1.Rows[i].Cells[1].Value.ToString())
                    {
                        dataGridView1.Rows[i].Cells[0].Value = "Reservado";
                    }
                    else
                    { 
                    }
                }
                p++;
            }
            reader.Close();

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

        private void button5_Click(object sender, EventArgs e)
        {
            AVajillas r = new AVajillas();
            r.id_alquiler.Text = id_reserva.Text;
            if (r.ShowDialog() == DialogResult.OK)
            {
                costo_vajilla.Text = r.costo_total.Text;
                calcular_total();
            }
            else
            {
                costo_vajilla.Text = r.costo_total.Text;
                calcular_total();
            }
        }

        void calcular_total()
        {
            tot_alqu.Text = Convert.ToString(Convert.ToDouble(costo_insumo.Text) + Convert.ToDouble(costo_vajilla.Text)+Convert.ToDouble(costo_meseros.Text));
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Reservado")
                {
                    tot_alqu.Text = Convert.ToString(Convert.ToDouble(tot_alqu.Text) + Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value.ToString()));
                }
            }
            tot_alqu.Text=Convert.ToString(Convert.ToDouble(tot_alqu.Text)+Convert.ToDouble(textBox5.Text));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AInsumos i = new AInsumos();
            i.id_alquiler.Text = id_reserva.Text;
            if (i.ShowDialog() == DialogResult.OK)
            {
                costo_insumo.Text = i.costo_total.Text;
                calcular_total();
            }
            else
            {
                costo_insumo.Text = i.costo_total.Text;
                calcular_total();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (horas.Text == "")
            {
                MessageBox.Show("ingrese horas de contrato de los meseros");
            }
            else
            {
                AMeseros m = new AMeseros();
                m.id_alquiler.Text = id_reserva.Text;
                m.horas.Text = horas.Text;
                if (m.ShowDialog() == DialogResult.OK)
                {
                    costo_meseros.Text = m.costo_total.Text;
                    calcular_total();
                }
                else
                {
                    costo_meseros.Text = m.costo_total.Text;
                    calcular_total();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            string campos = "evento='" + textBox1.Text + "',para_fecha='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',hora_i='" + dateTimePicker3.Text + "',hasta_fecha='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',hora_f='" + dateTimePicker4.Text + "', num_personas=" + textBox4.Text + ",garantia=" + textBox5.Text;
            if (obDatos.actualizar("reserva", campos, " id = " + id_reserva.Text + ""))
            {

            }
            else
            {
            }
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Reservado")
                {
                    try
                    {
                        obDatos = new Conexion();
                        string mr = "insert into res_salon(id_reserva,id_salon) values(" + id_reserva.Text + ",'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "')";
                        if (obDatos.insertar(mr))
                        {
                        }
                        else
                        {
                        }
                    }
                    catch
                    {

                    }
                }
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Desabilitado")
                {
                    try
                    {
                        obDatos = new Conexion();
                        if (obDatos.eliminar("res_salon", "id_reserva = '" + id_reserva.Text + "' and id_salon='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'"))
                        {
                        }
                        else
                        {
                        }
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcular_total();
            groupBox2.Visible = true;
            button2.Enabled = false;
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                MessageBox.Show("Ingrese un monto de garantia");
            }
            else
            {
                obDatos = new Conexion();
                string campos = "evento='" + textBox1.Text + "',para_fecha='" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',hora_i='" + dateTimePicker3.Text + "',hasta_fecha='" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',hora_f='" + dateTimePicker4.Text + "', num_personas=" + textBox4.Text + ",garantia=" + textBox5.Text;
                if (obDatos.actualizar("reserva", campos, " id = " + id_reserva.Text + ""))
                {

                }
                else
                {
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Reservado")
                    {
                        try
                        {
                            obDatos = new Conexion();
                            string mr = "insert into res_salon(id_reserva,id_salon) values(" + id_reserva.Text + ",'" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "')";
                            if (obDatos.insertar(mr))
                            {
                            }
                            else
                            {
                            }
                        }
                        catch
                        {

                        }
                    }
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Desabilitado")
                    {
                        try
                        {
                            obDatos = new Conexion();
                            if (obDatos.eliminar("res_salon", "id_reserva = '" + id_reserva.Text + "' and id_salon='" + dataGridView1.Rows[i].Cells[1].Value.ToString() + "'"))
                            {
                                MessageBox.Show("Registro eliminado");
                            }
                            else
                            {
                                MessageBox.Show("error al eliminar");
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                obDatos = new Conexion();
                string alq = "insert into alquiler(id,estado,id_reserva,fecha_conf,monto_total,garantia) values(" + id_reserva.Text + ",'Activado'," + id_reserva.Text + ",curdate()," + tot_alqu.Text + "," + textBox7.Text + ")";
                if (obDatos.insertar(alq))
                {
                }
                else
                {
                }
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            obDatos = new Conexion();
            string alq = "insert into alquiler(id,estado,id_reserva,fecha_conf,monto_total,garantia) values(" + id_reserva.Text + ",'Cancelado'," + id_reserva.Text + ",curdate(),0,0)";
            if (obDatos.insertar(alq))
            {
            }
            else
            {
            }
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void horas_KeyPress(object sender, KeyPressEventArgs e)
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
