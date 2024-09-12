namespace binario
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
            this.tb_entrada = new System.Windows.Forms.TextBox();
            this.b_calcular = new System.Windows.Forms.Button();
            this.l_salida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_entrada
            // 
            this.tb_entrada.Location = new System.Drawing.Point(322, 180);
            this.tb_entrada.Name = "tb_entrada";
            this.tb_entrada.Size = new System.Drawing.Size(100, 20);
            this.tb_entrada.TabIndex = 0;
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(322, 207);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(100, 23);
            this.b_calcular.TabIndex = 1;
            this.b_calcular.Text = "Convertir";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // l_salida
            // 
            this.l_salida.AutoSize = true;
            this.l_salida.Location = new System.Drawing.Point(350, 246);
            this.l_salida.Name = "l_salida";
            this.l_salida.Size = new System.Drawing.Size(39, 13);
            this.l_salida.TabIndex = 2;
            this.l_salida.Text = "Binario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_salida);
            this.Controls.Add(this.b_calcular);
            this.Controls.Add(this.tb_entrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_entrada;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.Label l_salida;
    }
}

