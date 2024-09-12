namespace Ejercicio05
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
            this.gpCreate = new System.Windows.Forms.GroupBox();
            this.bNewList1 = new System.Windows.Forms.Button();
            this.bNewList2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bCleanList = new System.Windows.Forms.Button();
            this.bList3 = new System.Windows.Forms.Button();
            this.gpCreate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpCreate
            // 
            this.gpCreate.Controls.Add(this.bNewList2);
            this.gpCreate.Controls.Add(this.bNewList1);
            this.gpCreate.Location = new System.Drawing.Point(158, 143);
            this.gpCreate.Name = "gpCreate";
            this.gpCreate.Size = new System.Drawing.Size(200, 115);
            this.gpCreate.TabIndex = 0;
            this.gpCreate.TabStop = false;
            this.gpCreate.Text = "Create Lists";
            // 
            // bNewList1
            // 
            this.bNewList1.Location = new System.Drawing.Point(7, 20);
            this.bNewList1.Name = "bNewList1";
            this.bNewList1.Size = new System.Drawing.Size(187, 37);
            this.bNewList1.TabIndex = 0;
            this.bNewList1.Text = "Create List 1";
            this.bNewList1.UseVisualStyleBackColor = true;
            this.bNewList1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bNewList2
            // 
            this.bNewList2.Location = new System.Drawing.Point(7, 63);
            this.bNewList2.Name = "bNewList2";
            this.bNewList2.Size = new System.Drawing.Size(187, 37);
            this.bNewList2.TabIndex = 1;
            this.bNewList2.Text = "Create List 2";
            this.bNewList2.UseVisualStyleBackColor = true;
            this.bNewList2.Click += new System.EventHandler(this.bNewList2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bCleanList);
            this.groupBox1.Controls.Add(this.bList3);
            this.groupBox1.Location = new System.Drawing.Point(387, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 115);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Work with lists";
            // 
            // bCleanList
            // 
            this.bCleanList.Location = new System.Drawing.Point(7, 63);
            this.bCleanList.Name = "bCleanList";
            this.bCleanList.Size = new System.Drawing.Size(187, 37);
            this.bCleanList.TabIndex = 1;
            this.bCleanList.Text = "Clean Lists";
            this.bCleanList.UseVisualStyleBackColor = true;
            this.bCleanList.Click += new System.EventHandler(this.bCleanList_Click);
            // 
            // bList3
            // 
            this.bList3.Location = new System.Drawing.Point(7, 20);
            this.bList3.Name = "bList3";
            this.bList3.Size = new System.Drawing.Size(187, 37);
            this.bList3.TabIndex = 0;
            this.bList3.Text = "Show List 3";
            this.bList3.UseVisualStyleBackColor = true;
            this.bList3.Click += new System.EventHandler(this.bList3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpCreate.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCreate;
        private System.Windows.Forms.Button bNewList2;
        private System.Windows.Forms.Button bNewList1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bCleanList;
        private System.Windows.Forms.Button bList3;
    }
}

