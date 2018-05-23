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
            this.panelConsultarEmails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultarEmails)).BeginInit();
            this.SuspendLayout();
            // 
            // panelConsultarEmails
            // 
            this.panelConsultarEmails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelConsultarEmails.Controls.Add(this.groupBox1);
            this.panelConsultarEmails.Controls.Add(this.btnDescargarEmails);
            this.panelConsultarEmails.Controls.Add(this.lblEmails);
            this.panelConsultarEmails.Controls.Add(this.lblCiclo);
            this.panelConsultarEmails.Controls.Add(this.lblConsultarEmails);
            this.panelConsultarEmails.Controls.Add(this.button1);
            this.panelConsultarEmails.Controls.Add(this.dgvConsultarEmails);
            this.panelConsultarEmails.Controls.Add(this.textBox2);
            this.panelConsultarEmails.Location = new System.Drawing.Point(0, -1);
            this.panelConsultarEmails.Name = "panelConsultarEmails";
            this.panelConsultarEmails.Size = new System.Drawing.Size(799, 454);
            this.panelConsultarEmails.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.cbEspecialidad);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.lblEspecialidad);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 187);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros";
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(16, 53);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 24);
            this.cbSexo.TabIndex = 16;
            // 
            // cbEspecialidad
            // 
            this.cbEspecialidad.FormattingEnabled = true;
            this.cbEspecialidad.Location = new System.Drawing.Point(16, 108);
            this.cbEspecialidad.Name = "cbEspecialidad";
            this.cbEspecialidad.Size = new System.Drawing.Size(121, 24);
            this.cbEspecialidad.TabIndex = 14;
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
            this.btnDescargarEmails.Location = new System.Drawing.Point(625, 392);
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
            this.lblEmails.Size = new System.Drawing.Size(253, 20);
            this.lblEmails.TabIndex = 17;
            this.lblEmails.Text = "Consultar correos electrónicos";
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
            this.lblConsultarEmails.Location = new System.Drawing.Point(638, 74);
            this.lblConsultarEmails.Name = "lblConsultarEmails";
            this.lblConsultarEmails.Size = new System.Drawing.Size(86, 13);
            this.lblConsultarEmails.TabIndex = 6;
            this.lblConsultarEmails.Text = "Ejemplo: 201801";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 64);
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
            this.dgvConsultarEmails.Size = new System.Drawing.Size(594, 263);
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
            // frmConsultarCorreos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosConsultarEmails;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailConsultarEmails;
        private System.Windows.Forms.TextBox textBox2;
    }
}