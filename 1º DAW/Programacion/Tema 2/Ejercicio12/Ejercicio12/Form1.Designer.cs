namespace Ejercicio12
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
            this.l_p1 = new System.Windows.Forms.Label();
            this.l_p2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_p1 = new System.Windows.Forms.TextBox();
            this.tb_p2 = new System.Windows.Forms.TextBox();
            this.tb_p3 = new System.Windows.Forms.TextBox();
            this.b_calcular = new System.Windows.Forms.Button();
            this.l_total = new System.Windows.Forms.Label();
            this.l_iva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // l_p1
            // 
            this.l_p1.AutoSize = true;
            this.l_p1.Location = new System.Drawing.Point(82, 89);
            this.l_p1.Name = "l_p1";
            this.l_p1.Size = new System.Drawing.Size(59, 13);
            this.l_p1.TabIndex = 0;
            this.l_p1.Text = "Producto 1";
            // 
            // l_p2
            // 
            this.l_p2.AutoSize = true;
            this.l_p2.Location = new System.Drawing.Point(82, 118);
            this.l_p2.Name = "l_p2";
            this.l_p2.Size = new System.Drawing.Size(59, 13);
            this.l_p2.TabIndex = 1;
            this.l_p2.Text = "Producto 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Producto 3";
            // 
            // tb_p1
            // 
            this.tb_p1.Location = new System.Drawing.Point(148, 86);
            this.tb_p1.Name = "tb_p1";
            this.tb_p1.Size = new System.Drawing.Size(100, 20);
            this.tb_p1.TabIndex = 3;
            // 
            // tb_p2
            // 
            this.tb_p2.Location = new System.Drawing.Point(148, 115);
            this.tb_p2.Name = "tb_p2";
            this.tb_p2.Size = new System.Drawing.Size(100, 20);
            this.tb_p2.TabIndex = 4;
            // 
            // tb_p3
            // 
            this.tb_p3.Location = new System.Drawing.Point(148, 145);
            this.tb_p3.Name = "tb_p3";
            this.tb_p3.Size = new System.Drawing.Size(100, 20);
            this.tb_p3.TabIndex = 5;
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(148, 172);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(100, 23);
            this.b_calcular.TabIndex = 6;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.b_calcular_Click);
            // 
            // l_total
            // 
            this.l_total.Location = new System.Drawing.Point(281, 108);
            this.l_total.Name = "l_total";
            this.l_total.Size = new System.Drawing.Size(163, 23);
            this.l_total.TabIndex = 7;
            this.l_total.Text = "Total Sin IVA =";
            this.l_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_iva
            // 
            this.l_iva.Location = new System.Drawing.Point(281, 138);
            this.l_iva.Name = "l_iva";
            this.l_iva.Size = new System.Drawing.Size(163, 23);
            this.l_iva.TabIndex = 8;
            this.l_iva.Text = "Total Con IVA =";
            this.l_iva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_iva);
            this.Controls.Add(this.l_total);
            this.Controls.Add(this.b_calcular);
            this.Controls.Add(this.tb_p3);
            this.Controls.Add(this.tb_p2);
            this.Controls.Add(this.tb_p1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_p2);
            this.Controls.Add(this.l_p1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_p1;
        private System.Windows.Forms.Label l_p2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_p1;
        private System.Windows.Forms.TextBox tb_p2;
        private System.Windows.Forms.TextBox tb_p3;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.Label l_total;
        private System.Windows.Forms.Label l_iva;
    }
}

