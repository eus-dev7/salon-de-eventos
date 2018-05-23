namespace Salon_real
{
    partial class Control_Empleados
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cargoemp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.diremp = new System.Windows.Forms.TextBox();
            this.telfemp = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.apemp = new System.Windows.Forms.TextBox();
            this.nomemp = new System.Windows.Forms.TextBox();
            this.ciemp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.sueldo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 49;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(736, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 48;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(638, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Vaciar casilleros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(587, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(587, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(587, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cargo";
            // 
            // cargoemp
            // 
            this.cargoemp.FormattingEnabled = true;
            this.cargoemp.Items.AddRange(new object[] {
            "Administrador",
            "Mesero"});
            this.cargoemp.Location = new System.Drawing.Point(654, 182);
            this.cargoemp.Name = "cargoemp";
            this.cargoemp.Size = new System.Drawing.Size(146, 21);
            this.cargoemp.TabIndex = 42;
            this.cargoemp.VisibleChanged += new System.EventHandler(this.cargoemp_VisibleChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(587, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "CI";
            // 
            // diremp
            // 
            this.diremp.Location = new System.Drawing.Point(645, 295);
            this.diremp.Name = "diremp";
            this.diremp.Size = new System.Drawing.Size(155, 20);
            this.diremp.TabIndex = 38;
            // 
            // telfemp
            // 
            this.telfemp.Location = new System.Drawing.Point(645, 257);
            this.telfemp.Name = "telfemp";
            this.telfemp.Size = new System.Drawing.Size(155, 20);
            this.telfemp.TabIndex = 37;
            this.telfemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telfemp_KeyPress);
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(654, 217);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(146, 20);
            this.contraseña.TabIndex = 36;
            // 
            // apemp
            // 
            this.apemp.Location = new System.Drawing.Point(642, 142);
            this.apemp.Name = "apemp";
            this.apemp.Size = new System.Drawing.Size(158, 20);
            this.apemp.TabIndex = 35;
            // 
            // nomemp
            // 
            this.nomemp.Location = new System.Drawing.Point(642, 99);
            this.nomemp.Name = "nomemp";
            this.nomemp.Size = new System.Drawing.Size(158, 20);
            this.nomemp.TabIndex = 34;
            // 
            // ciemp
            // 
            this.ciemp.Location = new System.Drawing.Point(638, 50);
            this.ciemp.Name = "ciemp";
            this.ciemp.Size = new System.Drawing.Size(162, 20);
            this.ciemp.TabIndex = 33;
            this.ciemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ciemp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Buscar CI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 329);
            this.dataGridView1.TabIndex = 30;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "sueldo";
            // 
            // sueldo
            // 
            this.sueldo.Location = new System.Drawing.Point(645, 325);
            this.sueldo.Name = "sueldo";
            this.sueldo.Size = new System.Drawing.Size(155, 20);
            this.sueldo.TabIndex = 51;
            // 
            // Control_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 401);
            this.Controls.Add(this.sueldo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cargoemp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diremp);
            this.Controls.Add(this.telfemp);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.apemp);
            this.Controls.Add(this.nomemp);
            this.Controls.Add(this.ciemp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Control_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control_Empleados";
            this.Load += new System.EventHandler(this.Control_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cargoemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox diremp;
        private System.Windows.Forms.TextBox telfemp;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.TextBox apemp;
        private System.Windows.Forms.TextBox nomemp;
        private System.Windows.Forms.TextBox ciemp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sueldo;
    }
}