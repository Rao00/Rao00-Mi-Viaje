namespace EjercicioAyudaPorFavor
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtBilleteMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesetas = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.lResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Billete Minimo";
            // 
            // txtBilleteMin
            // 
            this.txtBilleteMin.Location = new System.Drawing.Point(384, 78);
            this.txtBilleteMin.Name = "txtBilleteMin";
            this.txtBilleteMin.Size = new System.Drawing.Size(100, 20);
            this.txtBilleteMin.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipo de moneda";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(384, 54);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(100, 20);
            this.txtType.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Cuantas";
            // 
            // txtPesetas
            // 
            this.txtPesetas.Location = new System.Drawing.Point(384, 104);
            this.txtPesetas.Name = "txtPesetas";
            this.txtPesetas.Size = new System.Drawing.Size(100, 20);
            this.txtPesetas.TabIndex = 11;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(384, 130);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 23);
            this.bCalcular.TabIndex = 10;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click_1);
            // 
            // lResultado
            // 
            this.lResultado.Location = new System.Drawing.Point(358, 160);
            this.lResultado.Name = "lResultado";
            this.lResultado.Size = new System.Drawing.Size(148, 237);
            this.lResultado.TabIndex = 9;
            this.lResultado.Text = "Resultado";
            this.lResultado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBilleteMin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPesetas);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.lResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBilleteMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesetas;
        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.Label lResultado;
    }
}

