namespace Ejercicio22
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
            this.bCalcular = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(335, 239);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(111, 53);
            this.bCalcular.TabIndex = 0;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(335, 191);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(111, 20);
            this.txtNum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.bCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCalcular;
        private System.Windows.Forms.TextBox txtNum;
    }
}

