namespace Ejercicio03
{
    partial class Ejercicio03
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
            this.l_01 = new System.Windows.Forms.Label();
            this.tb_01 = new System.Windows.Forms.TextBox();
            this.b_01 = new System.Windows.Forms.Button();
            this.b_02 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_01
            // 
            this.l_01.AutoSize = true;
            this.l_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_01.ForeColor = System.Drawing.SystemColors.Control;
            this.l_01.Location = new System.Drawing.Point(70, 171);
            this.l_01.Name = "l_01";
            this.l_01.Size = new System.Drawing.Size(131, 20);
            this.l_01.TabIndex = 0;
            this.l_01.Text = "Boton Pulsado:";
            // 
            // tb_01
            // 
            this.tb_01.Enabled = false;
            this.tb_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_01.ForeColor = System.Drawing.SystemColors.MenuText;
            this.tb_01.Location = new System.Drawing.Point(201, 169);
            this.tb_01.Name = "tb_01";
            this.tb_01.Size = new System.Drawing.Size(500, 26);
            this.tb_01.TabIndex = 1;
            // 
            // b_01
            // 
            this.b_01.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_01.Location = new System.Drawing.Point(200, 201);
            this.b_01.Name = "b_01";
            this.b_01.Size = new System.Drawing.Size(150, 50);
            this.b_01.TabIndex = 2;
            this.b_01.Text = "Boton 1";
            this.b_01.UseVisualStyleBackColor = true;
            this.b_01.Click += new System.EventHandler(this.b_01_Click);
            // 
            // b_02
            // 
            this.b_02.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.b_02.Location = new System.Drawing.Point(357, 201);
            this.b_02.Name = "b_02";
            this.b_02.Size = new System.Drawing.Size(150, 50);
            this.b_02.TabIndex = 3;
            this.b_02.Text = "Boton 2";
            this.b_02.UseVisualStyleBackColor = true;
            this.b_02.Click += new System.EventHandler(this.b_02_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(576, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Borrar texto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_02);
            this.Controls.Add(this.b_01);
            this.Controls.Add(this.tb_01);
            this.Controls.Add(this.l_01);
            this.Name = "Ejercicio03";
            this.Text = "Ejercicio 03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_01;
        private System.Windows.Forms.TextBox tb_01;
        private System.Windows.Forms.Button b_01;
        private System.Windows.Forms.Button b_02;
        private System.Windows.Forms.Button button1;
    }
}

