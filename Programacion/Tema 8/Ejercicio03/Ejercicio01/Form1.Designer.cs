using System.Drawing.Drawing2D;
using System.IO;

namespace Ejercicio01
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
            this.btnCrearCircl = new System.Windows.Forms.Button();
            this.btnMostrarRect = new System.Windows.Forms.Button();
            this.btnCrearCuadr = new System.Windows.Forms.Button();
            this.btnMostarCirc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.btnCrearPoli = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCircl
            // 
            this.btnCrearCircl.FlatAppearance.BorderSize = 0;
            this.btnCrearCircl.Location = new System.Drawing.Point(12, 12);
            this.btnCrearCircl.Name = "btnCrearCircl";
            this.btnCrearCircl.Size = new System.Drawing.Size(119, 119);
            this.btnCrearCircl.TabIndex = 0;
            this.btnCrearCircl.Text = "Crear Figura";
            this.btnCrearCircl.UseVisualStyleBackColor = true;
            this.btnCrearCircl.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnMostrarRect
            // 
            this.btnMostrarRect.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarRect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarRect.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarRect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarRect.Location = new System.Drawing.Point(0, 0);
            this.btnMostrarRect.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrarRect.Name = "btnMostrarRect";
            this.btnMostrarRect.Size = new System.Drawing.Size(400, 41);
            this.btnMostrarRect.TabIndex = 1;
            this.btnMostrarRect.Text = "Mostrar Cuadrados";
            this.btnMostrarRect.UseVisualStyleBackColor = false;
            this.btnMostrarRect.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrearCuadr
            // 
            this.btnCrearCuadr.FlatAppearance.BorderSize = 0;
            this.btnCrearCuadr.Location = new System.Drawing.Point(137, 12);
            this.btnCrearCuadr.Name = "btnCrearCuadr";
            this.btnCrearCuadr.Size = new System.Drawing.Size(119, 119);
            this.btnCrearCuadr.TabIndex = 2;
            this.btnCrearCuadr.Text = "Crear Figura";
            this.btnCrearCuadr.UseVisualStyleBackColor = true;
            this.btnCrearCuadr.Click += new System.EventHandler(this.btnCrearCuadr_Click);
            // 
            // btnMostarCirc
            // 
            this.btnMostarCirc.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostarCirc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostarCirc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostarCirc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostarCirc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostarCirc.Location = new System.Drawing.Point(400, 0);
            this.btnMostarCirc.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostarCirc.Name = "btnMostarCirc";
            this.btnMostarCirc.Size = new System.Drawing.Size(400, 41);
            this.btnMostarCirc.TabIndex = 3;
            this.btnMostarCirc.Text = "Mostrar Circulos";
            this.btnMostarCirc.UseVisualStyleBackColor = false;
            this.btnMostarCirc.Click += new System.EventHandler(this.btnMostarCirc_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnMostrarTodas, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnMostrarRect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMostarCirc, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 368);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 82);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.SetColumnSpan(this.btnMostrarTodas, 2);
            this.btnMostrarTodas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarTodas.Location = new System.Drawing.Point(0, 41);
            this.btnMostrarTodas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(800, 41);
            this.btnMostrarTodas.TabIndex = 4;
            this.btnMostrarTodas.Text = "Mostrar Todas las Figuras";
            this.btnMostrarTodas.UseVisualStyleBackColor = false;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // btnCrearPoli
            // 
            this.btnCrearPoli.FlatAppearance.BorderSize = 0;
            this.btnCrearPoli.Location = new System.Drawing.Point(262, 12);
            this.btnCrearPoli.Name = "btnCrearPoli";
            this.btnCrearPoli.Size = new System.Drawing.Size(119, 119);
            this.btnCrearPoli.TabIndex = 5;
            this.btnCrearPoli.Text = "Crear Poligono";
            this.btnCrearPoli.UseVisualStyleBackColor = true;
            this.btnCrearPoli.Click += new System.EventHandler(this.btnCrearPoli_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearPoli);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCrearCuadr);
            this.Controls.Add(this.btnCrearCircl);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCircl;
        private System.Windows.Forms.Button btnMostrarRect;
        private System.Windows.Forms.Button btnCrearCuadr;
        private System.Windows.Forms.Button btnMostarCirc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.Button btnCrearPoli;
    }
}

