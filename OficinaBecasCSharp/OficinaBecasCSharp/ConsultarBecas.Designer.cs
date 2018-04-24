namespace Vista
{
    partial class ConsultarBecas
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
            this.btnConsultarEmails = new System.Windows.Forms.Button();
            this.btnConsultarBecario = new System.Windows.Forms.Button();
            this.btnConsultarBecas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBecasExternas = new System.Windows.Forms.Button();
            this.btnBecasPUCP = new System.Windows.Forms.Button();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.NombreBecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntidadFinancieraBecas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConvocatoriaBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EspecialidadBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarBecas = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsultarEmails
            // 
            this.btnConsultarEmails.Location = new System.Drawing.Point(14, 393);
            this.btnConsultarEmails.Name = "btnConsultarEmails";
            this.btnConsultarEmails.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarEmails.TabIndex = 2;
            this.btnConsultarEmails.Text = "Consultar Emails";
            this.btnConsultarEmails.UseVisualStyleBackColor = true;
            this.btnConsultarEmails.Click += new System.EventHandler(this.btnConsultarEmails_Click);
            // 
            // btnConsultarBecario
            // 
            this.btnConsultarBecario.Location = new System.Drawing.Point(14, 245);
            this.btnConsultarBecario.Name = "btnConsultarBecario";
            this.btnConsultarBecario.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarBecario.TabIndex = 1;
            this.btnConsultarBecario.Text = "Consultar Becario";
            this.btnConsultarBecario.UseVisualStyleBackColor = true;
            this.btnConsultarBecario.Click += new System.EventHandler(this.btnConsultarBecario_Click);
            // 
            // btnConsultarBecas
            // 
            this.btnConsultarBecas.Location = new System.Drawing.Point(14, 93);
            this.btnConsultarBecas.Name = "btnConsultarBecas";
            this.btnConsultarBecas.Size = new System.Drawing.Size(104, 23);
            this.btnConsultarBecas.TabIndex = 0;
            this.btnConsultarBecas.Text = "Consultar Becas";
            this.btnConsultarBecas.UseVisualStyleBackColor = true;
            this.btnConsultarBecas.Click += new System.EventHandler(this.btnConsultarBecas_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnBuscarBecas);
            this.panel1.Controls.Add(this.dgvBecas);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnBecasExternas);
            this.panel1.Controls.Add(this.btnBecasPUCP);
            this.panel1.Location = new System.Drawing.Point(183, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 499);
            this.panel1.TabIndex = 8;
            // 
            // btnBecasExternas
            // 
            this.btnBecasExternas.AutoSize = true;
            this.btnBecasExternas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasExternas.Location = new System.Drawing.Point(39, 198);
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
            this.btnBecasPUCP.Location = new System.Drawing.Point(39, 127);
            this.btnBecasPUCP.Name = "btnBecasPUCP";
            this.btnBecasPUCP.Size = new System.Drawing.Size(79, 23);
            this.btnBecasPUCP.TabIndex = 4;
            this.btnBecasPUCP.Text = "Becas PUCP";
            this.btnBecasPUCP.UseVisualStyleBackColor = true;
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
            this.dgvBecas.Location = new System.Drawing.Point(142, 93);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.Size = new System.Drawing.Size(568, 364);
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
            // btnBuscarBecas
            // 
            this.btnBuscarBecas.Location = new System.Drawing.Point(457, 54);
            this.btnBuscarBecas.Name = "btnBuscarBecas";
            this.btnBuscarBecas.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBecas.TabIndex = 2;
            this.btnBuscarBecas.Text = "Buscar";
            this.btnBuscarBecas.UseVisualStyleBackColor = true;
            this.btnBuscarBecas.Click += new System.EventHandler(this.btnBuscarBecas_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.btnConsultarEmails);
            this.panel2.Controls.Add(this.btnConsultarBecas);
            this.panel2.Controls.Add(this.btnConsultarBecario);
            this.panel2.Location = new System.Drawing.Point(22, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 499);
            this.panel2.TabIndex = 10;
            // 
            // ConsultarBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 609);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "ConsultarBecas";
            this.Text = "ConsultarBecas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarEmails;
        private System.Windows.Forms.Button btnConsultarBecario;
        private System.Windows.Forms.Button btnConsultarBecas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBecasExternas;
        private System.Windows.Forms.Button btnBecasPUCP;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntidadFinancieraBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoriaBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadBeca;
        private System.Windows.Forms.Button btnBuscarBecas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}