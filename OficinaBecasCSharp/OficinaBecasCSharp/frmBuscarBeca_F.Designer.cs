namespace Vista
{
    partial class frmBuscarBeca_F
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
            this.dgv_beca = new System.Windows.Forms.DataGridView();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FINANCIADOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_beca)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_beca
            // 
            this.dgv_beca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_beca.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOMBRE,
            this.DESCRIPCION,
            this.FINANCIADOR,
            this.ESTADO});
            this.dgv_beca.Location = new System.Drawing.Point(12, 12);
            this.dgv_beca.Name = "dgv_beca";
            this.dgv_beca.Size = new System.Drawing.Size(577, 234);
            this.dgv_beca.TabIndex = 0;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(514, 252);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 25;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // NOMBRE
            // 
            this.NOMBRE.DataPropertyName = "Nombre_beca";
            this.NOMBRE.HeaderText = "NOMBRE";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "Descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            // 
            // FINANCIADOR
            // 
            this.FINANCIADOR.DataPropertyName = "Financiador";
            this.FINANCIADOR.HeaderText = "FINANCIADOR";
            this.FINANCIADOR.Name = "FINANCIADOR";
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "Estado";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            // 
            // frmBuscarBeca_F
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 281);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dgv_beca);
            this.Name = "frmBuscarBeca_F";
            this.Text = "frmBuscarBeca";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_beca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_beca;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FINANCIADOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}