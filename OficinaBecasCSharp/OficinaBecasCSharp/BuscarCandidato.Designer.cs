namespace Vista
{
    partial class BuscarCandidato
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
            this.dgvBuscarCandidato = new System.Windows.Forms.DataGridView();
            this.CodigoPUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Postulante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seleccionado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chPostulante = new System.Windows.Forms.CheckBox();
            this.chSeleccionado = new System.Windows.Forms.CheckBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.rbCodigoPUCP = new System.Windows.Forms.RadioButton();
            this.rbNombres = new System.Windows.Forms.RadioButton();
            this.rbApellidos = new System.Windows.Forms.RadioButton();
            this.rbDNI = new System.Windows.Forms.RadioButton();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCandidato)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBuscarCandidato
            // 
            this.dgvBuscarCandidato.AllowUserToAddRows = false;
            this.dgvBuscarCandidato.AllowUserToDeleteRows = false;
            this.dgvBuscarCandidato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarCandidato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPUCP,
            this.Nombres,
            this.Apellidos,
            this.DNI,
            this.Postulante,
            this.Seleccionado});
            this.dgvBuscarCandidato.Location = new System.Drawing.Point(25, 96);
            this.dgvBuscarCandidato.Name = "dgvBuscarCandidato";
            this.dgvBuscarCandidato.ReadOnly = true;
            this.dgvBuscarCandidato.RowTemplate.Height = 24;
            this.dgvBuscarCandidato.Size = new System.Drawing.Size(748, 370);
            this.dgvBuscarCandidato.TabIndex = 0;
            // 
            // CodigoPUCP
            // 
            this.CodigoPUCP.DataPropertyName = "CodigoPUCP";
            this.CodigoPUCP.HeaderText = "Código PUCP";
            this.CodigoPUCP.Name = "CodigoPUCP";
            this.CodigoPUCP.ReadOnly = true;
            // 
            // Nombres
            // 
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.ReadOnly = true;
            // 
            // Apellidos
            // 
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Postulante
            // 
            this.Postulante.DataPropertyName = "Postulante";
            this.Postulante.HeaderText = "Postulante";
            this.Postulante.Name = "Postulante";
            this.Postulante.ReadOnly = true;
            // 
            // Seleccionado
            // 
            this.Seleccionado.DataPropertyName = "Seleccionado";
            this.Seleccionado.HeaderText = "Seleccionado";
            this.Seleccionado.Name = "Seleccionado";
            this.Seleccionado.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro:";
            // 
            // chPostulante
            // 
            this.chPostulante.AutoSize = true;
            this.chPostulante.Location = new System.Drawing.Point(25, 60);
            this.chPostulante.Name = "chPostulante";
            this.chPostulante.Size = new System.Drawing.Size(97, 21);
            this.chPostulante.TabIndex = 3;
            this.chPostulante.Text = "Postulante";
            this.chPostulante.UseVisualStyleBackColor = true;
            // 
            // chSeleccionado
            // 
            this.chSeleccionado.AutoSize = true;
            this.chSeleccionado.Location = new System.Drawing.Point(176, 60);
            this.chSeleccionado.Name = "chSeleccionado";
            this.chSeleccionado.Size = new System.Drawing.Size(115, 21);
            this.chSeleccionado.TabIndex = 4;
            this.chSeleccionado.Text = "Seleccionado";
            this.chSeleccionado.UseVisualStyleBackColor = true;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(81, 21);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(210, 22);
            this.txtFiltro.TabIndex = 5;
            // 
            // rbCodigoPUCP
            // 
            this.rbCodigoPUCP.AutoSize = true;
            this.rbCodigoPUCP.Location = new System.Drawing.Point(328, 22);
            this.rbCodigoPUCP.Name = "rbCodigoPUCP";
            this.rbCodigoPUCP.Size = new System.Drawing.Size(114, 21);
            this.rbCodigoPUCP.TabIndex = 6;
            this.rbCodigoPUCP.TabStop = true;
            this.rbCodigoPUCP.Text = "Código PUCP";
            this.rbCodigoPUCP.UseVisualStyleBackColor = true;
            // 
            // rbNombres
            // 
            this.rbNombres.AutoSize = true;
            this.rbNombres.Location = new System.Drawing.Point(457, 22);
            this.rbNombres.Name = "rbNombres";
            this.rbNombres.Size = new System.Drawing.Size(86, 21);
            this.rbNombres.TabIndex = 7;
            this.rbNombres.TabStop = true;
            this.rbNombres.Text = "Nombres";
            this.rbNombres.UseVisualStyleBackColor = true;
            // 
            // rbApellidos
            // 
            this.rbApellidos.AutoSize = true;
            this.rbApellidos.Location = new System.Drawing.Point(562, 22);
            this.rbApellidos.Name = "rbApellidos";
            this.rbApellidos.Size = new System.Drawing.Size(86, 21);
            this.rbApellidos.TabIndex = 8;
            this.rbApellidos.TabStop = true;
            this.rbApellidos.Text = "Apellidos";
            this.rbApellidos.UseVisualStyleBackColor = true;
            // 
            // rbDNI
            // 
            this.rbDNI.AutoSize = true;
            this.rbDNI.Location = new System.Drawing.Point(669, 22);
            this.rbDNI.Name = "rbDNI";
            this.rbDNI.Size = new System.Drawing.Size(52, 21);
            this.rbDNI.TabIndex = 9;
            this.rbDNI.TabStop = true;
            this.rbDNI.Text = "DNI";
            this.rbDNI.UseVisualStyleBackColor = true;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(328, 54);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(110, 31);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(469, 54);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 31);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(611, 54);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(110, 31);
            this.btnSeleccionar.TabIndex = 12;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // BuscarCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.rbDNI);
            this.Controls.Add(this.rbApellidos);
            this.Controls.Add(this.rbNombres);
            this.Controls.Add(this.rbCodigoPUCP);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.chSeleccionado);
            this.Controls.Add(this.chPostulante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarCandidato);
            this.Name = "BuscarCandidato";
            this.Text = "Buscar Candidato";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarCandidato)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarCandidato;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Postulante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seleccionado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chPostulante;
        private System.Windows.Forms.CheckBox chSeleccionado;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.RadioButton rbCodigoPUCP;
        private System.Windows.Forms.RadioButton rbNombres;
        private System.Windows.Forms.RadioButton rbApellidos;
        private System.Windows.Forms.RadioButton rbDNI;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSeleccionar;
    }
}