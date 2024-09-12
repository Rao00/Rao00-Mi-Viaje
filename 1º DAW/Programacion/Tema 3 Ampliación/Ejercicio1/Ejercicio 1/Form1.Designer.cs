namespace Ejercicio_1
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
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.bIzq = new System.Windows.Forms.Button();
            this.bDer = new System.Windows.Forms.Button();
            this.lSalida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(292, 38);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(231, 20);
            this.txtEntrada.TabIndex = 0;
            // 
            // bIzq
            // 
            this.bIzq.Location = new System.Drawing.Point(141, 74);
            this.bIzq.Name = "bIzq";
            this.bIzq.Size = new System.Drawing.Size(260, 70);
            this.bIzq.TabIndex = 1;
            this.bIzq.Text = "Izquierda";
            this.bIzq.UseVisualStyleBackColor = true;
            this.bIzq.Click += new System.EventHandler(this.bIzq_Click);
            // 
            // bDer
            // 
            this.bDer.Location = new System.Drawing.Point(407, 74);
            this.bDer.Name = "bDer";
            this.bDer.Size = new System.Drawing.Size(260, 70);
            this.bDer.TabIndex = 2;
            this.bDer.Text = "Derecha";
            this.bDer.UseVisualStyleBackColor = true;
            this.bDer.Click += new System.EventHandler(this.bDer_Click);
            // 
            // lSalida
            // 
            this.lSalida.Location = new System.Drawing.Point(289, 147);
            this.lSalida.MaximumSize = new System.Drawing.Size(300, 300);
            this.lSalida.MinimumSize = new System.Drawing.Size(160, 300);
            this.lSalida.Name = "lSalida";
            this.lSalida.Size = new System.Drawing.Size(231, 300);
            this.lSalida.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSalida);
            this.Controls.Add(this.bDer);
            this.Controls.Add(this.bIzq);
            this.Controls.Add(this.txtEntrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button bIzq;
        private System.Windows.Forms.Button bDer;
        private System.Windows.Forms.Label lSalida;
    }
}

