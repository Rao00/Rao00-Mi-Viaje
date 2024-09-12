namespace Ejercicio20
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
            this.txtExponente = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.bCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtExponente
            // 
            this.txtExponente.Location = new System.Drawing.Point(289, 117);
            this.txtExponente.Name = "txtExponente";
            this.txtExponente.Size = new System.Drawing.Size(100, 20);
            this.txtExponente.TabIndex = 0;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(289, 143);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(100, 20);
            this.txtBase.TabIndex = 1;
            // 
            // bCalcular
            // 
            this.bCalcular.Location = new System.Drawing.Point(289, 178);
            this.bCalcular.Name = "bCalcular";
            this.bCalcular.Size = new System.Drawing.Size(100, 52);
            this.bCalcular.TabIndex = 2;
            this.bCalcular.Text = "Calcular";
            this.bCalcular.UseVisualStyleBackColor = true;
            this.bCalcular.Click += new System.EventHandler(this.bCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCalcular);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.txtExponente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExponente;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button bCalcular;
    }
}

