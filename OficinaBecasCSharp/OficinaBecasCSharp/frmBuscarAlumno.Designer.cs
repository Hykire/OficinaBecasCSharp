namespace Vista
{
    partial class frmBuscarAlumno
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
            this.gbox_criterios = new System.Windows.Forms.GroupBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.tbox_apellidos = new System.Windows.Forms.TextBox();
            this.tbox_nombres = new System.Windows.Forms.TextBox();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.dvg_alumnos = new System.Windows.Forms.DataGridView();
            this.CODIGO_PUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO_PUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.gbox_criterios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_criterios
            // 
            this.gbox_criterios.Controls.Add(this.button_buscar);
            this.gbox_criterios.Controls.Add(this.tbox_apellidos);
            this.gbox_criterios.Controls.Add(this.tbox_nombres);
            this.gbox_criterios.Controls.Add(this.tbox_codigo);
            this.gbox_criterios.Controls.Add(this.label_codigo);
            this.gbox_criterios.Controls.Add(this.label_nombre);
            this.gbox_criterios.Controls.Add(this.label_apellidos);
            this.gbox_criterios.Location = new System.Drawing.Point(12, 12);
            this.gbox_criterios.Name = "gbox_criterios";
            this.gbox_criterios.Size = new System.Drawing.Size(350, 174);
            this.gbox_criterios.TabIndex = 10;
            this.gbox_criterios.TabStop = false;
            this.gbox_criterios.Text = "Criterios de Búsqueda:";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(248, 132);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 11;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // tbox_apellidos
            // 
            this.tbox_apellidos.Location = new System.Drawing.Point(123, 79);
            this.tbox_apellidos.Name = "tbox_apellidos";
            this.tbox_apellidos.Size = new System.Drawing.Size(200, 20);
            this.tbox_apellidos.TabIndex = 4;
            // 
            // tbox_nombres
            // 
            this.tbox_nombres.Location = new System.Drawing.Point(123, 53);
            this.tbox_nombres.Name = "tbox_nombres";
            this.tbox_nombres.Size = new System.Drawing.Size(200, 20);
            this.tbox_nombres.TabIndex = 3;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(123, 27);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.Size = new System.Drawing.Size(100, 20);
            this.tbox_codigo.TabIndex = 2;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_codigo.Location = new System.Drawing.Point(21, 30);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(43, 13);
            this.label_codigo.TabIndex = 0;
            this.label_codigo.Text = "Código:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_nombre.Location = new System.Drawing.Point(21, 56);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(52, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombres:";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_apellidos.Location = new System.Drawing.Point(21, 82);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(52, 13);
            this.label_apellidos.TabIndex = 2;
            this.label_apellidos.Text = "Apellidos:";
            // 
            // dvg_alumnos
            // 
            this.dvg_alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_alumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO_PUCP,
            this.NOMBRES,
            this.APELLIDOS,
            this.CORREO_PUCP});
            this.dvg_alumnos.Location = new System.Drawing.Point(13, 203);
            this.dvg_alumnos.Name = "dvg_alumnos";
            this.dvg_alumnos.Size = new System.Drawing.Size(602, 150);
            this.dvg_alumnos.TabIndex = 11;
            // 
            // CODIGO_PUCP
            // 
            this.CODIGO_PUCP.DataPropertyName = "CodigoPUCP";
            this.CODIGO_PUCP.HeaderText = "Código";
            this.CODIGO_PUCP.Name = "CODIGO_PUCP";
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "Nombres";
            this.NOMBRES.HeaderText = "Nombres";
            this.NOMBRES.Name = "NOMBRES";
            // 
            // APELLIDOS
            // 
            this.APELLIDOS.DataPropertyName = "Apellidos";
            this.APELLIDOS.HeaderText = "Apellidos";
            this.APELLIDOS.Name = "APELLIDOS";
            // 
            // CORREO_PUCP
            // 
            this.CORREO_PUCP.DataPropertyName = "CorreoPUCP";
            this.CORREO_PUCP.HeaderText = "Correo PUCP";
            this.CORREO_PUCP.Name = "CORREO_PUCP";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(540, 174);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar.TabIndex = 24;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // frmBuscarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 371);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.dvg_alumnos);
            this.Controls.Add(this.gbox_criterios);
            this.Name = "frmBuscarAlumno";
            this.Text = "frmBuscarAlumno";
            this.gbox_criterios.ResumeLayout(false);
            this.gbox_criterios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_criterios;
        private System.Windows.Forms.TextBox tbox_apellidos;
        private System.Windows.Forms.TextBox tbox_nombres;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellidos;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.DataGridView dvg_alumnos;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO_PUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO_PUCP;
    }
}