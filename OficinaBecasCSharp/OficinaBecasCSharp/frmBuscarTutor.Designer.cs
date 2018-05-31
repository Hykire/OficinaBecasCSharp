namespace Vista
{
    partial class frmBuscarTutor
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
            this.btnBuscarT = new System.Windows.Forms.Button();
            this.DGVBuscartutor = new System.Windows.Forms.DataGridView();
            this.txtBuscarTutor = new System.Windows.Forms.TextBox();
            this.btnAgregarT = new System.Windows.Forms.Button();
            this.C1BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscartutor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarBTBP
            // 
            this.btnCancelarBTBP.Location = new System.Drawing.Point(385, 212);
            this.btnCancelarBTBP.Name = "btnCancelarBTBP";
            this.btnCancelarBTBP.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBTBP.TabIndex = 14;
            this.btnCancelarBTBP.Text = "Cancelar";
            this.btnCancelarBTBP.UseVisualStyleBackColor = true;
            this.btnCancelarBTBP.Click += new System.EventHandler(this.btnCancelarBTBP_Click);
            // 
            // btnBuscarT
            // 
            this.btnBuscarT.Location = new System.Drawing.Point(340, 23);
            this.btnBuscarT.Name = "btnBuscarT";
            this.btnBuscarT.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarT.TabIndex = 13;
            this.btnBuscarT.Text = "Buscar";
            this.btnBuscarT.UseVisualStyleBackColor = true;
            this.btnBuscarT.Click += new System.EventHandler(this.btnBuscarT_Click);
            // 
            // DGVBuscartutor
            // 
            this.DGVBuscartutor.AllowUserToAddRows = false;
            this.DGVBuscartutor.AllowUserToDeleteRows = false;
            this.DGVBuscartutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscartutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BuscarT,
            this.C2BuscarT,
            this.C3BuscarT,
            this.Id});
            this.DGVBuscartutor.Location = new System.Drawing.Point(26, 71);
            this.DGVBuscartutor.Name = "DGVBuscartutor";
            this.DGVBuscartutor.ReadOnly = true;
            this.DGVBuscartutor.Size = new System.Drawing.Size(434, 122);
            this.DGVBuscartutor.TabIndex = 12;
            // 
            // txtBuscarTutor
            // 
            this.txtBuscarTutor.Location = new System.Drawing.Point(26, 23);
            this.txtBuscarTutor.Name = "txtBuscarTutor";
            this.txtBuscarTutor.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarTutor.TabIndex = 11;
            // 
            // btnAgregarT
            // 
            this.btnAgregarT.Location = new System.Drawing.Point(304, 212);
            this.btnAgregarT.Name = "btnAgregarT";
            this.btnAgregarT.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarT.TabIndex = 10;
            this.btnAgregarT.Text = "Agregar";
            this.btnAgregarT.UseVisualStyleBackColor = true;
            this.btnAgregarT.Click += new System.EventHandler(this.btnAgregarT_Click);
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
            this.Id.DataPropertyName = "IdTutor";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // frmBuscarTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 246);
            this.Controls.Add(this.btnCancelarBTBP);
            this.Controls.Add(this.btnBuscarT);
            this.Controls.Add(this.DGVBuscartutor);
            this.Controls.Add(this.txtBuscarTutor);
            this.Controls.Add(this.btnAgregarT);
            this.Name = "frmBuscarTutor";
            this.Text = "frmBuscarTutor";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscartutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarBTBP;
        private System.Windows.Forms.Button btnBuscarT;
        private System.Windows.Forms.DataGridView DGVBuscartutor;
        private System.Windows.Forms.TextBox txtBuscarTutor;
        private System.Windows.Forms.Button btnAgregarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
    }
}