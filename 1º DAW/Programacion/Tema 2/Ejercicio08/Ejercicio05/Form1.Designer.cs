namespace Ejercicio05
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
            this.b_sum = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_sum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_sum
            // 
            this.b_sum.Location = new System.Drawing.Point(24, 148);
            this.b_sum.Name = "b_sum";
            this.b_sum.Size = new System.Drawing.Size(176, 23);
            this.b_sum.TabIndex = 0;
            this.b_sum.Text = "Calcular";
            this.b_sum.UseVisualStyleBackColor = true;
            this.b_sum.Click += new System.EventHandler(this.b_sum_Click);
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_1.Location = new System.Drawing.Point(87, 35);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(113, 21);
            this.tb_1.TabIndex = 2;
            // 
            // tb_out
            // 
            this.tb_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_out.Location = new System.Drawing.Point(24, 177);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(176, 21);
            this.tb_out.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sumar";
            // 
            // tb_sum
            // 
            this.tb_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_sum.Location = new System.Drawing.Point(87, 62);
            this.tb_sum.Name = "tb_sum";
            this.tb_sum.Size = new System.Drawing.Size(113, 21);
            this.tb_sum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Multiplicar por";
            // 
            // tb_mult
            // 
            this.tb_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_mult.Location = new System.Drawing.Point(87, 89);
            this.tb_mult.Name = "tb_mult";
            this.tb_mult.Size = new System.Drawing.Size(113, 21);
            this.tb_mult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(222, 210);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_mult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_sum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.b_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_sum;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_out;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_sum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mult;
    }
}

