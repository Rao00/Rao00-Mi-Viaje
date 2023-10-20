namespace Ejercicio14
{
    partial class Ejercicio12
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
            this.bCalcularFOR = new System.Windows.Forms.Button();
            this.lSalida = new System.Windows.Forms.Label();
            this.bCalcularWhile = new System.Windows.Forms.Button();
            this.bCalcularDOWHILE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCalcularFOR
            // 
            this.bCalcularFOR.Location = new System.Drawing.Point(220, 84);
            this.bCalcularFOR.Name = "bCalcularFOR";
            this.bCalcularFOR.Size = new System.Drawing.Size(112, 20);
            this.bCalcularFOR.TabIndex = 0;
            this.bCalcularFOR.Text = "Calcular FOR";
            this.bCalcularFOR.UseVisualStyleBackColor = true;
            this.bCalcularFOR.Click += new System.EventHandler(this.bInput_Click);
            // 
            // lSalida
            // 
            this.lSalida.AutoSize = true;
            this.lSalida.Location = new System.Drawing.Point(353, 84);
            this.lSalida.Name = "lSalida";
            this.lSalida.Size = new System.Drawing.Size(0, 13);
            this.lSalida.TabIndex = 2;
            // 
            // bCalcularWhile
            // 
            this.bCalcularWhile.Location = new System.Drawing.Point(220, 110);
            this.bCalcularWhile.Name = "bCalcularWhile";
            this.bCalcularWhile.Size = new System.Drawing.Size(112, 20);
            this.bCalcularWhile.TabIndex = 3;
            this.bCalcularWhile.Text = "Calcular WHILE";
            this.bCalcularWhile.UseVisualStyleBackColor = true;
            this.bCalcularWhile.Click += new System.EventHandler(this.bCalcularWhile_Click);
            // 
            // bCalcularDOWHILE
            // 
            this.bCalcularDOWHILE.Location = new System.Drawing.Point(220, 136);
            this.bCalcularDOWHILE.Name = "bCalcularDOWHILE";
            this.bCalcularDOWHILE.Size = new System.Drawing.Size(112, 20);
            this.bCalcularDOWHILE.TabIndex = 4;
            this.bCalcularDOWHILE.Text = "Calcular DO WHILE";
            this.bCalcularDOWHILE.UseVisualStyleBackColor = true;
            this.bCalcularDOWHILE.Click += new System.EventHandler(this.bCalcularDOWHILE_Click);
            // 
            // Ejercicio12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCalcularDOWHILE);
            this.Controls.Add(this.bCalcularWhile);
            this.Controls.Add(this.lSalida);
            this.Controls.Add(this.bCalcularFOR);
            this.Name = "Ejercicio12";
            this.Text = "Ejercicio12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcularFOR;
        private System.Windows.Forms.Label lSalida;
        private System.Windows.Forms.Button bCalcularWhile;
        private System.Windows.Forms.Button bCalcularDOWHILE;
    }
}

