namespace Ejercicio11
{
    partial class Ejercicio11
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
            this.tb_cliente = new System.Windows.Forms.TextBox();
            this.l_cliente = new System.Windows.Forms.Label();
            this.tb_interes = new System.Windows.Forms.TextBox();
            this.l_interes = new System.Windows.Forms.Label();
            this.l_resultado = new System.Windows.Forms.Label();
            this.b_calcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_cliente
            // 
            this.tb_cliente.Location = new System.Drawing.Point(165, 136);
            this.tb_cliente.Name = "tb_cliente";
            this.tb_cliente.Size = new System.Drawing.Size(100, 20);
            this.tb_cliente.TabIndex = 0;
            this.tb_cliente.TextChanged += new System.EventHandler(this.tb_cliente_TextChanged);
            // 
            // l_cliente
            // 
            this.l_cliente.AutoSize = true;
            this.l_cliente.Location = new System.Drawing.Point(55, 139);
            this.l_cliente.Name = "l_cliente";
            this.l_cliente.Size = new System.Drawing.Size(108, 13);
            this.l_cliente.TabIndex = 1;
            this.l_cliente.Text = "Cantidad Ingresada =";
            // 
            // tb_interes
            // 
            this.tb_interes.Location = new System.Drawing.Point(165, 174);
            this.tb_interes.Name = "tb_interes";
            this.tb_interes.Size = new System.Drawing.Size(100, 20);
            this.tb_interes.TabIndex = 2;
            // 
            // l_interes
            // 
            this.l_interes.AutoSize = true;
            this.l_interes.Location = new System.Drawing.Point(84, 177);
            this.l_interes.Name = "l_interes";
            this.l_interes.Size = new System.Drawing.Size(78, 13);
            this.l_interes.TabIndex = 3;
            this.l_interes.Text = "Interés Anual =";
            // 
            // l_resultado
            // 
            this.l_resultado.AutoSize = true;
            this.l_resultado.Location = new System.Drawing.Point(162, 209);
            this.l_resultado.Name = "l_resultado";
            this.l_resultado.Size = new System.Drawing.Size(76, 13);
            this.l_resultado.TabIndex = 4;
            this.l_resultado.Text = "Capital Final = ";
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(163, 235);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(102, 23);
            this.b_calcular.TabIndex = 5;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // Ejercicio11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.b_calcular);
            this.Controls.Add(this.l_resultado);
            this.Controls.Add(this.l_interes);
            this.Controls.Add(this.tb_interes);
            this.Controls.Add(this.l_cliente);
            this.Controls.Add(this.tb_cliente);
            this.Name = "Ejercicio11";
            this.Text = "Ejercicio11";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_cliente;
        private System.Windows.Forms.Label l_cliente;
        private System.Windows.Forms.TextBox tb_interes;
        private System.Windows.Forms.Label l_interes;
        private System.Windows.Forms.Label l_resultado;
        private System.Windows.Forms.Button b_calcular;
    }
}

