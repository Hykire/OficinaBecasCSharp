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
            this.panelConsultarEmails = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnDescargarEmails = new System.Windows.Forms.Button();
            this.lblEmails = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblConsultarEmails = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvConsultarEmails = new System.Windows.Forms.DataGridView();
            this.nombreConsultarEmails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosConsultarEmails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailConsultarEmails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panelConsultarBecario = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelConsultarBecas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            this.panelConsultarEmails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmails)).BeginInit();
            this.panelConsultarBecario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecarios)).BeginInit();
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
            // panelConsultarBecas
            // 
            this.panelConsultarBecas.Controls.Add(this.label1);
            this.panelConsultarBecas.Controls.Add(this.lblNombreBeca);
            this.panelConsultarBecas.Controls.Add(this.btnBuscarBecas);
            this.panelConsultarBecas.Controls.Add(this.dgvBecas);
            this.panelConsultarBecas.Controls.Add(this.textBox1);
            this.panelConsultarBecas.Controls.Add(this.btnBecasExternas);
            this.panelConsultarBecas.Controls.Add(this.btnBecasPUCP);
            this.panelConsultarBecas.Location = new System.Drawing.Point(166, 97);
            this.panelConsultarBecas.Name = "panelConsultarBecas";
            this.panelConsultarBecas.Size = new System.Drawing.Size(679, 487);
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
            this.dgvBecas.Size = new System.Drawing.Size(474, 352);
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
            // panelConsultarEmails
            // 
            this.panelConsultarEmails.Controls.Add(this.groupBox1);
            this.panelConsultarEmails.Controls.Add(this.btnDescargarEmails);
            this.panelConsultarEmails.Controls.Add(this.lblEmails);
            this.panelConsultarEmails.Controls.Add(this.lblCiclo);
            this.panelConsultarEmails.Controls.Add(this.lblConsultarEmails);
            this.panelConsultarEmails.Controls.Add(this.button1);
            this.panelConsultarEmails.Controls.Add(this.dgvConsultarEmails);
            this.panelConsultarEmails.Controls.Add(this.textBox2);
            this.panelConsultarEmails.Location = new System.Drawing.Point(166, 97);
            this.panelConsultarEmails.Name = "panelConsultarEmails";
            this.panelConsultarEmails.Size = new System.Drawing.Size(679, 487);
            this.panelConsultarEmails.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.cbEspecialidad);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 296);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(6, 49);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 16;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(6, 104);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 24);
            this.cbEspecialidad.TabIndex = 14;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(5, 33);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(6, 88);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 15;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // btnDescargarEmails
            // 
            this.btnDescargarEmails.Location = new System.Drawing.Point(505, 422);
            this.btnDescargarEmails.Name = "btnDescargarEmails";
            this.btnDescargarEmails.Size = new System.Drawing.Size(153, 23);
            this.btnDescargarEmails.TabIndex = 18;
            this.btnDescargarEmails.Text = "Descargar Emails";
            this.btnDescargarEmails.UseVisualStyleBackColor = true;
            // 
            // lblEmails
            // 
            this.lblEmails.AutoSize = true;
            this.lblEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmails.Location = new System.Drawing.Point(27, 18);
            this.lblEmails.Name = "lblEmails";
            this.lblEmails.Size = new System.Drawing.Size(144, 20);
            this.lblEmails.TabIndex = 17;
            this.lblEmails.Text = "Consultar Emails";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(184, 71);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(33, 13);
            this.lblCiclo.TabIndex = 7;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // lblConsultarEmails
            // 
            this.lblConsultarEmails.AutoSize = true;
            this.lblConsultarEmails.Location = new System.Drawing.Point(233, 42);
            this.lblConsultarEmails.Name = "lblConsultarEmails";
            this.lblConsultarEmails.Size = new System.Drawing.Size(86, 13);
            this.lblConsultarEmails.TabIndex = 6;
            this.lblConsultarEmails.Text = "Ejemplo: 201801";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvConsultarEmails
            // 
            this.dgvConsultarEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreConsultarEmails,
            this.apellidosConsultarEmails,
            this.emailConsultarEmails});
            this.dgvConsultarEmails.Location = new System.Drawing.Point(184, 103);
            this.dgvConsultarEmails.Name = "dgvConsultarEmails";
            this.dgvConsultarEmails.Size = new System.Drawing.Size(474, 296);
            this.dgvConsultarEmails.TabIndex = 3;
            // 
            // nombreConsultarEmails
            // 
            this.nombreConsultarEmails.HeaderText = "Nombres";
            this.nombreConsultarEmails.Name = "nombreConsultarEmails";
            // 
            // apellidosConsultarEmails
            // 
            this.apellidosConsultarEmails.HeaderText = "Apellidos";
            this.apellidosConsultarEmails.Name = "apellidosConsultarEmails";
            // 
            // emailConsultarEmails
            // 
            this.emailConsultarEmails.HeaderText = "Correo Electrónico";
            this.emailConsultarEmails.Name = "emailConsultarEmails";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(236, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 20);
            this.textBox2.TabIndex = 1;
            // 
            // panelConsultarBecario
            // 
            this.panelConsultarBecario.Controls.Add(this.lvlBecario);
            this.panelConsultarBecario.Controls.Add(this.lblCodBecario);
            this.panelConsultarBecario.Controls.Add(this.btnBuscarBecario);
            this.panelConsultarBecario.Controls.Add(this.dgvBecarios);
            this.panelConsultarBecario.Controls.Add(this.txtCodBecario);
            this.panelConsultarBecario.Location = new System.Drawing.Point(166, 97);
            this.panelConsultarBecario.Name = "panelConsultarBecario";
            this.panelConsultarBecario.Size = new System.Drawing.Size(679, 487);
            this.panelConsultarBecario.TabIndex = 12;
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
            this.btnBuscarBecario.Location = new System.Drawing.Point(457, 54);
            this.btnBuscarBecario.Name = "btnBuscarBecario";
            this.btnBuscarBecario.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBecario.TabIndex = 2;
            this.btnBuscarBecario.Text = "Buscar";
            this.btnBuscarBecario.UseVisualStyleBackColor = true;
            // 
            // dgvBecarios
            // 
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
            this.dgvBecarios.Size = new System.Drawing.Size(474, 352);
            this.dgvBecarios.TabIndex = 3;
            // 
            // NombreBecario
            // 
            this.NombreBecario.HeaderText = "Nombres";
            this.NombreBecario.Name = "NombreBecario";
            // 
            // ApellidosBecario
            // 
            this.ApellidosBecario.HeaderText = "Apellidos";
            this.ApellidosBecario.Name = "ApellidosBecario";
            // 
            // codPUCPBecario
            // 
            this.codPUCPBecario.HeaderText = "Código PUCP";
            this.codPUCPBecario.Name = "codPUCPBecario";
            // 
            // sexoBecario
            // 
            this.sexoBecario.HeaderText = "Sexo";
            this.sexoBecario.Name = "sexoBecario";
            // 
            // correoBecario
            // 
            this.correoBecario.HeaderText = "Correo Electrónico";
            this.correoBecario.Name = "correoBecario";
            // 
            // BecarioActivo
            // 
            this.BecarioActivo.HeaderText = "Activo";
            this.BecarioActivo.Name = "BecarioActivo";
            // 
            // txtCodBecario
            // 
            this.txtCodBecario.Location = new System.Drawing.Point(142, 54);
            this.txtCodBecario.Name = "txtCodBecario";
            this.txtCodBecario.Size = new System.Drawing.Size(251, 20);
            this.txtCodBecario.TabIndex = 1;
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
            this.panel2.Size = new System.Drawing.Size(138, 639);
            this.panel2.TabIndex = 10;
            // 
            // ConsultarBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelConsultarBecas);
            this.Controls.Add(this.panelConsultarEmails);
            this.Controls.Add(this.panelConsultarBecario);
            this.IsMdiContainer = true;
            this.Name = "ConsultarBecas";
            this.Text = "ConsultarBecas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ConsultarBecas_Load);
            this.panelConsultarBecas.ResumeLayout(false);
            this.panelConsultarBecas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            this.panelConsultarEmails.ResumeLayout(false);
            this.panelConsultarEmails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmails)).EndInit();
            this.panelConsultarBecario.ResumeLayout(false);
            this.panelConsultarBecario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnConsultarEmails;
        private System.Windows.Forms.Button btnConsultarBecario;
        private System.Windows.Forms.Button btnConsultarBecas;
        private System.Windows.Forms.Panel panelConsultarBecas;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntidadFinancieraBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoriaBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn EspecialidadBeca;
        private System.Windows.Forms.Button btnBuscarBecas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblNombreBeca;
        private System.Windows.Forms.Button btnBecasExternas;
        private System.Windows.Forms.Button btnBecasPUCP;
        private System.Windows.Forms.Panel panelConsultarBecario;
        private System.Windows.Forms.Label lblCodBecario;
        private System.Windows.Forms.Button btnBuscarBecario;
        private System.Windows.Forms.DataGridView dgvBecarios;
        private System.Windows.Forms.TextBox txtCodBecario;
        private System.Windows.Forms.Panel panelConsultarEmails;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblConsultarEmails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailConsultarEmails;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEmails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lvlBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecas;
        private System.Windows.Forms.Button btnDescargarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPUCPBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BecarioActivo;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}