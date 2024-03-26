namespace Programa_de_Gestion_de_Camas
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Medicina Intensiva");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Criticos (UCI y reanimación)", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cardiologia");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Endocrinologia");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Hematologia");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Medicina Digestiva");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Medicina Interna");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("MedicinaNuclear");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Neumologia");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Neurologia");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Oncologia");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Reumatologia");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Unidad de Enfermedades Infecciosas");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Especialidades médicas", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11,
            treeNode12,
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Cirugia General");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Cirugia Maxilofacial");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Cirugia Ortopedica y Traumatologia");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Oftalmologia");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Otorrinolaringologia");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Urologia");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Especialidades quirúrgicas", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Ginecologia");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Obstetricia");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Obstetricia", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23});
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Neonatologia");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Pediatria Especializada");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Pediatría", new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Psiquiatria");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Unidad de Transtornos Alimentarios");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Psiquiatría", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("UCI Neonatal");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("UCI Neonatal", new System.Windows.Forms.TreeNode[] {
            treeNode31});
            this.txtObjCamas = new System.Windows.Forms.TextBox();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtObjCamas
            // 
            this.txtObjCamas.Location = new System.Drawing.Point(607, 340);
            this.txtObjCamas.Name = "txtObjCamas";
            this.txtObjCamas.Size = new System.Drawing.Size(146, 20);
            this.txtObjCamas.TabIndex = 0;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(520, 366);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(233, 50);
            this.btnEjecutar.TabIndex = 1;
            this.btnEjecutar.Text = "Ejecutar Sistema de Distribucion de Camas";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(517, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero objetivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Font = new System.Drawing.Font("Sans Serif Collection", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.SystemColors.Info;
            this.treeView1.Indent = 20;
            this.treeView1.ItemHeight = 30;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(2, 12);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nMedicinaIntensiva";
            treeNode1.Text = "Medicina Intensiva";
            treeNode2.Name = "tnCriticos";
            treeNode2.Text = "Criticos (UCI y reanimación)";
            treeNode3.Name = "nCardiologia";
            treeNode3.Text = "Cardiologia";
            treeNode4.Name = "nEndocrinologia";
            treeNode4.Text = "Endocrinologia";
            treeNode5.Name = "nHematologia";
            treeNode5.Text = "Hematologia";
            treeNode6.Name = "nMedicinaDigestiva";
            treeNode6.Text = "Medicina Digestiva";
            treeNode7.Name = "nMedicinaInterna";
            treeNode7.Text = "Medicina Interna";
            treeNode8.Name = "nMedicinaNuclear";
            treeNode8.Text = "MedicinaNuclear";
            treeNode9.Name = "nNeumologia";
            treeNode9.Text = "Neumologia";
            treeNode10.Name = "nNeurologia";
            treeNode10.Text = "Neurologia";
            treeNode11.Name = "nOncologia";
            treeNode11.Text = "Oncologia";
            treeNode12.Name = "nReumatologia";
            treeNode12.Text = "Reumatologia";
            treeNode13.Name = "nUnidadEnfermedadesInfecciosas";
            treeNode13.Text = "Unidad de Enfermedades Infecciosas";
            treeNode14.Name = "tnEspecialidadesMedicas";
            treeNode14.Text = "Especialidades médicas";
            treeNode15.Name = "nCirugiaGeneral";
            treeNode15.Text = "Cirugia General";
            treeNode16.Name = "nCirugiaMaxilofacial";
            treeNode16.Text = "Cirugia Maxilofacial";
            treeNode17.Name = "nCirugiaOrtopedicaTraumatologia";
            treeNode17.Text = "Cirugia Ortopedica y Traumatologia";
            treeNode18.Name = "nOftalmologia";
            treeNode18.Text = "Oftalmologia";
            treeNode19.Name = "nOtorrinolaringologia";
            treeNode19.Text = "Otorrinolaringologia";
            treeNode20.Name = "nUrologia";
            treeNode20.Text = "Urologia";
            treeNode21.Name = "tnEspecialidadesQuirurgicas";
            treeNode21.Text = "Especialidades quirúrgicas";
            treeNode22.Name = "nGinecologia";
            treeNode22.Text = "Ginecologia";
            treeNode23.Name = "nObstetricia";
            treeNode23.Text = "Obstetricia";
            treeNode24.Name = "tnObstetricia";
            treeNode24.Text = "Obstetricia";
            treeNode25.Name = "nNeonatologia";
            treeNode25.Text = "Neonatologia";
            treeNode26.Name = "nPediatriaEspecializada";
            treeNode26.Text = "Pediatria Especializada";
            treeNode27.Name = "tnPediatria";
            treeNode27.Text = "Pediatría";
            treeNode28.Name = "nPsiquiatria";
            treeNode28.Text = "Psiquiatria";
            treeNode29.Name = "nUnidadTrastornosAlimentarios";
            treeNode29.Text = "Unidad de Transtornos Alimentarios";
            treeNode30.Name = "tnPsiquiatria";
            treeNode30.Text = "Psiquiatría";
            treeNode31.Name = "nUciNeonatal";
            treeNode31.Text = "UCI Neonatal";
            treeNode32.Name = "tnNeonatal";
            treeNode32.Text = "UCI Neonatal";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode14,
            treeNode21,
            treeNode24,
            treeNode27,
            treeNode30,
            treeNode32});
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(285, 426);
            this.treeView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.panel1.Location = new System.Drawing.Point(2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 453);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Criticos (UCI y Reanimación)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.txtObjCamas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtObjCamas;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

