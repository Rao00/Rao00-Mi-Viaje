namespace Ejercicio01
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
            this.b_input = new System.Windows.Forms.Button();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_input
            // 
            this.b_input.Location = new System.Drawing.Point(140, 170);
            this.b_input.Name = "b_input";
            this.b_input.Size = new System.Drawing.Size(157, 23);
            this.b_input.TabIndex = 0;
            this.b_input.Text = "Es dos??";
            this.b_input.UseVisualStyleBackColor = true;
            this.b_input.Click += new System.EventHandler(this.b_input_Click);
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(140, 144);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(157, 20);
            this.tb_input.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 363);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.b_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_input;
        private System.Windows.Forms.TextBox tb_input;
    }
}

