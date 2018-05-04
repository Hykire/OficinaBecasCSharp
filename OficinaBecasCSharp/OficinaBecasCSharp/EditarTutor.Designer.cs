namespace Vista
{
    partial class EditarTutor
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
            this.GBEstadoET = new System.Windows.Forms.GroupBox();
            this.CBEstadoET = new System.Windows.Forms.ComboBox();
            this.btnCancelarET = new System.Windows.Forms.Button();
            this.btnAceptarET = new System.Windows.Forms.Button();
            this.GBNuevoTutorET = new System.Windows.Forms.GroupBox();
            this.txtApET = new System.Windows.Forms.TextBox();
            this.txtNombET = new System.Windows.Forms.TextBox();
            this.txtCodET = new System.Windows.Forms.TextBox();
            this.LApeTutET = new System.Windows.Forms.Label();
            this.LNombreTutET = new System.Windows.Forms.Label();
            this.LCodigoTutET = new System.Windows.Forms.Label();
            this.GBEstadoET.SuspendLayout();
            this.GBNuevoTutorET.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBEstadoET
            // 
            this.GBEstadoET.Controls.Add(this.CBEstadoET);
            this.GBEstadoET.Location = new System.Drawing.Point(22, 177);
            this.GBEstadoET.Name = "GBEstadoET";
            this.GBEstadoET.Size = new System.Drawing.Size(301, 57);
            this.GBEstadoET.TabIndex = 8;
            this.GBEstadoET.TabStop = false;
            this.GBEstadoET.Text = "Estado";
            // 
            // CBEstadoET
            // 
            this.CBEstadoET.FormattingEnabled = true;
            this.CBEstadoET.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstadoET.Location = new System.Drawing.Point(65, 20);
            this.CBEstadoET.Name = "CBEstadoET";
            this.CBEstadoET.Size = new System.Drawing.Size(121, 21);
            this.CBEstadoET.TabIndex = 0;
            this.CBEstadoET.SelectedIndexChanged += new System.EventHandler(this.CBEstadoET_SelectedIndexChanged);
            // 
            // btnCancelarET
            // 
            this.btnCancelarET.Location = new System.Drawing.Point(248, 252);
            this.btnCancelarET.Name = "btnCancelarET";
            this.btnCancelarET.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarET.TabIndex = 7;
            this.btnCancelarET.Text = "Cancelar";
            this.btnCancelarET.UseVisualStyleBackColor = true;
            this.btnCancelarET.Click += new System.EventHandler(this.btnCancelarET_Click);
            // 
            // btnAceptarET
            // 
            this.btnAceptarET.Location = new System.Drawing.Point(167, 252);
            this.btnAceptarET.Name = "btnAceptarET";
            this.btnAceptarET.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarET.TabIndex = 6;
            this.btnAceptarET.Text = "Aceptar";
            this.btnAceptarET.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAceptarET.UseVisualStyleBackColor = true;
            this.btnAceptarET.Click += new System.EventHandler(this.btnAceptarET_Click);
            // 
            // GBNuevoTutorET
            // 
            this.GBNuevoTutorET.Controls.Add(this.txtApET);
            this.GBNuevoTutorET.Controls.Add(this.txtNombET);
            this.GBNuevoTutorET.Controls.Add(this.txtCodET);
            this.GBNuevoTutorET.Controls.Add(this.LApeTutET);
            this.GBNuevoTutorET.Controls.Add(this.LNombreTutET);
            this.GBNuevoTutorET.Controls.Add(this.LCodigoTutET);
            this.GBNuevoTutorET.Location = new System.Drawing.Point(22, 28);
            this.GBNuevoTutorET.Name = "GBNuevoTutorET";
            this.GBNuevoTutorET.Size = new System.Drawing.Size(301, 143);
            this.GBNuevoTutorET.TabIndex = 5;
            this.GBNuevoTutorET.TabStop = false;
            this.GBNuevoTutorET.Text = "Datos Principales";
            // 
            // txtApET
            // 
            this.txtApET.Location = new System.Drawing.Point(65, 101);
            this.txtApET.Name = "txtApET";
            this.txtApET.Size = new System.Drawing.Size(230, 20);
            this.txtApET.TabIndex = 5;
            // 
            // txtNombET
            // 
            this.txtNombET.Location = new System.Drawing.Point(65, 64);
            this.txtNombET.Name = "txtNombET";
            this.txtNombET.Size = new System.Drawing.Size(230, 20);
            this.txtNombET.TabIndex = 4;
            // 
            // txtCodET
            // 
            this.txtCodET.Location = new System.Drawing.Point(65, 27);
            this.txtCodET.Name = "txtCodET";
            this.txtCodET.Size = new System.Drawing.Size(117, 20);
            this.txtCodET.TabIndex = 3;
            this.txtCodET.TextChanged += new System.EventHandler(this.txtCodET_TextChanged);
            // 
            // LApeTutET
            // 
            this.LApeTutET.AutoSize = true;
            this.LApeTutET.Location = new System.Drawing.Point(6, 109);
            this.LApeTutET.Name = "LApeTutET";
            this.LApeTutET.Size = new System.Drawing.Size(52, 13);
            this.LApeTutET.TabIndex = 2;
            this.LApeTutET.Text = "Apellidos:";
            // 
            // LNombreTutET
            // 
            this.LNombreTutET.AutoSize = true;
            this.LNombreTutET.Location = new System.Drawing.Point(6, 71);
            this.LNombreTutET.Name = "LNombreTutET";
            this.LNombreTutET.Size = new System.Drawing.Size(47, 13);
            this.LNombreTutET.TabIndex = 1;
            this.LNombreTutET.Text = "Nombre:";
            // 
            // LCodigoTutET
            // 
            this.LCodigoTutET.AutoSize = true;
            this.LCodigoTutET.Location = new System.Drawing.Point(6, 34);
            this.LCodigoTutET.Name = "LCodigoTutET";
            this.LCodigoTutET.Size = new System.Drawing.Size(43, 13);
            this.LCodigoTutET.TabIndex = 0;
            this.LCodigoTutET.Text = "Codigo:";
            // 
            // EditarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 302);
            this.Controls.Add(this.GBEstadoET);
            this.Controls.Add(this.btnCancelarET);
            this.Controls.Add(this.btnAceptarET);
            this.Controls.Add(this.GBNuevoTutorET);
            this.Name = "EditarTutor";
            this.Text = "Editar Tutor";
            this.Load += new System.EventHandler(this.Editar_Tutor_Load);
            this.GBEstadoET.ResumeLayout(false);
            this.GBNuevoTutorET.ResumeLayout(false);
            this.GBNuevoTutorET.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GBEstadoET;
        private System.Windows.Forms.ComboBox CBEstadoET;
        private System.Windows.Forms.Button btnCancelarET;
        private System.Windows.Forms.Button btnAceptarET;
        private System.Windows.Forms.GroupBox GBNuevoTutorET;
        private System.Windows.Forms.TextBox txtApET;
        private System.Windows.Forms.TextBox txtNombET;
        private System.Windows.Forms.TextBox txtCodET;
        private System.Windows.Forms.Label LApeTutET;
        private System.Windows.Forms.Label LNombreTutET;
        private System.Windows.Forms.Label LCodigoTutET;
    }
}