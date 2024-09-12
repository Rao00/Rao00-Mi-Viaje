namespace Ejercicio213
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.tb_horas = new System.Windows.Forms.TextBox();
            this.tb_extra = new System.Windows.Forms.TextBox();
            this.b_calcular = new System.Windows.Forms.Button();
            this.tb_pago = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(132, 68);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(35, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Horas";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(106, 120);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(61, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Horas extra";
            // 
            // tb_horas
            // 
            this.tb_horas.Location = new System.Drawing.Point(196, 65);
            this.tb_horas.Name = "tb_horas";
            this.tb_horas.Size = new System.Drawing.Size(100, 20);
            this.tb_horas.TabIndex = 2;
            // 
            // tb_extra
            // 
            this.tb_extra.Location = new System.Drawing.Point(196, 117);
            this.tb_extra.Name = "tb_extra";
            this.tb_extra.Size = new System.Drawing.Size(100, 20);
            this.tb_extra.TabIndex = 3;
            // 
            // b_calcular
            // 
            this.b_calcular.Location = new System.Drawing.Point(356, 170);
            this.b_calcular.Name = "b_calcular";
            this.b_calcular.Size = new System.Drawing.Size(75, 23);
            this.b_calcular.TabIndex = 4;
            this.b_calcular.Text = "Calcular";
            this.b_calcular.UseVisualStyleBackColor = true;
            this.b_calcular.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tb_pago
            // 
            this.tb_pago.Location = new System.Drawing.Point(196, 173);
            this.tb_pago.Name = "tb_pago";
            this.tb_pago.Size = new System.Drawing.Size(100, 20);
            this.tb_pago.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pago por Hora";
            // 
            // l_resultado
            // 
            this.l_resultado.AutoSize = true;
            this.l_resultado.Location = new System.Drawing.Point(353, 140);
            this.l_resultado.Name = "l_resultado";
            this.l_resultado.Size = new System.Drawing.Size(55, 13);
            this.l_resultado.TabIndex = 7;
            this.l_resultado.Text = "Nomina = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_resultado);
            this.Controls.Add(this.tb_pago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_calcular);
            this.Controls.Add(this.tb_extra);
            this.Controls.Add(this.tb_horas);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox tb_horas;
        private System.Windows.Forms.TextBox tb_extra;
        private System.Windows.Forms.Button b_calcular;
        private System.Windows.Forms.TextBox tb_pago;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_resultado;
    }
}

