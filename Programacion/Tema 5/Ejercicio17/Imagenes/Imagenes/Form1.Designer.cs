namespace Imagenes
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
            this.bEjecutar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.lNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEjecutar
            // 
            this.bEjecutar.Location = new System.Drawing.Point(304, 211);
            this.bEjecutar.Name = "bEjecutar";
            this.bEjecutar.Size = new System.Drawing.Size(170, 84);
            this.bEjecutar.TabIndex = 0;
            this.bEjecutar.Text = "Adivina el numero";
            this.bEjecutar.UseVisualStyleBackColor = true;
            this.bEjecutar.Click += new System.EventHandler(this.bEjecutar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(304, 185);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(170, 20);
            this.txtNum.TabIndex = 1;
            // 
            // lNum
            // 
            this.lNum.Location = new System.Drawing.Point(301, 162);
            this.lNum.Name = "lNum";
            this.lNum.Size = new System.Drawing.Size(173, 14);
            this.lNum.TabIndex = 2;
            this.lNum.Text = "En que numero estas pensando";
            this.lNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lNum);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.bEjecutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEjecutar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lNum;
    }
}

