namespace Vista
{
    partial class frmConsultarCorreos
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
            this.panelConsultarEmails = new System.Windows.Forms.Panel();
            this.txtCorreosObtenidos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.btnDescargarEmails = new System.Windows.Forms.Button();
            this.lblEmails = new System.Windows.Forms.Label();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.lblConsultarEmails = new System.Windows.Forms.Label();
            this.btnBuscarCorreos = new System.Windows.Forms.Button();
            this.dgvConsultarEmails = new System.Windows.Forms.DataGridView();
            this.nombreConsultarEmails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosConsultarEmails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailConsultarEmails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoPUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCicloSolicitado = new System.Windows.Forms.TextBox();
            this.panelConsultarEmails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarEmails
            // 
            this.panelConsultarEmails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarEmails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConsultarEmails.Controls.Add(this.txtCorreosObtenidos);
            this.panelConsultarEmails.Controls.Add(this.groupBox1);
            this.panelConsultarEmails.Controls.Add(this.btnDescargarEmails);
            this.panelConsultarEmails.Controls.Add(this.lblEmails);
            this.panelConsultarEmails.Controls.Add(this.lblCiclo);
            this.panelConsultarEmails.Controls.Add(this.lblConsultarEmails);
            this.panelConsultarEmails.Controls.Add(this.btnBuscarCorreos);
            this.panelConsultarEmails.Controls.Add(this.dgvConsultarEmails);
            this.panelConsultarEmails.Controls.Add(this.txtCicloSolicitado);
            this.panelConsultarEmails.Location = new System.Drawing.Point(10, 17);
            this.panelConsultarEmails.Name = "panelConsultarEmails";
            this.panelConsultarEmails.Size = new System.Drawing.Size(740, 525);
            this.panelConsultarEmails.TabIndex = 14;
            // 
            // txtCorreosObtenidos
            // 
            this.txtCorreosObtenidos.Location = new System.Drawing.Point(41, 419);
            this.txtCorreosObtenidos.Multiline = true;
            this.txtCorreosObtenidos.Name = "txtCorreosObtenidos";
            this.txtCorreosObtenidos.Size = new System.Drawing.Size(200, 79);
            this.txtCorreosObtenidos.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFiltrar);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.cbEspecialidad);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 187);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(18, 156);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(119, 23);
            this.btnFiltrar.TabIndex = 17;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(16, 53);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 16;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.cbSexo_SelectedIndexChanged);
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(16, 108);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 24);
            this.cbEspecialidad.TabIndex = 14;
            this.cbEspecialidad.SelectedIndexChanged += new System.EventHandler(this.cbEspecialidad_SelectedIndexChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(15, 37);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(31, 13);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(16, 92);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(67, 13);
            this.lblEspecialidad.TabIndex = 15;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // btnDescargarEmails
            // 
            this.btnDescargarEmails.Location = new System.Drawing.Point(296, 453);
            this.btnDescargarEmails.Name = "btnDescargarEmails";
            this.btnDescargarEmails.Size = new System.Drawing.Size(141, 23);
            this.btnDescargarEmails.TabIndex = 18;
            this.btnDescargarEmails.Text = "Descargar Emails";
            this.btnDescargarEmails.UseVisualStyleBackColor = true;
            this.btnDescargarEmails.Click += new System.EventHandler(this.btnDescargarEmails_Click);
            // 
            // lblEmails
            // 
            this.lblEmails.AutoSize = true;
            this.lblEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmails.Location = new System.Drawing.Point(12, 10);
            this.lblEmails.Name = "lblEmails";
            this.lblEmails.Size = new System.Drawing.Size(253, 20);
            this.lblEmails.TabIndex = 17;
            this.lblEmails.Text = "Consultar correos electrónicos";
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Location = new System.Drawing.Point(194, 49);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(33, 13);
            this.lblCiclo.TabIndex = 7;
            this.lblCiclo.Text = "Ciclo:";
            // 
            // lblConsultarEmails
            // 
            this.lblConsultarEmails.AutoSize = true;
            this.lblConsultarEmails.Location = new System.Drawing.Point(648, 52);
            this.lblConsultarEmails.Name = "lblConsultarEmails";
            this.lblConsultarEmails.Size = new System.Drawing.Size(83, 13);
            this.lblConsultarEmails.TabIndex = 6;
            this.lblConsultarEmails.Text = "Ejemplo: 2018-1";
            // 
            // btnBuscarCorreos
            // 
            this.btnBuscarCorreos.Location = new System.Drawing.Point(537, 42);
            this.btnBuscarCorreos.Name = "btnBuscarCorreos";
            this.btnBuscarCorreos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarCorreos.TabIndex = 2;
            this.btnBuscarCorreos.Text = "Buscar";
            this.btnBuscarCorreos.UseVisualStyleBackColor = true;
            this.btnBuscarCorreos.Click += new System.EventHandler(this.btnBuscarCorreos_Click);
            // 
            // dgvConsultarEmails
            // 
            this.dgvConsultarEmails.AllowUserToAddRows = false;
            this.dgvConsultarEmails.AllowUserToDeleteRows = false;
            this.dgvConsultarEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsultarEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultarEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreConsultarEmails,
            this.apellidosConsultarEmails,
            this.emailConsultarEmails,
            this.CodigoPUCP,
            this.Sex,
            this.nombEspecialidad});
            this.dgvConsultarEmails.Location = new System.Drawing.Point(194, 81);
            this.dgvConsultarEmails.Name = "dgvConsultarEmails";
            this.dgvConsultarEmails.ReadOnly = true;
            this.dgvConsultarEmails.Size = new System.Drawing.Size(533, 332);
            this.dgvConsultarEmails.TabIndex = 3;
            // 
            // nombreConsultarEmails
            // 
            this.nombreConsultarEmails.DataPropertyName = "Nombres";
            this.nombreConsultarEmails.HeaderText = "Nombres";
            this.nombreConsultarEmails.Name = "nombreConsultarEmails";
            this.nombreConsultarEmails.ReadOnly = true;
            // 
            // apellidosConsultarEmails
            // 
            this.apellidosConsultarEmails.DataPropertyName = "Apellidos";
            this.apellidosConsultarEmails.HeaderText = "Apellidos";
            this.apellidosConsultarEmails.Name = "apellidosConsultarEmails";
            this.apellidosConsultarEmails.ReadOnly = true;
            // 
            // emailConsultarEmails
            // 
            this.emailConsultarEmails.DataPropertyName = "CorreoPUCP";
            this.emailConsultarEmails.HeaderText = "Correo Electrónico";
            this.emailConsultarEmails.Name = "emailConsultarEmails";
            this.emailConsultarEmails.ReadOnly = true;
            // 
            // CodigoPUCP
            // 
            this.CodigoPUCP.DataPropertyName = "CodigoPUCP";
            this.CodigoPUCP.HeaderText = "Codigo PUCP";
            this.CodigoPUCP.Name = "CodigoPUCP";
            this.CodigoPUCP.ReadOnly = true;
            // 
            // Sex
            // 
            this.Sex.DataPropertyName = "Sexo";
            this.Sex.HeaderText = "Sexo";
            this.Sex.Name = "Sex";
            this.Sex.ReadOnly = true;
            // 
            // nombEspecialidad
            // 
            this.nombEspecialidad.DataPropertyName = "NombreEspecialidad";
            this.nombEspecialidad.HeaderText = "Especialidad";
            this.nombEspecialidad.Name = "nombEspecialidad";
            this.nombEspecialidad.ReadOnly = true;
            // 
            // txtCicloSolicitado
            // 
            this.txtCicloSolicitado.Location = new System.Drawing.Point(246, 45);
            this.txtCicloSolicitado.Name = "txtCicloSolicitado";
            this.txtCicloSolicitado.Size = new System.Drawing.Size(251, 20);
            this.txtCicloSolicitado.TabIndex = 1;
            // 
            // frmConsultarCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 568);
            this.Controls.Add(this.panelConsultarEmails);
            this.Name = "frmConsultarCorreos";
            this.Text = "frmConsultarCorreos";
            this.panelConsultarEmails.ResumeLayout(false);
            this.panelConsultarEmails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelConsultarEmails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbEspecialidad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnDescargarEmails;
        private System.Windows.Forms.Label lblEmails;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.Label lblConsultarEmails;
        private System.Windows.Forms.Button btnBuscarCorreos;
        private System.Windows.Forms.DataGridView dgvConsultarEmails;
        private System.Windows.Forms.TextBox txtCicloSolicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombEspecialidad;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtCorreosObtenidos;
    }
}