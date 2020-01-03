namespace ConvertirStringBinario
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
            this.tbxString = new System.Windows.Forms.TextBox();
            this.tbxBinary = new System.Windows.Forms.TextBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxString
            // 
            this.tbxString.Location = new System.Drawing.Point(12, 12);
            this.tbxString.Multiline = true;
            this.tbxString.Name = "tbxString";
            this.tbxString.Size = new System.Drawing.Size(414, 108);
            this.tbxString.TabIndex = 0;
            // 
            // tbxBinary
            // 
            this.tbxBinary.Location = new System.Drawing.Point(12, 136);
            this.tbxBinary.Multiline = true;
            this.tbxBinary.Name = "tbxBinary";
            this.tbxBinary.Size = new System.Drawing.Size(414, 108);
            this.tbxBinary.TabIndex = 1;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(336, 263);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(90, 42);
            this.btnConvertir.TabIndex = 2;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 556);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.tbxBinary);
            this.Controls.Add(this.tbxString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxString;
        private System.Windows.Forms.TextBox tbxBinary;
        private System.Windows.Forms.Button btnConvertir;
    }
}

