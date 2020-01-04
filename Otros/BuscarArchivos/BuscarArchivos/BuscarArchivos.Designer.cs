namespace BuscarArchivos
{
    partial class BuscarArchivos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRuta = new System.Windows.Forms.TextBox();
            this.btnRuta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxBusqueda = new System.Windows.Forms.TextBox();
            this.pbCarga = new System.Windows.Forms.ProgressBar();
            this.lbPorcentaje = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEstatus = new System.Windows.Forms.Label();
            this.bwBusqueda = new System.ComponentModel.BackgroundWorker();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta:";
            // 
            // tbxRuta
            // 
            this.tbxRuta.Enabled = false;
            this.tbxRuta.Location = new System.Drawing.Point(79, 9);
            this.tbxRuta.Name = "tbxRuta";
            this.tbxRuta.Size = new System.Drawing.Size(649, 22);
            this.tbxRuta.TabIndex = 1;
            // 
            // btnRuta
            // 
            this.btnRuta.Location = new System.Drawing.Point(734, 6);
            this.btnRuta.Name = "btnRuta";
            this.btnRuta.Size = new System.Drawing.Size(37, 25);
            this.btnRuta.TabIndex = 2;
            this.btnRuta.Text = "...";
            this.btnRuta.UseVisualStyleBackColor = true;
            this.btnRuta.Click += new System.EventHandler(this.btnRuta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Archivo:";
            // 
            // tbxBusqueda
            // 
            this.tbxBusqueda.Location = new System.Drawing.Point(77, 53);
            this.tbxBusqueda.Name = "tbxBusqueda";
            this.tbxBusqueda.Size = new System.Drawing.Size(649, 22);
            this.tbxBusqueda.TabIndex = 4;
            // 
            // pbCarga
            // 
            this.pbCarga.Location = new System.Drawing.Point(79, 94);
            this.pbCarga.Name = "pbCarga";
            this.pbCarga.Size = new System.Drawing.Size(647, 23);
            this.pbCarga.TabIndex = 5;
            // 
            // lbPorcentaje
            // 
            this.lbPorcentaje.AutoSize = true;
            this.lbPorcentaje.Location = new System.Drawing.Point(732, 94);
            this.lbPorcentaje.Name = "lbPorcentaje";
            this.lbPorcentaje.Size = new System.Drawing.Size(20, 17);
            this.lbPorcentaje.TabIndex = 6;
            this.lbPorcentaje.Text = "%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado:";
            // 
            // lbEstatus
            // 
            this.lbEstatus.AutoSize = true;
            this.lbEstatus.Location = new System.Drawing.Point(76, 144);
            this.lbEstatus.Name = "lbEstatus";
            this.lbEstatus.Size = new System.Drawing.Size(20, 17);
            this.lbEstatus.TabIndex = 8;
            this.lbEstatus.Text = "...";
            // 
            // bwBusqueda
            // 
            this.bwBusqueda.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwBusqueda_DoWork);
            this.bwBusqueda.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwBusqueda_ProgressChanged);
            this.bwBusqueda.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwBusqueda_RunWorkerCompleted);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(651, 556);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(75, 23);
            this.btnBusqueda.TabIndex = 10;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Ruta,
            this.Tamano});
            this.dataGridView1.Location = new System.Drawing.Point(79, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(649, 363);
            this.dataGridView1.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 87;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.Width = 67;
            // 
            // Tamano
            // 
            this.Tamano.HeaderText = "Tamaño";
            this.Tamano.Name = "Tamano";
            this.Tamano.Width = 89;
            // 
            // BuscarArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 684);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.lbEstatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPorcentaje);
            this.Controls.Add(this.pbCarga);
            this.Controls.Add(this.tbxBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRuta);
            this.Controls.Add(this.tbxRuta);
            this.Controls.Add(this.label1);
            this.Name = "BuscarArchivos";
            this.Text = "Buscar Archivos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRuta;
        private System.Windows.Forms.Button btnRuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxBusqueda;
        private System.Windows.Forms.ProgressBar pbCarga;
        private System.Windows.Forms.Label lbPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEstatus;
        private System.ComponentModel.BackgroundWorker bwBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tamano;
    }
}

