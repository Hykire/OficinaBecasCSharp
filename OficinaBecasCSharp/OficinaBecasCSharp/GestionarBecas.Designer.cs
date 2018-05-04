namespace Vista
{
    partial class GestionarBecas
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
            this.PGestBecas = new System.Windows.Forms.Panel();
            this.btnDescargarGB = new System.Windows.Forms.Button();
            this.DGVDocumentosGB = new System.Windows.Forms.DataGridView();
            this.C1GB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2GB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chbxInactivasGB = new System.Windows.Forms.CheckBox();
            this.chbxActivasGB = new System.Windows.Forms.CheckBox();
            this.txtNombBecaGB = new System.Windows.Forms.TextBox();
            this.GBDescripBecaGB = new System.Windows.Forms.GroupBox();
            this.txtBDescBecaGB = new System.Windows.Forms.TextBox();
            this.BEliminarCitaGC = new System.Windows.Forms.Button();
            this.BEditarCitaGC = new System.Windows.Forms.Button();
            this.BAgregarBecaGB = new System.Windows.Forms.Button();
            this.btnBuscarBecaGB = new System.Windows.Forms.Button();
            this.LTituloGC = new System.Windows.Forms.Label();
            this.GBDetalleBecaGB = new System.Windows.Forms.GroupBox();
            this.txtCodTutorGC = new System.Windows.Forms.TextBox();
            this.LFechaUltConvocGB = new System.Windows.Forms.Label();
            this.txtBFechaGC = new System.Windows.Forms.TextBox();
            this.LNombBecaGB = new System.Windows.Forms.Label();
            this.LSelFechaGC = new System.Windows.Forms.Label();
            this.btnMNGestBecas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PGestBecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDocumentosGB)).BeginInit();
            this.GBDescripBecaGB.SuspendLayout();
            this.GBDetalleBecaGB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGestBecas
            // 
            this.PGestBecas.Controls.Add(this.btnDescargarGB);
            this.PGestBecas.Controls.Add(this.DGVDocumentosGB);
            this.PGestBecas.Controls.Add(this.chbxInactivasGB);
            this.PGestBecas.Controls.Add(this.chbxActivasGB);
            this.PGestBecas.Controls.Add(this.txtNombBecaGB);
            this.PGestBecas.Controls.Add(this.GBDescripBecaGB);
            this.PGestBecas.Controls.Add(this.BEliminarCitaGC);
            this.PGestBecas.Controls.Add(this.BEditarCitaGC);
            this.PGestBecas.Controls.Add(this.BAgregarBecaGB);
            this.PGestBecas.Controls.Add(this.btnBuscarBecaGB);
            this.PGestBecas.Controls.Add(this.LTituloGC);
            this.PGestBecas.Controls.Add(this.GBDetalleBecaGB);
            this.PGestBecas.Controls.Add(this.LSelFechaGC);
            this.PGestBecas.Location = new System.Drawing.Point(252, 52);
            this.PGestBecas.Name = "PGestBecas";
            this.PGestBecas.Size = new System.Drawing.Size(522, 345);
            this.PGestBecas.TabIndex = 25;
            // 
            // btnDescargarGB
            // 
            this.btnDescargarGB.Location = new System.Drawing.Point(386, 296);
            this.btnDescargarGB.Name = "btnDescargarGB";
            this.btnDescargarGB.Size = new System.Drawing.Size(75, 23);
            this.btnDescargarGB.TabIndex = 13;
            this.btnDescargarGB.Text = "Descargar";
            this.btnDescargarGB.UseVisualStyleBackColor = true;
            this.btnDescargarGB.Click += new System.EventHandler(this.btnDescargarGB_Click);
            // 
            // DGVDocumentosGB
            // 
            this.DGVDocumentosGB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDocumentosGB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1GB,
            this.C2GB});
            this.DGVDocumentosGB.Location = new System.Drawing.Point(28, 247);
            this.DGVDocumentosGB.Name = "DGVDocumentosGB";
            this.DGVDocumentosGB.Size = new System.Drawing.Size(291, 72);
            this.DGVDocumentosGB.TabIndex = 12;
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
            // chbxInactivasGB
            // 
            this.chbxInactivasGB.AutoSize = true;
            this.chbxInactivasGB.Location = new System.Drawing.Point(417, 71);
            this.chbxInactivasGB.Name = "chbxInactivasGB";
            this.chbxInactivasGB.Size = new System.Drawing.Size(69, 17);
            this.chbxInactivasGB.TabIndex = 11;
            this.chbxInactivasGB.Text = "Inactivas";
            this.chbxInactivasGB.UseVisualStyleBackColor = true;
            // 
            // chbxActivasGB
            // 
            this.chbxActivasGB.AutoSize = true;
            this.chbxActivasGB.Location = new System.Drawing.Point(350, 71);
            this.chbxActivasGB.Name = "chbxActivasGB";
            this.chbxActivasGB.Size = new System.Drawing.Size(61, 17);
            this.chbxActivasGB.TabIndex = 10;
            this.chbxActivasGB.Text = "Activas";
            this.chbxActivasGB.UseVisualStyleBackColor = true;
            // 
            // txtNombBecaGB
            // 
            this.txtNombBecaGB.Location = new System.Drawing.Point(147, 72);
            this.txtNombBecaGB.Name = "txtNombBecaGB";
            this.txtNombBecaGB.Size = new System.Drawing.Size(190, 20);
            this.txtNombBecaGB.TabIndex = 9;
            // 
            // GBDescripBecaGB
            // 
            this.GBDescripBecaGB.Controls.Add(this.txtBDescBecaGB);
            this.GBDescripBecaGB.Location = new System.Drawing.Point(338, 127);
            this.GBDescripBecaGB.Name = "GBDescripBecaGB";
            this.GBDescripBecaGB.Size = new System.Drawing.Size(168, 160);
            this.GBDescripBecaGB.TabIndex = 8;
            this.GBDescripBecaGB.TabStop = false;
            this.GBDescripBecaGB.Text = "Descripción";
            // 
            // txtBDescBecaGB
            // 
            this.txtBDescBecaGB.Location = new System.Drawing.Point(6, 28);
            this.txtBDescBecaGB.Multiline = true;
            this.txtBDescBecaGB.Name = "txtBDescBecaGB";
            this.txtBDescBecaGB.Size = new System.Drawing.Size(155, 122);
            this.txtBDescBecaGB.TabIndex = 13;
            // 
            // BEliminarCitaGC
            // 
            this.BEliminarCitaGC.Location = new System.Drawing.Point(408, 20);
            this.BEliminarCitaGC.Name = "BEliminarCitaGC";
            this.BEliminarCitaGC.Size = new System.Drawing.Size(85, 23);
            this.BEliminarCitaGC.TabIndex = 7;
            this.BEliminarCitaGC.Text = "Eliminar Beca";
            this.BEliminarCitaGC.UseVisualStyleBackColor = true;
            this.BEliminarCitaGC.Click += new System.EventHandler(this.BEliminarCitaGC_Click);
            // 
            // BEditarCitaGC
            // 
            this.BEditarCitaGC.Location = new System.Drawing.Point(327, 20);
            this.BEditarCitaGC.Name = "BEditarCitaGC";
            this.BEditarCitaGC.Size = new System.Drawing.Size(75, 23);
            this.BEditarCitaGC.TabIndex = 6;
            this.BEditarCitaGC.Text = "Editar Beca";
            this.BEditarCitaGC.UseVisualStyleBackColor = true;
            this.BEditarCitaGC.Click += new System.EventHandler(this.BEditarCitaGC_Click);
            // 
            // BAgregarBecaGB
            // 
            this.BAgregarBecaGB.Location = new System.Drawing.Point(235, 20);
            this.BAgregarBecaGB.Name = "BAgregarBecaGB";
            this.BAgregarBecaGB.Size = new System.Drawing.Size(86, 23);
            this.BAgregarBecaGB.TabIndex = 5;
            this.BAgregarBecaGB.Text = "Agregar Beca";
            this.BAgregarBecaGB.UseVisualStyleBackColor = true;
            this.BAgregarBecaGB.Click += new System.EventHandler(this.BAgregarBecaGB_Click);
            // 
            // btnBuscarBecaGB
            // 
            this.btnBuscarBecaGB.Location = new System.Drawing.Point(372, 94);
            this.btnBuscarBecaGB.Name = "btnBuscarBecaGB";
            this.btnBuscarBecaGB.Size = new System.Drawing.Size(99, 23);
            this.btnBuscarBecaGB.TabIndex = 4;
            this.btnBuscarBecaGB.Text = "Buscar Beca";
            this.btnBuscarBecaGB.UseVisualStyleBackColor = true;
            this.btnBuscarBecaGB.Click += new System.EventHandler(this.btnBuscarBecaGB_Click);
            // 
            // LTituloGC
            // 
            this.LTituloGC.AutoSize = true;
            this.LTituloGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGC.Location = new System.Drawing.Point(19, 20);
            this.LTituloGC.Name = "LTituloGC";
            this.LTituloGC.Size = new System.Drawing.Size(143, 20);
            this.LTituloGC.TabIndex = 2;
            this.LTituloGC.Text = "Gestionar Becas";
            // 
            // GBDetalleBecaGB
            // 
            this.GBDetalleBecaGB.Controls.Add(this.txtCodTutorGC);
            this.GBDetalleBecaGB.Controls.Add(this.LFechaUltConvocGB);
            this.GBDetalleBecaGB.Controls.Add(this.txtBFechaGC);
            this.GBDetalleBecaGB.Controls.Add(this.LNombBecaGB);
            this.GBDetalleBecaGB.Location = new System.Drawing.Point(24, 127);
            this.GBDetalleBecaGB.Name = "GBDetalleBecaGB";
            this.GBDetalleBecaGB.Size = new System.Drawing.Size(298, 110);
            this.GBDetalleBecaGB.TabIndex = 3;
            this.GBDetalleBecaGB.TabStop = false;
            this.GBDetalleBecaGB.Text = "Detalle de Beca";
            // 
            // txtCodTutorGC
            // 
            this.txtCodTutorGC.Location = new System.Drawing.Point(145, 59);
            this.txtCodTutorGC.Name = "txtCodTutorGC";
            this.txtCodTutorGC.Size = new System.Drawing.Size(138, 20);
            this.txtCodTutorGC.TabIndex = 16;
            // 
            // LFechaUltConvocGB
            // 
            this.LFechaUltConvocGB.AutoSize = true;
            this.LFechaUltConvocGB.Location = new System.Drawing.Point(21, 62);
            this.LFechaUltConvocGB.Name = "LFechaUltConvocGB";
            this.LFechaUltConvocGB.Size = new System.Drawing.Size(105, 13);
            this.LFechaUltConvocGB.TabIndex = 15;
            this.LFechaUltConvocGB.Text = "Última Convocatoria:";
            // 
            // txtBFechaGC
            // 
            this.txtBFechaGC.Location = new System.Drawing.Point(68, 25);
            this.txtBFechaGC.Name = "txtBFechaGC";
            this.txtBFechaGC.Size = new System.Drawing.Size(215, 20);
            this.txtBFechaGC.TabIndex = 7;
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
            // LSelFechaGC
            // 
            this.LSelFechaGC.AutoSize = true;
            this.LSelFechaGC.Location = new System.Drawing.Point(26, 76);
            this.LSelFechaGC.Name = "LSelFechaGC";
            this.LSelFechaGC.Size = new System.Drawing.Size(114, 13);
            this.LSelFechaGC.TabIndex = 1;
            this.LSelFechaGC.Text = "Seleccionar una beca:";
            // 
            // btnMNGestBecas
            // 
            this.btnMNGestBecas.Location = new System.Drawing.Point(34, 125);
            this.btnMNGestBecas.Name = "btnMNGestBecas";
            this.btnMNGestBecas.Size = new System.Drawing.Size(111, 24);
            this.btnMNGestBecas.TabIndex = 0;
            this.btnMNGestBecas.Text = "Gestionar Becas";
            this.btnMNGestBecas.UseVisualStyleBackColor = true;
            this.btnMNGestBecas.Click += new System.EventHandler(this.btnMNGestBecas_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMNGestBecas);
            this.panel1.Location = new System.Drawing.Point(34, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 278);
            this.panel1.TabIndex = 27;
            // 
            // GestionarBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PGestBecas);
            this.IsMdiContainer = true;
            this.Name = "GestionarBecas";
            this.Text = "Gestionar Becas";
            this.PGestBecas.ResumeLayout(false);
            this.PGestBecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDocumentosGB)).EndInit();
            this.GBDescripBecaGB.ResumeLayout(false);
            this.GBDescripBecaGB.PerformLayout();
            this.GBDetalleBecaGB.ResumeLayout(false);
            this.GBDetalleBecaGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PGestBecas;
        private System.Windows.Forms.Button btnDescargarGB;
        private System.Windows.Forms.DataGridView DGVDocumentosGB;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1GB;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2GB;
        private System.Windows.Forms.CheckBox chbxInactivasGB;
        private System.Windows.Forms.CheckBox chbxActivasGB;
        private System.Windows.Forms.TextBox txtNombBecaGB;
        private System.Windows.Forms.GroupBox GBDescripBecaGB;
        private System.Windows.Forms.TextBox txtBDescBecaGB;
        private System.Windows.Forms.Button BEliminarCitaGC;
        private System.Windows.Forms.Button BEditarCitaGC;
        private System.Windows.Forms.Button BAgregarBecaGB;
        private System.Windows.Forms.Button btnBuscarBecaGB;
        private System.Windows.Forms.Label LTituloGC;
        private System.Windows.Forms.GroupBox GBDetalleBecaGB;
        private System.Windows.Forms.TextBox txtCodTutorGC;
        private System.Windows.Forms.Label LFechaUltConvocGB;
        private System.Windows.Forms.TextBox txtBFechaGC;
        private System.Windows.Forms.Label LNombBecaGB;
        private System.Windows.Forms.Label LSelFechaGC;
        private System.Windows.Forms.Button btnMNGestBecas;
        private System.Windows.Forms.Panel panel1;
    }
}