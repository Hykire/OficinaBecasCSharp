namespace Vista
{
    partial class AgregarBecarioATutor
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
            this.GBTutorABTXB = new System.Windows.Forms.GroupBox();
            this.CBTutorABTXB = new System.Windows.Forms.ComboBox();
            this.btnCancelarABTXB = new System.Windows.Forms.Button();
            this.btnAceptarABTXB = new System.Windows.Forms.Button();
            this.GBNuevoBecATutABTXB = new System.Windows.Forms.GroupBox();
            this.btnBuscarABTXB = new System.Windows.Forms.Button();
            this.txtApABTXB = new System.Windows.Forms.TextBox();
            this.txtNombABTXB = new System.Windows.Forms.TextBox();
            this.txtCodABTXB = new System.Windows.Forms.TextBox();
            this.LApeABTXB = new System.Windows.Forms.Label();
            this.LNombreABTXB = new System.Windows.Forms.Label();
            this.LCodigoABTXB = new System.Windows.Forms.Label();
            this.GBTutorABTXB.SuspendLayout();
            this.GBNuevoBecATutABTXB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBTutorABTXB
            // 
            this.GBTutorABTXB.Controls.Add(this.CBTutorABTXB);
            this.GBTutorABTXB.Location = new System.Drawing.Point(22, 178);
            this.GBTutorABTXB.Name = "GBTutorABTXB";
            this.GBTutorABTXB.Size = new System.Drawing.Size(301, 57);
            this.GBTutorABTXB.TabIndex = 8;
            this.GBTutorABTXB.TabStop = false;
            this.GBTutorABTXB.Text = "Tutor Asignado";
            // 
            // CBTutorABTXB
            // 
            this.CBTutorABTXB.FormattingEnabled = true;
            this.CBTutorABTXB.Items.AddRange(new object[] {
            "Tutor 1",
            "Tutor 2",
            "Tutor 3",
            "Tutor 4"});
            this.CBTutorABTXB.Location = new System.Drawing.Point(65, 20);
            this.CBTutorABTXB.Name = "CBTutorABTXB";
            this.CBTutorABTXB.Size = new System.Drawing.Size(121, 21);
            this.CBTutorABTXB.TabIndex = 0;
            this.CBTutorABTXB.SelectedIndexChanged += new System.EventHandler(this.CBTutorABTXB_SelectedIndexChanged);
            // 
            // btnCancelarABTXB
            // 
            this.btnCancelarABTXB.Location = new System.Drawing.Point(248, 253);
            this.btnCancelarABTXB.Name = "btnCancelarABTXB";
            this.btnCancelarABTXB.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarABTXB.TabIndex = 7;
            this.btnCancelarABTXB.Text = "Cancelar";
            this.btnCancelarABTXB.UseVisualStyleBackColor = true;
            this.btnCancelarABTXB.Click += new System.EventHandler(this.btnCancelarABTXB_Click);
            // 
            // btnAceptarABTXB
            // 
            this.btnAceptarABTXB.Location = new System.Drawing.Point(167, 253);
            this.btnAceptarABTXB.Name = "btnAceptarABTXB";
            this.btnAceptarABTXB.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarABTXB.TabIndex = 6;
            this.btnAceptarABTXB.Text = "Aceptar";
            this.btnAceptarABTXB.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarABTXB.UseVisualStyleBackColor = true;
            this.btnAceptarABTXB.Click += new System.EventHandler(this.btnAceptarABTXB_Click);
            // 
            // GBNuevoBecATutABTXB
            // 
            this.GBNuevoBecATutABTXB.Controls.Add(this.btnBuscarABTXB);
            this.GBNuevoBecATutABTXB.Controls.Add(this.txtApABTXB);
            this.GBNuevoBecATutABTXB.Controls.Add(this.txtNombABTXB);
            this.GBNuevoBecATutABTXB.Controls.Add(this.txtCodABTXB);
            this.GBNuevoBecATutABTXB.Controls.Add(this.LApeABTXB);
            this.GBNuevoBecATutABTXB.Controls.Add(this.LNombreABTXB);
            this.GBNuevoBecATutABTXB.Controls.Add(this.LCodigoABTXB);
            this.GBNuevoBecATutABTXB.Location = new System.Drawing.Point(22, 29);
            this.GBNuevoBecATutABTXB.Name = "GBNuevoBecATutABTXB";
            this.GBNuevoBecATutABTXB.Size = new System.Drawing.Size(301, 143);
            this.GBNuevoBecATutABTXB.TabIndex = 5;
            this.GBNuevoBecATutABTXB.TabStop = false;
            this.GBNuevoBecATutABTXB.Text = "Datos Principales";
            // 
            // btnBuscarABTXB
            // 
            this.btnBuscarABTXB.Location = new System.Drawing.Point(189, 27);
            this.btnBuscarABTXB.Name = "btnBuscarABTXB";
            this.btnBuscarABTXB.Size = new System.Drawing.Size(82, 20);
            this.btnBuscarABTXB.TabIndex = 6;
            this.btnBuscarABTXB.Text = "Buscar";
            this.btnBuscarABTXB.UseVisualStyleBackColor = true;
            this.btnBuscarABTXB.Click += new System.EventHandler(this.btnBuscarABTXB_Click);
            // 
            // txtApABTXB
            // 
            this.txtApABTXB.Location = new System.Drawing.Point(65, 101);
            this.txtApABTXB.Name = "txtApABTXB";
            this.txtApABTXB.Size = new System.Drawing.Size(230, 20);
            this.txtApABTXB.TabIndex = 5;
            // 
            // txtNombABTXB
            // 
            this.txtNombABTXB.Location = new System.Drawing.Point(65, 64);
            this.txtNombABTXB.Name = "txtNombABTXB";
            this.txtNombABTXB.Size = new System.Drawing.Size(230, 20);
            this.txtNombABTXB.TabIndex = 4;
            // 
            // txtCodABTXB
            // 
            this.txtCodABTXB.Location = new System.Drawing.Point(65, 27);
            this.txtCodABTXB.Name = "txtCodABTXB";
            this.txtCodABTXB.Size = new System.Drawing.Size(117, 20);
            this.txtCodABTXB.TabIndex = 3;
            // 
            // LApeABTXB
            // 
            this.LApeABTXB.AutoSize = true;
            this.LApeABTXB.Location = new System.Drawing.Point(6, 109);
            this.LApeABTXB.Name = "LApeABTXB";
            this.LApeABTXB.Size = new System.Drawing.Size(52, 13);
            this.LApeABTXB.TabIndex = 2;
            this.LApeABTXB.Text = "Apellidos:";
            // 
            // LNombreABTXB
            // 
            this.LNombreABTXB.AutoSize = true;
            this.LNombreABTXB.Location = new System.Drawing.Point(6, 71);
            this.LNombreABTXB.Name = "LNombreABTXB";
            this.LNombreABTXB.Size = new System.Drawing.Size(47, 13);
            this.LNombreABTXB.TabIndex = 1;
            this.LNombreABTXB.Text = "Nombre:";
            // 
            // LCodigoABTXB
            // 
            this.LCodigoABTXB.AutoSize = true;
            this.LCodigoABTXB.Location = new System.Drawing.Point(6, 34);
            this.LCodigoABTXB.Name = "LCodigoABTXB";
            this.LCodigoABTXB.Size = new System.Drawing.Size(43, 13);
            this.LCodigoABTXB.TabIndex = 0;
            this.LCodigoABTXB.Text = "Codigo:";
            // 
            // AgregarBecarioATutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 304);
            this.Controls.Add(this.GBTutorABTXB);
            this.Controls.Add(this.btnCancelarABTXB);
            this.Controls.Add(this.btnAceptarABTXB);
            this.Controls.Add(this.GBNuevoBecATutABTXB);
            this.Name = "AgregarBecarioATutor";
            this.Text = "Agregar Becario A Tutor";
            this.GBTutorABTXB.ResumeLayout(false);
            this.GBNuevoBecATutABTXB.ResumeLayout(false);
            this.GBNuevoBecATutABTXB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBTutorABTXB;
        private System.Windows.Forms.ComboBox CBTutorABTXB;
        private System.Windows.Forms.Button btnCancelarABTXB;
        private System.Windows.Forms.Button btnAceptarABTXB;
        private System.Windows.Forms.GroupBox GBNuevoBecATutABTXB;
        private System.Windows.Forms.Button btnBuscarABTXB;
        private System.Windows.Forms.TextBox txtApABTXB;
        private System.Windows.Forms.TextBox txtNombABTXB;
        private System.Windows.Forms.TextBox txtCodABTXB;
        private System.Windows.Forms.Label LApeABTXB;
        private System.Windows.Forms.Label LNombreABTXB;
        private System.Windows.Forms.Label LCodigoABTXB;
    }
}