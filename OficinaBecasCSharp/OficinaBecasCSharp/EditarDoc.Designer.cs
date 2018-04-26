namespace Vista
{
    partial class EditarDoc
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
            this.btnCancelarEDGB = new System.Windows.Forms.Button();
            this.btnAceptarGDGB = new System.Windows.Forms.Button();
            this.GBDatosDocGB = new System.Windows.Forms.GroupBox();
            this.cbxEditEstadoDocGb = new System.Windows.Forms.ComboBox();
            this.txtNombdocEDGB = new System.Windows.Forms.TextBox();
            this.LEstadoDocEDGB = new System.Windows.Forms.Label();
            this.LnombreEDGB = new System.Windows.Forms.Label();
            this.GBDatosDocGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarEDGB
            // 
            this.btnCancelarEDGB.Location = new System.Drawing.Point(212, 171);
            this.btnCancelarEDGB.Name = "btnCancelarEDGB";
            this.btnCancelarEDGB.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarEDGB.TabIndex = 6;
            this.btnCancelarEDGB.Text = "Cancelar";
            this.btnCancelarEDGB.UseVisualStyleBackColor = true;
            this.btnCancelarEDGB.Click += new System.EventHandler(this.btnCancelarEDGB_Click);
            // 
            // btnAceptarGDGB
            // 
            this.btnAceptarGDGB.Location = new System.Drawing.Point(130, 171);
            this.btnAceptarGDGB.Name = "btnAceptarGDGB";
            this.btnAceptarGDGB.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarGDGB.TabIndex = 5;
            this.btnAceptarGDGB.Text = "Aceptar";
            this.btnAceptarGDGB.UseVisualStyleBackColor = true;
            this.btnAceptarGDGB.Click += new System.EventHandler(this.btnAceptarGDGB_Click);
            // 
            // GBDatosDocGB
            // 
            this.GBDatosDocGB.Controls.Add(this.cbxEditEstadoDocGb);
            this.GBDatosDocGB.Controls.Add(this.txtNombdocEDGB);
            this.GBDatosDocGB.Controls.Add(this.LEstadoDocEDGB);
            this.GBDatosDocGB.Controls.Add(this.LnombreEDGB);
            this.GBDatosDocGB.Location = new System.Drawing.Point(19, 21);
            this.GBDatosDocGB.Name = "GBDatosDocGB";
            this.GBDatosDocGB.Size = new System.Drawing.Size(254, 113);
            this.GBDatosDocGB.TabIndex = 4;
            this.GBDatosDocGB.TabStop = false;
            this.GBDatosDocGB.Text = "Documento";
            // 
            // cbxEditEstadoDocGb
            // 
            this.cbxEditEstadoDocGb.FormattingEnabled = true;
            this.cbxEditEstadoDocGb.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbxEditEstadoDocGb.Location = new System.Drawing.Point(74, 58);
            this.cbxEditEstadoDocGb.Name = "cbxEditEstadoDocGb";
            this.cbxEditEstadoDocGb.Size = new System.Drawing.Size(152, 21);
            this.cbxEditEstadoDocGb.TabIndex = 3;
            // 
            // txtNombdocEDGB
            // 
            this.txtNombdocEDGB.Location = new System.Drawing.Point(74, 26);
            this.txtNombdocEDGB.Name = "txtNombdocEDGB";
            this.txtNombdocEDGB.Size = new System.Drawing.Size(152, 20);
            this.txtNombdocEDGB.TabIndex = 2;
            // 
            // LEstadoDocEDGB
            // 
            this.LEstadoDocEDGB.AutoSize = true;
            this.LEstadoDocEDGB.Location = new System.Drawing.Point(15, 61);
            this.LEstadoDocEDGB.Name = "LEstadoDocEDGB";
            this.LEstadoDocEDGB.Size = new System.Drawing.Size(43, 13);
            this.LEstadoDocEDGB.TabIndex = 1;
            this.LEstadoDocEDGB.Text = "Estado:";
            // 
            // LnombreEDGB
            // 
            this.LnombreEDGB.AutoSize = true;
            this.LnombreEDGB.Location = new System.Drawing.Point(15, 29);
            this.LnombreEDGB.Name = "LnombreEDGB";
            this.LnombreEDGB.Size = new System.Drawing.Size(47, 13);
            this.LnombreEDGB.TabIndex = 0;
            this.LnombreEDGB.Text = "Nombre:";
            // 
            // EditarDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 214);
            this.Controls.Add(this.btnCancelarEDGB);
            this.Controls.Add(this.btnAceptarGDGB);
            this.Controls.Add(this.GBDatosDocGB);
            this.Name = "EditarDoc";
            this.Text = "EditarDoc";
            this.GBDatosDocGB.ResumeLayout(false);
            this.GBDatosDocGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarEDGB;
        private System.Windows.Forms.Button btnAceptarGDGB;
        private System.Windows.Forms.GroupBox GBDatosDocGB;
        private System.Windows.Forms.ComboBox cbxEditEstadoDocGb;
        private System.Windows.Forms.TextBox txtNombdocEDGB;
        private System.Windows.Forms.Label LEstadoDocEDGB;
        private System.Windows.Forms.Label LnombreEDGB;
    }
}