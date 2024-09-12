namespace Ejemplo01
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
            this.boton_smr = new System.Windows.Forms.Button();
            this.boton_bach = new System.Windows.Forms.Button();
            this.boton_otro = new System.Windows.Forms.Button();
            this.l_pregunta = new System.Windows.Forms.Label();
            this.tb_otro = new System.Windows.Forms.TextBox();
            this.l_otro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boton_smr
            // 
            this.boton_smr.Location = new System.Drawing.Point(187, 276);
            this.boton_smr.Name = "boton_smr";
            this.boton_smr.Size = new System.Drawing.Size(75, 23);
            this.boton_smr.TabIndex = 0;
            this.boton_smr.Text = "SMR";
            this.boton_smr.UseVisualStyleBackColor = true;
            this.boton_smr.Click += new System.EventHandler(this.boton_smr_Click);
            // 
            // boton_bach
            // 
            this.boton_bach.Location = new System.Drawing.Point(296, 276);
            this.boton_bach.Name = "boton_bach";
            this.boton_bach.Size = new System.Drawing.Size(75, 23);
            this.boton_bach.TabIndex = 1;
            this.boton_bach.Text = "Bach";
            this.boton_bach.UseVisualStyleBackColor = true;
            this.boton_bach.Click += new System.EventHandler(this.boton_bach_Click);
            // 
            // boton_otro
            // 
            this.boton_otro.Location = new System.Drawing.Point(402, 276);
            this.boton_otro.Name = "boton_otro";
            this.boton_otro.Size = new System.Drawing.Size(75, 23);
            this.boton_otro.TabIndex = 2;
            this.boton_otro.Text = "Otro";
            this.boton_otro.UseVisualStyleBackColor = true;
            this.boton_otro.Click += new System.EventHandler(this.boton_otro_Click);
            // 
            // l_pregunta
            // 
            this.l_pregunta.AutoSize = true;
            this.l_pregunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.l_pregunta.ForeColor = System.Drawing.SystemColors.Control;
            this.l_pregunta.Location = new System.Drawing.Point(220, 229);
            this.l_pregunta.Name = "l_pregunta";
            this.l_pregunta.Size = new System.Drawing.Size(218, 26);
            this.l_pregunta.TabIndex = 3;
            this.l_pregunta.Text = "¿Que has estudiado?";
            // 
            // tb_otro
            // 
            this.tb_otro.Location = new System.Drawing.Point(390, 305);
            this.tb_otro.Name = "tb_otro";
            this.tb_otro.Size = new System.Drawing.Size(100, 20);
            this.tb_otro.TabIndex = 4;
            this.tb_otro.Visible = false;
            this.tb_otro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // l_otro
            // 
            this.l_otro.AutoSize = true;
            this.l_otro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.l_otro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_otro.Location = new System.Drawing.Point(415, 328);
            this.l_otro.Name = "l_otro";
            this.l_otro.Size = new System.Drawing.Size(0, 20);
            this.l_otro.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(638, 538);
            this.Controls.Add(this.l_otro);
            this.Controls.Add(this.tb_otro);
            this.Controls.Add(this.l_pregunta);
            this.Controls.Add(this.boton_otro);
            this.Controls.Add(this.boton_bach);
            this.Controls.Add(this.boton_smr);
            this.Name = "Form1";
            this.Text = "Mi primer Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_smr;
        private System.Windows.Forms.Button boton_bach;
        private System.Windows.Forms.Button boton_otro;
        private System.Windows.Forms.Label l_pregunta;
        private System.Windows.Forms.TextBox tb_otro;
        private System.Windows.Forms.Label l_otro;
    }
}

