namespace Vista
{
    partial class BuscarBecarioT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1BecarioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BecarioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BecarioT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarBBACGC = new System.Windows.Forms.Button();
            this.btnAceptarBBACGC = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BecarioT,
            this.C2BecarioT,
            this.C3BecarioT});
            this.dataGridView1.Location = new System.Drawing.Point(15, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(498, 124);
            this.dataGridView1.TabIndex = 5;
            // 
            // C1BecarioT
            // 
            this.C1BecarioT.HeaderText = "Codigo";
            this.C1BecarioT.Name = "C1BecarioT";
            // 
            // C2BecarioT
            // 
            this.C2BecarioT.HeaderText = "Nombre";
            this.C2BecarioT.Name = "C2BecarioT";
            this.C2BecarioT.Width = 150;
            // 
            // C3BecarioT
            // 
            this.C3BecarioT.HeaderText = "Apellidos";
            this.C3BecarioT.Name = "C3BecarioT";
            this.C3BecarioT.Width = 200;
            // 
            // btnCancelarBBACGC
            // 
            this.btnCancelarBBACGC.Location = new System.Drawing.Point(438, 162);
            this.btnCancelarBBACGC.Name = "btnCancelarBBACGC";
            this.btnCancelarBBACGC.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBBACGC.TabIndex = 4;
            this.btnCancelarBBACGC.Text = "Cancelar";
            this.btnCancelarBBACGC.UseVisualStyleBackColor = true;
            this.btnCancelarBBACGC.Click += new System.EventHandler(this.btnCancelarBBACGC_Click);
            // 
            // btnAceptarBBACGC
            // 
            this.btnAceptarBBACGC.Location = new System.Drawing.Point(357, 162);
            this.btnAceptarBBACGC.Name = "btnAceptarBBACGC";
            this.btnAceptarBBACGC.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBBACGC.TabIndex = 3;
            this.btnAceptarBBACGC.Text = "Aceptar";
            this.btnAceptarBBACGC.UseVisualStyleBackColor = true;
            this.btnAceptarBBACGC.Click += new System.EventHandler(this.btnAceptarBBACGC_Click);
            // 
            // BuscarBecarioT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 202);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancelarBBACGC);
            this.Controls.Add(this.btnAceptarBBACGC);
            this.Name = "BuscarBecarioT";
            this.Text = "BuscarBecarioT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BecarioT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BecarioT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BecarioT;
        private System.Windows.Forms.Button btnCancelarBBACGC;
        private System.Windows.Forms.Button btnAceptarBBACGC;
    }
}