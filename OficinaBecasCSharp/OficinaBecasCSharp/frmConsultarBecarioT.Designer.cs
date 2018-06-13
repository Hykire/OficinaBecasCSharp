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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorreoPUCP = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombreBecario = new System.Windows.Forms.TextBox();
            this.lvlBecario = new System.Windows.Forms.Label();
            this.lblCodBecario = new System.Windows.Forms.Label();
            this.btnBuscarBecario = new System.Windows.Forms.Button();
            this.dgvBecarios = new System.Windows.Forms.DataGridView();
            this.NombreBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPUCPBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BecarioActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodBecario = new System.Windows.Forms.TextBox();
            this.panelConsultarBecario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarBecario
            // 
            this.panelConsultarBecario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarBecario.Controls.Add(this.label2);
            this.panelConsultarBecario.Controls.Add(this.label4);
            this.panelConsultarBecario.Controls.Add(this.label5);
            this.panelConsultarBecario.Controls.Add(this.txtCodigo);
            this.panelConsultarBecario.Controls.Add(this.txtCorreoPUCP);
            this.panelConsultarBecario.Controls.Add(this.txtNombreBecario);
            this.panelConsultarBecario.Controls.Add(this.lvlBecario);
            this.panelConsultarBecario.Controls.Add(this.label3);
            this.panelConsultarBecario.Controls.Add(this.lblCodBecario);
            this.panelConsultarBecario.Controls.Add(this.btnBuscarBecario);
            this.panelConsultarBecario.Controls.Add(this.dgvBecarios);
            this.panelConsultarBecario.Controls.Add(this.txtApellidos);
            this.panelConsultarBecario.Controls.Add(this.txtCodBecario);
            this.panelConsultarBecario.Location = new System.Drawing.Point(12, 12);
            this.panelConsultarBecario.Name = "panelConsultarBecario";
            this.panelConsultarBecario.Size = new System.Drawing.Size(701, 541);
            this.panelConsultarBecario.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Correo PUCP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombres";
            // 
            // txtCorreoPUCP
            // 
            this.txtCorreoPUCP.Enabled = false;
            this.txtCorreoPUCP.Location = new System.Drawing.Point(406, 448);
            this.txtCorreoPUCP.Name = "txtCorreoPUCP";
            this.txtCorreoPUCP.Size = new System.Drawing.Size(206, 20);
            this.txtCorreoPUCP.TabIndex = 31;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(406, 403);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(115, 20);
            this.txtApellidos.TabIndex = 30;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(85, 444);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(193, 20);
            this.txtCodigo.TabIndex = 29;
            // 
            // txtNombreBecario
            // 
            this.txtNombreBecario.Enabled = false;
            this.txtNombreBecario.Location = new System.Drawing.Point(85, 399);
            this.txtNombreBecario.Name = "txtNombreBecario";
            this.txtNombreBecario.Size = new System.Drawing.Size(193, 20);
            this.txtNombreBecario.TabIndex = 28;
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
            this.lblCodBecario.Location = new System.Drawing.Point(20, 41);
            this.lblCodBecario.Name = "lblCodBecario";
            this.lblCodBecario.Size = new System.Drawing.Size(93, 13);
            this.lblCodBecario.TabIndex = 6;
            this.lblCodBecario.Text = "Código de becario";
            // 
            // btnBuscarBecario
            // 
            this.btnBuscarBecario.Location = new System.Drawing.Point(566, 57);
            this.btnBuscarBecario.Name = "btnBuscarBecario";
            this.btnBuscarBecario.Size = new System.Drawing.Size(112, 23);
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
            this.dgvBecarios.Location = new System.Drawing.Point(23, 96);
            this.dgvBecarios.Name = "dgvBecarios";
            this.dgvBecarios.ReadOnly = true;
            this.dgvBecarios.Size = new System.Drawing.Size(655, 269);
            this.dgvBecarios.TabIndex = 3;
            this.dgvBecarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBecarios_CellClick);
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
            // txtCodBecario
            // 
            this.txtCodBecario.Location = new System.Drawing.Point(23, 57);
            this.txtCodBecario.Name = "txtCodBecario";
            this.txtCodBecario.Size = new System.Drawing.Size(497, 20);
            this.txtCodBecario.TabIndex = 1;
            // 
            // frmConsultarBecarioT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 565);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCorreoPUCP;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombreBecario;
    }
}