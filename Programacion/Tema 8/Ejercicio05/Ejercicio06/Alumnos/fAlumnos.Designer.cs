namespace Ejercicio06.Alumnos
{
    partial class fAlumnos
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminarNota = new System.Windows.Forms.Button();
            this.btnMediaMenor = new System.Windows.Forms.Button();
            this.btnMediaMayor = new System.Windows.Forms.Button();
            this.btnAñadirNota = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlumnosEnCurso = new System.Windows.Forms.Button();
            this.btnShowAlumno = new System.Windows.Forms.Button();
            this.btnSortAlphOrderAlumnos = new System.Windows.Forms.Button();
            this.btnDeleteAlumno = new System.Windows.Forms.Button();
            this.btnMostrarAlumnos = new System.Windows.Forms.Button();
            this.btnNewAlumno = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEliminarNota);
            this.groupBox2.Controls.Add(this.btnMediaMenor);
            this.groupBox2.Controls.Add(this.btnMediaMayor);
            this.groupBox2.Controls.Add(this.btnAñadirNota);
            this.groupBox2.Location = new System.Drawing.Point(29, 241);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(742, 180);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // btnEliminarNota
            // 
            this.btnEliminarNota.Location = new System.Drawing.Point(23, 107);
            this.btnEliminarNota.Name = "btnEliminarNota";
            this.btnEliminarNota.Size = new System.Drawing.Size(344, 40);
            this.btnEliminarNota.TabIndex = 5;
            this.btnEliminarNota.Text = "Eliminar notas Alumno";
            this.btnEliminarNota.UseVisualStyleBackColor = true;
            this.btnEliminarNota.Click += new System.EventHandler(this.btnEliminarNota_Click);
            // 
            // btnMediaMenor
            // 
            this.btnMediaMenor.Location = new System.Drawing.Point(375, 107);
            this.btnMediaMenor.Name = "btnMediaMenor";
            this.btnMediaMenor.Size = new System.Drawing.Size(342, 40);
            this.btnMediaMenor.TabIndex = 4;
            this.btnMediaMenor.Text = "Notas medias mayores o iguales a 5";
            this.btnMediaMenor.UseCompatibleTextRendering = true;
            this.btnMediaMenor.UseVisualStyleBackColor = true;
            this.btnMediaMenor.Click += new System.EventHandler(this.btnMediaMenor_Click);
            // 
            // btnMediaMayor
            // 
            this.btnMediaMayor.Location = new System.Drawing.Point(373, 34);
            this.btnMediaMayor.Name = "btnMediaMayor";
            this.btnMediaMayor.Size = new System.Drawing.Size(344, 40);
            this.btnMediaMayor.TabIndex = 3;
            this.btnMediaMayor.Text = "Notas medias mayores o iguales a 5";
            this.btnMediaMayor.UseVisualStyleBackColor = true;
            this.btnMediaMayor.Click += new System.EventHandler(this.btnMediaMayor_Click);
            // 
            // btnAñadirNota
            // 
            this.btnAñadirNota.Location = new System.Drawing.Point(23, 34);
            this.btnAñadirNota.Name = "btnAñadirNota";
            this.btnAñadirNota.Size = new System.Drawing.Size(344, 40);
            this.btnAñadirNota.TabIndex = 3;
            this.btnAñadirNota.Text = "Añadir notas a un Alumno";
            this.btnAñadirNota.UseVisualStyleBackColor = true;
            this.btnAñadirNota.Click += new System.EventHandler(this.btnAñadirNota_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlumnosEnCurso);
            this.groupBox1.Controls.Add(this.btnShowAlumno);
            this.groupBox1.Controls.Add(this.btnSortAlphOrderAlumnos);
            this.groupBox1.Controls.Add(this.btnDeleteAlumno);
            this.groupBox1.Controls.Add(this.btnMostrarAlumnos);
            this.groupBox1.Controls.Add(this.btnNewAlumno);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(742, 191);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumnos";
            // 
            // btnAlumnosEnCurso
            // 
            this.btnAlumnosEnCurso.Location = new System.Drawing.Point(198, 137);
            this.btnAlumnosEnCurso.Name = "btnAlumnosEnCurso";
            this.btnAlumnosEnCurso.Size = new System.Drawing.Size(344, 40);
            this.btnAlumnosEnCurso.TabIndex = 5;
            this.btnAlumnosEnCurso.Text = "Mostrar Alumnos pertenecientes a un curso";
            this.btnAlumnosEnCurso.UseVisualStyleBackColor = true;
            this.btnAlumnosEnCurso.Click += new System.EventHandler(this.btnAlumnosEnCurso_Click);
            // 
            // btnShowAlumno
            // 
            this.btnShowAlumno.Location = new System.Drawing.Point(375, 87);
            this.btnShowAlumno.Name = "btnShowAlumno";
            this.btnShowAlumno.Size = new System.Drawing.Size(344, 40);
            this.btnShowAlumno.TabIndex = 4;
            this.btnShowAlumno.Text = "Mostrar Alumno por nombre";
            this.btnShowAlumno.UseVisualStyleBackColor = true;
            this.btnShowAlumno.Click += new System.EventHandler(this.btnShowAlumno_Click);
            // 
            // btnSortAlphOrderAlumnos
            // 
            this.btnSortAlphOrderAlumnos.Location = new System.Drawing.Point(23, 87);
            this.btnSortAlphOrderAlumnos.Name = "btnSortAlphOrderAlumnos";
            this.btnSortAlphOrderAlumnos.Size = new System.Drawing.Size(344, 40);
            this.btnSortAlphOrderAlumnos.TabIndex = 3;
            this.btnSortAlphOrderAlumnos.Text = "Ordenar Alumnos por orden alfabetico";
            this.btnSortAlphOrderAlumnos.UseVisualStyleBackColor = true;
            this.btnSortAlphOrderAlumnos.Click += new System.EventHandler(this.btnSortAlphOrderAlumnos_Click);
            // 
            // btnDeleteAlumno
            // 
            this.btnDeleteAlumno.Location = new System.Drawing.Point(258, 36);
            this.btnDeleteAlumno.Name = "btnDeleteAlumno";
            this.btnDeleteAlumno.Size = new System.Drawing.Size(225, 40);
            this.btnDeleteAlumno.TabIndex = 2;
            this.btnDeleteAlumno.Text = "Eliminar Alumno";
            this.btnDeleteAlumno.UseVisualStyleBackColor = true;
            this.btnDeleteAlumno.Click += new System.EventHandler(this.btnDeleteAlumno_Click);
            // 
            // btnMostrarAlumnos
            // 
            this.btnMostrarAlumnos.Location = new System.Drawing.Point(499, 36);
            this.btnMostrarAlumnos.Name = "btnMostrarAlumnos";
            this.btnMostrarAlumnos.Size = new System.Drawing.Size(220, 40);
            this.btnMostrarAlumnos.TabIndex = 1;
            this.btnMostrarAlumnos.Text = "Ver Lista Alumnos";
            this.btnMostrarAlumnos.UseVisualStyleBackColor = true;
            this.btnMostrarAlumnos.Click += new System.EventHandler(this.btnMostrarAlumnos_Click);
            // 
            // btnNewAlumno
            // 
            this.btnNewAlumno.Location = new System.Drawing.Point(23, 36);
            this.btnNewAlumno.Name = "btnNewAlumno";
            this.btnNewAlumno.Size = new System.Drawing.Size(220, 40);
            this.btnNewAlumno.TabIndex = 0;
            this.btnNewAlumno.Text = "Nuevo Alumno";
            this.btnNewAlumno.UseVisualStyleBackColor = true;
            this.btnNewAlumno.Click += new System.EventHandler(this.btnNewAlumno_Click);
            // 
            // fAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAlumnos";
            this.Text = "fAlumnos";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMediaMenor;
        private System.Windows.Forms.Button btnMediaMayor;
        private System.Windows.Forms.Button btnAñadirNota;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowAlumno;
        private System.Windows.Forms.Button btnSortAlphOrderAlumnos;
        private System.Windows.Forms.Button btnDeleteAlumno;
        private System.Windows.Forms.Button btnMostrarAlumnos;
        private System.Windows.Forms.Button btnNewAlumno;
        private System.Windows.Forms.Button btnEliminarNota;
        private System.Windows.Forms.Button btnAlumnosEnCurso;
    }
}