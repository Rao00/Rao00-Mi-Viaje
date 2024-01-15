namespace Ejercicio07
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
            this.bNewWords = new System.Windows.Forms.Button();
            this.bSortWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bNewWords
            // 
            this.bNewWords.Location = new System.Drawing.Point(319, 156);
            this.bNewWords.Name = "bNewWords";
            this.bNewWords.Size = new System.Drawing.Size(120, 60);
            this.bNewWords.TabIndex = 0;
            this.bNewWords.Text = "Introduce a Word";
            this.bNewWords.UseVisualStyleBackColor = true;
            this.bNewWords.Click += new System.EventHandler(this.bNewWords_Click);
            // 
            // bSortWords
            // 
            this.bSortWords.Location = new System.Drawing.Point(319, 222);
            this.bSortWords.Name = "bSortWords";
            this.bSortWords.Size = new System.Drawing.Size(120, 63);
            this.bSortWords.TabIndex = 1;
            this.bSortWords.Text = "Check Words";
            this.bSortWords.UseVisualStyleBackColor = true;
            this.bSortWords.Click += new System.EventHandler(this.bSortWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSortWords);
            this.Controls.Add(this.bNewWords);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNewWords;
        private System.Windows.Forms.Button bSortWords;
    }
}

