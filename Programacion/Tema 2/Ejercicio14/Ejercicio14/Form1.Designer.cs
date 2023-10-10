namespace Ejercicio14
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
            this.b_mayor = new System.Windows.Forms.Button();
            this.b_menor = new System.Windows.Forms.Button();
            this.b_noigual = new System.Windows.Forms.Button();
            this.b_igual = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.l_1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_mayor
            // 
            this.b_mayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b_mayor.Location = new System.Drawing.Point(193, 169);
            this.b_mayor.Name = "b_mayor";
            this.b_mayor.Size = new System.Drawing.Size(52, 52);
            this.b_mayor.TabIndex = 0;
            this.b_mayor.Text = ">";
            this.b_mayor.UseVisualStyleBackColor = true;
            this.b_mayor.Click += new System.EventHandler(this.b_mayor_Click);
            // 
            // b_menor
            // 
            this.b_menor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b_menor.Location = new System.Drawing.Point(290, 169);
            this.b_menor.Name = "b_menor";
            this.b_menor.Size = new System.Drawing.Size(52, 52);
            this.b_menor.TabIndex = 1;
            this.b_menor.Text = "<";
            this.b_menor.UseVisualStyleBackColor = true;
            this.b_menor.Click += new System.EventHandler(this.b_menor_Click);
            // 
            // b_noigual
            // 
            this.b_noigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b_noigual.Location = new System.Drawing.Point(478, 169);
            this.b_noigual.Name = "b_noigual";
            this.b_noigual.Size = new System.Drawing.Size(52, 52);
            this.b_noigual.TabIndex = 3;
            this.b_noigual.Text = "!=";
            this.b_noigual.UseVisualStyleBackColor = true;
            this.b_noigual.Click += new System.EventHandler(this.b_noigual_Click);
            // 
            // b_igual
            // 
            this.b_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.b_igual.Location = new System.Drawing.Point(381, 169);
            this.b_igual.Name = "b_igual";
            this.b_igual.Size = new System.Drawing.Size(52, 52);
            this.b_igual.TabIndex = 2;
            this.b_igual.Text = "=";
            this.b_igual.UseVisualStyleBackColor = true;
            this.b_igual.Click += new System.EventHandler(this.b_igual_Click);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(193, 129);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(337, 20);
            this.tb_1.TabIndex = 4;
            // 
            // tb_2
            // 
            this.tb_2.Location = new System.Drawing.Point(193, 242);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(337, 20);
            this.tb_2.TabIndex = 5;
            // 
            // l_1
            // 
            this.l_1.AutoSize = true;
            this.l_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.l_1.Location = new System.Drawing.Point(280, 297);
            this.l_1.Name = "l_1";
            this.l_1.Size = new System.Drawing.Size(138, 63);
            this.l_1.TabIndex = 6;
            this.l_1.Text = "True";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.l_1);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.b_noigual);
            this.Controls.Add(this.b_igual);
            this.Controls.Add(this.b_menor);
            this.Controls.Add(this.b_mayor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_mayor;
        private System.Windows.Forms.Button b_menor;
        private System.Windows.Forms.Button b_noigual;
        private System.Windows.Forms.Button b_igual;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.Label l_1;
    }
}

