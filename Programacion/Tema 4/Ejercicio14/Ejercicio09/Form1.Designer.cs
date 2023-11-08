namespace Ejercicio09
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
            this.lResultado = new System.Windows.Forms.Label();
            this.bCalcular = new System.Windows.Forms.Button();
            this.txtPesetas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lResultado
            // 
            this.lResultado.Location = new System.Drawing.Point(125, 132);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(148, 237);
            this.lResultado.TabIndex = 0;
            this.lResultado.Text = "Resultado";
            this.lResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(151, 102);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 23);
            this.bCalcular.TabIndex = 1;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // txtPesetas
            // 
            this.txtPesetas.Location = new System.Drawing.Point(151, 76);
            this.txtPesetas.Name = "txtPesetas";
            this.txtPesetas.Size = new System.Drawing.Size(100, 20);
            this.txtPesetas.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPesetas);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.lResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lResultado;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox txtPesetas;
    }
}

