namespace Ejercicio27
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
            this.bPrimo = new System.Windows.Forms.Button();
            this.txtPrimo = new System.Windows.Forms.TextBox();
            this.txtPrimo2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bPrimo
            // 
            this.bPrimo.Location = new System.Drawing.Point(350, 182);
            this.bPrimo.Name = "bPrimo";
            this.bPrimo.Size = new System.Drawing.Size(100, 46);
            this.bPrimo.TabIndex = 0;
            this.bPrimo.Text = "Primo";
            this.bPrimo.UseVisualStyleBackColor = true;
            this.bPrimo.Click += new System.EventHandler(this.bPrimo_Click);
            // 
            // txtPrimo
            // 
            this.txtPrimo.Location = new System.Drawing.Point(293, 156);
            this.txtPrimo.Name = "txtPrimo";
            this.txtPrimo.Size = new System.Drawing.Size(100, 20);
            this.txtPrimo.TabIndex = 1;
            // 
            // txtPrimo2
            // 
            this.txtPrimo2.Location = new System.Drawing.Point(399, 156);
            this.txtPrimo2.Name = "txtPrimo2";
            this.txtPrimo2.Size = new System.Drawing.Size(100, 20);
            this.txtPrimo2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrimo2);
            this.Controls.Add(this.txtPrimo);
            this.Controls.Add(this.bPrimo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bPrimo;
        private System.Windows.Forms.TextBox txtPrimo;
        private System.Windows.Forms.TextBox txtPrimo2;
    }
}

