namespace Vista
{
    partial class BuscarBecarioABTXB
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
            this.btnCancelarABTXB = new System.Windows.Forms.Button();
            this.btnBuscarABTXB = new System.Windows.Forms.Button();
            this.DGVBuscarBecarioABTXB = new System.Windows.Forms.DataGridView();
            this.C1BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarBecarioABTXB = new System.Windows.Forms.TextBox();
            this.btnAgregarABTXB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarBecarioABTXB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelarABTXB
            // 
            this.btnCancelarABTXB.Location = new System.Drawing.Point(372, 215);
            this.btnCancelarABTXB.Name = "btnCancelarABTXB";
            this.btnCancelarABTXB.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarABTXB.TabIndex = 9;
            this.btnCancelarABTXB.Text = "Cancelar";
            this.btnCancelarABTXB.UseVisualStyleBackColor = true;
            this.btnCancelarABTXB.Click += new System.EventHandler(this.btnCancelarABTXB_Click);
            // 
            // btnBuscarABTXB
            // 
            this.btnBuscarABTXB.Location = new System.Drawing.Point(327, 26);
            this.btnBuscarABTXB.Name = "btnBuscarABTXB";
            this.btnBuscarABTXB.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarABTXB.TabIndex = 8;
            this.btnBuscarABTXB.Text = "Buscar";
            this.btnBuscarABTXB.UseVisualStyleBackColor = true;
            this.btnBuscarABTXB.Click += new System.EventHandler(this.btnBuscarABTXB_Click);
            // 
            // DGVBuscarBecarioABTXB
            // 
            this.DGVBuscarBecarioABTXB.AllowUserToAddRows = false;
            this.DGVBuscarBecarioABTXB.AllowUserToDeleteRows = false;
            this.DGVBuscarBecarioABTXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscarBecarioABTXB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BuscarT,
            this.C2BuscarT,
            this.C3BuscarT});
            this.DGVBuscarBecarioABTXB.Location = new System.Drawing.Point(13, 74);
            this.DGVBuscarBecarioABTXB.Name = "DGVBuscarBecarioABTXB";
            this.DGVBuscarBecarioABTXB.ReadOnly = true;
            this.DGVBuscarBecarioABTXB.Size = new System.Drawing.Size(434, 122);
            this.DGVBuscarBecarioABTXB.TabIndex = 7;
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
            // txtBuscarBecarioABTXB
            // 
            this.txtBuscarBecarioABTXB.Location = new System.Drawing.Point(13, 26);
            this.txtBuscarBecarioABTXB.Name = "txtBuscarBecarioABTXB";
            this.txtBuscarBecarioABTXB.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarBecarioABTXB.TabIndex = 6;
            // 
            // btnAgregarABTXB
            // 
            this.btnAgregarABTXB.Location = new System.Drawing.Point(291, 215);
            this.btnAgregarABTXB.Name = "btnAgregarABTXB";
            this.btnAgregarABTXB.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarABTXB.TabIndex = 5;
            this.btnAgregarABTXB.Text = "Agregar";
            this.btnAgregarABTXB.UseVisualStyleBackColor = true;
            this.btnAgregarABTXB.Click += new System.EventHandler(this.btnAgregarABTXB_Click);
            // 
            // BuscarBecarioABTXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 250);
            this.Controls.Add(this.btnCancelarABTXB);
            this.Controls.Add(this.btnBuscarABTXB);
            this.Controls.Add(this.DGVBuscarBecarioABTXB);
            this.Controls.Add(this.txtBuscarBecarioABTXB);
            this.Controls.Add(this.btnAgregarABTXB);
            this.Name = "BuscarBecarioABTXB";
            this.Text = "Buscar Becario";
            this.Load += new System.EventHandler(this.BuscarBecarioABTXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarBecarioABTXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarABTXB;
        private System.Windows.Forms.Button btnBuscarABTXB;
        private System.Windows.Forms.DataGridView DGVBuscarBecarioABTXB;
        private System.Windows.Forms.TextBox txtBuscarBecarioABTXB;
        private System.Windows.Forms.Button btnAgregarABTXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BuscarT;
    }
}