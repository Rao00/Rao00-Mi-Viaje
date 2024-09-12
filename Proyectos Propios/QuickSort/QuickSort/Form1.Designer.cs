namespace QuickSort
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnShowList = new System.Windows.Forms.Button();
            this.btnComprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(246, 143);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(143, 150);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear lista";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(395, 143);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(143, 150);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Ordenar Lista";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnShowList
            // 
            this.btnShowList.Location = new System.Drawing.Point(246, 96);
            this.btnShowList.Name = "btnShowList";
            this.btnShowList.Size = new System.Drawing.Size(292, 41);
            this.btnShowList.TabIndex = 2;
            this.btnShowList.Text = "Ver Lista";
            this.btnShowList.UseVisualStyleBackColor = true;
            this.btnShowList.Click += new System.EventHandler(this.btnShowList_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new System.Drawing.Point(246, 299);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new System.Drawing.Size(292, 41);
            this.btnComprobar.TabIndex = 3;
            this.btnComprobar.Text = "Check";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new System.EventHandler(this.btnComprobar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.btnShowList);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnCrear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnShowList;
        private System.Windows.Forms.Button btnComprobar;
    }
}

