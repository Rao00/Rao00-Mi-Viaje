namespace Ejercicio04
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
            this.tb_num1 = new System.Windows.Forms.TextBox();
            this.tb_num2 = new System.Windows.Forms.TextBox();
            this.b_sum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_num1
            // 
            this.tb_num1.Location = new System.Drawing.Point(313, 74);
            this.tb_num1.Name = "tb_num1";
            this.tb_num1.Size = new System.Drawing.Size(100, 20);
            this.tb_num1.TabIndex = 2;
            this.tb_num1.Text = "0";
            this.tb_num1.TextChanged += new System.EventHandler(this.tb_num1_TextChanged);
            // 
            // tb_num2
            // 
            this.tb_num2.Location = new System.Drawing.Point(313, 139);
            this.tb_num2.Name = "tb_num2";
            this.tb_num2.Size = new System.Drawing.Size(100, 20);
            this.tb_num2.TabIndex = 3;
            this.tb_num2.Text = "0";
            this.tb_num2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // b_sum
            // 
            this.b_sum.Location = new System.Drawing.Point(313, 198);
            this.b_sum.Name = "b_sum";
            this.b_sum.Size = new System.Drawing.Size(100, 30);
            this.b_sum.TabIndex = 1;
            this.b_sum.Text = "Sumar";
            this.b_sum.UseVisualStyleBackColor = true;
            this.b_sum.Click += new System.EventHandler(this.b_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_num2);
            this.Controls.Add(this.tb_num1);
            this.Controls.Add(this.b_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Button b_sum;
    }
}

