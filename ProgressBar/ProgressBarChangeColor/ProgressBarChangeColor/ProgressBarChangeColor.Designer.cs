namespace ProgressBarChangeColor
{
    partial class ProgressBarChangeColor
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
            this.pbUno = new System.Windows.Forms.ProgressBar();
            this.pbDos = new System.Windows.Forms.ProgressBar();
            this.pbTres = new System.Windows.Forms.ProgressBar();
            this.btnColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pbUno
            // 
            this.pbUno.Location = new System.Drawing.Point(12, 12);
            this.pbUno.Name = "pbUno";
            this.pbUno.Size = new System.Drawing.Size(551, 39);
            this.pbUno.TabIndex = 0;
            // 
            // pbDos
            // 
            this.pbDos.Location = new System.Drawing.Point(12, 57);
            this.pbDos.Name = "pbDos";
            this.pbDos.Size = new System.Drawing.Size(551, 39);
            this.pbDos.TabIndex = 1;
            // 
            // pbTres
            // 
            this.pbTres.Location = new System.Drawing.Point(12, 102);
            this.pbTres.Name = "pbTres";
            this.pbTres.Size = new System.Drawing.Size(551, 39);
            this.pbTres.TabIndex = 2;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(456, 161);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(107, 37);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // ProgressBarChangeColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 253);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pbTres);
            this.Controls.Add(this.pbDos);
            this.Controls.Add(this.pbUno);
            this.Name = "ProgressBarChangeColor";
            this.Text = "Cambio de color de progress bar";
            this.Load += new System.EventHandler(this.ProgressBarChangeColor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbUno;
        private System.Windows.Forms.ProgressBar pbDos;
        private System.Windows.Forms.ProgressBar pbTres;
        private System.Windows.Forms.Button btnColor;
    }
}

