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
            this.b_res = new System.Windows.Forms.Button();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.tb_2 = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_sum
            // 
            this.b_sum.Location = new System.Drawing.Point(125, 25);
            this.b_sum.Name = "b_sum";
            this.b_sum.Size = new System.Drawing.Size(75, 23);
            this.b_sum.TabIndex = 0;
            this.b_sum.Text = "Sumar";
            this.b_sum.UseVisualStyleBackColor = true;
            this.b_sum.Click += new System.EventHandler(this.b_sum_Click);
            // 
            // b_res
            // 
            this.b_res.Location = new System.Drawing.Point(125, 66);
            this.b_res.Name = "b_res";
            this.b_res.Size = new System.Drawing.Size(75, 23);
            this.b_res.TabIndex = 1;
            this.b_res.Text = "Restar";
            this.b_res.UseVisualStyleBackColor = true;
            this.b_res.Click += new System.EventHandler(this.b_res_Click);
            // 
            // tb_1
            // 
            this.tb_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_1.Location = new System.Drawing.Point(24, 26);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(100, 21);
            this.tb_1.TabIndex = 2;
            // 
            // tb_2
            // 
            this.tb_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_2.Location = new System.Drawing.Point(24, 67);
            this.tb_2.Name = "tb_2";
            this.tb_2.Size = new System.Drawing.Size(100, 21);
            this.tb_2.TabIndex = 3;
            // 
            // tb_out
            // 
            this.tb_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_out.Location = new System.Drawing.Point(24, 109);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(176, 21);
            this.tb_out.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(222, 148);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_2);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.b_res);
            this.Controls.Add(this.b_sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_sum;
        private System.Windows.Forms.Button b_res;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.TextBox tb_2;
        private System.Windows.Forms.TextBox tb_out;
    }
}

