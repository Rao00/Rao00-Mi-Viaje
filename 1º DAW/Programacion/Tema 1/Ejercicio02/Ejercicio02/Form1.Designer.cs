namespace Ejercicio02
{
    partial class ejercicio02
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
            this.l_principal = new System.Windows.Forms.Label();
            this.tb_1 = new System.Windows.Forms.TextBox();
            this.b_contenido = new System.Windows.Forms.Button();
            this.b_colorform = new System.Windows.Forms.Button();
            this.b_colortexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_principal
            // 
            this.l_principal.AutoSize = true;
            this.l_principal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.l_principal.Location = new System.Drawing.Point(190, 60);
            this.l_principal.Name = "l_principal";
            this.l_principal.Size = new System.Drawing.Size(226, 20);
            this.l_principal.TabIndex = 0;
            this.l_principal.Text = "MI PRIMER FORMULARIO";
            this.l_principal.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_1
            // 
            this.tb_1.Location = new System.Drawing.Point(160, 110);
            this.tb_1.Name = "tb_1";
            this.tb_1.Size = new System.Drawing.Size(280, 20);
            this.tb_1.TabIndex = 1;
            // 
            // b_contenido
            // 
            this.b_contenido.Location = new System.Drawing.Point(160, 156);
            this.b_contenido.Name = "b_contenido";
            this.b_contenido.Size = new System.Drawing.Size(280, 25);
            this.b_contenido.TabIndex = 2;
            this.b_contenido.Text = "Muestra el contenido del Cuadro de Texto";
            this.b_contenido.UseVisualStyleBackColor = true;
            this.b_contenido.Click += new System.EventHandler(this.b_contenido_Click);
            // 
            // b_colorform
            // 
            this.b_colorform.Location = new System.Drawing.Point(160, 206);
            this.b_colorform.Name = "b_colorform";
            this.b_colorform.Size = new System.Drawing.Size(280, 25);
            this.b_colorform.TabIndex = 3;
            this.b_colorform.Text = "Cambia el color del formulario";
            this.b_colorform.UseVisualStyleBackColor = true;
            this.b_colorform.Click += new System.EventHandler(this.b_colorform_Click);
            // 
            // b_colortexto
            // 
            this.b_colortexto.Location = new System.Drawing.Point(160, 258);
            this.b_colortexto.Name = "b_colortexto";
            this.b_colortexto.Size = new System.Drawing.Size(280, 25);
            this.b_colortexto.TabIndex = 4;
            this.b_colortexto.Text = "Cambia el color del texto del cuadro";
            this.b_colortexto.UseVisualStyleBackColor = true;
            this.b_colortexto.Click += new System.EventHandler(this.b_colortexto_Click);
            // 
            // ejercicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.b_colortexto);
            this.Controls.Add(this.b_colorform);
            this.Controls.Add(this.b_contenido);
            this.Controls.Add(this.tb_1);
            this.Controls.Add(this.l_principal);
            this.Name = "ejercicio02";
            this.Text = "ejercicio02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_principal;
        private System.Windows.Forms.TextBox tb_1;
        private System.Windows.Forms.Button b_contenido;
        private System.Windows.Forms.Button b_colorform;
        private System.Windows.Forms.Button b_colortexto;
    }
}

