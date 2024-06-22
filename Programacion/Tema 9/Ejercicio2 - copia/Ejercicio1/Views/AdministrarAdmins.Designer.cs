namespace Ejercicio1
{
    partial class AdministrarAdmins
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPisoAsignado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOrdenador = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gb1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnAplicar, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 208);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(209, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 56);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPisoAsignado);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(209, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 67);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Piso Asignado";
            // 
            // txtPisoAsignado
            // 
            this.txtPisoAsignado.Location = new System.Drawing.Point(6, 30);
            this.txtPisoAsignado.Name = "txtPisoAsignado";
            this.txtPisoAsignado.Size = new System.Drawing.Size(188, 31);
            this.txtPisoAsignado.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOrdenador);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 67);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ordenador";
            // 
            // txtOrdenador
            // 
            this.txtOrdenador.Location = new System.Drawing.Point(6, 30);
            this.txtOrdenador.Name = "txtOrdenador";
            this.txtOrdenador.Size = new System.Drawing.Size(188, 31);
            this.txtOrdenador.TabIndex = 0;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtDNI);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(3, 3);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(200, 67);
            this.gb1.TabIndex = 1;
            this.gb1.TabStop = false;
            this.gb1.Text = "DNI";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(6, 30);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(188, 31);
            this.txtDNI.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoras);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 67);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(6, 30);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(188, 31);
            this.txtHoras.TabIndex = 0;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(3, 149);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(200, 56);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar Cambios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // AdministrarAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 231);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdministrarAdmins";
            this.Text = "AdministrarAdmins";
            this.Load += new System.EventHandler(this.AdministrarAdmins_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPisoAsignado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOrdenador;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnAplicar;
    }
}