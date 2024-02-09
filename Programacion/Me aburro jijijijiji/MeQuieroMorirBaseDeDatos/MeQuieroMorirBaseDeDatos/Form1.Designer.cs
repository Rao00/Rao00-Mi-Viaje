namespace MeQuieroMorirBaseDeDatos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Clientes");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Productos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Puntos de Venta");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Relaciones");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("JARDINERIA", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.trV = new System.Windows.Forms.TreeView();
            this.bAñadirDatos = new System.Windows.Forms.Button();
            this.bEliminarDatos = new System.Windows.Forms.Button();
            this.bAñadirTabla = new System.Windows.Forms.Button();
            this.bEliminarTabla = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.rbFilas = new System.Windows.Forms.RadioButton();
            this.rbColumnas = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bModSelec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // trV
            // 
            this.trV.Location = new System.Drawing.Point(-1, -1);
            this.trV.Name = "trV";
            treeNode1.Name = "tabla_clientes";
            treeNode1.Text = "Clientes";
            treeNode2.Name = "tabla_productos";
            treeNode2.Text = "Productos";
            treeNode3.Name = "tabla_puntosVenta";
            treeNode3.Text = "Puntos de Venta";
            treeNode4.Name = "relaciones";
            treeNode4.Text = "Relaciones";
            treeNode5.Name = "BaseDatos";
            treeNode5.Text = "JARDINERIA";
            this.trV.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.trV.Size = new System.Drawing.Size(165, 588);
            this.trV.TabIndex = 0;
            // 
            // bAñadirDatos
            // 
            this.bAñadirDatos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAñadirDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirDatos.Location = new System.Drawing.Point(163, -1);
            this.bAñadirDatos.Name = "bAñadirDatos";
            this.bAñadirDatos.Size = new System.Drawing.Size(170, 37);
            this.bAñadirDatos.TabIndex = 1;
            this.bAñadirDatos.Text = "Añadir Datos (Selecciona tabla)";
            this.bAñadirDatos.UseVisualStyleBackColor = false;
            this.bAñadirDatos.Click += new System.EventHandler(this.initTreeView);
            // 
            // bEliminarDatos
            // 
            this.bEliminarDatos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEliminarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarDatos.Location = new System.Drawing.Point(163, 35);
            this.bEliminarDatos.Name = "bEliminarDatos";
            this.bEliminarDatos.Size = new System.Drawing.Size(170, 37);
            this.bEliminarDatos.TabIndex = 2;
            this.bEliminarDatos.Text = "Eliminar Datos (Selecciona tabla)";
            this.bEliminarDatos.UseVisualStyleBackColor = false;
            // 
            // bAñadirTabla
            // 
            this.bAñadirTabla.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bAñadirTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAñadirTabla.Location = new System.Drawing.Point(332, -1);
            this.bAñadirTabla.Name = "bAñadirTabla";
            this.bAñadirTabla.Size = new System.Drawing.Size(221, 37);
            this.bAñadirTabla.TabIndex = 3;
            this.bAñadirTabla.Text = "Añadir Tabla (Selecciona base de datos)";
            this.bAñadirTabla.UseVisualStyleBackColor = false;
            // 
            // bEliminarTabla
            // 
            this.bEliminarTabla.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bEliminarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEliminarTabla.Location = new System.Drawing.Point(332, 35);
            this.bEliminarTabla.Name = "bEliminarTabla";
            this.bEliminarTabla.Size = new System.Drawing.Size(221, 37);
            this.bEliminarTabla.TabIndex = 4;
            this.bEliminarTabla.Text = "Eliminar Tabla (Selecciona base de datos)";
            this.bEliminarTabla.UseVisualStyleBackColor = false;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(163, 71);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(779, 515);
            this.dataGrid.TabIndex = 5;
            // 
            // rbFilas
            // 
            this.rbFilas.AutoSize = true;
            this.rbFilas.Checked = true;
            this.rbFilas.Location = new System.Drawing.Point(559, 11);
            this.rbFilas.Name = "rbFilas";
            this.rbFilas.Size = new System.Drawing.Size(121, 17);
            this.rbFilas.TabIndex = 6;
            this.rbFilas.TabStop = true;
            this.rbFilas.Text = "Interactuar con Filas";
            this.rbFilas.UseVisualStyleBackColor = true;
            // 
            // rbColumnas
            // 
            this.rbColumnas.AutoSize = true;
            this.rbColumnas.Location = new System.Drawing.Point(559, 44);
            this.rbColumnas.Name = "rbColumnas";
            this.rbColumnas.Size = new System.Drawing.Size(146, 17);
            this.rbColumnas.TabIndex = 7;
            this.rbColumnas.Text = "Interactuar con Columnas";
            this.rbColumnas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bModSelec);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(711, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 73);
            this.panel1.TabIndex = 8;
            // 
            // bModSelec
            // 
            this.bModSelec.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bModSelec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModSelec.Location = new System.Drawing.Point(143, -1);
            this.bModSelec.Name = "bModSelec";
            this.bModSelec.Size = new System.Drawing.Size(87, 73);
            this.bModSelec.TabIndex = 9;
            this.bModSelec.Text = "Modificar Seleccion";
            this.bModSelec.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fila Final --> - - - - - - - - - ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fila Inicial --> - - - - - - - - ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(941, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbColumnas);
            this.Controls.Add(this.rbFilas);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.bEliminarTabla);
            this.Controls.Add(this.bAñadirTabla);
            this.Controls.Add(this.bEliminarDatos);
            this.Controls.Add(this.bAñadirDatos);
            this.Controls.Add(this.trV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TreeView trV;
        private System.Windows.Forms.Button bAñadirDatos;
        private System.Windows.Forms.Button bEliminarDatos;
        private System.Windows.Forms.Button bAñadirTabla;
        private System.Windows.Forms.Button bEliminarTabla;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.RadioButton rbFilas;
        private System.Windows.Forms.RadioButton rbColumnas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bModSelec;
    }
}

