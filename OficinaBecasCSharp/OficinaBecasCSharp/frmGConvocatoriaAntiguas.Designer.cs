namespace Vista
{
    partial class frmGConvocatoriaAntiguas
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPersonalizar = new System.Windows.Forms.Button();
            this.chCreador = new System.Windows.Forms.CheckBox();
            this.chCiclo = new System.Windows.Forms.CheckBox();
            this.chBeca = new System.Windows.Forms.CheckBox();
            this.chPostulantes = new System.Windows.Forms.CheckBox();
            this.chSeleccionados = new System.Windows.Forms.CheckBox();
            this.chPrevistos = new System.Windows.Forms.CheckBox();
            this.chCandidatos = new System.Windows.Forms.CheckBox();
            this.chFechaFin = new System.Windows.Forms.CheckBox();
            this.chFechaCreacion = new System.Windows.Forms.CheckBox();
            this.chDescripcion = new System.Windows.Forms.CheckBox();
            this.chFechaInicio = new System.Windows.Forms.CheckBox();
            this.chNombre = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvocatoria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.dgvConvocatoria.Location = new System.Drawing.Point(19, 83);
            this.dgvConvocatoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvConvocatoria.Name = "dgvConvocatoria";
            this.dgvConvocatoria.ReadOnly = true;
            this.dgvConvocatoria.RowTemplate.Height = 24;
            this.dgvConvocatoria.Size = new System.Drawing.Size(699, 315);
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
            this.DescripcionConvocatoria.Width = 180;
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
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro por Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFiltroNombre
            // 
            this.txtFiltroNombre.Location = new System.Drawing.Point(110, 19);
            this.txtFiltroNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFiltroNombre.Name = "txtFiltroNombre";
            this.txtFiltroNombre.Size = new System.Drawing.Size(283, 20);
            this.txtFiltroNombre.TabIndex = 2;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(532, 19);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(85, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(621, 19);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 23);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(224, 43);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(68, 23);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cbFiltroCiclo
            // 
            this.cbFiltroCiclo.FormattingEnabled = true;
            this.cbFiltroCiclo.Location = new System.Drawing.Point(110, 43);
            this.cbFiltroCiclo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbFiltroCiclo.Name = "cbFiltroCiclo";
            this.cbFiltroCiclo.Size = new System.Drawing.Size(92, 21);
            this.cbFiltroCiclo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtro por Ciclo:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(325, 43);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(68, 23);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPersonalizar);
            this.groupBox1.Controls.Add(this.chCreador);
            this.groupBox1.Controls.Add(this.chCiclo);
            this.groupBox1.Controls.Add(this.chBeca);
            this.groupBox1.Controls.Add(this.chPostulantes);
            this.groupBox1.Controls.Add(this.chSeleccionados);
            this.groupBox1.Controls.Add(this.chPrevistos);
            this.groupBox1.Controls.Add(this.chCandidatos);
            this.groupBox1.Controls.Add(this.chFechaFin);
            this.groupBox1.Controls.Add(this.chFechaCreacion);
            this.groupBox1.Controls.Add(this.chDescripcion);
            this.groupBox1.Controls.Add(this.chFechaInicio);
            this.groupBox1.Controls.Add(this.chNombre);
            this.groupBox1.Location = new System.Drawing.Point(19, 413);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(699, 108);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar Columnas Visibles";
            // 
            // btnPersonalizar
            // 
            this.btnPersonalizar.Location = new System.Drawing.Point(602, 31);
            this.btnPersonalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPersonalizar.Name = "btnPersonalizar";
            this.btnPersonalizar.Size = new System.Drawing.Size(85, 23);
            this.btnPersonalizar.TabIndex = 25;
            this.btnPersonalizar.Text = "Personalizar";
            this.btnPersonalizar.UseVisualStyleBackColor = true;
            this.btnPersonalizar.Click += new System.EventHandler(this.btnPersonalizar_Click);
            // 
            // chCreador
            // 
            this.chCreador.AutoSize = true;
            this.chCreador.Location = new System.Drawing.Point(361, 73);
            this.chCreador.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chCreador.Name = "chCreador";
            this.chCreador.Size = new System.Drawing.Size(63, 17);
            this.chCreador.TabIndex = 24;
            this.chCreador.Text = "Creador";
            this.chCreador.UseVisualStyleBackColor = true;
            // 
            // chCiclo
            // 
            this.chCiclo.AutoSize = true;
            this.chCiclo.Location = new System.Drawing.Point(361, 31);
            this.chCiclo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chCiclo.Name = "chCiclo";
            this.chCiclo.Size = new System.Drawing.Size(49, 17);
            this.chCiclo.TabIndex = 22;
            this.chCiclo.Text = "Ciclo";
            this.chCiclo.UseVisualStyleBackColor = true;
            // 
            // chBeca
            // 
            this.chBeca.AutoSize = true;
            this.chBeca.Location = new System.Drawing.Point(361, 52);
            this.chBeca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chBeca.Name = "chBeca";
            this.chBeca.Size = new System.Drawing.Size(51, 17);
            this.chBeca.TabIndex = 23;
            this.chBeca.Text = "Beca";
            this.chBeca.UseVisualStyleBackColor = true;
            // 
            // chPostulantes
            // 
            this.chPostulantes.AutoSize = true;
            this.chPostulantes.Location = new System.Drawing.Point(244, 31);
            this.chPostulantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chPostulantes.Name = "chPostulantes";
            this.chPostulantes.Size = new System.Drawing.Size(81, 17);
            this.chPostulantes.TabIndex = 20;
            this.chPostulantes.Text = "Postulantes";
            this.chPostulantes.UseVisualStyleBackColor = true;
            // 
            // chSeleccionados
            // 
            this.chSeleccionados.AutoSize = true;
            this.chSeleccionados.Location = new System.Drawing.Point(244, 73);
            this.chSeleccionados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chSeleccionados.Name = "chSeleccionados";
            this.chSeleccionados.Size = new System.Drawing.Size(96, 17);
            this.chSeleccionados.TabIndex = 21;
            this.chSeleccionados.Text = "Seleccionados";
            this.chSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chSeleccionados.UseVisualStyleBackColor = true;
            // 
            // chPrevistos
            // 
            this.chPrevistos.AutoSize = true;
            this.chPrevistos.Location = new System.Drawing.Point(123, 73);
            this.chPrevistos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chPrevistos.Name = "chPrevistos";
            this.chPrevistos.Size = new System.Drawing.Size(69, 17);
            this.chPrevistos.TabIndex = 18;
            this.chPrevistos.Text = "Previstos";
            this.chPrevistos.UseVisualStyleBackColor = true;
            // 
            // chCandidatos
            // 
            this.chCandidatos.AutoSize = true;
            this.chCandidatos.Location = new System.Drawing.Point(244, 52);
            this.chCandidatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chCandidatos.Name = "chCandidatos";
            this.chCandidatos.Size = new System.Drawing.Size(79, 17);
            this.chCandidatos.TabIndex = 19;
            this.chCandidatos.Text = "Candidatos";
            this.chCandidatos.UseVisualStyleBackColor = true;
            // 
            // chFechaFin
            // 
            this.chFechaFin.AutoSize = true;
            this.chFechaFin.Location = new System.Drawing.Point(123, 31);
            this.chFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chFechaFin.Name = "chFechaFin";
            this.chFechaFin.Size = new System.Drawing.Size(73, 17);
            this.chFechaFin.TabIndex = 16;
            this.chFechaFin.Text = "Fecha Fin";
            this.chFechaFin.UseVisualStyleBackColor = true;
            this.chFechaFin.CheckedChanged += new System.EventHandler(this.chFechaFin_CheckedChanged);
            // 
            // chFechaCreacion
            // 
            this.chFechaCreacion.AutoSize = true;
            this.chFechaCreacion.Location = new System.Drawing.Point(123, 52);
            this.chFechaCreacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chFechaCreacion.Name = "chFechaCreacion";
            this.chFechaCreacion.Size = new System.Drawing.Size(101, 17);
            this.chFechaCreacion.TabIndex = 17;
            this.chFechaCreacion.Text = "Fecha Creación";
            this.chFechaCreacion.UseVisualStyleBackColor = true;
            // 
            // chDescripcion
            // 
            this.chDescripcion.AutoSize = true;
            this.chDescripcion.Location = new System.Drawing.Point(21, 52);
            this.chDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chDescripcion.Name = "chDescripcion";
            this.chDescripcion.Size = new System.Drawing.Size(82, 17);
            this.chDescripcion.TabIndex = 14;
            this.chDescripcion.Text = "Descripción";
            this.chDescripcion.UseVisualStyleBackColor = true;
            // 
            // chFechaInicio
            // 
            this.chFechaInicio.AutoSize = true;
            this.chFechaInicio.Location = new System.Drawing.Point(21, 73);
            this.chFechaInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chFechaInicio.Name = "chFechaInicio";
            this.chFechaInicio.Size = new System.Drawing.Size(84, 17);
            this.chFechaInicio.TabIndex = 15;
            this.chFechaInicio.Text = "Fecha Inicio";
            this.chFechaInicio.UseVisualStyleBackColor = true;
            // 
            // chNombre
            // 
            this.chNombre.AutoSize = true;
            this.chNombre.Location = new System.Drawing.Point(21, 31);
            this.chNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chNombre.Name = "chNombre";
            this.chNombre.Size = new System.Drawing.Size(63, 17);
            this.chNombre.TabIndex = 13;
            this.chNombre.Text = "Nombre";
            this.chNombre.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtFiltroNombre);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvConvocatoria);
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSeleccionar);
            this.panel1.Controls.Add(this.cbFiltroCiclo);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 541);
            this.panel1.TabIndex = 10;
            // 
            // frmGConvocatoriaAntiguas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 646);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGConvocatoriaAntiguas";
            this.Text = "BuscarConvocatoria";
            this.Load += new System.EventHandler(this.BuscarConvocatoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConvocatoria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConvocatoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltroNombre;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ComboBox cbFiltroCiclo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chCreador;
        private System.Windows.Forms.CheckBox chCiclo;
        private System.Windows.Forms.CheckBox chBeca;
        private System.Windows.Forms.CheckBox chPostulantes;
        private System.Windows.Forms.CheckBox chSeleccionados;
        private System.Windows.Forms.CheckBox chPrevistos;
        private System.Windows.Forms.CheckBox chCandidatos;
        private System.Windows.Forms.CheckBox chFechaFin;
        private System.Windows.Forms.CheckBox chFechaCreacion;
        private System.Windows.Forms.CheckBox chDescripcion;
        private System.Windows.Forms.CheckBox chFechaInicio;
        private System.Windows.Forms.CheckBox chNombre;
        private System.Windows.Forms.Button btnPersonalizar;
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
        private System.Windows.Forms.Panel panel1;
    }
}