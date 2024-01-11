namespace Imagenes
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.lTexto = new System.Windows.Forms.Label();
            this.TimerBarra = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(47, 66);
            this.pbProgreso.MarqueeAnimationSpeed = 1000;
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(186, 23);
            this.pbProgreso.Step = 1;
            this.pbProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgreso.TabIndex = 0;
            // 
            // lTexto
            // 
            this.lTexto.Location = new System.Drawing.Point(44, 28);
            this.lTexto.Name = "lTexto";
            this.lTexto.Size = new System.Drawing.Size(189, 35);
            this.lTexto.TabIndex = 1;
            this.lTexto.Text = "Analizando tus Pensamientos...";
            this.lTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerBarra
            // 
            this.TimerBarra.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.ControlBox = false;
            this.Controls.Add(this.lTexto);
            this.Controls.Add(this.pbProgreso);
            this.MaximumSize = new System.Drawing.Size(300, 150);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingBar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.Label lTexto;
        private System.Windows.Forms.Timer TimerBarra;
    }
}