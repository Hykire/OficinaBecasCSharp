namespace Vista
{
    partial class AgregarBecaGB
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
            this.DGVDocumentosGB = new System.Windows.Forms.DataGridView();
            this.C1GB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2GB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBDescripBecaEBGB = new System.Windows.Forms.GroupBox();
            this.txtBDescBecaEBGB = new System.Windows.Forms.TextBox();
            this.GBDetalleBecaEBGB = new System.Windows.Forms.GroupBox();
            this.cbxEstadoBecaEBGB = new System.Windows.Forms.ComboBox();
            this.LEstadoBecaEBGB = new System.Windows.Forms.Label();
            this.txtCodTutorEBGC = new System.Windows.Forms.TextBox();
            this.LFechaUltConvocEBGB = new System.Windows.Forms.Label();
            this.txtBFechaEBGC = new System.Windows.Forms.TextBox();
            this.LNombBecaGB = new System.Windows.Forms.Label();
            this.btnAdjuntarABGB = new System.Windows.Forms.Button();
            this.btAceptarABGB = new System.Windows.Forms.Button();
            this.btnCancelarABGB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDocumentosGB)).BeginInit();
            this.GBDescripBecaEBGB.SuspendLayout();
            this.GBDetalleBecaEBGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVDocumentosGB
            // 
            this.DGVDocumentosGB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDocumentosGB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1GB,
            this.C2GB});
            this.DGVDocumentosGB.Location = new System.Drawing.Point(19, 218);
            this.DGVDocumentosGB.Name = "DGVDocumentosGB";
            this.DGVDocumentosGB.Size = new System.Drawing.Size(291, 72);
            this.DGVDocumentosGB.TabIndex = 26;
            // 
            // C1GB
            // 
            this.C1GB.HeaderText = "Documento";
            this.C1GB.Name = "C1GB";
            this.C1GB.Width = 120;
            // 
            // C2GB
            // 
            this.C2GB.HeaderText = "DescripcionDoc";
            this.C2GB.Name = "C2GB";
            this.C2GB.Width = 150;
            // 
            // GBDescripBecaEBGB
            // 
            this.GBDescripBecaEBGB.Controls.Add(this.txtBDescBecaEBGB);
            this.GBDescripBecaEBGB.Location = new System.Drawing.Point(326, 68);
            this.GBDescripBecaEBGB.Name = "GBDescripBecaEBGB";
            this.GBDescripBecaEBGB.Size = new System.Drawing.Size(168, 160);
            this.GBDescripBecaEBGB.TabIndex = 25;
            this.GBDescripBecaEBGB.TabStop = false;
            this.GBDescripBecaEBGB.Text = "Descripción";
            // 
            // txtBDescBecaEBGB
            // 
            this.txtBDescBecaEBGB.Location = new System.Drawing.Point(6, 28);
            this.txtBDescBecaEBGB.Multiline = true;
            this.txtBDescBecaEBGB.Name = "txtBDescBecaEBGB";
            this.txtBDescBecaEBGB.Size = new System.Drawing.Size(155, 122);
            this.txtBDescBecaEBGB.TabIndex = 13;
            // 
            // GBDetalleBecaEBGB
            // 
            this.GBDetalleBecaEBGB.Controls.Add(this.cbxEstadoBecaEBGB);
            this.GBDetalleBecaEBGB.Controls.Add(this.LEstadoBecaEBGB);
            this.GBDetalleBecaEBGB.Controls.Add(this.txtCodTutorEBGC);
            this.GBDetalleBecaEBGB.Controls.Add(this.LFechaUltConvocEBGB);
            this.GBDetalleBecaEBGB.Controls.Add(this.txtBFechaEBGC);
            this.GBDetalleBecaEBGB.Controls.Add(this.LNombBecaGB);
            this.GBDetalleBecaEBGB.Location = new System.Drawing.Point(12, 31);
            this.GBDetalleBecaEBGB.Name = "GBDetalleBecaEBGB";
            this.GBDetalleBecaEBGB.Size = new System.Drawing.Size(298, 147);
            this.GBDetalleBecaEBGB.TabIndex = 24;
            this.GBDetalleBecaEBGB.TabStop = false;
            this.GBDetalleBecaEBGB.Text = "Detalle de Beca";
            // 
            // cbxEstadoBecaEBGB
            // 
            this.cbxEstadoBecaEBGB.FormattingEnabled = true;
            this.cbxEstadoBecaEBGB.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.cbxEstadoBecaEBGB.Location = new System.Drawing.Point(145, 91);
            this.cbxEstadoBecaEBGB.Name = "cbxEstadoBecaEBGB";
            this.cbxEstadoBecaEBGB.Size = new System.Drawing.Size(138, 21);
            this.cbxEstadoBecaEBGB.TabIndex = 18;
            // 
            // LEstadoBecaEBGB
            // 
            this.LEstadoBecaEBGB.AutoSize = true;
            this.LEstadoBecaEBGB.Location = new System.Drawing.Point(24, 91);
            this.LEstadoBecaEBGB.Name = "LEstadoBecaEBGB";
            this.LEstadoBecaEBGB.Size = new System.Drawing.Size(40, 13);
            this.LEstadoBecaEBGB.TabIndex = 17;
            this.LEstadoBecaEBGB.Text = "Estado";
            // 
            // txtCodTutorEBGC
            // 
            this.txtCodTutorEBGC.Location = new System.Drawing.Point(145, 59);
            this.txtCodTutorEBGC.Name = "txtCodTutorEBGC";
            this.txtCodTutorEBGC.Size = new System.Drawing.Size(138, 20);
            this.txtCodTutorEBGC.TabIndex = 16;
            // 
            // LFechaUltConvocEBGB
            // 
            this.LFechaUltConvocEBGB.AutoSize = true;
            this.LFechaUltConvocEBGB.Location = new System.Drawing.Point(21, 62);
            this.LFechaUltConvocEBGB.Name = "LFechaUltConvocEBGB";
            this.LFechaUltConvocEBGB.Size = new System.Drawing.Size(78, 13);
            this.LFechaUltConvocEBGB.TabIndex = 15;
            this.LFechaUltConvocEBGB.Text = "Vigente desde:";
            // 
            // txtBFechaEBGC
            // 
            this.txtBFechaEBGC.Location = new System.Drawing.Point(68, 25);
            this.txtBFechaEBGC.Name = "txtBFechaEBGC";
            this.txtBFechaEBGC.Size = new System.Drawing.Size(215, 20);
            this.txtBFechaEBGC.TabIndex = 7;
            // 
            // LNombBecaGB
            // 
            this.LNombBecaGB.AutoSize = true;
            this.LNombBecaGB.Location = new System.Drawing.Point(20, 28);
            this.LNombBecaGB.Name = "LNombBecaGB";
            this.LNombBecaGB.Size = new System.Drawing.Size(47, 13);
            this.LNombBecaGB.TabIndex = 2;
            this.LNombBecaGB.Text = "Nombre:";
            // 
            // btnAdjuntarABGB
            // 
            this.btnAdjuntarABGB.Location = new System.Drawing.Point(360, 253);
            this.btnAdjuntarABGB.Name = "btnAdjuntarABGB";
            this.btnAdjuntarABGB.Size = new System.Drawing.Size(105, 23);
            this.btnAdjuntarABGB.TabIndex = 27;
            this.btnAdjuntarABGB.Text = "Adjuntar";
            this.btnAdjuntarABGB.UseVisualStyleBackColor = true;
            this.btnAdjuntarABGB.Click += new System.EventHandler(this.btnAdjuntarABGB_Click);
            // 
            // btAceptarABGB
            // 
            this.btAceptarABGB.Location = new System.Drawing.Point(350, 311);
            this.btAceptarABGB.Name = "btAceptarABGB";
            this.btAceptarABGB.Size = new System.Drawing.Size(75, 23);
            this.btAceptarABGB.TabIndex = 28;
            this.btAceptarABGB.Text = "Aceptar";
            this.btAceptarABGB.UseVisualStyleBackColor = true;
            this.btAceptarABGB.Click += new System.EventHandler(this.btAceptarABGB_Click);
            // 
            // btnCancelarABGB
            // 
            this.btnCancelarABGB.Location = new System.Drawing.Point(432, 311);
            this.btnCancelarABGB.Name = "btnCancelarABGB";
            this.btnCancelarABGB.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarABGB.TabIndex = 29;
            this.btnCancelarABGB.Text = "Cancelar";
            this.btnCancelarABGB.UseVisualStyleBackColor = true;
            this.btnCancelarABGB.Click += new System.EventHandler(this.btnCancelarABGB_Click);
            // 
            // AgregarBecaGB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 346);
            this.Controls.Add(this.btnCancelarABGB);
            this.Controls.Add(this.btAceptarABGB);
            this.Controls.Add(this.btnAdjuntarABGB);
            this.Controls.Add(this.DGVDocumentosGB);
            this.Controls.Add(this.GBDescripBecaEBGB);
            this.Controls.Add(this.GBDetalleBecaEBGB);
            this.Name = "AgregarBecaGB";
            this.Text = "Agregar Beca";
            ((System.ComponentModel.ISupportInitialize)(this.DGVDocumentosGB)).EndInit();
            this.GBDescripBecaEBGB.ResumeLayout(false);
            this.GBDescripBecaEBGB.PerformLayout();
            this.GBDetalleBecaEBGB.ResumeLayout(false);
            this.GBDetalleBecaEBGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVDocumentosGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1GB;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2GB;
        private System.Windows.Forms.GroupBox GBDescripBecaEBGB;
        private System.Windows.Forms.TextBox txtBDescBecaEBGB;
        private System.Windows.Forms.GroupBox GBDetalleBecaEBGB;
        private System.Windows.Forms.ComboBox cbxEstadoBecaEBGB;
        private System.Windows.Forms.Label LEstadoBecaEBGB;
        private System.Windows.Forms.TextBox txtCodTutorEBGC;
        private System.Windows.Forms.Label LFechaUltConvocEBGB;
        private System.Windows.Forms.TextBox txtBFechaEBGC;
        private System.Windows.Forms.Label LNombBecaGB;
        private System.Windows.Forms.Button btnAdjuntarABGB;
        private System.Windows.Forms.Button btAceptarABGB;
        private System.Windows.Forms.Button btnCancelarABGB;
    }
}