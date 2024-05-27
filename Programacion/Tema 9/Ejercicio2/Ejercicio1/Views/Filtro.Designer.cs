namespace Ejercicio1
{
    partial class Filtro
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
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtResultados = new System.Windows.Forms.RichTextBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbApellido = new System.Windows.Forms.RadioButton();
            this.rbCorreo = new System.Windows.Forms.RadioButton();
            this.rbTelefono = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnNoFiltrar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.rbProfesores = new System.Windows.Forms.RadioButton();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbAlumnos = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbDNI
            // 
            this.rbDNI.AutoCheck = false;
            this.rbDNI.AutoSize = true;
            this.rbDNI.Checked = true;
            this.rbDNI.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDNI.Location = new System.Drawing.Point(14, 18);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(65, 28);
            this.rbDNI.TabIndex = 0;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            this.rbDNI.Click += new System.EventHandler(this.rbDNI_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtResultados);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(125, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 176);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // txtResultados
            // 
            this.txtResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResultados.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtResultados.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultados.Location = new System.Drawing.Point(6, 25);
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.ReadOnly = true;
            this.txtResultados.RightMargin = 190;
            this.txtResultados.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtResultados.Size = new System.Drawing.Size(218, 145);
            this.txtResultados.TabIndex = 7;
            this.txtResultados.Text = "";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoCheck = false;
            this.rbNombre.AutoSize = true;
            this.rbNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNombre.Location = new System.Drawing.Point(14, 52);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(103, 28);
            this.rbNombre.TabIndex = 2;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.Click += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbApellido
            // 
            this.rbApellido.AutoCheck = false;
            this.rbApellido.AutoSize = true;
            this.rbApellido.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbApellido.Location = new System.Drawing.Point(14, 86);
            this.rbApellido.Name = "rbApellido";
            this.rbApellido.Size = new System.Drawing.Size(106, 28);
            this.rbApellido.TabIndex = 3;
            this.rbApellido.Text = "Apellido";
            this.rbApellido.UseVisualStyleBackColor = true;
            this.rbApellido.Click += new System.EventHandler(this.rbApellido_CheckedChanged);
            // 
            // rbCorreo
            // 
            this.rbCorreo.AutoCheck = false;
            this.rbCorreo.AutoSize = true;
            this.rbCorreo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCorreo.Location = new System.Drawing.Point(14, 154);
            this.rbCorreo.Name = "rbCorreo";
            this.rbCorreo.Size = new System.Drawing.Size(92, 28);
            this.rbCorreo.TabIndex = 4;
            this.rbCorreo.Text = "Correo";
            this.rbCorreo.UseVisualStyleBackColor = true;
            this.rbCorreo.Click += new System.EventHandler(this.rbCorreo_CheckedChanged);
            // 
            // rbTelefono
            // 
            this.rbTelefono.AutoCheck = false;
            this.rbTelefono.AutoSize = true;
            this.rbTelefono.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTelefono.Location = new System.Drawing.Point(14, 120);
            this.rbTelefono.Name = "rbTelefono";
            this.rbTelefono.Size = new System.Drawing.Size(111, 28);
            this.rbTelefono.TabIndex = 5;
            this.rbTelefono.Text = "Telefono";
            this.rbTelefono.UseVisualStyleBackColor = true;
            this.rbTelefono.Click += new System.EventHandler(this.rbTelefono_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro.Location = new System.Drawing.Point(12, 194);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(549, 31);
            this.txtFiltro.TabIndex = 6;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // btnNoFiltrar
            // 
            this.btnNoFiltrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoFiltrar.Location = new System.Drawing.Point(12, 231);
            this.btnNoFiltrar.Name = "btnNoFiltrar";
            this.btnNoFiltrar.Size = new System.Drawing.Size(285, 35);
            this.btnNoFiltrar.TabIndex = 7;
            this.btnNoFiltrar.Text = "Volver sin Filtrar";
            this.btnNoFiltrar.UseVisualStyleBackColor = true;
            this.btnNoFiltrar.Click += new System.EventHandler(this.btnNoFiltrar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(303, 231);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(258, 35);
            this.btnFiltrar.TabIndex = 8;
            this.btnFiltrar.Text = "Volver con el Filtro";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // rbProfesores
            // 
            this.rbProfesores.AutoCheck = false;
            this.rbProfesores.AutoSize = true;
            this.rbProfesores.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbProfesores.Location = new System.Drawing.Point(378, 32);
            this.rbProfesores.Name = "rbProfesores";
            this.rbProfesores.Size = new System.Drawing.Size(128, 28);
            this.rbProfesores.TabIndex = 9;
            this.rbProfesores.Text = "Profesores";
            this.rbProfesores.UseVisualStyleBackColor = true;
            this.rbProfesores.Click += new System.EventHandler(this.rbtnProfesores_CheckedChanged);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoCheck = false;
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdmin.Location = new System.Drawing.Point(378, 74);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(184, 28);
            this.rbAdmin.TabIndex = 10;
            this.rbAdmin.Text = "Administradores";
            this.rbAdmin.UseVisualStyleBackColor = true;
            this.rbAdmin.Click += new System.EventHandler(this.rbtnAdmin_CheckedChanged);
            // 
            // rbAlumnos
            // 
            this.rbAlumnos.AutoCheck = false;
            this.rbAlumnos.AutoSize = true;
            this.rbAlumnos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAlumnos.Location = new System.Drawing.Point(378, 116);
            this.rbAlumnos.Name = "rbAlumnos";
            this.rbAlumnos.Size = new System.Drawing.Size(111, 28);
            this.rbAlumnos.TabIndex = 11;
            this.rbAlumnos.Text = "Alumnos";
            this.rbAlumnos.UseVisualStyleBackColor = true;
            this.rbAlumnos.Click += new System.EventHandler(this.rbtnAlumnos_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoCheck = false;
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.Location = new System.Drawing.Point(377, 158);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(86, 28);
            this.rbTodos.TabIndex = 12;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.Click += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // Filtro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 275);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbAlumnos);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.rbProfesores);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnNoFiltrar);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.rbTelefono);
            this.Controls.Add(this.rbCorreo);
            this.Controls.Add(this.rbApellido);
            this.Controls.Add(this.rbNombre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbDNI);
            this.Name = "Filtro";
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.Filtro_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbApellido;
        private System.Windows.Forms.RadioButton rbCorreo;
        private System.Windows.Forms.RadioButton rbTelefono;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RichTextBox txtResultados;
        private System.Windows.Forms.Button btnNoFiltrar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.RadioButton rbProfesores;
        private System.Windows.Forms.RadioButton rbAdmin;
        private System.Windows.Forms.RadioButton rbAlumnos;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}