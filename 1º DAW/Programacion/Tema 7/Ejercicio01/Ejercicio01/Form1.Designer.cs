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
            this.bInsertar = new System.Windows.Forms.Button();
            this.bLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bInsertar
            // 
            this.bInsertar.Location = new System.Drawing.Point(318, 153);
            this.bInsertar.Name = "bInsertar";
            this.bInsertar.Size = new System.Drawing.Size(153, 61);
            this.bInsertar.TabIndex = 0;
            this.bInsertar.Text = "Insertar Datos";
            this.bInsertar.UseVisualStyleBackColor = true;
            this.bInsertar.Click += new System.EventHandler(this.bInsertar_Click);
            // 
            // bLeer
            // 
            this.bLeer.Location = new System.Drawing.Point(318, 229);
            this.bLeer.Name = "bLeer";
            this.bLeer.Size = new System.Drawing.Size(153, 61);
            this.bLeer.TabIndex = 1;
            this.bLeer.Text = "Leer Datos";
            this.bLeer.UseVisualStyleBackColor = true;
            this.bLeer.Click += new System.EventHandler(this.bLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bLeer);
            this.Controls.Add(this.bInsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bInsertar;
        private System.Windows.Forms.Button bLeer;
    }
}

