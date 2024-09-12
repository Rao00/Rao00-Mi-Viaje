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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b_1 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_1
            // 
            this.b_1.Location = new System.Drawing.Point(200, 375);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(100, 50);
            this.b_1.TabIndex = 0;
            this.b_1.Text = "Boton 1";
            this.b_1.UseVisualStyleBackColor = true;
            this.b_1.Click += new System.EventHandler(this.b_1_Click);
            // 
            // b_2
            // 
            this.b_2.Location = new System.Drawing.Point(500, 375);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(100, 50);
            this.b_2.TabIndex = 1;
            this.b_2.Text = "Boton 2";
            this.b_2.UseVisualStyleBackColor = true;
            this.b_2.Click += new System.EventHandler(this.b_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.b_2);
            this.Controls.Add(this.b_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Button b_2;
    }
}

