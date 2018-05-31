namespace Vista
{
    partial class frmBuscarConvocatoria
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
            this.dgvConvocatoria = new System.Windows.Forms.DataGridView();
            this.NombreConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCandidatosPrevistos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadTotalCandidatos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPostulantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadSeleccionados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CicloConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCreadorConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroNombre = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cbFiltroCiclo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvocatoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConvocatoria
            // 
            this.dgvConvocatoria.AllowUserToAddRows = false;
            this.dgvConvocatoria.AllowUserToDeleteRows = false;
            this.dgvConvocatoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConvocatoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreConvocatoria,
            this.DescripcionConvocatoria,
            this.FechaInicio,
            this.FechaFin,
            this.FechaCreacion,
            this.CantidadCandidatosPrevistos,
            this.CantidadTotalCandidatos,
            this.CantidadPostulantes,
            this.CantidadSeleccionados,
            this.CicloConvocatoria,
            this.NombreBeca,
            this.NombreCreadorConvocatoria});
            this.dgvConvocatoria.Location = new System.Drawing.Point(16, 125);
            this.dgvConvocatoria.Name = "dgvConvocatoria";
            this.dgvConvocatoria.ReadOnly = true;
            this.dgvConvocatoria.RowTemplate.Height = 24;
            this.dgvConvocatoria.Size = new System.Drawing.Size(1167, 388);
            this.dgvConvocatoria.TabIndex = 0;
            // 
            // NombreConvocatoria
            // 
            this.NombreConvocatoria.DataPropertyName = "NombreConvocatoria";
            this.NombreConvocatoria.HeaderText = "Nombre de Convocatoria";
            this.NombreConvocatoria.Name = "NombreConvocatoria";
            this.NombreConvocatoria.ReadOnly = true;
            // 
            // DescripcionConvocatoria
            // 
            this.DescripcionConvocatoria.DataPropertyName = "DescripcionConvocatoria";
            this.DescripcionConvocatoria.HeaderText = "Descripción de Convocatoria";
            this.DescripcionConvocatoria.Name = "DescripcionConvocatoria";
            this.DescripcionConvocatoria.ReadOnly = true;
            // 
            // FechaInicio
            // 
            this.FechaInicio.DataPropertyName = "FechaInicio";
            this.FechaInicio.HeaderText = "Fecha de Inicio";
            this.FechaInicio.Name = "FechaInicio";
            this.FechaInicio.ReadOnly = true;
            // 
            // FechaFin
            // 
            this.FechaFin.DataPropertyName = "FechaFin";
            this.FechaFin.HeaderText = "Fecha de Fin";
            this.FechaFin.Name = "FechaFin";
            this.FechaFin.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "Fecha de Creación";
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            // 
            // CantidadCandidatosPrevistos
            // 
            this.CantidadCandidatosPrevistos.DataPropertyName = "CantidadCandidatosPrevistos";
            this.CantidadCandidatosPrevistos.HeaderText = "Cantidad de Candidatos Previstos";
            this.CantidadCandidatosPrevistos.Name = "CantidadCandidatosPrevistos";
            this.CantidadCandidatosPrevistos.ReadOnly = true;
            // 
            // CantidadTotalCandidatos
            // 
            this.CantidadTotalCandidatos.DataPropertyName = "CantidadTotalCandidatos";
            this.CantidadTotalCandidatos.HeaderText = "Cantidad Total de Candidatos";
            this.CantidadTotalCandidatos.Name = "CantidadTotalCandidatos";
            this.CantidadTotalCandidatos.ReadOnly = true;
            // 
            // CantidadPostulantes
            // 
            this.CantidadPostulantes.DataPropertyName = "CantidadPostulantes";
            this.CantidadPostulantes.HeaderText = "Cantidad de Postulantes";
            this.CantidadPostulantes.Name = "CantidadPostulantes";
            this.CantidadPostulantes.ReadOnly = true;
            // 
            // CantidadSeleccionados
            // 
            this.CantidadSeleccionados.DataPropertyName = "CantidadSeleccionados";
            this.CantidadSeleccionados.HeaderText = "Cantidad de Seleccionados";
            this.CantidadSeleccionados.Name = "CantidadSeleccionados";
            this.CantidadSeleccionados.ReadOnly = true;
            // 
            // CicloConvocatoria
            // 
            this.CicloConvocatoria.DataPropertyName = "CicloConvocatoria";
            this.CicloConvocatoria.HeaderText = "Ciclo de Convocatoria";
            this.CicloConvocatoria.Name = "CicloConvocatoria";
            this.CicloConvocatoria.ReadOnly = true;
            // 
            // NombreBeca
            // 
            this.NombreBeca.DataPropertyName = "NombreBeca";
            this.NombreBeca.HeaderText = "Beca Asociada";
            this.NombreBeca.Name = "NombreBeca";
            this.NombreBeca.ReadOnly = true;
            // 
            // NombreCreadorConvocatoria
            // 
            this.NombreCreadorConvocatoria.DataPropertyName = "NombreCreadorConvocatoria";
            this.NombreCreadorConvocatoria.HeaderText = "Creador de Convocatoria";
            this.NombreCreadorConvocatoria.Name = "NombreCreadorConvocatoria";
            this.NombreCreadorConvocatoria.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro por Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(154, 26);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(387, 22);
            this.txtFiltroNombre.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(592, 19);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(191, 36);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(819, 17);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(191, 36);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(350, 70);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(191, 36);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFiltroCiclo
            // 
            this.cbFiltroCiclo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCiclo.FormattingEnabled = true;
            this.cbFiltroCiclo.Location = new System.Drawing.Point(154, 77);
            this.cbFiltroCiclo.Name = "cbFiltroCiclo";
            this.cbFiltroCiclo.Size = new System.Drawing.Size(121, 24);
            this.cbFiltroCiclo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtro por Ciclo:";
            // 
            // frmBuscarConvocatoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 525);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFiltroCiclo);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtFiltroNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvConvocatoria);
            this.Name = "frmBuscarConvocatoria";
            this.Text = "BuscarConvocatoria";
            this.Load += new System.EventHandler(this.BuscarConvocatoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvocatoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConvocatoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCandidatosPrevistos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadTotalCandidatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPostulantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadSeleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn CicloConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCreadorConvocatoria;
        private System.Windows.Forms.ComboBox cbFiltroCiclo;
        private System.Windows.Forms.Label label2;
    }
}