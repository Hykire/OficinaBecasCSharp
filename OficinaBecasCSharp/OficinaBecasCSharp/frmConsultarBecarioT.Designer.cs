namespace Vista
{
    partial class frmConsultarBecarioT
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
            this.panelConsultarBecario = new System.Windows.Forms.Panel();
            this.lvlBecario = new System.Windows.Forms.Label();
            this.lblCodBecario = new System.Windows.Forms.Label();
            this.btnBuscarBecario = new System.Windows.Forms.Button();
            this.dgvBecarios = new System.Windows.Forms.DataGridView();
            this.txtCodBecario = new System.Windows.Forms.TextBox();
            this.NombreBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPUCPBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BecarioActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelConsultarBecario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarBecario
            // 
            this.panelConsultarBecario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarBecario.Controls.Add(this.lvlBecario);
            this.panelConsultarBecario.Controls.Add(this.lblCodBecario);
            this.panelConsultarBecario.Controls.Add(this.btnBuscarBecario);
            this.panelConsultarBecario.Controls.Add(this.dgvBecarios);
            this.panelConsultarBecario.Controls.Add(this.txtCodBecario);
            this.panelConsultarBecario.Location = new System.Drawing.Point(0, 0);
            this.panelConsultarBecario.Name = "panelConsultarBecario";
            this.panelConsultarBecario.Size = new System.Drawing.Size(799, 450);
            this.panelConsultarBecario.TabIndex = 13;
            // 
            // lvlBecario
            // 
            this.lvlBecario.AutoSize = true;
            this.lvlBecario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlBecario.Location = new System.Drawing.Point(19, 12);
            this.lvlBecario.Name = "lvlBecario";
            this.lvlBecario.Size = new System.Drawing.Size(152, 20);
            this.lvlBecario.TabIndex = 18;
            this.lvlBecario.Text = "Consultar Becario";
            // 
            // lblCodBecario
            // 
            this.lblCodBecario.AutoSize = true;
            this.lblCodBecario.Location = new System.Drawing.Point(142, 35);
            this.lblCodBecario.Name = "lblCodBecario";
            this.lblCodBecario.Size = new System.Drawing.Size(93, 13);
            this.lblCodBecario.TabIndex = 6;
            this.lblCodBecario.Text = "Código de becario";
            // 
            // btnBuscarBecario
            // 
            this.btnBuscarBecario.Location = new System.Drawing.Point(661, 54);
            this.btnBuscarBecario.Name = "btnBuscarBecario";
            this.btnBuscarBecario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBecario.TabIndex = 2;
            this.btnBuscarBecario.Text = "Buscar";
            this.btnBuscarBecario.UseVisualStyleBackColor = true;
            this.btnBuscarBecario.Click += new System.EventHandler(this.btnBuscarBecario_Click);
            // 
            // dgvBecarios
            // 
            this.dgvBecarios.AllowUserToAddRows = false;
            this.dgvBecarios.AllowUserToDeleteRows = false;
            this.dgvBecarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBecarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBecario,
            this.ApellidosBecario,
            this.codPUCPBecario,
            this.sexoBecario,
            this.correoBecario,
            this.BecarioActivo});
            this.dgvBecarios.Location = new System.Drawing.Point(142, 93);
            this.dgvBecarios.Name = "dgvBecarios";
            this.dgvBecarios.ReadOnly = true;
            this.dgvBecarios.Size = new System.Drawing.Size(594, 315);
            this.dgvBecarios.TabIndex = 3;
            // 
            // txtCodBecario
            // 
            this.txtCodBecario.Location = new System.Drawing.Point(142, 54);
            this.txtCodBecario.Name = "txtCodBecario";
            this.txtCodBecario.Size = new System.Drawing.Size(341, 20);
            this.txtCodBecario.TabIndex = 1;
            // 
            // NombreBecario
            // 
            this.NombreBecario.DataPropertyName = "Nombres";
            this.NombreBecario.HeaderText = "Nombres";
            this.NombreBecario.Name = "NombreBecario";
            this.NombreBecario.ReadOnly = true;
            // 
            // ApellidosBecario
            // 
            this.ApellidosBecario.DataPropertyName = "Apellidos";
            this.ApellidosBecario.HeaderText = "Apellidos";
            this.ApellidosBecario.Name = "ApellidosBecario";
            this.ApellidosBecario.ReadOnly = true;
            // 
            // codPUCPBecario
            // 
            this.codPUCPBecario.DataPropertyName = "CodigoPUCP";
            this.codPUCPBecario.HeaderText = "Código PUCP";
            this.codPUCPBecario.Name = "codPUCPBecario";
            this.codPUCPBecario.ReadOnly = true;
            // 
            // sexoBecario
            // 
            this.sexoBecario.DataPropertyName = "Sexo";
            this.sexoBecario.HeaderText = "Sexo";
            this.sexoBecario.Name = "sexoBecario";
            this.sexoBecario.ReadOnly = true;
            // 
            // correoBecario
            // 
            this.correoBecario.DataPropertyName = "CorreoPUCP";
            this.correoBecario.HeaderText = "Correo Electrónico";
            this.correoBecario.Name = "correoBecario";
            this.correoBecario.ReadOnly = true;
            // 
            // BecarioActivo
            // 
            this.BecarioActivo.DataPropertyName = "Estado";
            this.BecarioActivo.HeaderText = "Activo";
            this.BecarioActivo.Name = "BecarioActivo";
            this.BecarioActivo.ReadOnly = true;
            // 
            // frmConsultarBecarioT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConsultarBecario);
            this.Name = "frmConsultarBecarioT";
            this.Text = "frmConsultarBecarioT";
            this.panelConsultarBecario.ResumeLayout(false);
            this.panelConsultarBecario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarBecario;
        private System.Windows.Forms.Label lvlBecario;
        private System.Windows.Forms.Label lblCodBecario;
        private System.Windows.Forms.Button btnBuscarBecario;
        private System.Windows.Forms.DataGridView dgvBecarios;
        private System.Windows.Forms.TextBox txtCodBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPUCPBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BecarioActivo;
    }
}