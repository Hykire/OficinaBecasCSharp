namespace Vista
{
    partial class CoordinadorComunicaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGestionarConvocatoria = new System.Windows.Forms.Button();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.ContestóSolicitudFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoBeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadDeCréditos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatosPersonales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnFiltrarResultados = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lbDatosPersonales = new System.Windows.Forms.Label();
            this.lbCantidadCreditos = new System.Windows.Forms.Label();
            this.lbTipoBeca = new System.Windows.Forms.Label();
            this.lbSolicitud = new System.Windows.Forms.Label();
            this.txtTipoBeca = new System.Windows.Forms.TextBox();
            this.txtDatosPersonales = new System.Windows.Forms.TextBox();
            this.txtCantidadCreditos = new System.Windows.Forms.TextBox();
            this.cbSolicitud = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Consultar:";
            // 
            // btnGestionarConvocatoria
            // 
            this.btnGestionarConvocatoria.Location = new System.Drawing.Point(90, 118);
            this.btnGestionarConvocatoria.Name = "btnGestionarConvocatoria";
            this.btnGestionarConvocatoria.Size = new System.Drawing.Size(157, 51);
            this.btnGestionarConvocatoria.TabIndex = 15;
            this.btnGestionarConvocatoria.Text = "Gestionar Convocatoria";
            this.btnGestionarConvocatoria.UseVisualStyleBackColor = true;
            this.btnGestionarConvocatoria.Click += new System.EventHandler(this.btnGestionarConvocatoria_Click);
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(135, 58);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(156, 24);
            this.cbConsulta.TabIndex = 16;
            // 
            // ContestóSolicitudFecha
            // 
            this.ContestóSolicitudFecha.HeaderText = "ContestóSolicitudFecha";
            this.ContestóSolicitudFecha.Name = "ContestóSolicitudFecha";
            // 
            // TipoBeca
            // 
            this.TipoBeca.HeaderText = "TipoBeca";
            this.TipoBeca.Name = "TipoBeca";
            // 
            // CantidadDeCréditos
            // 
            this.CantidadDeCréditos.HeaderText = "CantidadDeCréditos";
            this.CantidadDeCréditos.Name = "CantidadDeCréditos";
            // 
            // DatosPersonales
            // 
            this.DatosPersonales.HeaderText = "DatosPersonales";
            this.DatosPersonales.Name = "DatosPersonales";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DatosPersonales,
            this.CantidadDeCréditos,
            this.TipoBeca,
            this.ContestóSolicitudFecha});
            this.dgvDatos.Location = new System.Drawing.Point(557, 97);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(454, 354);
            this.dgvDatos.TabIndex = 18;
            // 
            // btnFiltrarResultados
            // 
            this.btnFiltrarResultados.Location = new System.Drawing.Point(557, 49);
            this.btnFiltrarResultados.Name = "btnFiltrarResultados";
            this.btnFiltrarResultados.Size = new System.Drawing.Size(139, 33);
            this.btnFiltrarResultados.TabIndex = 19;
            this.btnFiltrarResultados.Text = "Filtrar Resultados";
            this.btnFiltrarResultados.UseVisualStyleBackColor = true;
            this.btnFiltrarResultados.Click += new System.EventHandler(this.btnFiltrarResultados_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(895, 49);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 33);
            this.btnModificar.TabIndex = 20;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lbDatosPersonales
            // 
            this.lbDatosPersonales.AutoSize = true;
            this.lbDatosPersonales.Location = new System.Drawing.Point(36, 243);
            this.lbDatosPersonales.Name = "lbDatosPersonales";
            this.lbDatosPersonales.Size = new System.Drawing.Size(124, 17);
            this.lbDatosPersonales.TabIndex = 21;
            this.lbDatosPersonales.Text = "Datos Personales:";
            // 
            // lbCantidadCreditos
            // 
            this.lbCantidadCreditos.AutoSize = true;
            this.lbCantidadCreditos.Location = new System.Drawing.Point(36, 297);
            this.lbCantidadCreditos.Name = "lbCantidadCreditos";
            this.lbCantidadCreditos.Size = new System.Drawing.Size(144, 17);
            this.lbCantidadCreditos.TabIndex = 22;
            this.lbCantidadCreditos.Text = "Cantidad de Créditos:";
            // 
            // lbTipoBeca
            // 
            this.lbTipoBeca.AutoSize = true;
            this.lbTipoBeca.Location = new System.Drawing.Point(36, 346);
            this.lbTipoBeca.Name = "lbTipoBeca";
            this.lbTipoBeca.Size = new System.Drawing.Size(96, 17);
            this.lbTipoBeca.TabIndex = 23;
            this.lbTipoBeca.Text = "Tipo de Beca:";
            // 
            // lbSolicitud
            // 
            this.lbSolicitud.AutoSize = true;
            this.lbSolicitud.Location = new System.Drawing.Point(36, 395);
            this.lbSolicitud.Name = "lbSolicitud";
            this.lbSolicitud.Size = new System.Drawing.Size(211, 17);
            this.lbSolicitud.TabIndex = 24;
            this.lbSolicitud.Text = "¿Contestó Solicitud a la Fecha?:";
            // 
            // txtTipoBeca
            // 
            this.txtTipoBeca.Location = new System.Drawing.Point(259, 341);
            this.txtTipoBeca.Name = "txtTipoBeca";
            this.txtTipoBeca.Size = new System.Drawing.Size(249, 22);
            this.txtTipoBeca.TabIndex = 25;
            // 
            // txtDatosPersonales
            // 
            this.txtDatosPersonales.Location = new System.Drawing.Point(259, 243);
            this.txtDatosPersonales.Name = "txtDatosPersonales";
            this.txtDatosPersonales.Size = new System.Drawing.Size(249, 22);
            this.txtDatosPersonales.TabIndex = 26;
            this.txtDatosPersonales.TextChanged += new System.EventHandler(this.txtDatosPersonales_TextChanged);
            // 
            // txtCantidadCreditos
            // 
            this.txtCantidadCreditos.Location = new System.Drawing.Point(259, 292);
            this.txtCantidadCreditos.Name = "txtCantidadCreditos";
            this.txtCantidadCreditos.Size = new System.Drawing.Size(249, 22);
            this.txtCantidadCreditos.TabIndex = 27;
            // 
            // cbSolicitud
            // 
            this.cbSolicitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSolicitud.FormattingEnabled = true;
            this.cbSolicitud.Location = new System.Drawing.Point(352, 388);
            this.cbSolicitud.Name = "cbSolicitud";
            this.cbSolicitud.Size = new System.Drawing.Size(54, 24);
            this.cbSolicitud.TabIndex = 28;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(206, 429);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 33);
            this.btnAceptar.TabIndex = 29;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // CoordinadorComunicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 519);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbSolicitud);
            this.Controls.Add(this.txtCantidadCreditos);
            this.Controls.Add(this.txtDatosPersonales);
            this.Controls.Add(this.txtTipoBeca);
            this.Controls.Add(this.lbSolicitud);
            this.Controls.Add(this.lbTipoBeca);
            this.Controls.Add(this.lbCantidadCreditos);
            this.Controls.Add(this.lbDatosPersonales);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnFiltrarResultados);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.btnGestionarConvocatoria);
            this.Name = "CoordinadorComunicaciones";
            this.Text = "Coordinador Comunicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGestionarConvocatoria;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContestóSolicitudFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoBeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadDeCréditos;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatosPersonales;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnFiltrarResultados;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lbDatosPersonales;
        private System.Windows.Forms.Label lbCantidadCreditos;
        private System.Windows.Forms.Label lbTipoBeca;
        private System.Windows.Forms.Label lbSolicitud;
        private System.Windows.Forms.TextBox txtTipoBeca;
        private System.Windows.Forms.TextBox txtDatosPersonales;
        private System.Windows.Forms.TextBox txtCantidadCreditos;
        private System.Windows.Forms.ComboBox cbSolicitud;
        private System.Windows.Forms.Button btnAceptar;
    }
}