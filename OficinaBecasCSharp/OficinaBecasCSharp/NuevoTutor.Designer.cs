namespace Vista
{
    partial class NuevoTutor
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
            this.LCodigoTutNT = new System.Windows.Forms.Label();
            this.GBNuevoTutorNT = new System.Windows.Forms.GroupBox();
            this.LNombreTutNT = new System.Windows.Forms.Label();
            this.LApeTutNT = new System.Windows.Forms.Label();
            this.txtCodNT = new System.Windows.Forms.TextBox();
            this.txtNombNT = new System.Windows.Forms.TextBox();
            this.txtApNT = new System.Windows.Forms.TextBox();
            this.btnAceptarNT = new System.Windows.Forms.Button();
            this.btnCancelarNT = new System.Windows.Forms.Button();
            this.btnBuscarNT = new System.Windows.Forms.Button();
            this.GBEstadoNT = new System.Windows.Forms.GroupBox();
            this.CBEstadoNT = new System.Windows.Forms.ComboBox();
            this.GBNuevoTutorNT.SuspendLayout();
            this.GBEstadoNT.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCodigoTutNT
            // 
            this.LCodigoTutNT.AutoSize = true;
            this.LCodigoTutNT.Location = new System.Drawing.Point(6, 34);
            this.LCodigoTutNT.Name = "LCodigoTutNT";
            this.LCodigoTutNT.Size = new System.Drawing.Size(43, 13);
            this.LCodigoTutNT.TabIndex = 0;
            this.LCodigoTutNT.Text = "Codigo:";
            // 
            // GBNuevoTutorNT
            // 
            this.GBNuevoTutorNT.Controls.Add(this.btnBuscarNT);
            this.GBNuevoTutorNT.Controls.Add(this.txtApNT);
            this.GBNuevoTutorNT.Controls.Add(this.txtNombNT);
            this.GBNuevoTutorNT.Controls.Add(this.txtCodNT);
            this.GBNuevoTutorNT.Controls.Add(this.LApeTutNT);
            this.GBNuevoTutorNT.Controls.Add(this.LNombreTutNT);
            this.GBNuevoTutorNT.Controls.Add(this.LCodigoTutNT);
            this.GBNuevoTutorNT.Location = new System.Drawing.Point(19, 44);
            this.GBNuevoTutorNT.Name = "GBNuevoTutorNT";
            this.GBNuevoTutorNT.Size = new System.Drawing.Size(301, 143);
            this.GBNuevoTutorNT.TabIndex = 1;
            this.GBNuevoTutorNT.TabStop = false;
            this.GBNuevoTutorNT.Text = "Datos Principales";
            // 
            // LNombreTutNT
            // 
            this.LNombreTutNT.AutoSize = true;
            this.LNombreTutNT.Location = new System.Drawing.Point(6, 71);
            this.LNombreTutNT.Name = "LNombreTutNT";
            this.LNombreTutNT.Size = new System.Drawing.Size(47, 13);
            this.LNombreTutNT.TabIndex = 1;
            this.LNombreTutNT.Text = "Nombre:";
            // 
            // LApeTutNT
            // 
            this.LApeTutNT.AutoSize = true;
            this.LApeTutNT.Location = new System.Drawing.Point(6, 109);
            this.LApeTutNT.Name = "LApeTutNT";
            this.LApeTutNT.Size = new System.Drawing.Size(52, 13);
            this.LApeTutNT.TabIndex = 2;
            this.LApeTutNT.Text = "Apellidos:";
            // 
            // txtCodNT
            // 
            this.txtCodNT.Location = new System.Drawing.Point(65, 27);
            this.txtCodNT.Name = "txtCodNT";
            this.txtCodNT.Size = new System.Drawing.Size(117, 20);
            this.txtCodNT.TabIndex = 3;
            this.txtCodNT.TextChanged += new System.EventHandler(this.txtCodNT_TextChanged);
            // 
            // txtNombNT
            // 
            this.txtNombNT.Location = new System.Drawing.Point(65, 64);
            this.txtNombNT.Name = "txtNombNT";
            this.txtNombNT.Size = new System.Drawing.Size(230, 20);
            this.txtNombNT.TabIndex = 4;
            // 
            // txtApNT
            // 
            this.txtApNT.Location = new System.Drawing.Point(65, 101);
            this.txtApNT.Name = "txtApNT";
            this.txtApNT.Size = new System.Drawing.Size(230, 20);
            this.txtApNT.TabIndex = 5;
            // 
            // btnAceptarNT
            // 
            this.btnAceptarNT.Location = new System.Drawing.Point(164, 268);
            this.btnAceptarNT.Name = "btnAceptarNT";
            this.btnAceptarNT.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNT.TabIndex = 2;
            this.btnAceptarNT.Text = "Aceptar";
            this.btnAceptarNT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarNT.UseVisualStyleBackColor = true;
            this.btnAceptarNT.Click += new System.EventHandler(this.btnAceptarNT_Click);
            // 
            // btnCancelarNT
            // 
            this.btnCancelarNT.Location = new System.Drawing.Point(245, 268);
            this.btnCancelarNT.Name = "btnCancelarNT";
            this.btnCancelarNT.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNT.TabIndex = 3;
            this.btnCancelarNT.Text = "Cancelar";
            this.btnCancelarNT.UseVisualStyleBackColor = true;
            this.btnCancelarNT.Click += new System.EventHandler(this.btnCancelarNT_Click);
            // 
            // btnBuscarNT
            // 
            this.btnBuscarNT.Location = new System.Drawing.Point(189, 27);
            this.btnBuscarNT.Name = "btnBuscarNT";
            this.btnBuscarNT.Size = new System.Drawing.Size(82, 20);
            this.btnBuscarNT.TabIndex = 6;
            this.btnBuscarNT.Text = "Buscar";
            this.btnBuscarNT.UseVisualStyleBackColor = true;
            this.btnBuscarNT.Click += new System.EventHandler(this.btnBuscarNT_Click);
            // 
            // GBEstadoNT
            // 
            this.GBEstadoNT.Controls.Add(this.CBEstadoNT);
            this.GBEstadoNT.Location = new System.Drawing.Point(19, 193);
            this.GBEstadoNT.Name = "GBEstadoNT";
            this.GBEstadoNT.Size = new System.Drawing.Size(301, 57);
            this.GBEstadoNT.TabIndex = 4;
            this.GBEstadoNT.TabStop = false;
            this.GBEstadoNT.Text = "Estado";
            // 
            // CBEstadoNT
            // 
            this.CBEstadoNT.FormattingEnabled = true;
            this.CBEstadoNT.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstadoNT.Location = new System.Drawing.Point(65, 20);
            this.CBEstadoNT.Name = "CBEstadoNT";
            this.CBEstadoNT.Size = new System.Drawing.Size(121, 21);
            this.CBEstadoNT.TabIndex = 0;
            this.CBEstadoNT.SelectedIndexChanged += new System.EventHandler(this.CBEstadoNT_SelectedIndexChanged);
            // 
            // NuevoTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 303);
            this.Controls.Add(this.GBEstadoNT);
            this.Controls.Add(this.btnCancelarNT);
            this.Controls.Add(this.btnAceptarNT);
            this.Controls.Add(this.GBNuevoTutorNT);
            this.Name = "NuevoTutor";
            this.Text = "Nuevo Tutor";
            this.GBNuevoTutorNT.ResumeLayout(false);
            this.GBNuevoTutorNT.PerformLayout();
            this.GBEstadoNT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LCodigoTutNT;
        private System.Windows.Forms.GroupBox GBNuevoTutorNT;
        private System.Windows.Forms.TextBox txtApNT;
        private System.Windows.Forms.TextBox txtNombNT;
        private System.Windows.Forms.TextBox txtCodNT;
        private System.Windows.Forms.Label LApeTutNT;
        private System.Windows.Forms.Label LNombreTutNT;
        private System.Windows.Forms.Button btnAceptarNT;
        private System.Windows.Forms.Button btnCancelarNT;
        private System.Windows.Forms.Button btnBuscarNT;
        private System.Windows.Forms.GroupBox GBEstadoNT;
        private System.Windows.Forms.ComboBox CBEstadoNT;
    }
}