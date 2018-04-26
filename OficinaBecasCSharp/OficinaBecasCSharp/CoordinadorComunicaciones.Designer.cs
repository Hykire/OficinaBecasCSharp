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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBeca = new System.Windows.Forms.Button();
            this.txtDescripcionConvocatoria = new System.Windows.Forms.TextBox();
            this.lbBeca = new System.Windows.Forms.Label();
            this.lbDescripciónConvocatoria = new System.Windows.Forms.Label();
            this.txtNombreConvocatoria = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbBeca = new System.Windows.Forms.ComboBox();
            this.txtNumeroEnviados = new System.Windows.Forms.TextBox();
            this.txtNumeroRespuestas = new System.Windows.Forms.TextBox();
            this.txtFechaConvocatoria = new System.Windows.Forms.TextBox();
            this.lbNombreConvocatoria = new System.Windows.Forms.Label();
            this.lbFechaConvocatoria = new System.Windows.Forms.Label();
            this.lbNumeroTotalEnviados = new System.Windows.Forms.Label();
            this.lbNumeroRespuestas = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnFiltrarResultados = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NúmeroDeRespuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTotalEnviados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripciónConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.btnGestionarConvocatoria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(546, 13);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(575, 22);
            this.txtFiltro.TabIndex = 60;
            // 
            // btnBeca
            // 
            this.btnBeca.Location = new System.Drawing.Point(462, 400);
            this.btnBeca.Name = "btnBeca";
            this.btnBeca.Size = new System.Drawing.Size(35, 24);
            this.btnBeca.TabIndex = 59;
            this.btnBeca.Text = "...";
            this.btnBeca.UseVisualStyleBackColor = true;
            this.btnBeca.Click += new System.EventHandler(this.btnBeca_Click);
            // 
            // txtDescripcionConvocatoria
            // 
            this.txtDescripcionConvocatoria.Location = new System.Drawing.Point(248, 355);
            this.txtDescripcionConvocatoria.Name = "txtDescripcionConvocatoria";
            this.txtDescripcionConvocatoria.Size = new System.Drawing.Size(249, 22);
            this.txtDescripcionConvocatoria.TabIndex = 58;
            // 
            // lbBeca
            // 
            this.lbBeca.AutoSize = true;
            this.lbBeca.Location = new System.Drawing.Point(25, 403);
            this.lbBeca.Name = "lbBeca";
            this.lbBeca.Size = new System.Drawing.Size(44, 17);
            this.lbBeca.TabIndex = 57;
            this.lbBeca.Text = "Beca:";
            // 
            // lbDescripciónConvocatoria
            // 
            this.lbDescripciónConvocatoria.AutoSize = true;
            this.lbDescripciónConvocatoria.Location = new System.Drawing.Point(25, 360);
            this.lbDescripciónConvocatoria.Name = "lbDescripciónConvocatoria";
            this.lbDescripciónConvocatoria.Size = new System.Drawing.Size(193, 17);
            this.lbDescripciónConvocatoria.TabIndex = 56;
            this.lbDescripciónConvocatoria.Text = "Descripción de Convocatoria:";
            // 
            // txtNombreConvocatoria
            // 
            this.txtNombreConvocatoria.Location = new System.Drawing.Point(248, 306);
            this.txtNombreConvocatoria.Name = "txtNombreConvocatoria";
            this.txtNombreConvocatoria.Size = new System.Drawing.Size(249, 22);
            this.txtNombreConvocatoria.TabIndex = 55;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(1074, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 33);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(670, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(116, 33);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(164, 460);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(116, 33);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbBeca
            // 
            this.cbBeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeca.FormattingEnabled = true;
            this.cbBeca.Location = new System.Drawing.Point(248, 400);
            this.cbBeca.Name = "cbBeca";
            this.cbBeca.Size = new System.Drawing.Size(195, 24);
            this.cbBeca.TabIndex = 51;
            // 
            // txtNumeroEnviados
            // 
            this.txtNumeroEnviados.Location = new System.Drawing.Point(248, 208);
            this.txtNumeroEnviados.Name = "txtNumeroEnviados";
            this.txtNumeroEnviados.Size = new System.Drawing.Size(249, 22);
            this.txtNumeroEnviados.TabIndex = 50;
            // 
            // txtNumeroRespuestas
            // 
            this.txtNumeroRespuestas.Location = new System.Drawing.Point(248, 159);
            this.txtNumeroRespuestas.Name = "txtNumeroRespuestas";
            this.txtNumeroRespuestas.Size = new System.Drawing.Size(249, 22);
            this.txtNumeroRespuestas.TabIndex = 49;
            // 
            // txtFechaConvocatoria
            // 
            this.txtFechaConvocatoria.Location = new System.Drawing.Point(248, 257);
            this.txtFechaConvocatoria.Name = "txtFechaConvocatoria";
            this.txtFechaConvocatoria.Size = new System.Drawing.Size(249, 22);
            this.txtFechaConvocatoria.TabIndex = 48;
            // 
            // lbNombreConvocatoria
            // 
            this.lbNombreConvocatoria.AutoSize = true;
            this.lbNombreConvocatoria.Location = new System.Drawing.Point(25, 311);
            this.lbNombreConvocatoria.Name = "lbNombreConvocatoria";
            this.lbNombreConvocatoria.Size = new System.Drawing.Size(169, 17);
            this.lbNombreConvocatoria.TabIndex = 47;
            this.lbNombreConvocatoria.Text = "Nombre de Convocatoria:";
            // 
            // lbFechaConvocatoria
            // 
            this.lbFechaConvocatoria.AutoSize = true;
            this.lbFechaConvocatoria.Location = new System.Drawing.Point(25, 262);
            this.lbFechaConvocatoria.Name = "lbFechaConvocatoria";
            this.lbFechaConvocatoria.Size = new System.Drawing.Size(158, 17);
            this.lbFechaConvocatoria.TabIndex = 46;
            this.lbFechaConvocatoria.Text = "Fecha de Convocatoria:";
            // 
            // lbNumeroTotalEnviados
            // 
            this.lbNumeroTotalEnviados.AutoSize = true;
            this.lbNumeroTotalEnviados.Location = new System.Drawing.Point(25, 213);
            this.lbNumeroTotalEnviados.Name = "lbNumeroTotalEnviados";
            this.lbNumeroTotalEnviados.Size = new System.Drawing.Size(180, 17);
            this.lbNumeroTotalEnviados.TabIndex = 45;
            this.lbNumeroTotalEnviados.Text = "Número Total de Enviados:";
            // 
            // lbNumeroRespuestas
            // 
            this.lbNumeroRespuestas.AutoSize = true;
            this.lbNumeroRespuestas.Location = new System.Drawing.Point(25, 159);
            this.lbNumeroRespuestas.Name = "lbNumeroRespuestas";
            this.lbNumeroRespuestas.Size = new System.Drawing.Size(157, 17);
            this.lbNumeroRespuestas.TabIndex = 44;
            this.lbNumeroRespuestas.Text = "Número de Respuestas";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(867, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(116, 33);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFiltrarResultados
            // 
            this.btnFiltrarResultados.Location = new System.Drawing.Point(1154, 8);
            this.btnFiltrarResultados.Name = "btnFiltrarResultados";
            this.btnFiltrarResultados.Size = new System.Drawing.Size(139, 33);
            this.btnFiltrarResultados.TabIndex = 42;
            this.btnFiltrarResultados.Text = "Filtrar Resultados";
            this.btnFiltrarResultados.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConvocatoria,
            this.NúmeroDeRespuestas,
            this.NumeroTotalEnviados,
            this.FechaConvocatoria,
            this.NombreConvocatoria,
            this.DescripciónConvocatoria,
            this.Beca});
            this.dgvDatos.Location = new System.Drawing.Point(546, 56);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(747, 354);
            this.dgvDatos.TabIndex = 41;
            // 
            // idConvocatoria
            // 
            this.idConvocatoria.HeaderText = "idConvocatoria";
            this.idConvocatoria.Name = "idConvocatoria";
            // 
            // NúmeroDeRespuestas
            // 
            this.NúmeroDeRespuestas.HeaderText = "NúmeroDeRespuestas";
            this.NúmeroDeRespuestas.Name = "NúmeroDeRespuestas";
            // 
            // NumeroTotalEnviados
            // 
            this.NumeroTotalEnviados.HeaderText = "NumeroTotalEnviados";
            this.NumeroTotalEnviados.Name = "NumeroTotalEnviados";
            // 
            // FechaConvocatoria
            // 
            this.FechaConvocatoria.HeaderText = "FechaConvocatoria";
            this.FechaConvocatoria.Name = "FechaConvocatoria";
            // 
            // NombreConvocatoria
            // 
            this.NombreConvocatoria.HeaderText = "NombreConvocatoria";
            this.NombreConvocatoria.Name = "NombreConvocatoria";
            // 
            // DescripciónConvocatoria
            // 
            this.DescripciónConvocatoria.HeaderText = "DescripciónConvocatoria";
            this.DescripciónConvocatoria.Name = "DescripciónConvocatoria";
            // 
            // Beca
            // 
            this.Beca.HeaderText = "Beca";
            this.Beca.Name = "Beca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Consultar:";
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(124, 17);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(156, 24);
            this.cbConsulta.TabIndex = 39;
            // 
            // btnGestionarConvocatoria
            // 
            this.btnGestionarConvocatoria.Location = new System.Drawing.Point(79, 77);
            this.btnGestionarConvocatoria.Name = "btnGestionarConvocatoria";
            this.btnGestionarConvocatoria.Size = new System.Drawing.Size(157, 51);
            this.btnGestionarConvocatoria.TabIndex = 38;
            this.btnGestionarConvocatoria.Text = "Gestionar Convocatoria";
            this.btnGestionarConvocatoria.UseVisualStyleBackColor = true;
            this.btnGestionarConvocatoria.Click += new System.EventHandler(this.btnGestionarConvocatoria_Click);
            // 
            // CoordinadorComunicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 508);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnBeca);
            this.Controls.Add(this.txtDescripcionConvocatoria);
            this.Controls.Add(this.lbBeca);
            this.Controls.Add(this.lbDescripciónConvocatoria);
            this.Controls.Add(this.txtNombreConvocatoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cbBeca);
            this.Controls.Add(this.txtNumeroEnviados);
            this.Controls.Add(this.txtNumeroRespuestas);
            this.Controls.Add(this.txtFechaConvocatoria);
            this.Controls.Add(this.lbNombreConvocatoria);
            this.Controls.Add(this.lbFechaConvocatoria);
            this.Controls.Add(this.lbNumeroTotalEnviados);
            this.Controls.Add(this.lbNumeroRespuestas);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnFiltrarResultados);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConsulta);
            this.Controls.Add(this.btnGestionarConvocatoria);
            this.Name = "CoordinadorComunicaciones";
            this.Text = "CoordinadorComunicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBeca;
        private System.Windows.Forms.TextBox txtDescripcionConvocatoria;
        private System.Windows.Forms.Label lbBeca;
        private System.Windows.Forms.Label lbDescripciónConvocatoria;
        private System.Windows.Forms.TextBox txtNombreConvocatoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbBeca;
        private System.Windows.Forms.TextBox txtNumeroEnviados;
        private System.Windows.Forms.TextBox txtNumeroRespuestas;
        private System.Windows.Forms.TextBox txtFechaConvocatoria;
        private System.Windows.Forms.Label lbNombreConvocatoria;
        private System.Windows.Forms.Label lbFechaConvocatoria;
        private System.Windows.Forms.Label lbNumeroTotalEnviados;
        private System.Windows.Forms.Label lbNumeroRespuestas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnFiltrarResultados;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroDeRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTotalEnviados;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripciónConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Button btnGestionarConvocatoria;
    }
}