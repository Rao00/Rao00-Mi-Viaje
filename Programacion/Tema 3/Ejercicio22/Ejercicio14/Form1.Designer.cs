namespace Ejercicio14
{
    partial class Ejercicio22
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
            this.bComprobar = new System.Windows.Forms.Button();
            this.lSalida = new System.Windows.Forms.Label();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bComprobar
            // 
            this.bComprobar.Location = new System.Drawing.Point(220, 84);
            this.bComprobar.Name = "bComprobar";
            this.bComprobar.Size = new System.Drawing.Size(112, 20);
            this.bComprobar.TabIndex = 0;
            this.bComprobar.Text = "Comprobar";
            this.bComprobar.UseVisualStyleBackColor = true;
            this.bComprobar.Click += new System.EventHandler(this.bInput_Click);
            // 
            // lSalida
            // 
            this.lSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSalida.Location = new System.Drawing.Point(338, 55);
            this.lSalida.Name = "lSalida";
            this.lSalida.Size = new System.Drawing.Size(327, 130);
            this.lSalida.TabIndex = 2;
            this.lSalida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSerie
            // 
            this.txtSerie.Location = new System.Drawing.Point(220, 55);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(112, 20);
            this.txtSerie.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "exponente";
            // 
            // Ejercicio22
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lSalida);
            this.Controls.Add(this.bComprobar);
            this.Name = "Ejercicio22";
            this.Text = "Ejercicio22";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bComprobar;
        private System.Windows.Forms.Label lSalida;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label label2;
    }
}

