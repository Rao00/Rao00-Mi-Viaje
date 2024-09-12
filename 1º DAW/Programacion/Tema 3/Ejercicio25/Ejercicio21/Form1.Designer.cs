namespace Ejercicio21
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
            this.bSerieWhile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bSerieFor = new System.Windows.Forms.Button();
            this.bSerieDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSerieWhile
            // 
            this.bSerieWhile.Location = new System.Drawing.Point(380, 156);
            this.bSerieWhile.Name = "bSerieWhile";
            this.bSerieWhile.Size = new System.Drawing.Size(146, 46);
            this.bSerieWhile.TabIndex = 0;
            this.bSerieWhile.Text = "Ver Serie While";
            this.bSerieWhile.UseVisualStyleBackColor = true;
            this.bSerieWhile.Click += new System.EventHandler(this.bSerie_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tablas de multiplicar ";
            // 
            // bSerieFor
            // 
            this.bSerieFor.Location = new System.Drawing.Point(380, 208);
            this.bSerieFor.Name = "bSerieFor";
            this.bSerieFor.Size = new System.Drawing.Size(146, 46);
            this.bSerieFor.TabIndex = 3;
            this.bSerieFor.Text = "Ver Serie For";
            this.bSerieFor.UseVisualStyleBackColor = true;
            this.bSerieFor.Click += new System.EventHandler(this.bSerieFor_Click);
            // 
            // bSerieDoWhile
            // 
            this.bSerieDoWhile.Location = new System.Drawing.Point(380, 260);
            this.bSerieDoWhile.Name = "bSerieDoWhile";
            this.bSerieDoWhile.Size = new System.Drawing.Size(146, 46);
            this.bSerieDoWhile.TabIndex = 4;
            this.bSerieDoWhile.Text = "Ver Serie Do While";
            this.bSerieDoWhile.UseVisualStyleBackColor = true;
            this.bSerieDoWhile.Click += new System.EventHandler(this.bSerieDoWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSerieDoWhile);
            this.Controls.Add(this.bSerieFor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSerieWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSerieWhile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSerieFor;
        private System.Windows.Forms.Button bSerieDoWhile;
    }
}

