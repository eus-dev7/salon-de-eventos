namespace Salon_real
{
    partial class AInsumos
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
            this.costo_total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.eli = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cant_res = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cant = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.id_vajilla = new System.Windows.Forms.Label();
            this.id_alquiler = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // costo_total
            // 
            this.costo_total.AutoSize = true;
            this.costo_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo_total.Location = new System.Drawing.Point(498, 400);
            this.costo_total.Name = "costo_total";
            this.costo_total.Size = new System.Drawing.Size(18, 20);
            this.costo_total.TabIndex = 46;
            this.costo_total.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Costo total";
            // 
            // eli
            // 
            this.eli.AutoSize = true;
            this.eli.Location = new System.Drawing.Point(12, 383);
            this.eli.Name = "eli";
            this.eli.Size = new System.Drawing.Size(13, 13);
            this.eli.TabIndex = 44;
            this.eli.Text = "_";
            this.eli.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 374);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cant_res
            // 
            this.cant_res.Location = new System.Drawing.Point(149, 376);
            this.cant_res.Name = "cant_res";
            this.cant_res.Size = new System.Drawing.Size(88, 20);
            this.cant_res.TabIndex = 42;
            this.cant_res.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cant_res_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Modificar cantidad";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(333, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Lista de alquilados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "Alquilar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Location = new System.Drawing.Point(188, 189);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(13, 13);
            this.cant.TabIndex = 37;
            this.cant.Text = "_";
            this.cant.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Cantidad";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(297, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(102, 189);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(13, 13);
            this.nombre.TabIndex = 34;
            this.nombre.Text = "_";
            // 
            // id_vajilla
            // 
            this.id_vajilla.AutoSize = true;
            this.id_vajilla.Location = new System.Drawing.Point(55, 189);
            this.id_vajilla.Name = "id_vajilla";
            this.id_vajilla.Size = new System.Drawing.Size(13, 13);
            this.id_vajilla.TabIndex = 33;
            this.id_vajilla.Text = "_";
            this.id_vajilla.Visible = false;
            // 
            // id_alquiler
            // 
            this.id_alquiler.AutoSize = true;
            this.id_alquiler.Location = new System.Drawing.Point(12, 189);
            this.id_alquiler.Name = "id_alquiler";
            this.id_alquiler.Size = new System.Drawing.Size(13, 13);
            this.id_alquiler.TabIndex = 32;
            this.id_alquiler.Text = "_";
            this.id_alquiler.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 235);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 133);
            this.dataGridView2.TabIndex = 31;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Todas los insumos disponibles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 139);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 426);
            this.Controls.Add(this.costo_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eli);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cant_res);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id_vajilla);
            this.Controls.Add(this.id_alquiler);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alquiler de insumos";
            this.Load += new System.EventHandler(this.AInsumos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label costo_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eli;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cant_res;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label id_vajilla;
        public System.Windows.Forms.Label id_alquiler;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}