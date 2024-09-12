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
            this.gbElements = new System.Windows.Forms.GroupBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bShow = new System.Windows.Forms.Button();
            this.bFirstPosition = new System.Windows.Forms.Button();
            this.bPositionValue = new System.Windows.Forms.Button();
            this.gbSortRemove = new System.Windows.Forms.GroupBox();
            this.bRemoveAllElements = new System.Windows.Forms.Button();
            this.bSort = new System.Windows.Forms.Button();
            this.bRemovePosition = new System.Windows.Forms.Button();
            this.bRemoveAllValues = new System.Windows.Forms.Button();
            this.bRemoveFirst = new System.Windows.Forms.Button();
            this.gbElements.SuspendLayout();
            this.gbSortRemove.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbElements
            // 
            this.gbElements.Controls.Add(this.bPositionValue);
            this.gbElements.Controls.Add(this.bFirstPosition);
            this.gbElements.Controls.Add(this.bShow);
            this.gbElements.Controls.Add(this.bInsert);
            this.gbElements.Controls.Add(this.bAdd);
            this.gbElements.Location = new System.Drawing.Point(116, 66);
            this.gbElements.Name = "gbElements";
            this.gbElements.Padding = new System.Windows.Forms.Padding(10);
            this.gbElements.Size = new System.Drawing.Size(243, 323);
            this.gbElements.TabIndex = 0;
            this.gbElements.TabStop = false;
            this.gbElements.Text = "Elements";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(13, 26);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(217, 50);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Add Elements";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(13, 82);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(217, 50);
            this.bInsert.TabIndex = 1;
            this.bInsert.Text = "Insert Elements";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(13, 138);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(217, 50);
            this.bShow.TabIndex = 2;
            this.bShow.Text = "Show List";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // bFirstPosition
            // 
            this.bFirstPosition.Location = new System.Drawing.Point(13, 194);
            this.bFirstPosition.Name = "bFirstPosition";
            this.bFirstPosition.Size = new System.Drawing.Size(217, 50);
            this.bFirstPosition.TabIndex = 3;
            this.bFirstPosition.Text = "Show First Element";
            this.bFirstPosition.UseVisualStyleBackColor = true;
            this.bFirstPosition.Click += new System.EventHandler(this.bFirstPosition_Click);
            // 
            // bPositionValue
            // 
            this.bPositionValue.Location = new System.Drawing.Point(13, 250);
            this.bPositionValue.Name = "bPositionValue";
            this.bPositionValue.Size = new System.Drawing.Size(217, 50);
            this.bPositionValue.TabIndex = 4;
            this.bPositionValue.Text = "Show Position of Value";
            this.bPositionValue.UseVisualStyleBackColor = true;
            this.bPositionValue.Click += new System.EventHandler(this.bPositionValue_Click);
            // 
            // gbSortRemove
            // 
            this.gbSortRemove.Controls.Add(this.bRemoveAllElements);
            this.gbSortRemove.Controls.Add(this.bSort);
            this.gbSortRemove.Controls.Add(this.bRemovePosition);
            this.gbSortRemove.Controls.Add(this.bRemoveAllValues);
            this.gbSortRemove.Controls.Add(this.bRemoveFirst);
            this.gbSortRemove.Location = new System.Drawing.Point(413, 66);
            this.gbSortRemove.Name = "gbSortRemove";
            this.gbSortRemove.Padding = new System.Windows.Forms.Padding(10);
            this.gbSortRemove.Size = new System.Drawing.Size(243, 323);
            this.gbSortRemove.TabIndex = 5;
            this.gbSortRemove.TabStop = false;
            this.gbSortRemove.Text = "Sort and Remove";
            // 
            // bRemoveAllElements
            // 
            this.bRemoveAllElements.Location = new System.Drawing.Point(13, 194);
            this.bRemoveAllElements.Name = "bRemoveAllElements";
            this.bRemoveAllElements.Size = new System.Drawing.Size(217, 50);
            this.bRemoveAllElements.TabIndex = 4;
            this.bRemoveAllElements.Text = "Remove all Elements";
            this.bRemoveAllElements.UseVisualStyleBackColor = true;
            this.bRemoveAllElements.Click += new System.EventHandler(this.bRemoveAllElements_Click);
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(13, 250);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(217, 50);
            this.bSort.TabIndex = 3;
            this.bSort.Text = "Sort List";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.bSort_Click);
            // 
            // bRemovePosition
            // 
            this.bRemovePosition.Location = new System.Drawing.Point(13, 138);
            this.bRemovePosition.Name = "bRemovePosition";
            this.bRemovePosition.Size = new System.Drawing.Size(217, 50);
            this.bRemovePosition.TabIndex = 2;
            this.bRemovePosition.Text = "Remove Position";
            this.bRemovePosition.UseVisualStyleBackColor = true;
            this.bRemovePosition.Click += new System.EventHandler(this.bRemovePosition_Click);
            // 
            // bRemoveAllValues
            // 
            this.bRemoveAllValues.Location = new System.Drawing.Point(13, 82);
            this.bRemoveAllValues.Name = "bRemoveAllValues";
            this.bRemoveAllValues.Size = new System.Drawing.Size(217, 50);
            this.bRemoveAllValues.TabIndex = 1;
            this.bRemoveAllValues.Text = "Remove Values";
            this.bRemoveAllValues.UseVisualStyleBackColor = true;
            this.bRemoveAllValues.Click += new System.EventHandler(this.bRemoveAllValues_Click);
            // 
            // bRemoveFirst
            // 
            this.bRemoveFirst.Location = new System.Drawing.Point(13, 26);
            this.bRemoveFirst.Name = "bRemoveFirst";
            this.bRemoveFirst.Size = new System.Drawing.Size(217, 50);
            this.bRemoveFirst.TabIndex = 0;
            this.bRemoveFirst.Text = "Remove First Value";
            this.bRemoveFirst.UseVisualStyleBackColor = true;
            this.bRemoveFirst.Click += new System.EventHandler(this.bRemoveFirst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSortRemove);
            this.Controls.Add(this.gbElements);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbElements.ResumeLayout(false);
            this.gbSortRemove.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElements;
        private System.Windows.Forms.Button bPositionValue;
        private System.Windows.Forms.Button bFirstPosition;
        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.GroupBox gbSortRemove;
        private System.Windows.Forms.Button bRemoveAllElements;
        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.Button bRemovePosition;
        private System.Windows.Forms.Button bRemoveAllValues;
        private System.Windows.Forms.Button bRemoveFirst;
    }
}

