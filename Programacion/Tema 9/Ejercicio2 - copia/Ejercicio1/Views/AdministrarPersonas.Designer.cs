namespace Ejercicio1
{
    partial class AdministrarPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarPersonas));
            this.pnlDni = new System.Windows.Forms.Panel();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.pnlNombre = new System.Windows.Forms.Panel();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.pnlTelefono = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlApellidos = new System.Windows.Forms.Panel();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnFinal = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnPrincipio = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbRegistro = new System.Windows.Forms.GroupBox();
            this.btnGuardarNuevo = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.lblNumRegistro = new System.Windows.Forms.Label();
            this.btnError = new System.Windows.Forms.Button();
            this.pnlDni.SuspendLayout();
            this.pnlNombre.SuspendLayout();
            this.pnlTelefono.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlApellidos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRegistro.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDni
            // 
            this.pnlDni.Controls.Add(this.txtDni);
            this.pnlDni.Controls.Add(this.lblDni);
            this.pnlDni.Location = new System.Drawing.Point(117, 34);
            this.pnlDni.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pnlDni.Name = "pnlDni";
            this.pnlDni.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDni.Size = new System.Drawing.Size(232, 35);
            this.pnlDni.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDni.Location = new System.Drawing.Point(64, 9);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(158, 20);
            this.txtDni.TabIndex = 4;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDni.Location = new System.Drawing.Point(8, 6);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(50, 24);
            this.lblDni.TabIndex = 3;
            this.lblDni.Text = "DNI:";
            // 
            // pnlNombre
            // 
            this.pnlNombre.Controls.Add(this.txtNombre);
            this.pnlNombre.Controls.Add(this.lblNombre);
            this.pnlNombre.Location = new System.Drawing.Point(71, 82);
            this.pnlNombre.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pnlNombre.Name = "pnlNombre";
            this.pnlNombre.Padding = new System.Windows.Forms.Padding(5);
            this.pnlNombre.Size = new System.Drawing.Size(278, 35);
            this.pnlNombre.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(111, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(14, 6);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(91, 24);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // pnlTelefono
            // 
            this.pnlTelefono.Controls.Add(this.txtTelefono);
            this.pnlTelefono.Controls.Add(this.lblTelefono);
            this.pnlTelefono.Location = new System.Drawing.Point(71, 130);
            this.pnlTelefono.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pnlTelefono.Name = "pnlTelefono";
            this.pnlTelefono.Padding = new System.Windows.Forms.Padding(5);
            this.pnlTelefono.Size = new System.Drawing.Size(278, 35);
            this.pnlTelefono.TabIndex = 6;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono.Location = new System.Drawing.Point(110, 9);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(158, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(7, 6);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(99, 24);
            this.lblTelefono.TabIndex = 3;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // pnlEmail
            // 
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Controls.Add(this.lblEmail);
            this.pnlEmail.Location = new System.Drawing.Point(482, 130);
            this.pnlEmail.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Padding = new System.Windows.Forms.Padding(5);
            this.pnlEmail.Size = new System.Drawing.Size(243, 35);
            this.pnlEmail.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(81, 9);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(7, 6);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 24);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // pnlApellidos
            // 
            this.pnlApellidos.Controls.Add(this.txtApellidos);
            this.pnlApellidos.Controls.Add(this.lblApellidos);
            this.pnlApellidos.Location = new System.Drawing.Point(447, 82);
            this.pnlApellidos.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.pnlApellidos.Name = "pnlApellidos";
            this.pnlApellidos.Padding = new System.Windows.Forms.Padding(5);
            this.pnlApellidos.Size = new System.Drawing.Size(278, 35);
            this.pnlApellidos.TabIndex = 8;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Location = new System.Drawing.Point(116, 9);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(158, 20);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidos.Location = new System.Drawing.Point(7, 6);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(103, 24);
            this.lblApellidos.TabIndex = 3;
            this.lblApellidos.Text = "Apellidos:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.btnAnterior, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnFinal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSiguiente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrincipio, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 415);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 35);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnterior.BackgroundImage")));
            this.btnAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Location = new System.Drawing.Point(120, 0);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(281, 35);
            this.btnAnterior.TabIndex = 3;
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnFinal
            // 
            this.btnFinal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFinal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinal.BackgroundImage")));
            this.btnFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinal.FlatAppearance.BorderSize = 0;
            this.btnFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinal.Location = new System.Drawing.Point(682, 0);
            this.btnFinal.Margin = new System.Windows.Forms.Padding(0);
            this.btnFinal.Name = "btnFinal";
            this.btnFinal.Size = new System.Drawing.Size(122, 35);
            this.btnFinal.TabIndex = 2;
            this.btnFinal.UseVisualStyleBackColor = false;
            this.btnFinal.Click += new System.EventHandler(this.btnFinal_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.BackgroundImage")));
            this.btnSiguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Mistral", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(401, 0);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(0);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(281, 35);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnPrincipio
            // 
            this.btnPrincipio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrincipio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrincipio.BackgroundImage")));
            this.btnPrincipio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrincipio.FlatAppearance.BorderSize = 0;
            this.btnPrincipio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipio.Location = new System.Drawing.Point(0, 0);
            this.btnPrincipio.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrincipio.Name = "btnPrincipio";
            this.btnPrincipio.Size = new System.Drawing.Size(120, 35);
            this.btnPrincipio.TabIndex = 0;
            this.btnPrincipio.UseVisualStyleBackColor = false;
            this.btnPrincipio.Click += new System.EventHandler(this.btnPrincipio_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.gbRegistro, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnFiltrar, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnMoreInfo, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(71, 187);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 216);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(330, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 123);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actualizar y Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(6, 78);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(309, 46);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(6, 26);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(309, 46);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // gbRegistro
            // 
            this.gbRegistro.Controls.Add(this.btnGuardarNuevo);
            this.gbRegistro.Controls.Add(this.btnLimpiar);
            this.gbRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegistro.Location = new System.Drawing.Point(3, 3);
            this.gbRegistro.Name = "gbRegistro";
            this.gbRegistro.Size = new System.Drawing.Size(321, 123);
            this.gbRegistro.TabIndex = 0;
            this.gbRegistro.TabStop = false;
            this.gbRegistro.Text = "Añadir Registros";
            // 
            // btnGuardarNuevo
            // 
            this.btnGuardarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevo.Location = new System.Drawing.Point(6, 78);
            this.btnGuardarNuevo.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.btnGuardarNuevo.Name = "btnGuardarNuevo";
            this.btnGuardarNuevo.Size = new System.Drawing.Size(309, 46);
            this.btnGuardarNuevo.TabIndex = 1;
            this.btnGuardarNuevo.Text = "Guardar Nuevo";
            this.btnGuardarNuevo.UseVisualStyleBackColor = true;
            this.btnGuardarNuevo.Click += new System.EventHandler(this.btnGuardarNuevo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Enabled = false;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(6, 26);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(309, 46);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnFiltrarProfesores
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.btnFiltrar, 2);
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(3, 132);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(648, 37);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrarProfesores_Click);
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel2.SetColumnSpan(this.btnMoreInfo, 2);
            this.btnMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreInfo.Location = new System.Drawing.Point(3, 175);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(647, 38);
            this.btnMoreInfo.TabIndex = 6;
            this.btnMoreInfo.Text = "Mas Informacion";
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // lblNumRegistro
            // 
            this.lblNumRegistro.AutoSize = true;
            this.lblNumRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistro.Location = new System.Drawing.Point(452, 32);
            this.lblNumRegistro.Name = "lblNumRegistro";
            this.lblNumRegistro.Size = new System.Drawing.Size(172, 33);
            this.lblNumRegistro.TabIndex = 13;
            this.lblNumRegistro.Text = "Registro: --";
            // 
            // btnError
            // 
            this.btnError.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnError.BackgroundImage")));
            this.btnError.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnError.Enabled = false;
            this.btnError.FlatAppearance.BorderSize = 0;
            this.btnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnError.Location = new System.Drawing.Point(716, 362);
            this.btnError.Name = "btnError";
            this.btnError.Size = new System.Drawing.Size(40, 38);
            this.btnError.TabIndex = 14;
            this.btnError.UseVisualStyleBackColor = true;
            this.btnError.Visible = false;
            // 
            // AdministrarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumRegistro);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlApellidos);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlTelefono);
            this.Controls.Add(this.pnlNombre);
            this.Controls.Add(this.pnlDni);
            this.Controls.Add(this.btnError);
            this.Name = "AdministrarPersonas";
            this.Text = "Administrar Personas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pnlDni.ResumeLayout(false);
            this.pnlDni.PerformLayout();
            this.pnlNombre.ResumeLayout(false);
            this.pnlNombre.PerformLayout();
            this.pnlTelefono.ResumeLayout(false);
            this.pnlTelefono.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlApellidos.ResumeLayout(false);
            this.pnlApellidos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbRegistro.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Panel pnlNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel pnlTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnPrincipio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnFinal;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbRegistro;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnGuardarNuevo;
        private System.Windows.Forms.Label lblNumRegistro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMoreInfo;
        private System.Windows.Forms.Button btnError;
    }
}

