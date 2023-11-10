namespace Ejercicio19__Ampliacion_
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
            this.bEmpezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bEmpezar
            // 
            this.bEmpezar.Location = new System.Drawing.Point(261, 201);
            this.bEmpezar.Name = "bEmpezar";
            this.bEmpezar.Size = new System.Drawing.Size(208, 77);
            this.bEmpezar.TabIndex = 0;
            this.bEmpezar.Text = "Empezar";
            this.bEmpezar.UseVisualStyleBackColor = true;
            this.bEmpezar.Click += new System.EventHandler(this.bEmpezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bEmpezar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEmpezar;
    }
}

