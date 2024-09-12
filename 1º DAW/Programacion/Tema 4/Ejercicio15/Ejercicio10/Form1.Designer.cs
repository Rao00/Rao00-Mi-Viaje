namespace Ejercicio10
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
            this.bCalcular = new System.Windows.Forms.Button();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.lResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(171, 101);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 23);
            this.bCalcular.TabIndex = 0;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(171, 75);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtEntrada.TabIndex = 1;
            // 
            // lResultado
            // 
            this.lResultado.Location = new System.Drawing.Point(72, 127);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(301, 268);
            this.lResultado.TabIndex = 2;
            this.lResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lResultado);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.bCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label lResultado;
    }
}

