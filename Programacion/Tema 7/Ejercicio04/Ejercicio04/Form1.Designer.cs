namespace Ejercicio04
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
            this.btnNewEmpleado = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.btnAddVenta = new System.Windows.Forms.Button();
            this.btnAddEdad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewEmpleado
            // 
            this.btnNewEmpleado.Location = new System.Drawing.Point(194, 141);
            this.btnNewEmpleado.Name = "btnNewEmpleado";
            this.btnNewEmpleado.Size = new System.Drawing.Size(176, 56);
            this.btnNewEmpleado.TabIndex = 0;
            this.btnNewEmpleado.Text = "Nuevo empleado";
            this.btnNewEmpleado.UseVisualStyleBackColor = true;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(408, 141);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(176, 56);
            this.btnMostrarLista.TabIndex = 1;
            this.btnMostrarLista.Text = "Ver Lista empleados";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            // 
            // btnAddVenta
            // 
            this.btnAddVenta.Location = new System.Drawing.Point(408, 235);
            this.btnAddVenta.Name = "btnAddVenta";
            this.btnAddVenta.Size = new System.Drawing.Size(176, 56);
            this.btnAddVenta.TabIndex = 3;
            this.btnAddVenta.Text = "Añadir Venta";
            this.btnAddVenta.UseVisualStyleBackColor = true;
            // 
            // btnAddEdad
            // 
            this.btnAddEdad.Location = new System.Drawing.Point(194, 235);
            this.btnAddEdad.Name = "btnAddEdad";
            this.btnAddEdad.Size = new System.Drawing.Size(176, 56);
            this.btnAddEdad.TabIndex = 2;
            this.btnAddEdad.Text = "Cumpleaños de un Empleado";
            this.btnAddEdad.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddVenta);
            this.Controls.Add(this.btnAddEdad);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.btnNewEmpleado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmpleado;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnAddVenta;
        private System.Windows.Forms.Button btnAddEdad;
    }
}

