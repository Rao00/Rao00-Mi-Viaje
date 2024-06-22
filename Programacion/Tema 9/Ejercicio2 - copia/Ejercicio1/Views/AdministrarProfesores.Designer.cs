namespace Ejercicio1
{
    partial class AdministrarProfesores
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCursoAsignado = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAsignatura1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAsignatura2 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCursoTutor = new System.Windows.Forms.TextBox();
            this.cbEsTutor = new System.Windows.Forms.CheckBox();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gb1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAplicar, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.txtDNI);
            this.gb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb1.Location = new System.Drawing.Point(3, 3);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(200, 70);
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
            this.groupBox1.Controls.Add(this.txtCursoAsignado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Curso Asignado";
            // 
            // txtCursoAsignado
            // 
            this.txtCursoAsignado.Location = new System.Drawing.Point(6, 30);
            this.txtCursoAsignado.Name = "txtCursoAsignado";
            this.txtCursoAsignado.Size = new System.Drawing.Size(188, 31);
            this.txtCursoAsignado.TabIndex = 0;
            this.txtCursoAsignado.TextChanged += new System.EventHandler(this.txtCursoAsignado_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAsignatura1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(209, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 70);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignatura 1";
            // 
            // txtAsignatura1
            // 
            this.txtAsignatura1.Location = new System.Drawing.Point(6, 30);
            this.txtAsignatura1.Name = "txtAsignatura1";
            this.txtAsignatura1.Size = new System.Drawing.Size(188, 31);
            this.txtAsignatura1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAsignatura2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(209, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 70);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignatura 2";
            // 
            // txtAsignatura2
            // 
            this.txtAsignatura2.Location = new System.Drawing.Point(6, 30);
            this.txtAsignatura2.Name = "txtAsignatura2";
            this.txtAsignatura2.Size = new System.Drawing.Size(188, 31);
            this.txtAsignatura2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox4, 2);
            this.groupBox4.Controls.Add(this.cbEsTutor);
            this.groupBox4.Controls.Add(this.txtCursoTutor);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 155);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(407, 70);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Curso del que es Tutor";
            // 
            // txtCursoTutor
            // 
            this.txtCursoTutor.Location = new System.Drawing.Point(171, 30);
            this.txtCursoTutor.Name = "txtCursoTutor";
            this.txtCursoTutor.Size = new System.Drawing.Size(223, 31);
            this.txtCursoTutor.TabIndex = 0;
            this.txtCursoTutor.Visible = false;
            // 
            // cbEsTutor
            // 
            this.cbEsTutor.AutoSize = true;
            this.cbEsTutor.Location = new System.Drawing.Point(25, 30);
            this.cbEsTutor.Name = "cbEsTutor";
            this.cbEsTutor.Size = new System.Drawing.Size(117, 29);
            this.cbEsTutor.TabIndex = 1;
            this.cbEsTutor.Text = "Es tutor?";
            this.cbEsTutor.UseVisualStyleBackColor = true;
            this.cbEsTutor.CheckedChanged += new System.EventHandler(this.cbEsTutor_CheckedChanged);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Enabled = false;
            this.btnAplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicar.Location = new System.Drawing.Point(3, 231);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(200, 57);
            this.btnAplicar.TabIndex = 6;
            this.btnAplicar.Text = "Aplicar Cambios";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(209, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 57);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // AdministrarProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 315);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdministrarProfesores";
            this.Text = "AdministrarProfesores";
            this.Load += new System.EventHandler(this.AdministrarProfesores_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCursoTutor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAsignatura2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtAsignatura1;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCursoAsignado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox cbEsTutor;
        private System.Windows.Forms.Button btnAplicar;
    }
}