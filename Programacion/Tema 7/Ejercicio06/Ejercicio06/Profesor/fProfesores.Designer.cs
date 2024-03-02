namespace Ejercicio06.Profesores
{
    partial class fProfesores
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
            this.btnShowProfesoresAsinatura = new System.Windows.Forms.Button();
            this.btnDeleteAsignaturas = new System.Windows.Forms.Button();
            this.btnAddAsignatura = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowProfesor = new System.Windows.Forms.Button();
            this.btnSortAlphOrderProfesor = new System.Windows.Forms.Button();
            this.btnDeleteProfesor = new System.Windows.Forms.Button();
            this.btnMostrarListaProfesores = new System.Windows.Forms.Button();
            this.btnNewProfesor = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowProfesoresAsinatura);
            this.groupBox2.Controls.Add(this.btnDeleteAsignaturas);
            this.groupBox2.Controls.Add(this.btnAddAsignatura);
            this.groupBox2.Location = new System.Drawing.Point(29, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(742, 197);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Asignaturas";
            // 
            // btnShowProfesoresAsinatura
            // 
            this.btnShowProfesoresAsinatura.Location = new System.Drawing.Point(193, 102);
            this.btnShowProfesoresAsinatura.Name = "btnShowProfesoresAsinatura";
            this.btnShowProfesoresAsinatura.Size = new System.Drawing.Size(344, 60);
            this.btnShowProfesoresAsinatura.TabIndex = 4;
            this.btnShowProfesoresAsinatura.Text = "Mostrar profesores que imparten asigantura";
            this.btnShowProfesoresAsinatura.UseVisualStyleBackColor = true;
            this.btnShowProfesoresAsinatura.Click += new System.EventHandler(this.btnShowProfesoresAsinatura_Click);
            // 
            // btnDeleteAsignaturas
            // 
            this.btnDeleteAsignaturas.Location = new System.Drawing.Point(373, 36);
            this.btnDeleteAsignaturas.Name = "btnDeleteAsignaturas";
            this.btnDeleteAsignaturas.Size = new System.Drawing.Size(344, 40);
            this.btnDeleteAsignaturas.TabIndex = 3;
            this.btnDeleteAsignaturas.Text = "Elminiar asignaturas de un profesor";
            this.btnDeleteAsignaturas.UseVisualStyleBackColor = true;
            this.btnDeleteAsignaturas.Click += new System.EventHandler(this.btnDeleteAsignaturas_Click);
            // 
            // btnAddAsignatura
            // 
            this.btnAddAsignatura.Location = new System.Drawing.Point(23, 36);
            this.btnAddAsignatura.Name = "btnAddAsignatura";
            this.btnAddAsignatura.Size = new System.Drawing.Size(344, 40);
            this.btnAddAsignatura.TabIndex = 3;
            this.btnAddAsignatura.Text = "Añadir asignatura a un Profesor";
            this.btnAddAsignatura.UseVisualStyleBackColor = true;
            this.btnAddAsignatura.Click += new System.EventHandler(this.btnAddAsignatura_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowProfesor);
            this.groupBox1.Controls.Add(this.btnSortAlphOrderProfesor);
            this.groupBox1.Controls.Add(this.btnDeleteProfesor);
            this.groupBox1.Controls.Add(this.btnMostrarListaProfesores);
            this.groupBox1.Controls.Add(this.btnNewProfesor);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(742, 150);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Profesores";
            // 
            // btnShowProfesor
            // 
            this.btnShowProfesor.Location = new System.Drawing.Point(375, 87);
            this.btnShowProfesor.Name = "btnShowProfesor";
            this.btnShowProfesor.Size = new System.Drawing.Size(344, 40);
            this.btnShowProfesor.TabIndex = 4;
            this.btnShowProfesor.Text = "Mostrar profesor";
            this.btnShowProfesor.UseVisualStyleBackColor = true;
            this.btnShowProfesor.Click += new System.EventHandler(this.btnShowProfesor_Click);
            // 
            // btnSortAlphOrderProfesor
            // 
            this.btnSortAlphOrderProfesor.Location = new System.Drawing.Point(23, 87);
            this.btnSortAlphOrderProfesor.Name = "btnSortAlphOrderProfesor";
            this.btnSortAlphOrderProfesor.Size = new System.Drawing.Size(344, 40);
            this.btnSortAlphOrderProfesor.TabIndex = 3;
            this.btnSortAlphOrderProfesor.Text = "Ordenar profesores por orden alfabetico";
            this.btnSortAlphOrderProfesor.UseVisualStyleBackColor = true;
            this.btnSortAlphOrderProfesor.Click += new System.EventHandler(this.btnSortAlphOrderProfesor_Click);
            // 
            // btnDeleteProfesor
            // 
            this.btnDeleteProfesor.Location = new System.Drawing.Point(258, 36);
            this.btnDeleteProfesor.Name = "btnDeleteProfesor";
            this.btnDeleteProfesor.Size = new System.Drawing.Size(225, 40);
            this.btnDeleteProfesor.TabIndex = 2;
            this.btnDeleteProfesor.Text = "Eliminar profesor";
            this.btnDeleteProfesor.UseVisualStyleBackColor = true;
            this.btnDeleteProfesor.Click += new System.EventHandler(this.btnDeleteProfesor_Click);
            // 
            // btnMostrarListaProfesores
            // 
            this.btnMostrarListaProfesores.Location = new System.Drawing.Point(499, 36);
            this.btnMostrarListaProfesores.Name = "btnMostrarListaProfesores";
            this.btnMostrarListaProfesores.Size = new System.Drawing.Size(220, 40);
            this.btnMostrarListaProfesores.TabIndex = 1;
            this.btnMostrarListaProfesores.Text = "Ver Lista profesores";
            this.btnMostrarListaProfesores.UseVisualStyleBackColor = true;
            this.btnMostrarListaProfesores.Click += new System.EventHandler(this.btnMostrarListaProfesores_Click);
            // 
            // btnNewProfesor
            // 
            this.btnNewProfesor.Location = new System.Drawing.Point(23, 36);
            this.btnNewProfesor.Name = "btnNewProfesor";
            this.btnNewProfesor.Size = new System.Drawing.Size(220, 40);
            this.btnNewProfesor.TabIndex = 0;
            this.btnNewProfesor.Text = "Nuevo profesor";
            this.btnNewProfesor.UseVisualStyleBackColor = true;
            this.btnNewProfesor.Click += new System.EventHandler(this.btnNewProfesor_Click);
            // 
            // fProfesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fProfesores";
            this.Text = "fProfesores";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowProfesoresAsinatura;
        private System.Windows.Forms.Button btnDeleteAsignaturas;
        private System.Windows.Forms.Button btnAddAsignatura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowProfesor;
        private System.Windows.Forms.Button btnSortAlphOrderProfesor;
        private System.Windows.Forms.Button btnDeleteProfesor;
        private System.Windows.Forms.Button btnMostrarListaProfesores;
        private System.Windows.Forms.Button btnNewProfesor;
    }
}