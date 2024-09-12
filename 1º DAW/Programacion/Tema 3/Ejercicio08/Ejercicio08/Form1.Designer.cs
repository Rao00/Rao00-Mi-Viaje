namespace Ejercicio08
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
            this.bAdd = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(133, 71);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Añadir";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(133, 37);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(100, 20);
            this.txtNew.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.bAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox txtNew;
        private System.Windows.Forms.Label label1;
    }
}

