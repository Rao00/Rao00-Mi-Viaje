using System.Drawing.Drawing2D;
using System.IO;

namespace Ejercicio03
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
            this.btnMostrarRect = new System.Windows.Forms.Button();
            this.btnMostarCirc = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMostrarLados = new System.Windows.Forms.Button();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.btnCrearPoli = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnMostrarRect.Text = "Mostrar Poligonos";
            this.btnMostrarRect.UseVisualStyleBackColor = false;
            this.btnMostrarRect.Click += new System.EventHandler(this.btnMostrar_Click);
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
            this.tableLayoutPanel1.Controls.Add(this.btnMostrarLados, 0, 1);
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
            // btnMostrarLados
            // 
            this.btnMostrarLados.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarLados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarLados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarLados.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarLados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarLados.Location = new System.Drawing.Point(0, 41);
            this.btnMostrarLados.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrarLados.Name = "btnMostrarLados";
            this.btnMostrarLados.Size = new System.Drawing.Size(400, 41);
            this.btnMostrarLados.TabIndex = 5;
            this.btnMostrarLados.Text = "Mostrar Numero lados";
            this.btnMostrarLados.UseVisualStyleBackColor = false;
            this.btnMostrarLados.Click += new System.EventHandler(this.btnMostrarLados_Click);
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.BackColor = System.Drawing.SystemColors.Control;
            this.btnMostrarTodas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMostrarTodas.Location = new System.Drawing.Point(400, 41);
            this.btnMostrarTodas.Margin = new System.Windows.Forms.Padding(0);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(400, 41);
            this.btnMostrarTodas.TabIndex = 4;
            this.btnMostrarTodas.Text = "Mostrar Todas las Figuras";
            this.btnMostrarTodas.UseVisualStyleBackColor = false;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // btnCrearPoli
            // 
            this.btnCrearPoli.FlatAppearance.BorderSize = 0;
            this.btnCrearPoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPoli.Location = new System.Drawing.Point(182, 61);
            this.btnCrearPoli.Name = "btnCrearPoli";
            this.btnCrearPoli.Size = new System.Drawing.Size(438, 246);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarRect;
        private System.Windows.Forms.Button btnMostarCirc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.Button btnCrearPoli;
        private System.Windows.Forms.Button btnMostrarLados;
    }
}

