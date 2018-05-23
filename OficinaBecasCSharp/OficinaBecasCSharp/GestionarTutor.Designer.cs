namespace Vista
{
    partial class GestionarTutor
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
            this.panelConsultarBecas = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreBeca = new System.Windows.Forms.Label();
            this.btnBuscarBecas = new System.Windows.Forms.Button();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.NombreBecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntidadFinancieraBecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConvocatoriaBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBecasExternas = new System.Windows.Forms.Button();
            this.btnBecasPUCP = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelConsultarBecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelConsultarBecas
            // 
            this.panelConsultarBecas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarBecas.Controls.Add(this.label1);
            this.panelConsultarBecas.Controls.Add(this.lblNombreBeca);
            this.panelConsultarBecas.Controls.Add(this.btnBuscarBecas);
            this.panelConsultarBecas.Controls.Add(this.dgvBecas);
            this.panelConsultarBecas.Controls.Add(this.textBox1);
            this.panelConsultarBecas.Controls.Add(this.btnBecasExternas);
            this.panelConsultarBecas.Controls.Add(this.btnBecasPUCP);
            this.panelConsultarBecas.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarBecas.Name = "panelConsultarBecas";
            this.panelConsultarBecas.Size = new System.Drawing.Size(804, 441);
            this.panelConsultarBecas.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Consultar Becas";
            // 
            // lblNombreBeca
            // 
            this.lblNombreBeca.AutoSize = true;
            this.lblNombreBeca.Location = new System.Drawing.Point(36, 45);
            this.lblNombreBeca.Name = "lblNombreBeca";
            this.lblNombreBeca.Size = new System.Drawing.Size(87, 13);
            this.lblNombreBeca.TabIndex = 6;
            this.lblNombreBeca.Text = "Nombre de Beca";
            // 
            // btnBuscarBecas
            // 
            this.btnBuscarBecas.Location = new System.Drawing.Point(457, 61);
            this.btnBuscarBecas.Name = "btnBuscarBecas";
            this.btnBuscarBecas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBecas.TabIndex = 2;
            this.btnBuscarBecas.Text = "Buscar";
            this.btnBuscarBecas.UseVisualStyleBackColor = true;
            this.btnBuscarBecas.Click += new System.EventHandler(this.btnBuscarBecas_Click);
            // 
            // dgvBecas
            // 
            this.dgvBecas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBecas,
            this.EntidadFinancieraBecas,
            this.FechaConvocatoriaBeca,
            this.EspecialidadBeca});
            this.dgvBecas.Location = new System.Drawing.Point(139, 103);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.Size = new System.Drawing.Size(650, 323);
            this.dgvBecas.TabIndex = 3;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnBecasExternas
            // 
            this.btnBecasExternas.AutoSize = true;
            this.btnBecasExternas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasExternas.Location = new System.Drawing.Point(36, 208);
            this.btnBecasExternas.Name = "btnBecasExternas";
            this.btnBecasExternas.Size = new System.Drawing.Size(91, 23);
            this.btnBecasExternas.TabIndex = 5;
            this.btnBecasExternas.Text = "Becas Externas";
            this.btnBecasExternas.UseVisualStyleBackColor = true;
            // 
            // btnBecasPUCP
            // 
            this.btnBecasPUCP.AutoSize = true;
            this.btnBecasPUCP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasPUCP.Location = new System.Drawing.Point(36, 136);
            this.btnBecasPUCP.Name = "btnBecasPUCP";
            this.btnBecasPUCP.Size = new System.Drawing.Size(79, 23);
            this.btnBecasPUCP.TabIndex = 4;
            this.btnBecasPUCP.Text = "Becas PUCP";
            this.btnBecasPUCP.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelConsultarBecas);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 441);
            this.panel2.TabIndex = 15;
            // 
            // GestionarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.panel2);
            this.Name = "GestionarTutor";
            this.Text = "Gestionar Tutor";
            this.panelConsultarBecas.ResumeLayout(false);
            this.panelConsultarBecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelConsultarBecas;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntidadFinancieraBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoriaBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadBeca;
        private System.Windows.Forms.Button btnBuscarBecas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblNombreBeca;
        private System.Windows.Forms.Button btnBecasExternas;
        private System.Windows.Forms.Button btnBecasPUCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecas;
        private System.Windows.Forms.Panel panel2;
    }
}