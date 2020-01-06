namespace ConvertirBinarioString
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
            this.tbxBinario = new System.Windows.Forms.TextBox();
            this.tbxCadena = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxBinario
            // 
            this.tbxBinario.Location = new System.Drawing.Point(12, 12);
            this.tbxBinario.Multiline = true;
            this.tbxBinario.Name = "tbxBinario";
            this.tbxBinario.Size = new System.Drawing.Size(414, 108);
            this.tbxBinario.TabIndex = 1;
            // 
            // tbxCadena
            // 
            this.tbxCadena.Location = new System.Drawing.Point(12, 126);
            this.tbxCadena.Multiline = true;
            this.tbxCadena.Name = "tbxCadena";
            this.tbxCadena.Size = new System.Drawing.Size(414, 108);
            this.tbxCadena.TabIndex = 2;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(336, 255);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(90, 42);
            this.btnConvertir.TabIndex = 3;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 410);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.tbxCadena);
            this.Controls.Add(this.tbxBinario);
            this.Name = "Form1";
            this.Text = "Convertir de binario a cadena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxBinario;
        private System.Windows.Forms.TextBox tbxCadena;
        private System.Windows.Forms.Button btnConvertir;
    }
}

