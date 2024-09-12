namespace Ejercicio09
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
            this.b_mult = new System.Windows.Forms.Button();
            this.b_div = new System.Windows.Forms.Button();
            this.tb_01 = new System.Windows.Forms.TextBox();
            this.tb_02 = new System.Windows.Forms.TextBox();
            this.tb_out = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_sum
            // 
            this.b_sum.Location = new System.Drawing.Point(209, 56);
            this.b_sum.Name = "b_sum";
            this.b_sum.Size = new System.Drawing.Size(75, 23);
            this.b_sum.TabIndex = 0;
            this.b_sum.Text = "Sumar";
            this.b_sum.UseVisualStyleBackColor = true;
            this.b_sum.Click += new System.EventHandler(this.b_sum_Click);
            // 
            // b_res
            // 
            this.b_res.Location = new System.Drawing.Point(209, 86);
            this.b_res.Name = "b_res";
            this.b_res.Size = new System.Drawing.Size(75, 23);
            this.b_res.TabIndex = 1;
            this.b_res.Text = "Restar";
            this.b_res.UseVisualStyleBackColor = true;
            this.b_res.Click += new System.EventHandler(this.b_res_Click);
            // 
            // b_mult
            // 
            this.b_mult.Location = new System.Drawing.Point(285, 56);
            this.b_mult.Name = "b_mult";
            this.b_mult.Size = new System.Drawing.Size(75, 23);
            this.b_mult.TabIndex = 2;
            this.b_mult.Text = "Multiplicar";
            this.b_mult.UseVisualStyleBackColor = true;
            this.b_mult.Click += new System.EventHandler(this.b_mult_Click);
            // 
            // b_div
            // 
            this.b_div.Location = new System.Drawing.Point(285, 86);
            this.b_div.Name = "b_div";
            this.b_div.Size = new System.Drawing.Size(75, 23);
            this.b_div.TabIndex = 3;
            this.b_div.Text = "Dividir";
            this.b_div.UseVisualStyleBackColor = true;
            this.b_div.Click += new System.EventHandler(this.b_div_Click);
            // 
            // tb_01
            // 
            this.tb_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_01.Location = new System.Drawing.Point(13, 57);
            this.tb_01.Name = "tb_01";
            this.tb_01.Size = new System.Drawing.Size(190, 21);
            this.tb_01.TabIndex = 4;
            // 
            // tb_02
            // 
            this.tb_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_02.Location = new System.Drawing.Point(13, 87);
            this.tb_02.Name = "tb_02";
            this.tb_02.Size = new System.Drawing.Size(190, 21);
            this.tb_02.TabIndex = 5;
            // 
            // tb_out
            // 
            this.tb_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.tb_out.Location = new System.Drawing.Point(12, 149);
            this.tb_out.Name = "tb_out";
            this.tb_out.Size = new System.Drawing.Size(347, 30);
            this.tb_out.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(373, 265);
            this.Controls.Add(this.tb_out);
            this.Controls.Add(this.tb_02);
            this.Controls.Add(this.tb_01);
            this.Controls.Add(this.b_div);
            this.Controls.Add(this.b_mult);
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
        private System.Windows.Forms.Button b_mult;
        private System.Windows.Forms.Button b_div;
        private System.Windows.Forms.TextBox tb_01;
        private System.Windows.Forms.TextBox tb_02;
        private System.Windows.Forms.TextBox tb_out;
    }
}

