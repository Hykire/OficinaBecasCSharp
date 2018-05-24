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
            this.Nombre_beca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Financiador = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Nombre_beca,
            this.Descripcion,
            this.FechaConvocatoria,
            this.Financiador});
            this.dgvBuscarBecas.Location = new System.Drawing.Point(16, 53);
            this.dgvBuscarBecas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBuscarBecas.Name = "dgvBuscarBecas";
            this.dgvBuscarBecas.Size = new System.Drawing.Size(1016, 404);
            this.dgvBuscarBecas.TabIndex = 4;
            this.dgvBuscarBecas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarBecas_CellContentClick);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(880, 492);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(133, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(643, 492);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(136, 28);
            this.btnAñadir.TabIndex = 6;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // Nombre_beca
            // 
            this.Nombre_beca.DataPropertyName = "Nombre_beca";
            this.Nombre_beca.HeaderText = "Nombre de Becas";
            this.Nombre_beca.Name = "Nombre_beca";
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // FechaConvocatoria
            // 
            this.FechaConvocatoria.DataPropertyName = "FechaConvocatoria";
            this.FechaConvocatoria.HeaderText = "Fecha de Convocatoria";
            this.FechaConvocatoria.Name = "FechaConvocatoria";
            // 
            // Financiador
            // 
            this.Financiador.DataPropertyName = "Financiador";
            this.Financiador.HeaderText = "Financiador";
            this.Financiador.Name = "Financiador";
            // 
            // BuscarBeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvBuscarBecas);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BuscarBeca";
            this.Text = "BuscarBeca";
            this.Load += new System.EventHandler(this.BuscarBeca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarBecas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarBecas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_beca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Financiador;
    }
}