namespace Pacman
{
    partial class fPacman
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
            GLControl = new OpenTK.WinForms.GLControl();
            SuspendLayout();
            // 
            // GLControl
            // 
            GLControl.API = OpenTK.Windowing.Common.ContextAPI.OpenGL;
            GLControl.APIVersion = new System.Version(3, 3, 0, 0);
            GLControl.Flags = OpenTK.Windowing.Common.ContextFlags.Default;
            GLControl.IsEventDriven = true;
            GLControl.Location = new System.Drawing.Point(24, 12);
            GLControl.Name = "GLControl";
            GLControl.Profile = OpenTK.Windowing.Common.ContextProfile.Core;
            GLControl.Size = new System.Drawing.Size(762, 762);
            GLControl.TabIndex = 0;
            GLControl.Text = "glControl1";
            GLControl.Load += LoadGlControl;
            GLControl.Paint += PaintGLControl;
            GLControl.KeyDown += KeyPressed;
            // 
            // fPacman
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            ClientSize = new System.Drawing.Size(809, 786);
            Controls.Add(GLControl);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "fPacman";
            Text = "Pacman";
            ResumeLayout(false);
        }

        #endregion

        private OpenTK.WinForms.GLControl GLControl;
    }
}

