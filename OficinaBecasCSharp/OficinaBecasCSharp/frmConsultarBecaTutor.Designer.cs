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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcionSelec = new System.Windows.Forms.TextBox();
            this.txtFinanciadorSelec = new System.Windows.Forms.TextBox();
            this.txtFechaConvocatoriaSelec = new System.Windows.Forms.TextBox();
            this.txtNombreBecaSelec = new System.Windows.Forms.TextBox();
            this.btnBecasExternasCBT = new System.Windows.Forms.Button();
            this.btnBecasPUCPCBT = new System.Windows.Forms.Button();
            this.LabelCBT = new System.Windows.Forms.Label();
            this.LNombBecaCBT = new System.Windows.Forms.Label();
            this.btnBuscarBecaCBT = new System.Windows.Forms.Button();
            this.DGVConsBecaT = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Financiador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodBecCBT = new System.Windows.Forms.TextBox();
            this.panelConsultarBecaT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsBecaT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarBecaT
            // 
            this.panelConsultarBecaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarBecaT.Controls.Add(this.label5);
            this.panelConsultarBecaT.Controls.Add(this.label4);
            this.panelConsultarBecaT.Controls.Add(this.label3);
            this.panelConsultarBecaT.Controls.Add(this.label2);
            this.panelConsultarBecaT.Controls.Add(this.txtDescripcionSelec);
            this.panelConsultarBecaT.Controls.Add(this.txtFinanciadorSelec);
            this.panelConsultarBecaT.Controls.Add(this.txtFechaConvocatoriaSelec);
            this.panelConsultarBecaT.Controls.Add(this.txtNombreBecaSelec);
            this.panelConsultarBecaT.Controls.Add(this.btnBecasExternasCBT);
            this.panelConsultarBecaT.Controls.Add(this.btnBecasPUCPCBT);
            this.panelConsultarBecaT.Controls.Add(this.LabelCBT);
            this.panelConsultarBecaT.Controls.Add(this.LNombBecaCBT);
            this.panelConsultarBecaT.Controls.Add(this.btnBuscarBecaCBT);
            this.panelConsultarBecaT.Controls.Add(this.DGVConsBecaT);
            this.panelConsultarBecaT.Controls.Add(this.txtCodBecCBT);
            this.panelConsultarBecaT.Location = new System.Drawing.Point(12, 12);
            this.panelConsultarBecaT.Name = "panelConsultarBecaT";
            this.panelConsultarBecaT.Size = new System.Drawing.Size(904, 603);
            this.panelConsultarBecaT.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Fecha de convocatoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Financiador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre de Beca";
            // 
            // txtDescripcionSelec
            // 
            this.txtDescripcionSelec.Enabled = false;
            this.txtDescripcionSelec.Location = new System.Drawing.Point(507, 386);
            this.txtDescripcionSelec.Multiline = true;
            this.txtDescripcionSelec.Name = "txtDescripcionSelec";
            this.txtDescripcionSelec.Size = new System.Drawing.Size(259, 45);
            this.txtDescripcionSelec.TabIndex = 31;
            // 
            // txtFinanciadorSelec
            // 
            this.txtFinanciadorSelec.Enabled = false;
            this.txtFinanciadorSelec.Location = new System.Drawing.Point(169, 507);
            this.txtFinanciadorSelec.Multiline = true;
            this.txtFinanciadorSelec.Name = "txtFinanciadorSelec";
            this.txtFinanciadorSelec.Size = new System.Drawing.Size(259, 42);
            this.txtFinanciadorSelec.TabIndex = 30;
            // 
            // txtFechaConvocatoriaSelec
            // 
            this.txtFechaConvocatoriaSelec.Enabled = false;
            this.txtFechaConvocatoriaSelec.Location = new System.Drawing.Point(289, 411);
            this.txtFechaConvocatoriaSelec.Name = "txtFechaConvocatoriaSelec";
            this.txtFechaConvocatoriaSelec.Size = new System.Drawing.Size(157, 20);
            this.txtFechaConvocatoriaSelec.TabIndex = 29;
            // 
            // txtNombreBecaSelec
            // 
            this.txtNombreBecaSelec.Enabled = false;
            this.txtNombreBecaSelec.Location = new System.Drawing.Point(289, 362);
            this.txtNombreBecaSelec.Name = "txtNombreBecaSelec";
            this.txtNombreBecaSelec.Size = new System.Drawing.Size(157, 20);
            this.txtNombreBecaSelec.TabIndex = 28;
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
            this.btnBuscarBecaCBT.Location = new System.Drawing.Point(672, 58);
            this.btnBuscarBecaCBT.Name = "btnBuscarBecaCBT";
            this.btnBuscarBecaCBT.Size = new System.Drawing.Size(133, 23);
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
            this.Id,
            this.Descripcion,
            this.Nombre,
            this.Financiador});
            this.DGVConsBecaT.Location = new System.Drawing.Point(169, 99);
            this.DGVConsBecaT.Name = "DGVConsBecaT";
            this.DGVConsBecaT.ReadOnly = true;
            this.DGVConsBecaT.Size = new System.Drawing.Size(636, 220);
            this.DGVConsBecaT.TabIndex = 3;
            this.DGVConsBecaT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVConsBecaT_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_beca";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre_beca";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Financiador
            // 
            this.Financiador.DataPropertyName = "Financiador";
            this.Financiador.HeaderText = "Financiador";
            this.Financiador.Name = "Financiador";
            this.Financiador.ReadOnly = true;
            // 
            // txtCodBecCBT
            // 
            this.txtCodBecCBT.Location = new System.Drawing.Point(169, 58);
            this.txtCodBecCBT.Name = "txtCodBecCBT";
            this.txtCodBecCBT.Size = new System.Drawing.Size(473, 20);
            this.txtCodBecCBT.TabIndex = 1;
            // 
            // frmConsultarBecaTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 627);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Financiador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcionSelec;
        private System.Windows.Forms.TextBox txtFinanciadorSelec;
        private System.Windows.Forms.TextBox txtFechaConvocatoriaSelec;
        private System.Windows.Forms.TextBox txtNombreBecaSelec;
    }
}