namespace Ejercicio06.Cursos
{
    partial class fCursos
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnShowCursos = new System.Windows.Forms.Button();
            this.btnShowCursoContent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 59);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(226, 74);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Añadir Curso";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(279, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(226, 74);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Eliminar Curso";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnShowCursos
            // 
            this.btnShowCursos.Location = new System.Drawing.Point(279, 219);
            this.btnShowCursos.Name = "btnShowCursos";
            this.btnShowCursos.Size = new System.Drawing.Size(226, 74);
            this.btnShowCursos.TabIndex = 2;
            this.btnShowCursos.Text = "Mostrar todos los Cursos";
            this.btnShowCursos.UseVisualStyleBackColor = true;
            this.btnShowCursos.Click += new System.EventHandler(this.btnShowCursos_Click);
            // 
            // btnShowCursoContent
            // 
            this.btnShowCursoContent.Location = new System.Drawing.Point(279, 299);
            this.btnShowCursoContent.Name = "btnShowCursoContent";
            this.btnShowCursoContent.Size = new System.Drawing.Size(226, 74);
            this.btnShowCursoContent.TabIndex = 3;
            this.btnShowCursoContent.Text = "Mostar todos los alumnos de un curso";
            this.btnShowCursoContent.UseVisualStyleBackColor = true;
            this.btnShowCursoContent.Click += new System.EventHandler(this.btnShowCursoContent_Click);
            // 
            // fCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowCursoContent);
            this.Controls.Add(this.btnShowCursos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "fCursos";
            this.Text = "fCursos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnShowCursos;
        private System.Windows.Forms.Button btnShowCursoContent;
    }
}