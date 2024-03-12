namespace Ejercicio01
{
    partial class fPoligono
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadLados = new System.Windows.Forms.TextBox();
            this.btnAceptarForma = new System.Windows.Forms.Button();
            this.lblTam = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.txtTamañoLados = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.btnForma = new System.Windows.Forms.Button();
            this.cbCiruclo = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCiruclo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCantidadLados);
            this.groupBox1.Controls.Add(this.btnAceptarForma);
            this.groupBox1.Controls.Add(this.lblTam);
            this.groupBox1.Controls.Add(this.lblColor);
            this.groupBox1.Controls.Add(this.lblY);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.txtTamañoLados);
            this.groupBox1.Controls.Add(this.txtColor);
            this.groupBox1.Controls.Add(this.txtY);
            this.groupBox1.Controls.Add(this.txtX);
            this.groupBox1.Location = new System.Drawing.Point(38, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poligono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cantidad de Lados";
            // 
            // txtCantidadLados
            // 
            this.txtCantidadLados.Location = new System.Drawing.Point(108, 110);
            this.txtCantidadLados.Name = "txtCantidadLados";
            this.txtCantidadLados.Size = new System.Drawing.Size(104, 20);
            this.txtCantidadLados.TabIndex = 8;
            this.txtCantidadLados.TextChanged += new System.EventHandler(this.txtCantidadLados_TextChanged);
            // 
            // btnAceptarForma
            // 
            this.btnAceptarForma.Location = new System.Drawing.Point(25, 171);
            this.btnAceptarForma.Name = "btnAceptarForma";
            this.btnAceptarForma.Size = new System.Drawing.Size(216, 34);
            this.btnAceptarForma.TabIndex = 2;
            this.btnAceptarForma.Text = "Añadir Forma";
            this.btnAceptarForma.UseVisualStyleBackColor = true;
            this.btnAceptarForma.Click += new System.EventHandler(this.btnAceptarForma_Click);
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.Location = new System.Drawing.Point(46, 138);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(109, 13);
            this.lblTam.TabIndex = 7;
            this.lblTam.Text = "Tamaño de los Lados";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(124, 87);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 6;
            this.lblColor.Text = "Color";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(98, 61);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(57, 13);
            this.lblY.TabIndex = 5;
            this.lblY.Text = "Posicion Y";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(98, 35);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(57, 13);
            this.lblX.TabIndex = 4;
            this.lblX.Text = "Posicion X";
            // 
            // txtTamañoLados
            // 
            this.txtTamañoLados.Location = new System.Drawing.Point(161, 135);
            this.txtTamañoLados.Name = "txtTamañoLados";
            this.txtTamañoLados.Size = new System.Drawing.Size(104, 20);
            this.txtTamañoLados.TabIndex = 3;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(161, 84);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(104, 20);
            this.txtColor.TabIndex = 2;
            this.txtColor.TextChanged += new System.EventHandler(this.ChangeColor);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(161, 58);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(104, 20);
            this.txtY.TabIndex = 1;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(161, 32);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(104, 20);
            this.txtX.TabIndex = 0;
            // 
            // btnForma
            // 
            this.btnForma.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnForma.Enabled = false;
            this.btnForma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnForma.Location = new System.Drawing.Point(344, 26);
            this.btnForma.Name = "btnForma";
            this.btnForma.Size = new System.Drawing.Size(230, 230);
            this.btnForma.TabIndex = 1;
            this.btnForma.UseVisualStyleBackColor = false;
            // 
            // cbCiruclo
            // 
            this.cbCiruclo.AutoSize = true;
            this.cbCiruclo.Location = new System.Drawing.Point(218, 112);
            this.cbCiruclo.Name = "cbCiruclo";
            this.cbCiruclo.Size = new System.Drawing.Size(58, 17);
            this.cbCiruclo.TabIndex = 10;
            this.cbCiruclo.Text = "Ciruclo";
            this.cbCiruclo.UseVisualStyleBackColor = true;
            this.cbCiruclo.CheckedChanged += new System.EventHandler(this.cbCiruclo_CheckedChanged);
            // 
            // fPoligono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 282);
            this.Controls.Add(this.btnForma);
            this.Controls.Add(this.groupBox1);
            this.Name = "fPoligono";
            this.Text = "Poligono";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTam;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox txtTamañoLados;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnForma;
        private System.Windows.Forms.Button btnAceptarForma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidadLados;
        private System.Windows.Forms.CheckBox cbCiruclo;
    }
}