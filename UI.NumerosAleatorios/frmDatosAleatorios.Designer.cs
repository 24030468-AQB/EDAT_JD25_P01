namespace UI.NumerosAleatorios
{
    partial class frmDatosAleatorios
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMostrarMensaje = new Button();
            SuspendLayout();
            // 
            // btnMostrarMensaje
            // 
            btnMostrarMensaje.Location = new Point(202, 165);
            btnMostrarMensaje.Name = "btnMostrarMensaje";
            btnMostrarMensaje.Size = new Size(113, 23);
            btnMostrarMensaje.TabIndex = 0;
            btnMostrarMensaje.Text = "Mostrar mensaje ";
            btnMostrarMensaje.UseVisualStyleBackColor = true;
            btnMostrarMensaje.Click += btnMostrarMensaje_Click;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(btnMostrarMensaje);
            Name = "frmDatosAleatorios";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnMostrarMensaje;
    }
}
