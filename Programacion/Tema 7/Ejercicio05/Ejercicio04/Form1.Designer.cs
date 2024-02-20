namespace Ejercicio04
{
    partial class EmpleadosVentas
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
            this.btnShowEmpl = new System.Windows.Forms.Button();
            this.btnSortAlphOrder = new System.Windows.Forms.Button();
            this.btnDeleteEmpl = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteVentas = new System.Windows.Forms.Button();
            this.btnShowMostSells = new System.Windows.Forms.Button();
            this.btnSortVentas = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.btnAddVenta.Location = new System.Drawing.Point(23, 48);
            this.btnAddVenta.Name = "btnAddVenta";
            this.btnAddVenta.Size = new System.Drawing.Size(344, 40);
            this.btnAddVenta.TabIndex = 3;
            this.btnAddVenta.Text = "Añadir Venta a un Empleado";
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
            // btnShowEmpl
            // 
            this.btnShowEmpl.Location = new System.Drawing.Point(375, 87);
            this.btnShowEmpl.Name = "btnShowEmpl";
            this.btnShowEmpl.Size = new System.Drawing.Size(344, 40);
            this.btnShowEmpl.TabIndex = 4;
            this.btnShowEmpl.Text = "Mostrar empleado";
            this.btnShowEmpl.UseVisualStyleBackColor = true;
            this.btnShowEmpl.Click += new System.EventHandler(this.btnShowEmpl_Click);
            // 
            // btnSortAlphOrder
            // 
            this.btnSortAlphOrder.Location = new System.Drawing.Point(23, 87);
            this.btnSortAlphOrder.Name = "btnSortAlphOrder";
            this.btnSortAlphOrder.Size = new System.Drawing.Size(344, 40);
            this.btnSortAlphOrder.TabIndex = 3;
            this.btnSortAlphOrder.Text = "Ordenar empleados por orden alfabetico";
            this.btnSortAlphOrder.UseVisualStyleBackColor = true;
            this.btnSortAlphOrder.Click += new System.EventHandler(this.btnSortAlphOrder_Click);
            // 
            // btnDeleteEmpl
            // 
            this.btnDeleteEmpl.Location = new System.Drawing.Point(258, 36);
            this.btnDeleteEmpl.Name = "btnDeleteEmpl";
            this.btnDeleteEmpl.Size = new System.Drawing.Size(225, 40);
            this.btnDeleteEmpl.TabIndex = 2;
            this.btnDeleteEmpl.Text = "Eliminar empleado";
            this.btnDeleteEmpl.UseVisualStyleBackColor = true;
            this.btnDeleteEmpl.Click += new System.EventHandler(this.btnDeleteEmpl_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSortVentas);
            this.groupBox2.Controls.Add(this.btnDeleteVentas);
            this.groupBox2.Controls.Add(this.btnAddVenta);
            this.groupBox2.Controls.Add(this.btnShowMostSells);
            this.groupBox2.Location = new System.Drawing.Point(29, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(20);
            this.groupBox2.Size = new System.Drawing.Size(742, 217);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ventas";
            // 
            // btnDeleteVentas
            // 
            this.btnDeleteVentas.Location = new System.Drawing.Point(23, 129);
            this.btnDeleteVentas.Name = "btnDeleteVentas";
            this.btnDeleteVentas.Size = new System.Drawing.Size(344, 40);
            this.btnDeleteVentas.TabIndex = 3;
            this.btnDeleteVentas.Text = "Elminiar las ventas de un empleado";
            this.btnDeleteVentas.UseVisualStyleBackColor = true;
            this.btnDeleteVentas.Click += new System.EventHandler(this.btnDeleteVentas_Click);
            // 
            // btnShowMostSells
            // 
            this.btnShowMostSells.Location = new System.Drawing.Point(375, 48);
            this.btnShowMostSells.Name = "btnShowMostSells";
            this.btnShowMostSells.Size = new System.Drawing.Size(344, 40);
            this.btnShowMostSells.TabIndex = 0;
            this.btnShowMostSells.Text = "Empleado con mayores Ventas";
            this.btnShowMostSells.UseVisualStyleBackColor = true;
            this.btnShowMostSells.Click += new System.EventHandler(this.btnShowMostSells_Click);
            // 
            // btnSortVentas
            // 
            this.btnSortVentas.Location = new System.Drawing.Point(375, 129);
            this.btnSortVentas.Name = "btnSortVentas";
            this.btnSortVentas.Size = new System.Drawing.Size(344, 40);
            this.btnSortVentas.TabIndex = 4;
            this.btnSortVentas.Text = "Ordenar empleados por Ventas";
            this.btnSortVentas.UseVisualStyleBackColor = true;
            this.btnSortVentas.Click += new System.EventHandler(this.btnSortVentas_Click);
            // 
            // EmpleadosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmpleadosVentas";
            this.Text = "Empleados y Ventas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSortVentas;
        private System.Windows.Forms.Button btnDeleteVentas;
        private System.Windows.Forms.Button btnShowMostSells;
    }
}

