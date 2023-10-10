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
            this.b_cal = new System.Windows.Forms.Button();
            this.tb_e = new System.Windows.Forms.TextBox();
            this.tb_p = new System.Windows.Forms.TextBox();
            this.l_e = new System.Windows.Forms.Label();
            this.l_p = new System.Windows.Forms.Label();
            this.b_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_cal
            // 
            this.b_cal.Location = new System.Drawing.Point(146, 236);
            this.b_cal.Name = "b_cal";
            this.b_cal.Size = new System.Drawing.Size(100, 23);
            this.b_cal.TabIndex = 0;
            this.b_cal.Text = "Calcular";
            this.b_cal.UseVisualStyleBackColor = true;
            this.b_cal.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_e
            // 
            this.tb_e.Location = new System.Drawing.Point(146, 125);
            this.tb_e.Name = "tb_e";
            this.tb_e.Size = new System.Drawing.Size(100, 20);
            this.tb_e.TabIndex = 1;
            // 
            // tb_p
            // 
            this.tb_p.Location = new System.Drawing.Point(146, 180);
            this.tb_p.Name = "tb_p";
            this.tb_p.Size = new System.Drawing.Size(100, 20);
            this.tb_p.TabIndex = 2;
            // 
            // l_e
            // 
            this.l_e.AutoSize = true;
            this.l_e.Location = new System.Drawing.Point(98, 128);
            this.l_e.Name = "l_e";
            this.l_e.Size = new System.Drawing.Size(46, 13);
            this.l_e.TabIndex = 3;
            this.l_e.Text = "Euros = ";
            this.l_e.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_p
            // 
            this.l_p.AutoSize = true;
            this.l_p.Location = new System.Drawing.Point(89, 183);
            this.l_p.Name = "l_p";
            this.l_p.Size = new System.Drawing.Size(54, 13);
            this.l_p.TabIndex = 4;
            this.l_p.Text = "Pesetas =";
            // 
            // b_clear
            // 
            this.b_clear.Location = new System.Drawing.Point(146, 266);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(100, 23);
            this.b_clear.TabIndex = 5;
            this.b_clear.Text = "Limpiar";
            this.b_clear.UseVisualStyleBackColor = true;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(385, 450);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.l_p);
            this.Controls.Add(this.l_e);
            this.Controls.Add(this.tb_p);
            this.Controls.Add(this.tb_e);
            this.Controls.Add(this.b_cal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_cal;
        private System.Windows.Forms.TextBox tb_e;
        private System.Windows.Forms.TextBox tb_p;
        private System.Windows.Forms.Label l_e;
        private System.Windows.Forms.Label l_p;
        private System.Windows.Forms.Button b_clear;
    }
}

