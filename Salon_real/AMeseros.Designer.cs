namespace Salon_real
{
    partial class AMeseros
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cant = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.Label();
            this.id_vajilla = new System.Windows.Forms.Label();
            this.id_alquiler = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.horas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // costo_total
            // 
            this.costo_total.AutoSize = true;
            this.costo_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costo_total.Location = new System.Drawing.Point(502, 399);
            this.costo_total.Name = "costo_total";
            this.costo_total.Size = new System.Drawing.Size(18, 20);
            this.costo_total.TabIndex = 64;
            this.costo_total.Text = "_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(503, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "Costo total";
            // 
            // eli
            // 
            this.eli.AutoSize = true;
            this.eli.Location = new System.Drawing.Point(16, 382);
            this.eli.Name = "eli";
            this.eli.Size = new System.Drawing.Size(13, 13);
            this.eli.TabIndex = 62;
            this.eli.Text = "_";
            this.eli.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Lista de alquilados";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 56;
            this.button1.Text = "Contratar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cant
            // 
            this.cant.AutoSize = true;
            this.cant.Location = new System.Drawing.Point(192, 188);
            this.cant.Name = "cant";
            this.cant.Size = new System.Drawing.Size(13, 13);
            this.cant.TabIndex = 55;
            this.cant.Text = "_";
            this.cant.Visible = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(106, 188);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(13, 13);
            this.nombre.TabIndex = 52;
            this.nombre.Text = "_";
            // 
            // id_vajilla
            // 
            this.id_vajilla.AutoSize = true;
            this.id_vajilla.Location = new System.Drawing.Point(59, 188);
            this.id_vajilla.Name = "id_vajilla";
            this.id_vajilla.Size = new System.Drawing.Size(13, 13);
            this.id_vajilla.TabIndex = 51;
            this.id_vajilla.Text = "_";
            this.id_vajilla.Visible = false;
            // 
            // id_alquiler
            // 
            this.id_alquiler.AutoSize = true;
            this.id_alquiler.Location = new System.Drawing.Point(16, 188);
            this.id_alquiler.Name = "id_alquiler";
            this.id_alquiler.Size = new System.Drawing.Size(13, 13);
            this.id_alquiler.TabIndex = 50;
            this.id_alquiler.Text = "_";
            this.id_alquiler.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 234);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(537, 133);
            this.dataGridView2.TabIndex = 49;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Todas los meseros disponibles disponibles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(536, 139);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // horas
            // 
            this.horas.AutoSize = true;
            this.horas.Location = new System.Drawing.Point(12, 406);
            this.horas.Name = "horas";
            this.horas.Size = new System.Drawing.Size(13, 13);
            this.horas.TabIndex = 65;
            this.horas.Text = "0";
            // 
            // AMeseros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 428);
            this.Controls.Add(this.horas);
            this.Controls.Add(this.costo_total);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eli);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cant);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.id_vajilla);
            this.Controls.Add(this.id_alquiler);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AMeseros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato de meseros";
            this.Load += new System.EventHandler(this.AMeseros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label costo_total;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label eli;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label cant;
        private System.Windows.Forms.Label nombre;
        private System.Windows.Forms.Label id_vajilla;
        public System.Windows.Forms.Label id_alquiler;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label horas;
    }
}