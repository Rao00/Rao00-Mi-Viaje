namespace Ejercicio17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bNewArray = new System.Windows.Forms.Button();
            this.bLookArray = new System.Windows.Forms.Button();
            this.bLookItem = new System.Windows.Forms.Button();
            this.bSortArrayAsc = new System.Windows.Forms.Button();
            this.bSortArrayDes = new System.Windows.Forms.Button();
            this.txtSaveArray = new System.Windows.Forms.TextBox();
            this.lSaveArray = new System.Windows.Forms.Label();
            this.lExplicacion = new System.Windows.Forms.Label();
            this.b1and2 = new System.Windows.Forms.Button();
            this.bSum = new System.Windows.Forms.Button();
            this.bRes = new System.Windows.Forms.Button();
            this.bMul = new System.Windows.Forms.Button();
            this.bDiv = new System.Windows.Forms.Button();
            this.txtReadArray = new System.Windows.Forms.TextBox();
            this.lReadArray = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFila1 = new System.Windows.Forms.TextBox();
            this.txtFila2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bNewArray
            // 
            this.bNewArray.Location = new System.Drawing.Point(303, 116);
            this.bNewArray.Name = "bNewArray";
            this.bNewArray.Size = new System.Drawing.Size(267, 65);
            this.bNewArray.TabIndex = 0;
            this.bNewArray.Text = "Crear Array";
            this.bNewArray.UseVisualStyleBackColor = true;
            this.bNewArray.Click += new System.EventHandler(this.button1_Click);
            // 
            // bLookArray
            // 
            this.bLookArray.Location = new System.Drawing.Point(303, 184);
            this.bLookArray.Name = "bLookArray";
            this.bLookArray.Size = new System.Drawing.Size(133, 65);
            this.bLookArray.TabIndex = 1;
            this.bLookArray.Text = "Visualizar Matriz";
            this.bLookArray.UseVisualStyleBackColor = true;
            this.bLookArray.Click += new System.EventHandler(this.bLookArray_Click);
            // 
            // bLookItem
            // 
            this.bLookItem.Location = new System.Drawing.Point(303, 255);
            this.bLookItem.Name = "bLookItem";
            this.bLookItem.Size = new System.Drawing.Size(267, 65);
            this.bLookItem.TabIndex = 2;
            this.bLookItem.Text = "Buscar Elemento";
            this.bLookItem.UseVisualStyleBackColor = true;
            this.bLookItem.Click += new System.EventHandler(this.bLookItem_Click);
            // 
            // bSortArrayAsc
            // 
            this.bSortArrayAsc.Location = new System.Drawing.Point(303, 326);
            this.bSortArrayAsc.Name = "bSortArrayAsc";
            this.bSortArrayAsc.Size = new System.Drawing.Size(133, 65);
            this.bSortArrayAsc.TabIndex = 3;
            this.bSortArrayAsc.Text = "Ordenar Array Ascendentemente";
            this.bSortArrayAsc.UseVisualStyleBackColor = true;
            this.bSortArrayAsc.Click += new System.EventHandler(this.bSortArray_Click);
            // 
            // bSortArrayDes
            // 
            this.bSortArrayDes.Location = new System.Drawing.Point(442, 326);
            this.bSortArrayDes.Name = "bSortArrayDes";
            this.bSortArrayDes.Size = new System.Drawing.Size(128, 65);
            this.bSortArrayDes.TabIndex = 4;
            this.bSortArrayDes.Text = "Ordenar Array Descendentemente";
            this.bSortArrayDes.UseVisualStyleBackColor = true;
            this.bSortArrayDes.Click += new System.EventHandler(this.bSortArrayDes_Click);
            // 
            // txtSaveArray
            // 
            this.txtSaveArray.Location = new System.Drawing.Point(442, 90);
            this.txtSaveArray.Name = "txtSaveArray";
            this.txtSaveArray.Size = new System.Drawing.Size(128, 20);
            this.txtSaveArray.TabIndex = 5;
            this.txtSaveArray.Text = "1";
            this.txtSaveArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lSaveArray
            // 
            this.lSaveArray.AutoSize = true;
            this.lSaveArray.Location = new System.Drawing.Point(309, 95);
            this.lSaveArray.Name = "lSaveArray";
            this.lSaveArray.Size = new System.Drawing.Size(132, 13);
            this.lSaveArray.TabIndex = 6;
            this.lSaveArray.Text = "Selecciona donde guardar";
            // 
            // lExplicacion
            // 
            this.lExplicacion.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lExplicacion.Location = new System.Drawing.Point(41, 67);
            this.lExplicacion.Name = "lExplicacion";
            this.lExplicacion.Size = new System.Drawing.Size(256, 245);
            this.lExplicacion.TabIndex = 7;
            this.lExplicacion.Text = resources.GetString("lExplicacion.Text");
            // 
            // b1and2
            // 
            this.b1and2.Location = new System.Drawing.Point(576, 256);
            this.b1and2.Name = "b1and2";
            this.b1and2.Size = new System.Drawing.Size(166, 135);
            this.b1and2.TabIndex = 8;
            this.b1and2.Text = "Espacio 1 y Espacio 2";
            this.b1and2.UseVisualStyleBackColor = true;
            this.b1and2.Click += new System.EventHandler(this.b1and2_Click);
            // 
            // bSum
            // 
            this.bSum.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSum.Location = new System.Drawing.Point(576, 116);
            this.bSum.Name = "bSum";
            this.bSum.Size = new System.Drawing.Size(80, 65);
            this.bSum.TabIndex = 9;
            this.bSum.Text = "+";
            this.bSum.UseVisualStyleBackColor = false;
            // 
            // bRes
            // 
            this.bRes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRes.Location = new System.Drawing.Point(576, 185);
            this.bRes.Name = "bRes";
            this.bRes.Size = new System.Drawing.Size(80, 65);
            this.bRes.TabIndex = 10;
            this.bRes.Text = "-";
            this.bRes.UseVisualStyleBackColor = false;
            // 
            // bMul
            // 
            this.bMul.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bMul.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMul.Location = new System.Drawing.Point(662, 116);
            this.bMul.Name = "bMul";
            this.bMul.Size = new System.Drawing.Size(80, 65);
            this.bMul.TabIndex = 11;
            this.bMul.Text = "*";
            this.bMul.UseVisualStyleBackColor = false;
            // 
            // bDiv
            // 
            this.bDiv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDiv.Location = new System.Drawing.Point(662, 185);
            this.bDiv.Name = "bDiv";
            this.bDiv.Size = new System.Drawing.Size(80, 65);
            this.bDiv.TabIndex = 12;
            this.bDiv.Text = "/";
            this.bDiv.UseVisualStyleBackColor = false;
            // 
            // txtReadArray
            // 
            this.txtReadArray.Location = new System.Drawing.Point(442, 67);
            this.txtReadArray.Name = "txtReadArray";
            this.txtReadArray.Size = new System.Drawing.Size(128, 20);
            this.txtReadArray.TabIndex = 14;
            this.txtReadArray.Text = "1";
            this.txtReadArray.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lReadArray
            // 
            this.lReadArray.AutoSize = true;
            this.lReadArray.Location = new System.Drawing.Point(335, 70);
            this.lReadArray.Name = "lReadArray";
            this.lReadArray.Size = new System.Drawing.Size(101, 13);
            this.lReadArray.TabIndex = 15;
            this.lReadArray.Text = "Selecciona que leer";
            this.lReadArray.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(442, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 65);
            this.button1.TabIndex = 16;
            this.button1.Text = "Visualizar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFila1
            // 
            this.txtFila1.Location = new System.Drawing.Point(642, 67);
            this.txtFila1.Name = "txtFila1";
            this.txtFila1.Size = new System.Drawing.Size(100, 20);
            this.txtFila1.TabIndex = 19;
            this.txtFila1.Text = "1";
            this.txtFila1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFila2
            // 
            this.txtFila2.Location = new System.Drawing.Point(642, 90);
            this.txtFila2.Name = "txtFila2";
            this.txtFila2.Size = new System.Drawing.Size(100, 20);
            this.txtFila2.TabIndex = 18;
            this.txtFila2.Text = "2";
            this.txtFila2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Espacio --";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(582, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Espacio --";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFila1);
            this.Controls.Add(this.txtFila2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lReadArray);
            this.Controls.Add(this.txtReadArray);
            this.Controls.Add(this.bDiv);
            this.Controls.Add(this.bMul);
            this.Controls.Add(this.bRes);
            this.Controls.Add(this.bSum);
            this.Controls.Add(this.b1and2);
            this.Controls.Add(this.lExplicacion);
            this.Controls.Add(this.lSaveArray);
            this.Controls.Add(this.txtSaveArray);
            this.Controls.Add(this.bSortArrayDes);
            this.Controls.Add(this.bSortArrayAsc);
            this.Controls.Add(this.bLookItem);
            this.Controls.Add(this.bLookArray);
            this.Controls.Add(this.bNewArray);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bNewArray;
        private System.Windows.Forms.Button bLookArray;
        private System.Windows.Forms.Button bLookItem;
        private System.Windows.Forms.Button bSortArrayAsc;
        private System.Windows.Forms.Button bSortArrayDes;
        private System.Windows.Forms.TextBox txtSaveArray;
        private System.Windows.Forms.Label lSaveArray;
        private System.Windows.Forms.Label lExplicacion;
        private System.Windows.Forms.Button b1and2;
        private System.Windows.Forms.Button bSum;
        private System.Windows.Forms.Button bRes;
        private System.Windows.Forms.Button bMul;
        private System.Windows.Forms.Button bDiv;
        private System.Windows.Forms.TextBox txtReadArray;
        private System.Windows.Forms.Label lReadArray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFila1;
        private System.Windows.Forms.TextBox txtFila2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

