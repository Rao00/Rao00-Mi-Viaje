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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteEmpl = new System.Windows.Forms.Button();
            this.btnSortAlphOrder = new System.Windows.Forms.Button();
            this.btnShowEmpl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewEmpleado
            // 
            this.btnNewEmpleado.Location = new System.Drawing.Point(23, 36);
            this.btnNewEmpleado.Name = "btnNewEmpleado";
            this.btnNewEmpleado.Size = new System.Drawing.Size(220, 40);
            this.btnNewEmpleado.TabIndex = 0;
            this.btnNewEmpleado.Text = "Nuevo empleado";
            this.btnNewEmpleado.UseVisualStyleBackColor = true;
            this.btnNewEmpleado.Click += new System.EventHandler(this.btnNewEmpleado_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(499, 36);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(220, 40);
            this.btnMostrarLista.TabIndex = 1;
            this.btnMostrarLista.Text = "Ver Lista empleados";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // btnAddVenta
            // 
            this.btnAddVenta.Location = new System.Drawing.Point(551, 306);
            this.btnAddVenta.Name = "btnAddVenta";
            this.btnAddVenta.Size = new System.Drawing.Size(176, 56);
            this.btnAddVenta.TabIndex = 3;
            this.btnAddVenta.Text = "Añadir Venta";
            this.btnAddVenta.UseVisualStyleBackColor = true;
            this.btnAddVenta.Click += new System.EventHandler(this.btnAddVenta_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowEmpl);
            this.groupBox1.Controls.Add(this.btnSortAlphOrder);
            this.groupBox1.Controls.Add(this.btnDeleteEmpl);
            this.groupBox1.Controls.Add(this.btnMostrarLista);
            this.groupBox1.Controls.Add(this.btnNewEmpleado);
            this.groupBox1.Location = new System.Drawing.Point(29, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox1.Size = new System.Drawing.Size(742, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Empleados";
            // 
            // btnDeleteEmpl
            // 
            this.btnDeleteEmpl.Location = new System.Drawing.Point(258, 36);
            this.btnDeleteEmpl.Name = "btnDeleteEmpl";
            this.btnDeleteEmpl.Size = new System.Drawing.Size(225, 40);
            this.btnDeleteEmpl.TabIndex = 2;
            this.btnDeleteEmpl.Text = "Eliminar empleado";
            this.btnDeleteEmpl.UseVisualStyleBackColor = true;
            // 
            // btnSortAlphOrder
            // 
            this.btnSortAlphOrder.Location = new System.Drawing.Point(23, 87);
            this.btnSortAlphOrder.Name = "btnSortAlphOrder";
            this.btnSortAlphOrder.Size = new System.Drawing.Size(344, 40);
            this.btnSortAlphOrder.TabIndex = 3;
            this.btnSortAlphOrder.Text = "Ordenar empleados por orden alfabetico";
            this.btnSortAlphOrder.UseVisualStyleBackColor = true;
            // 
            // btnShowEmpl
            // 
            this.btnShowEmpl.Location = new System.Drawing.Point(375, 87);
            this.btnShowEmpl.Name = "btnShowEmpl";
            this.btnShowEmpl.Size = new System.Drawing.Size(344, 40);
            this.btnShowEmpl.TabIndex = 4;
            this.btnShowEmpl.Text = "Mostrar empleado";
            this.btnShowEmpl.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewEmpleado;
        private System.Windows.Forms.Button btnMostrarLista;
        private System.Windows.Forms.Button btnAddVenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteEmpl;
        private System.Windows.Forms.Button btnShowEmpl;
        private System.Windows.Forms.Button btnSortAlphOrder;
    }
}

