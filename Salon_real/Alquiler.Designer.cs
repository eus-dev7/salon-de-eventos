namespace Salon_real
{
    partial class Alquiler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.horas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.costo_meseros = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.costo_vajilla = new System.Windows.Forms.Label();
            this.costo_insumo = new System.Windows.Forms.Label();
            this.tot_alqu = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id_reserva = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 195);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(79, 28);
            this.button5.TabIndex = 22;
            this.button5.Text = "Vajillas";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 229);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 27);
            this.button4.TabIndex = 21;
            this.button4.Text = "Insumos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(611, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 28);
            this.button2.TabIndex = 19;
            this.button2.Text = "Guardar reserva";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.horas);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.costo_meseros);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.costo_vajilla);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.costo_insumo);
            this.groupBox2.Controls.Add(this.tot_alqu);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(375, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 261);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(236, 214);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 41);
            this.button8.TabIndex = 34;
            this.button8.Text = "Guardar alquiler";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // horas
            // 
            this.horas.Location = new System.Drawing.Point(283, 159);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(86, 20);
            this.horas.TabIndex = 33;
            this.horas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.horas_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(102, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(175, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "horas de contrato de meseros";
            // 
            // costo_meseros
            // 
            this.costo_meseros.AutoSize = true;
            this.costo_meseros.Location = new System.Drawing.Point(281, 137);
            this.costo_meseros.Name = "costo_meseros";
            this.costo_meseros.Size = new System.Drawing.Size(14, 13);
            this.costo_meseros.TabIndex = 31;
            this.costo_meseros.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(202, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Costo de Meseros es";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(202, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(150, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Costo total de vajillas es:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Costo total de insumos es:";
            // 
            // costo_vajilla
            // 
            this.costo_vajilla.AutoSize = true;
            this.costo_vajilla.Location = new System.Drawing.Point(281, 73);
            this.costo_vajilla.Name = "costo_vajilla";
            this.costo_vajilla.Size = new System.Drawing.Size(14, 13);
            this.costo_vajilla.TabIndex = 27;
            this.costo_vajilla.Text = "0";
            // 
            // costo_insumo
            // 
            this.costo_insumo.AutoSize = true;
            this.costo_insumo.Location = new System.Drawing.Point(281, 41);
            this.costo_insumo.Name = "costo_insumo";
            this.costo_insumo.Size = new System.Drawing.Size(14, 13);
            this.costo_insumo.TabIndex = 26;
            this.costo_insumo.Text = "0";
            // 
            // tot_alqu
            // 
            this.tot_alqu.AutoSize = true;
            this.tot_alqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tot_alqu.Location = new System.Drawing.Point(32, 54);
            this.tot_alqu.Name = "tot_alqu";
            this.tot_alqu.Size = new System.Drawing.Size(19, 20);
            this.tot_alqu.TabIndex = 25;
            this.tot_alqu.Text = "0";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 154);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 28);
            this.button6.TabIndex = 24;
            this.button6.Text = "Meseros";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(36, 118);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(99, 20);
            this.textBox7.TabIndex = 4;
            this.textBox7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox7_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Monto de garantia del alquiler";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Monto total de alquiler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alquilar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.id_reserva);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(14, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 265);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de reserva";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(97, 167);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker4.TabIndex = 17;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(97, 103);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(94, 20);
            this.dateTimePicker3.TabIndex = 16;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(97, 134);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(103, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(126, 235);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 20);
            this.textBox5.TabIndex = 13;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(140, 200);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 20);
            this.textBox4.TabIndex = 12;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reserva nº";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Garantia";
            // 
            // id_reserva
            // 
            this.id_reserva.AutoSize = true;
            this.id_reserva.Location = new System.Drawing.Point(122, 17);
            this.id_reserva.Name = "id_reserva";
            this.id_reserva.Size = new System.Drawing.Size(14, 13);
            this.id_reserva.TabIndex = 1;
            this.id_reserva.Text = "_";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fecha de fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Evento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Fecha inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora inicio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cantidad de personas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hora fin";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(14, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 143);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(611, 330);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(116, 23);
            this.button7.TabIndex = 24;
            this.button7.Text = "Cancelar reserva";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Alquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 434);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Alquiler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler";
            this.Load += new System.EventHandler(this.Alquiler_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label id_reserva;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.Button button6;
        public System.Windows.Forms.Label tot_alqu;
        private System.Windows.Forms.Label costo_vajilla;
        private System.Windows.Forms.Label costo_insumo;
        private System.Windows.Forms.Label costo_meseros;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.TextBox horas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}