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
            this.b_mostrar = new System.Windows.Forms.Button();
            this.tb_nom = new System.Windows.Forms.TextBox();
            this.tb_ape = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_mostrar
            // 
            this.b_mostrar.Location = new System.Drawing.Point(417, 221);
            this.b_mostrar.Name = "b_mostrar";
            this.b_mostrar.Size = new System.Drawing.Size(75, 23);
            this.b_mostrar.TabIndex = 0;
            this.b_mostrar.Text = "Mostrar nombre y apellidos";
            this.b_mostrar.UseVisualStyleBackColor = true;
            this.b_mostrar.Click += new System.EventHandler(this.b_mostrar_Click);
            // 
            // tb_nom
            // 
            this.tb_nom.Location = new System.Drawing.Point(417, 117);
            this.tb_nom.Name = "tb_nom";
            this.tb_nom.Size = new System.Drawing.Size(100, 20);
            this.tb_nom.TabIndex = 1;
            // 
            // tb_ape
            // 
            this.tb_ape.Location = new System.Drawing.Point(417, 167);
            this.tb_ape.Name = "tb_ape";
            this.tb_ape.Size = new System.Drawing.Size(100, 20);
            this.tb_ape.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Apellidos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_ape);
            this.Controls.Add(this.tb_nom);
            this.Controls.Add(this.b_mostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_mostrar;
        private System.Windows.Forms.TextBox tb_nom;
        private System.Windows.Forms.TextBox tb_ape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

