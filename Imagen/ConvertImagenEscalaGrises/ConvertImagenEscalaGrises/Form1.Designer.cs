namespace ConvertImagenEscalaGrises
{
    partial class Form1
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
            this.pbCargaImagen = new System.Windows.Forms.PictureBox();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.pbConversion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCargaImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCargaImagen
            // 
            this.pbCargaImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCargaImagen.Location = new System.Drawing.Point(24, 12);
            this.pbCargaImagen.Name = "pbCargaImagen";
            this.pbCargaImagen.Size = new System.Drawing.Size(459, 574);
            this.pbCargaImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCargaImagen.TabIndex = 0;
            this.pbCargaImagen.TabStop = false;
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(390, 606);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(93, 41);
            this.btnCargarImagen.TabIndex = 1;
            this.btnCargarImagen.Text = "Cargar";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.btnCargarImagen_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(900, 606);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(93, 41);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // pbConversion
            // 
            this.pbConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbConversion.Location = new System.Drawing.Point(534, 12);
            this.pbConversion.Name = "pbConversion";
            this.pbConversion.Size = new System.Drawing.Size(459, 574);
            this.pbConversion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConversion.TabIndex = 2;
            this.pbConversion.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 779);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.pbConversion);
            this.Controls.Add(this.btnCargarImagen);
            this.Controls.Add(this.pbCargaImagen);
            this.Name = "Form1";
            this.Text = "Convertir imagen a escala de grises";
            ((System.ComponentModel.ISupportInitialize)(this.pbCargaImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConversion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCargaImagen;
        private System.Windows.Forms.Button btnCargarImagen;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.PictureBox pbConversion;
    }
}

