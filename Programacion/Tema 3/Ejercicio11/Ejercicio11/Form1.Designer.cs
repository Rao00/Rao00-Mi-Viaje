namespace Ejercicio11
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
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinuto = new System.Windows.Forms.TextBox();
            this.txtSegundo = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.lHora = new System.Windows.Forms.Label();
            this.lMinutos = new System.Windows.Forms.Label();
            this.lSegundos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(333, 84);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 0;
            // 
            // txtMinuto
            // 
            this.txtMinuto.Location = new System.Drawing.Point(333, 135);
            this.txtMinuto.Name = "txtMinuto";
            this.txtMinuto.Size = new System.Drawing.Size(100, 20);
            this.txtMinuto.TabIndex = 1;
            // 
            // txtSegundo
            // 
            this.txtSegundo.Location = new System.Drawing.Point(333, 185);
            this.txtSegundo.Name = "txtSegundo";
            this.txtSegundo.Size = new System.Drawing.Size(100, 20);
            this.txtSegundo.TabIndex = 2;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(333, 224);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 23);
            this.bCalcular.TabIndex = 3;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // lHora
            // 
            this.lHora.AutoSize = true;
            this.lHora.Location = new System.Drawing.Point(288, 87);
            this.lHora.Name = "lHora";
            this.lHora.Size = new System.Drawing.Size(42, 13);
            this.lHora.TabIndex = 4;
            this.lHora.Text = "Hora = ";
            this.lHora.Click += new System.EventHandler(this.lHora_Click);
            // 
            // lMinutos
            // 
            this.lMinutos.AutoSize = true;
            this.lMinutos.Location = new System.Drawing.Point(274, 138);
            this.lMinutos.Name = "lMinutos";
            this.lMinutos.Size = new System.Drawing.Size(53, 13);
            this.lMinutos.TabIndex = 5;
            this.lMinutos.Text = "Minutos =";
            // 
            // lSegundos
            // 
            this.lSegundos.AutoSize = true;
            this.lSegundos.Location = new System.Drawing.Point(264, 188);
            this.lSegundos.Name = "lSegundos";
            this.lSegundos.Size = new System.Drawing.Size(64, 13);
            this.lSegundos.TabIndex = 6;
            this.lSegundos.Text = "Segundos =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lSegundos);
            this.Controls.Add(this.lMinutos);
            this.Controls.Add(this.lHora);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.txtSegundo);
            this.Controls.Add(this.txtMinuto);
            this.Controls.Add(this.txtHora);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinuto;
        private System.Windows.Forms.TextBox txtSegundo;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label lHora;
        private System.Windows.Forms.Label lMinutos;
        private System.Windows.Forms.Label lSegundos;
    }
}

