namespace Ejercicio06
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
            this.bCal = new System.Windows.Forms.Button();
            this.tbNota = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCal
            // 
            this.bCal.Location = new System.Drawing.Point(331, 219);
            this.bCal.Name = "bCal";
            this.bCal.Size = new System.Drawing.Size(100, 23);
            this.bCal.TabIndex = 0;
            this.bCal.Text = "Calificar";
            this.bCal.UseVisualStyleBackColor = true;
            this.bCal.Click += new System.EventHandler(this.bCal_Click);
            // 
            // tbNota
            // 
            this.tbNota.Location = new System.Drawing.Point(331, 179);
            this.tbNota.Name = "tbNota";
            this.tbNota.Size = new System.Drawing.Size(100, 20);
            this.tbNota.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNota);
            this.Controls.Add(this.bCal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCal;
        private System.Windows.Forms.TextBox tbNota;
    }
}

