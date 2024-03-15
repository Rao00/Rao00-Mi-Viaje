namespace Ejercicio06
{
    partial class Eje06
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eje06));
            this.btnGestionarCursos = new System.Windows.Forms.Button();
            this.btnGestionarAlumnos = new System.Windows.Forms.Button();
            this.btnGestionarProfesores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGestionarCursos
            // 
            this.btnGestionarCursos.Location = new System.Drawing.Point(258, 99);
            this.btnGestionarCursos.Name = "btnGestionarCursos";
            this.btnGestionarCursos.Size = new System.Drawing.Size(255, 68);
            this.btnGestionarCursos.TabIndex = 0;
            this.btnGestionarCursos.Text = "Gestion de Cursos";
            this.btnGestionarCursos.UseVisualStyleBackColor = true;
            this.btnGestionarCursos.Click += new System.EventHandler(this.btnGestionarCursos_Click);
            // 
            // btnGestionarAlumnos
            // 
            this.btnGestionarAlumnos.Location = new System.Drawing.Point(258, 183);
            this.btnGestionarAlumnos.Name = "btnGestionarAlumnos";
            this.btnGestionarAlumnos.Size = new System.Drawing.Size(255, 68);
            this.btnGestionarAlumnos.TabIndex = 1;
            this.btnGestionarAlumnos.Text = "Gestion de Alumnos";
            this.btnGestionarAlumnos.UseVisualStyleBackColor = true;
            this.btnGestionarAlumnos.Click += new System.EventHandler(this.btnGestionarAlumnos_Click);
            // 
            // btnGestionarProfesores
            // 
            this.btnGestionarProfesores.Location = new System.Drawing.Point(258, 266);
            this.btnGestionarProfesores.Name = "btnGestionarProfesores";
            this.btnGestionarProfesores.Size = new System.Drawing.Size(255, 68);
            this.btnGestionarProfesores.TabIndex = 2;
            this.btnGestionarProfesores.Text = "Gestion de Profesores";
            this.btnGestionarProfesores.UseVisualStyleBackColor = true;
            this.btnGestionarProfesores.Click += new System.EventHandler(this.btnGestionarProfesores_Click);
            // 
            // Eje06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGestionarProfesores);
            this.Controls.Add(this.btnGestionarAlumnos);
            this.Controls.Add(this.btnGestionarCursos);
            this.Name = "Eje06";
            this.Text = resources.GetString("$this.Text");
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGestionarCursos;
        private System.Windows.Forms.Button btnGestionarAlumnos;
        private System.Windows.Forms.Button btnGestionarProfesores;
    }
}

