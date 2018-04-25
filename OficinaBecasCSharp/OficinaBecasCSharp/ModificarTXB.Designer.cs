namespace Vista
{
    partial class ModificarTXB
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
            this.GBTutorMTXB = new System.Windows.Forms.GroupBox();
            this.CBTutorMTXB = new System.Windows.Forms.ComboBox();
            this.btnCancelarNT = new System.Windows.Forms.Button();
            this.btnAceptarNT = new System.Windows.Forms.Button();
            this.GBEditarBecarioMTXB = new System.Windows.Forms.GroupBox();
            this.txtApBecMTXB = new System.Windows.Forms.TextBox();
            this.txtNombBecMTXB = new System.Windows.Forms.TextBox();
            this.txtCodBecEBMTXB = new System.Windows.Forms.TextBox();
            this.LApeBecMTXB = new System.Windows.Forms.Label();
            this.LNombreBecMTXB = new System.Windows.Forms.Label();
            this.LCodigoBecEBMTXB = new System.Windows.Forms.Label();
            this.GBTutorMTXB.SuspendLayout();
            this.GBEditarBecarioMTXB.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBTutorMTXB
            // 
            this.GBTutorMTXB.Controls.Add(this.CBTutorMTXB);
            this.GBTutorMTXB.Location = new System.Drawing.Point(22, 178);
            this.GBTutorMTXB.Name = "GBTutorMTXB";
            this.GBTutorMTXB.Size = new System.Drawing.Size(301, 57);
            this.GBTutorMTXB.TabIndex = 8;
            this.GBTutorMTXB.TabStop = false;
            this.GBTutorMTXB.Text = "Tutor Asignado";
            // 
            // CBTutorMTXB
            // 
            this.CBTutorMTXB.FormattingEnabled = true;
            this.CBTutorMTXB.Items.AddRange(new object[] {
            "Tutor 1",
            "Tutor 2",
            "Tutor 3",
            "Tutor 4"});
            this.CBTutorMTXB.Location = new System.Drawing.Point(65, 20);
            this.CBTutorMTXB.Name = "CBTutorMTXB";
            this.CBTutorMTXB.Size = new System.Drawing.Size(121, 21);
            this.CBTutorMTXB.TabIndex = 0;
            this.CBTutorMTXB.SelectedIndexChanged += new System.EventHandler(this.CBTutorMTXB_SelectedIndexChanged);
            // 
            // btnCancelarNT
            // 
            this.btnCancelarNT.Location = new System.Drawing.Point(248, 253);
            this.btnCancelarNT.Name = "btnCancelarNT";
            this.btnCancelarNT.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNT.TabIndex = 7;
            this.btnCancelarNT.Text = "Cancelar";
            this.btnCancelarNT.UseVisualStyleBackColor = true;
            this.btnCancelarNT.Click += new System.EventHandler(this.btnCancelarNT_Click);
            // 
            // btnAceptarNT
            // 
            this.btnAceptarNT.Location = new System.Drawing.Point(167, 253);
            this.btnAceptarNT.Name = "btnAceptarNT";
            this.btnAceptarNT.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNT.TabIndex = 6;
            this.btnAceptarNT.Text = "Aceptar";
            this.btnAceptarNT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarNT.UseVisualStyleBackColor = true;
            this.btnAceptarNT.Click += new System.EventHandler(this.btnAceptarNT_Click);
            // 
            // GBEditarBecarioMTXB
            // 
            this.GBEditarBecarioMTXB.Controls.Add(this.txtApBecMTXB);
            this.GBEditarBecarioMTXB.Controls.Add(this.txtNombBecMTXB);
            this.GBEditarBecarioMTXB.Controls.Add(this.txtCodBecEBMTXB);
            this.GBEditarBecarioMTXB.Controls.Add(this.LApeBecMTXB);
            this.GBEditarBecarioMTXB.Controls.Add(this.LNombreBecMTXB);
            this.GBEditarBecarioMTXB.Controls.Add(this.LCodigoBecEBMTXB);
            this.GBEditarBecarioMTXB.Location = new System.Drawing.Point(22, 29);
            this.GBEditarBecarioMTXB.Name = "GBEditarBecarioMTXB";
            this.GBEditarBecarioMTXB.Size = new System.Drawing.Size(301, 143);
            this.GBEditarBecarioMTXB.TabIndex = 5;
            this.GBEditarBecarioMTXB.TabStop = false;
            this.GBEditarBecarioMTXB.Text = "Datos Principales";
            // 
            // txtApBecMTXB
            // 
            this.txtApBecMTXB.Location = new System.Drawing.Point(65, 101);
            this.txtApBecMTXB.Name = "txtApBecMTXB";
            this.txtApBecMTXB.Size = new System.Drawing.Size(230, 20);
            this.txtApBecMTXB.TabIndex = 5;
            // 
            // txtNombBecMTXB
            // 
            this.txtNombBecMTXB.Location = new System.Drawing.Point(65, 64);
            this.txtNombBecMTXB.Name = "txtNombBecMTXB";
            this.txtNombBecMTXB.Size = new System.Drawing.Size(230, 20);
            this.txtNombBecMTXB.TabIndex = 4;
            // 
            // txtCodBecEBMTXB
            // 
            this.txtCodBecEBMTXB.Location = new System.Drawing.Point(65, 27);
            this.txtCodBecEBMTXB.Name = "txtCodBecEBMTXB";
            this.txtCodBecEBMTXB.Size = new System.Drawing.Size(117, 20);
            this.txtCodBecEBMTXB.TabIndex = 3;
            // 
            // LApeBecMTXB
            // 
            this.LApeBecMTXB.AutoSize = true;
            this.LApeBecMTXB.Location = new System.Drawing.Point(6, 109);
            this.LApeBecMTXB.Name = "LApeBecMTXB";
            this.LApeBecMTXB.Size = new System.Drawing.Size(52, 13);
            this.LApeBecMTXB.TabIndex = 2;
            this.LApeBecMTXB.Text = "Apellidos:";
            // 
            // LNombreBecMTXB
            // 
            this.LNombreBecMTXB.AutoSize = true;
            this.LNombreBecMTXB.Location = new System.Drawing.Point(6, 71);
            this.LNombreBecMTXB.Name = "LNombreBecMTXB";
            this.LNombreBecMTXB.Size = new System.Drawing.Size(47, 13);
            this.LNombreBecMTXB.TabIndex = 1;
            this.LNombreBecMTXB.Text = "Nombre:";
            // 
            // LCodigoBecEBMTXB
            // 
            this.LCodigoBecEBMTXB.AutoSize = true;
            this.LCodigoBecEBMTXB.Location = new System.Drawing.Point(6, 34);
            this.LCodigoBecEBMTXB.Name = "LCodigoBecEBMTXB";
            this.LCodigoBecEBMTXB.Size = new System.Drawing.Size(43, 13);
            this.LCodigoBecEBMTXB.TabIndex = 0;
            this.LCodigoBecEBMTXB.Text = "Codigo:";
            // 
            // ModificarTXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 304);
            this.Controls.Add(this.GBTutorMTXB);
            this.Controls.Add(this.btnCancelarNT);
            this.Controls.Add(this.btnAceptarNT);
            this.Controls.Add(this.GBEditarBecarioMTXB);
            this.Name = "ModificarTXB";
            this.Text = "Modificar Tutor de Becado";
            this.GBTutorMTXB.ResumeLayout(false);
            this.GBEditarBecarioMTXB.ResumeLayout(false);
            this.GBEditarBecarioMTXB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBTutorMTXB;
        private System.Windows.Forms.ComboBox CBTutorMTXB;
        private System.Windows.Forms.Button btnCancelarNT;
        private System.Windows.Forms.Button btnAceptarNT;
        private System.Windows.Forms.GroupBox GBEditarBecarioMTXB;
        private System.Windows.Forms.TextBox txtApBecMTXB;
        private System.Windows.Forms.TextBox txtNombBecMTXB;
        private System.Windows.Forms.TextBox txtCodBecEBMTXB;
        private System.Windows.Forms.Label LApeBecMTXB;
        private System.Windows.Forms.Label LNombreBecMTXB;
        private System.Windows.Forms.Label LCodigoBecEBMTXB;
    }
}