namespace WinFormsPrototype
{
    partial class _4taPantalla
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Apellido = new System.Windows.Forms.Label();
            this.DNI = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaNacimiento);
            this.groupBox1.Controls.Add(this.DNI);
            this.groupBox1.Controls.Add(this.Apellido);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Location = new System.Drawing.Point(37, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 200);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del cliente";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(6, 31);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(51, 15);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.AutoSize = true;
            this.Apellido.Location = new System.Drawing.Point(6, 61);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(51, 15);
            this.Apellido.TabIndex = 1;
            this.Apellido.Text = "Apellido";
            // 
            // DNI
            // 
            this.DNI.AutoSize = true;
            this.DNI.Location = new System.Drawing.Point(6, 86);
            this.DNI.Name = "DNI";
            this.DNI.Size = new System.Drawing.Size(27, 15);
            this.DNI.TabIndex = 2;
            this.DNI.Text = "DNI";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSize = true;
            this.FechaNacimiento.Location = new System.Drawing.Point(6, 113);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(117, 15);
            this.FechaNacimiento.TabIndex = 3;
            this.FechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // _4taPantalla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "_4taPantalla";
            this.Text = "_4taPantalla";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label FechaNacimiento;
        private System.Windows.Forms.Label DNI;
        private System.Windows.Forms.Label Apellido;
        private System.Windows.Forms.Label Nombre;
    }
}