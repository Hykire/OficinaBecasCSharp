namespace Vista
{
    partial class BuscarTutorNT
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
            this.btnAgregarBTNT = new System.Windows.Forms.Button();
            this.txtBuscarTutorNT = new System.Windows.Forms.TextBox();
            this.DGVBuscarTutorNT = new System.Windows.Forms.DataGridView();
            this.C1BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BuscarT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarBTNT = new System.Windows.Forms.Button();
            this.btnCancelarBTNT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarTutorNT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarBTNT
            // 
            this.btnAgregarBTNT.Location = new System.Drawing.Point(291, 215);
            this.btnAgregarBTNT.Name = "btnAgregarBTNT";
            this.btnAgregarBTNT.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarBTNT.TabIndex = 0;
            this.btnAgregarBTNT.Text = "Agregar";
            this.btnAgregarBTNT.UseVisualStyleBackColor = true;
            this.btnAgregarBTNT.Click += new System.EventHandler(this.btnAgregarBTNT_Click);
            // 
            // txtBuscarTutorNT
            // 
            this.txtBuscarTutorNT.Location = new System.Drawing.Point(13, 26);
            this.txtBuscarTutorNT.Name = "txtBuscarTutorNT";
            this.txtBuscarTutorNT.Size = new System.Drawing.Size(275, 20);
            this.txtBuscarTutorNT.TabIndex = 1;
            // 
            // DGVBuscarTutorNT
            // 
            this.DGVBuscarTutorNT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBuscarTutorNT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BuscarT,
            this.C2BuscarT,
            this.C3BuscarT});
            this.DGVBuscarTutorNT.Location = new System.Drawing.Point(13, 74);
            this.DGVBuscarTutorNT.Name = "DGVBuscarTutorNT";
            this.DGVBuscarTutorNT.Size = new System.Drawing.Size(434, 122);
            this.DGVBuscarTutorNT.TabIndex = 2;
            // 
            // C1BuscarT
            // 
            this.C1BuscarT.HeaderText = "Codigo";
            this.C1BuscarT.Name = "C1BuscarT";
            // 
            // C2BuscarT
            // 
            this.C2BuscarT.HeaderText = "Nombre";
            this.C2BuscarT.Name = "C2BuscarT";
            // 
            // C3BuscarT
            // 
            this.C3BuscarT.HeaderText = "Apellidos";
            this.C3BuscarT.Name = "C3BuscarT";
            this.C3BuscarT.Width = 200;
            // 
            // btnBuscarBTNT
            // 
            this.btnBuscarBTNT.Location = new System.Drawing.Point(327, 26);
            this.btnBuscarBTNT.Name = "btnBuscarBTNT";
            this.btnBuscarBTNT.Size = new System.Drawing.Size(101, 23);
            this.btnBuscarBTNT.TabIndex = 3;
            this.btnBuscarBTNT.Text = "Buscar";
            this.btnBuscarBTNT.UseVisualStyleBackColor = true;
            // 
            // btnCancelarBTNT
            // 
            this.btnCancelarBTNT.Location = new System.Drawing.Point(372, 215);
            this.btnCancelarBTNT.Name = "btnCancelarBTNT";
            this.btnCancelarBTNT.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBTNT.TabIndex = 4;
            this.btnCancelarBTNT.Text = "Cancelar";
            this.btnCancelarBTNT.UseVisualStyleBackColor = true;
            this.btnCancelarBTNT.Click += new System.EventHandler(this.btnCancelarBTNT_Click);
            // 
            // BuscarTutorNT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 250);
            this.Controls.Add(this.btnCancelarBTNT);
            this.Controls.Add(this.btnBuscarBTNT);
            this.Controls.Add(this.DGVBuscarTutorNT);
            this.Controls.Add(this.txtBuscarTutorNT);
            this.Controls.Add(this.btnAgregarBTNT);
            this.Name = "BuscarTutorNT";
            this.Text = "Buscar Tutor";
            ((System.ComponentModel.ISupportInitialize)(this.DGVBuscarTutorNT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarBTNT;
        private System.Windows.Forms.TextBox txtBuscarTutorNT;
        private System.Windows.Forms.DataGridView DGVBuscarTutorNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BuscarT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BuscarT;
        private System.Windows.Forms.Button btnBuscarBTNT;
        private System.Windows.Forms.Button btnCancelarBTNT;
    }
}