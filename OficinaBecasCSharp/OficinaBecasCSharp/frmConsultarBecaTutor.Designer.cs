namespace Vista
{
    partial class frmConsultarBecaTutor
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
            this.panelConsultarBecaT = new System.Windows.Forms.Panel();
            this.btnBecasExternasCBT = new System.Windows.Forms.Button();
            this.btnBecasPUCPCBT = new System.Windows.Forms.Button();
            this.LabelCBT = new System.Windows.Forms.Label();
            this.LNombBecaCBT = new System.Windows.Forms.Label();
            this.btnBuscarBecaCBT = new System.Windows.Forms.Button();
            this.DGVConsBecaT = new System.Windows.Forms.DataGridView();
            this.txtCodBecCBT = new System.Windows.Forms.TextBox();
            this.Nombre_beca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BecarioActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Financiador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsultarBecaT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsBecaT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarBecaT
            // 
            this.panelConsultarBecaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarBecaT.Controls.Add(this.btnBecasExternasCBT);
            this.panelConsultarBecaT.Controls.Add(this.btnBecasPUCPCBT);
            this.panelConsultarBecaT.Controls.Add(this.LabelCBT);
            this.panelConsultarBecaT.Controls.Add(this.LNombBecaCBT);
            this.panelConsultarBecaT.Controls.Add(this.btnBuscarBecaCBT);
            this.panelConsultarBecaT.Controls.Add(this.DGVConsBecaT);
            this.panelConsultarBecaT.Controls.Add(this.txtCodBecCBT);
            this.panelConsultarBecaT.Location = new System.Drawing.Point(-1, -2);
            this.panelConsultarBecaT.Name = "panelConsultarBecaT";
            this.panelConsultarBecaT.Size = new System.Drawing.Size(801, 454);
            this.panelConsultarBecaT.TabIndex = 15;
            // 
            // btnBecasExternasCBT
            // 
            this.btnBecasExternasCBT.AutoSize = true;
            this.btnBecasExternasCBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasExternasCBT.Location = new System.Drawing.Point(46, 211);
            this.btnBecasExternasCBT.Name = "btnBecasExternasCBT";
            this.btnBecasExternasCBT.Size = new System.Drawing.Size(91, 23);
            this.btnBecasExternasCBT.TabIndex = 20;
            this.btnBecasExternasCBT.Text = "Becas Externas";
            this.btnBecasExternasCBT.UseVisualStyleBackColor = true;
            // 
            // btnBecasPUCPCBT
            // 
            this.btnBecasPUCPCBT.AutoSize = true;
            this.btnBecasPUCPCBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasPUCPCBT.Location = new System.Drawing.Point(46, 155);
            this.btnBecasPUCPCBT.Name = "btnBecasPUCPCBT";
            this.btnBecasPUCPCBT.Size = new System.Drawing.Size(79, 23);
            this.btnBecasPUCPCBT.TabIndex = 19;
            this.btnBecasPUCPCBT.Text = "Becas PUCP";
            this.btnBecasPUCPCBT.UseVisualStyleBackColor = true;
            // 
            // LabelCBT
            // 
            this.LabelCBT.AutoSize = true;
            this.LabelCBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCBT.Location = new System.Drawing.Point(19, 12);
            this.LabelCBT.Name = "LabelCBT";
            this.LabelCBT.Size = new System.Drawing.Size(132, 20);
            this.LabelCBT.TabIndex = 18;
            this.LabelCBT.Text = "Consultar Beca";
            // 
            // LNombBecaCBT
            // 
            this.LNombBecaCBT.AutoSize = true;
            this.LNombBecaCBT.Location = new System.Drawing.Point(166, 42);
            this.LNombBecaCBT.Name = "LNombBecaCBT";
            this.LNombBecaCBT.Size = new System.Drawing.Size(87, 13);
            this.LNombBecaCBT.TabIndex = 6;
            this.LNombBecaCBT.Text = "Nombre de Beca";
            // 
            // btnBuscarBecaCBT
            // 
            this.btnBuscarBecaCBT.Location = new System.Drawing.Point(676, 55);
            this.btnBuscarBecaCBT.Name = "btnBuscarBecaCBT";
            this.btnBuscarBecaCBT.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarBecaCBT.TabIndex = 2;
            this.btnBuscarBecaCBT.Text = "Buscar";
            this.btnBuscarBecaCBT.UseVisualStyleBackColor = true;
            this.btnBuscarBecaCBT.Click += new System.EventHandler(this.btnBuscarBecaCBT_Click);
            // 
            // DGVConsBecaT
            // 
            this.DGVConsBecaT.AllowUserToAddRows = false;
            this.DGVConsBecaT.AllowUserToDeleteRows = false;
            this.DGVConsBecaT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVConsBecaT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsBecaT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_beca,
            this.BecarioActivo,
            this.Descripcion,
            this.Financiador});
            this.DGVConsBecaT.Location = new System.Drawing.Point(169, 99);
            this.DGVConsBecaT.Name = "DGVConsBecaT";
            this.DGVConsBecaT.ReadOnly = true;
            this.DGVConsBecaT.Size = new System.Drawing.Size(599, 319);
            this.DGVConsBecaT.TabIndex = 3;
            // 
            // txtCodBecCBT
            // 
            this.txtCodBecCBT.Location = new System.Drawing.Point(169, 58);
            this.txtCodBecCBT.Name = "txtCodBecCBT";
            this.txtCodBecCBT.Size = new System.Drawing.Size(320, 20);
            this.txtCodBecCBT.TabIndex = 1;
            // 
            // Nombre_beca
            // 
            this.Nombre_beca.DataPropertyName = "Nombre_beca";
            this.Nombre_beca.HeaderText = "NombreBeca";
            this.Nombre_beca.Name = "Nombre_beca";
            this.Nombre_beca.ReadOnly = true;
            // 
            // BecarioActivo
            // 
            this.BecarioActivo.HeaderText = "Activo";
            this.BecarioActivo.Name = "BecarioActivo";
            this.BecarioActivo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Financiador
            // 
            this.Financiador.DataPropertyName = "Financiador";
            this.Financiador.HeaderText = "nombreFinanciador";
            this.Financiador.Name = "Financiador";
            this.Financiador.ReadOnly = true;
            // 
            // frmConsultarBecaTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConsultarBecaT);
            this.Name = "frmConsultarBecaTutor";
            this.Text = "frmConsultarBecaTutor";
            this.Load += new System.EventHandler(this.frmConsultarBecaTutor_Load);
            this.panelConsultarBecaT.ResumeLayout(false);
            this.panelConsultarBecaT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsBecaT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarBecaT;
        private System.Windows.Forms.Button btnBecasExternasCBT;
        private System.Windows.Forms.Button btnBecasPUCPCBT;
        private System.Windows.Forms.Label LabelCBT;
        private System.Windows.Forms.Label LNombBecaCBT;
        private System.Windows.Forms.Button btnBuscarBecaCBT;
        private System.Windows.Forms.DataGridView DGVConsBecaT;
        private System.Windows.Forms.TextBox txtCodBecCBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_beca;
        private System.Windows.Forms.DataGridViewTextBoxColumn BecarioActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Financiador;
    }
}