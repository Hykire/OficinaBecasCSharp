namespace Vista {
    partial class AdministracionSistema {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.GestionarBecasxAlumno = new System.Windows.Forms.Button();
            this.btnGestionarAlumnos = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.GestionarBecasxAlumno);
            this.panel1.Controls.Add(this.btnGestionarAlumnos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 441);
            this.panel1.TabIndex = 27;
            // 
            // GestionarBecasxAlumno
            // 
            this.GestionarBecasxAlumno.Location = new System.Drawing.Point(26, 198);
            this.GestionarBecasxAlumno.Name = "GestionarBecasxAlumno";
            this.GestionarBecasxAlumno.Size = new System.Drawing.Size(149, 23);
            this.GestionarBecasxAlumno.TabIndex = 5;
            this.GestionarBecasxAlumno.Text = "Gestionar Becas por Alumno";
            this.GestionarBecasxAlumno.UseVisualStyleBackColor = true;
            this.GestionarBecasxAlumno.Click += new System.EventHandler(this.GestionarBecasxAlumno_Click);
            // 
            // btnGestionarAlumnos
            // 
            this.btnGestionarAlumnos.Location = new System.Drawing.Point(26, 158);
            this.btnGestionarAlumnos.Name = "btnGestionarAlumnos";
            this.btnGestionarAlumnos.Size = new System.Drawing.Size(149, 23);
            this.btnGestionarAlumnos.TabIndex = 4;
            this.btnGestionarAlumnos.Text = "Gestionar Alumnos";
            this.btnGestionarAlumnos.UseVisualStyleBackColor = true;
            this.btnGestionarAlumnos.Click += new System.EventHandler(this.btnGestionarAlumnos_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 441);
            this.panel2.TabIndex = 28;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AdministracionSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 159);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministracionSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AdministracionSistema";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGestionarAlumnos;
        private System.Windows.Forms.Button GestionarBecasxAlumno;
    }
}