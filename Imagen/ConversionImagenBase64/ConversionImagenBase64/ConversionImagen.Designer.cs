namespace ConversionImagenBase64
{
    partial class ConversionImagen
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
            this.pbOrigen = new System.Windows.Forms.PictureBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBase = new System.Windows.Forms.Button();
            this.lbBase = new System.Windows.Forms.Label();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnImagen = new System.Windows.Forms.Button();
            this.pbConversion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrigen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConversion)).BeginInit();
            this.SuspendLayout();
            // 
            // pbOrigen
            // 
            this.pbOrigen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbOrigen.Location = new System.Drawing.Point(22, 12);
            this.pbOrigen.Name = "pbOrigen";
            this.pbOrigen.Size = new System.Drawing.Size(266, 325);
            this.pbOrigen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOrigen.TabIndex = 0;
            this.pbOrigen.TabStop = false;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(185, 359);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(103, 44);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBase
            // 
            this.btnBase.Location = new System.Drawing.Point(185, 418);
            this.btnBase.Name = "btnBase";
            this.btnBase.Size = new System.Drawing.Size(103, 44);
            this.btnBase.TabIndex = 2;
            this.btnBase.Text = "Img a 64";
            this.btnBase.UseVisualStyleBackColor = true;
            this.btnBase.Click += new System.EventHandler(this.btnBase_Click);
            // 
            // lbBase
            // 
            this.lbBase.AutoSize = true;
            this.lbBase.Location = new System.Drawing.Point(325, 12);
            this.lbBase.Name = "lbBase";
            this.lbBase.Size = new System.Drawing.Size(60, 17);
            this.lbBase.TabIndex = 3;
            this.lbBase.Text = "Base 64";
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(328, 42);
            this.txtBase.Multiline = true;
            this.txtBase.Name = "txtBase";
            this.txtBase.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBase.Size = new System.Drawing.Size(484, 295);
            this.txtBase.TabIndex = 4;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(185, 477);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(103, 44);
            this.btnImagen.TabIndex = 5;
            this.btnImagen.Text = "64 a img";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // pbConversion
            // 
            this.pbConversion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbConversion.Location = new System.Drawing.Point(328, 343);
            this.pbConversion.Name = "pbConversion";
            this.pbConversion.Size = new System.Drawing.Size(266, 325);
            this.pbConversion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbConversion.TabIndex = 6;
            this.pbConversion.TabStop = false;
            // 
            // ConversionImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 683);
            this.Controls.Add(this.pbConversion);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lbBase);
            this.Controls.Add(this.btnBase);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.pbOrigen);
            this.Name = "ConversionImagen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbOrigen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConversion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbOrigen;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnBase;
        private System.Windows.Forms.Label lbBase;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnImagen;
        private System.Windows.Forms.PictureBox pbConversion;
    }
}

