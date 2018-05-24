namespace Vista
{
    partial class frmBuscarPersona
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
            this.btnCancelarBTBP = new System.Windows.Forms.Button();
            this.btnBuscarBTBP = new System.Windows.Forms.Button();
            this.DGVBuscarPersona = new System.Windows.Forms.DataGridView();
            this.txtBuscarTutorBP = new System.Windows.Forms.TextBox();
            this.btnAgregarBTBP = new System.Windows.Forms.Button();
            this.C1BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarPersona)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarBTBP
            // 
            this.btnCancelarBTBP.Location = new System.Drawing.Point(373, 226);
            this.btnCancelarBTBP.Name = "btnCancelarBTBP";
            this.btnCancelarBTBP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBTBP.TabIndex = 9;
            this.btnCancelarBTBP.Text = "Cancelar";
            this.btnCancelarBTBP.UseVisualStyleBackColor = true;
            this.btnCancelarBTBP.Click += new System.EventHandler(this.btnCancelarBTBP_Click);
            // 
            // btnBuscarBTBP
            // 
            this.btnBuscarBTBP.Location = new System.Drawing.Point(328, 37);
            this.btnBuscarBTBP.Name = "btnBuscarBTBP";
            this.btnBuscarBTBP.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarBTBP.TabIndex = 8;
            this.btnBuscarBTBP.Text = "Buscar";
            this.btnBuscarBTBP.UseVisualStyleBackColor = true;
            this.btnBuscarBTBP.Click += new System.EventHandler(this.btnBuscarBTBP_Click);
            // 
            // DGVBuscarPersona
            // 
            this.DGVBuscarPersona.AllowUserToAddRows = false;
            this.DGVBuscarPersona.AllowUserToDeleteRows = false;
            this.DGVBuscarPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscarPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BuscarT,
            this.C2BuscarT,
            this.C3BuscarT,
            this.Id});
            this.DGVBuscarPersona.Location = new System.Drawing.Point(14, 85);
            this.DGVBuscarPersona.Name = "DGVBuscarPersona";
            this.DGVBuscarPersona.ReadOnly = true;
            this.DGVBuscarPersona.Size = new System.Drawing.Size(434, 122);
            this.DGVBuscarPersona.TabIndex = 7;
            // 
            // txtBuscarTutorBP
            // 
            this.txtBuscarTutorBP.Location = new System.Drawing.Point(14, 37);
            this.txtBuscarTutorBP.Name = "txtBuscarTutorBP";
            this.txtBuscarTutorBP.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarTutorBP.TabIndex = 6;
            // 
            // btnAgregarBTBP
            // 
            this.btnAgregarBTBP.Location = new System.Drawing.Point(292, 226);
            this.btnAgregarBTBP.Name = "btnAgregarBTBP";
            this.btnAgregarBTBP.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarBTBP.TabIndex = 5;
            this.btnAgregarBTBP.Text = "Agregar";
            this.btnAgregarBTBP.UseVisualStyleBackColor = true;
            this.btnAgregarBTBP.Click += new System.EventHandler(this.btnAgregarBTBP_Click);
            // 
            // C1BuscarT
            // 
            this.C1BuscarT.DataPropertyName = "CodigoPUCP";
            this.C1BuscarT.HeaderText = "Codigo";
            this.C1BuscarT.Name = "C1BuscarT";
            this.C1BuscarT.ReadOnly = true;
            // 
            // C2BuscarT
            // 
            this.C2BuscarT.DataPropertyName = "Nombres";
            this.C2BuscarT.HeaderText = "Nombre";
            this.C2BuscarT.Name = "C2BuscarT";
            this.C2BuscarT.ReadOnly = true;
            // 
            // C3BuscarT
            // 
            this.C3BuscarT.DataPropertyName = "Apellidos";
            this.C3BuscarT.HeaderText = "Apellidos";
            this.C3BuscarT.Name = "C3BuscarT";
            this.C3BuscarT.ReadOnly = true;
            this.C3BuscarT.Width = 200;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id_persona";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // frmBuscarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 263);
            this.Controls.Add(this.btnCancelarBTBP);
            this.Controls.Add(this.btnBuscarBTBP);
            this.Controls.Add(this.DGVBuscarPersona);
            this.Controls.Add(this.txtBuscarTutorBP);
            this.Controls.Add(this.btnAgregarBTBP);
            this.Name = "frmBuscarPersona";
            this.Text = "frmBuscarPersona";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarPersona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarBTBP;
        private System.Windows.Forms.Button btnBuscarBTBP;
        private System.Windows.Forms.DataGridView DGVBuscarPersona;
        private System.Windows.Forms.TextBox txtBuscarTutorBP;
        private System.Windows.Forms.Button btnAgregarBTBP;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}