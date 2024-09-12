namespace Ejercicio03
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
            this.btnNewFecha = new System.Windows.Forms.Button();
            this.btnSortFechas = new System.Windows.Forms.Button();
            this.btnLeer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewFecha
            // 
            this.btnNewFecha.Location = new System.Drawing.Point(247, 103);
            this.btnNewFecha.Name = "btnNewFecha";
            this.btnNewFecha.Size = new System.Drawing.Size(323, 73);
            this.btnNewFecha.TabIndex = 0;
            this.btnNewFecha.Text = "Ingresar Fechas";
            this.btnNewFecha.UseVisualStyleBackColor = true;
            this.btnNewFecha.Click += new System.EventHandler(this.btnNewFecha_Click);
            // 
            // btnSortFechas
            // 
            this.btnSortFechas.Location = new System.Drawing.Point(247, 190);
            this.btnSortFechas.Name = "btnSortFechas";
            this.btnSortFechas.Size = new System.Drawing.Size(323, 73);
            this.btnSortFechas.TabIndex = 1;
            this.btnSortFechas.Text = "Ordenar Fechas";
            this.btnSortFechas.UseVisualStyleBackColor = true;
            this.btnSortFechas.Click += new System.EventHandler(this.btnSortFechas_Click);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(247, 279);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(323, 73);
            this.btnLeer.TabIndex = 2;
            this.btnLeer.Text = "Mostrar Fechas";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnSortFechas);
            this.Controls.Add(this.btnNewFecha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewFecha;
        private System.Windows.Forms.Button btnSortFechas;
        private System.Windows.Forms.Button btnLeer;
    }
}

