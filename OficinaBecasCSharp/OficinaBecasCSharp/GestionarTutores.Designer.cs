namespace Vista
{
    partial class GestionarTutores
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
            this.panelBecariosXTutor = new System.Windows.Forms.Panel();
            this.btnBuscarBecadoGBXT = new System.Windows.Forms.Button();
            this.LBXA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LGestBecXTutBXT = new System.Windows.Forms.Label();
            this.LNotaTXB = new System.Windows.Forms.Label();
            this.btnModificarTXB = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNombTutorBXT = new System.Windows.Forms.TextBox();
            this.TxtCodTutorBXT = new System.Windows.Forms.TextBox();
            this.LNombTutor = new System.Windows.Forms.Label();
            this.LCodTutor = new System.Windows.Forms.Label();
            this.btnBXTVer = new System.Windows.Forms.Button();
            this.LSelecTutor = new System.Windows.Forms.Label();
            this.CBTutorGBXT = new System.Windows.Forms.ComboBox();
            this.DGVBXT = new System.Windows.Forms.DataGridView();
            this.C1BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBXTAnadir = new System.Windows.Forms.Button();
            this.panelBecariosXTutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBXT)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBecariosXTutor
            // 
            this.panelBecariosXTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelBecariosXTutor.AutoSize = true;
            this.panelBecariosXTutor.Controls.Add(this.btnBuscarBecadoGBXT);
            this.panelBecariosXTutor.Controls.Add(this.LBXA);
            this.panelBecariosXTutor.Controls.Add(this.textBox1);
            this.panelBecariosXTutor.Controls.Add(this.LGestBecXTutBXT);
            this.panelBecariosXTutor.Controls.Add(this.LNotaTXB);
            this.panelBecariosXTutor.Controls.Add(this.btnModificarTXB);
            this.panelBecariosXTutor.Controls.Add(this.groupBox1);
            this.panelBecariosXTutor.Controls.Add(this.DGVBXT);
            this.panelBecariosXTutor.Controls.Add(this.btnBXTAnadir);
            this.panelBecariosXTutor.Location = new System.Drawing.Point(0, -2);
            this.panelBecariosXTutor.Name = "panelBecariosXTutor";
            this.panelBecariosXTutor.Size = new System.Drawing.Size(804, 445);
            this.panelBecariosXTutor.TabIndex = 6;
            // 
            // btnBuscarBecadoGBXT
            // 
            this.btnBuscarBecadoGBXT.Location = new System.Drawing.Point(438, 56);
            this.btnBuscarBecadoGBXT.Name = "btnBuscarBecadoGBXT";
            this.btnBuscarBecadoGBXT.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarBecadoGBXT.TabIndex = 13;
            this.btnBuscarBecadoGBXT.Text = "Buscar";
            this.btnBuscarBecadoGBXT.UseVisualStyleBackColor = true;
            // 
            // LBXA
            // 
            this.LBXA.AutoSize = true;
            this.LBXA.Location = new System.Drawing.Point(24, 61);
            this.LBXA.Name = "LBXA";
            this.LBXA.Size = new System.Drawing.Size(98, 13);
            this.LBXA.TabIndex = 12;
            this.LBXA.Text = "Buscar por alumno:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(128, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 11;
            // 
            // LGestBecXTutBXT
            // 
            this.LGestBecXTutBXT.AutoSize = true;
            this.LGestBecXTutBXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestBecXTutBXT.Location = new System.Drawing.Point(10, 13);
            this.LGestBecXTutBXT.Name = "LGestBecXTutBXT";
            this.LGestBecXTutBXT.Size = new System.Drawing.Size(241, 20);
            this.LGestBecXTutBXT.TabIndex = 10;
            this.LGestBecXTutBXT.Text = "Gestionar Becarios por Tutor";
            // 
            // LNotaTXB
            // 
            this.LNotaTXB.AutoSize = true;
            this.LNotaTXB.Location = new System.Drawing.Point(354, 136);
            this.LNotaTXB.Name = "LNotaTXB";
            this.LNotaTXB.Size = new System.Drawing.Size(226, 26);
            this.LNotaTXB.TabIndex = 9;
            this.LNotaTXB.Text = "Para modificar el Tutor de un Becario\r\nseleccionar una fila y hacer clic en \"Modi" +
    "ficar\"";
            // 
            // btnModificarTXB
            // 
            this.btnModificarTXB.Location = new System.Drawing.Point(693, 366);
            this.btnModificarTXB.Name = "btnModificarTXB";
            this.btnModificarTXB.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTXB.TabIndex = 8;
            this.btnModificarTXB.Text = "Modificar";
            this.btnModificarTXB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNombTutorBXT);
            this.groupBox1.Controls.Add(this.TxtCodTutorBXT);
            this.groupBox1.Controls.Add(this.LNombTutor);
            this.groupBox1.Controls.Add(this.LCodTutor);
            this.groupBox1.Controls.Add(this.btnBXTVer);
            this.groupBox1.Controls.Add(this.LSelecTutor);
            this.groupBox1.Controls.Add(this.CBTutorGBXT);
            this.groupBox1.Location = new System.Drawing.Point(21, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 267);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Tutor:";
            // 
            // TxtNombTutorBXT
            // 
            this.TxtNombTutorBXT.Enabled = false;
            this.TxtNombTutorBXT.Location = new System.Drawing.Point(65, 140);
            this.TxtNombTutorBXT.Name = "TxtNombTutorBXT";
            this.TxtNombTutorBXT.Size = new System.Drawing.Size(207, 20);
            this.TxtNombTutorBXT.TabIndex = 5;
            // 
            // TxtCodTutorBXT
            // 
            this.TxtCodTutorBXT.Enabled = false;
            this.TxtCodTutorBXT.Location = new System.Drawing.Point(65, 103);
            this.TxtCodTutorBXT.Name = "TxtCodTutorBXT";
            this.TxtCodTutorBXT.Size = new System.Drawing.Size(128, 20);
            this.TxtCodTutorBXT.TabIndex = 4;
            // 
            // LNombTutor
            // 
            this.LNombTutor.AutoSize = true;
            this.LNombTutor.Location = new System.Drawing.Point(8, 143);
            this.LNombTutor.Name = "LNombTutor";
            this.LNombTutor.Size = new System.Drawing.Size(47, 13);
            this.LNombTutor.TabIndex = 3;
            this.LNombTutor.Text = "Nombre:";
            // 
            // LCodTutor
            // 
            this.LCodTutor.AutoSize = true;
            this.LCodTutor.Location = new System.Drawing.Point(12, 104);
            this.LCodTutor.Name = "LCodTutor";
            this.LCodTutor.Size = new System.Drawing.Size(43, 13);
            this.LCodTutor.TabIndex = 2;
            this.LCodTutor.Text = "Código:";
            // 
            // btnBXTVer
            // 
            this.btnBXTVer.Location = new System.Drawing.Point(169, 212);
            this.btnBXTVer.Name = "btnBXTVer";
            this.btnBXTVer.Size = new System.Drawing.Size(103, 23);
            this.btnBXTVer.TabIndex = 1;
            this.btnBXTVer.Text = "Ver Becarios";
            this.btnBXTVer.UseVisualStyleBackColor = true;
            // 
            // LSelecTutor
            // 
            this.LSelecTutor.AutoSize = true;
            this.LSelecTutor.Location = new System.Drawing.Point(7, 28);
            this.LSelecTutor.Name = "LSelecTutor";
            this.LSelecTutor.Size = new System.Drawing.Size(91, 13);
            this.LSelecTutor.TabIndex = 7;
            this.LSelecTutor.Text = "Seleccionar Tutor";
            // 
            // CBTutorGBXT
            // 
            this.CBTutorGBXT.FormattingEnabled = true;
            this.CBTutorGBXT.Items.AddRange(new object[] {
            "Seleccionar",
            "Tutor 1",
            "Tutor 2",
            "Tutor 3"});
            this.CBTutorGBXT.Location = new System.Drawing.Point(12, 56);
            this.CBTutorGBXT.Name = "CBTutorGBXT";
            this.CBTutorGBXT.Size = new System.Drawing.Size(260, 21);
            this.CBTutorGBXT.TabIndex = 6;
            // 
            // DGVBXT
            // 
            this.DGVBXT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBXT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BXT,
            this.C2BXT,
            this.C3BXT,
            this.C4BXT});
            this.DGVBXT.Location = new System.Drawing.Point(357, 174);
            this.DGVBXT.Name = "DGVBXT";
            this.DGVBXT.Size = new System.Drawing.Size(420, 150);
            this.DGVBXT.TabIndex = 4;
            // 
            // C1BXT
            // 
            this.C1BXT.HeaderText = "Codigo";
            this.C1BXT.Name = "C1BXT";
            // 
            // C2BXT
            // 
            this.C2BXT.HeaderText = "Nombre";
            this.C2BXT.Name = "C2BXT";
            // 
            // C3BXT
            // 
            this.C3BXT.HeaderText = "Apellidos";
            this.C3BXT.Name = "C3BXT";
            // 
            // C4BXT
            // 
            this.C4BXT.HeaderText = "Correo Electronico";
            this.C4BXT.Name = "C4BXT";
            // 
            // btnBXTAnadir
            // 
            this.btnBXTAnadir.Location = new System.Drawing.Point(563, 369);
            this.btnBXTAnadir.Name = "btnBXTAnadir";
            this.btnBXTAnadir.Size = new System.Drawing.Size(100, 23);
            this.btnBXTAnadir.TabIndex = 0;
            this.btnBXTAnadir.Text = "Añadir Becario\r\n";
            this.btnBXTAnadir.UseVisualStyleBackColor = true;
            this.btnBXTAnadir.Click += new System.EventHandler(this.btnBXTAnadir_Click_1);
            // 
            // GestionarTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 441);
            this.Controls.Add(this.panelBecariosXTutor);
            this.Name = "GestionarTutores";
            this.Text = "GestionarTutores";
            this.Load += new System.EventHandler(this.GestionarTutores_Load);
            this.panelBecariosXTutor.ResumeLayout(false);
            this.panelBecariosXTutor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBXT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelBecariosXTutor;
        private System.Windows.Forms.Button btnBuscarBecadoGBXT;
        private System.Windows.Forms.Label LBXA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LGestBecXTutBXT;
        private System.Windows.Forms.Label LNotaTXB;
        private System.Windows.Forms.Button btnModificarTXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtNombTutorBXT;
        private System.Windows.Forms.TextBox TxtCodTutorBXT;
        private System.Windows.Forms.Label LNombTutor;
        private System.Windows.Forms.Label LCodTutor;
        private System.Windows.Forms.Button btnBXTVer;
        private System.Windows.Forms.Label LSelecTutor;
        private System.Windows.Forms.ComboBox CBTutorGBXT;
        private System.Windows.Forms.DataGridView DGVBXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4BXT;
        private System.Windows.Forms.Button btnBXTAnadir;
    }
}