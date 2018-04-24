namespace Vista
{
    partial class BuscarBeca
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
            this.dgvBuscarBecas = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.NombreBecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntidadFinancieraBecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConvocatoriaBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeleccionarBecas = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarBecas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarBecas
            // 
            this.dgvBuscarBecas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBuscarBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBecas,
            this.EntidadFinancieraBecas,
            this.FechaConvocatoriaBeca,
            this.EspecialidadBeca,
            this.SeleccionarBecas});
            this.dgvBuscarBecas.Location = new System.Drawing.Point(12, 43);
            this.dgvBuscarBecas.Name = "dgvBuscarBecas";
            this.dgvBuscarBecas.Size = new System.Drawing.Size(776, 328);
            this.dgvBuscarBecas.TabIndex = 4;
            this.dgvBuscarBecas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarBecas_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(660, 400);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(482, 400);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(102, 23);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // NombreBecas
            // 
            this.NombreBecas.HeaderText = "Nombre de Becas";
            this.NombreBecas.Name = "NombreBecas";
            // 
            // EntidadFinancieraBecas
            // 
            this.EntidadFinancieraBecas.HeaderText = "Financiador";
            this.EntidadFinancieraBecas.Name = "EntidadFinancieraBecas";
            // 
            // FechaConvocatoriaBeca
            // 
            this.FechaConvocatoriaBeca.HeaderText = "Fecha de Convocatoria";
            this.FechaConvocatoriaBeca.Name = "FechaConvocatoriaBeca";
            // 
            // EspecialidadBeca
            // 
            this.EspecialidadBeca.HeaderText = "Especialidad";
            this.EspecialidadBeca.Name = "EspecialidadBeca";
            // 
            // SeleccionarBecas
            // 
            this.SeleccionarBecas.HeaderText = "Seleccionar Becas";
            this.SeleccionarBecas.Name = "SeleccionarBecas";
            this.SeleccionarBecas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SeleccionarBecas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // BuscarBeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvBuscarBecas);
            this.Name = "BuscarBeca";
            this.Text = "BuscarBeca";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarBecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarBecas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntidadFinancieraBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoriaBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadBeca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeleccionarBecas;
    }
}