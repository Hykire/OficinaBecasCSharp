﻿namespace Vista
{
    partial class frmGConvocatoriaActual
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGConvocatoriaActual));
            this.panelCC = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadSeleccionados = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCicloConvocatoria = new System.Windows.Forms.ComboBox();
            this.txtCreadorConvocatoria = new System.Windows.Forms.TextBox();
            this.txtTotalCandidatos = new System.Windows.Forms.TextBox();
            this.txtCantidadCandidatosPrevistos = new System.Windows.Forms.TextBox();
            this.txtCantidadPostulantes = new System.Windows.Forms.TextBox();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtBecaAsociada = new System.Windows.Forms.TextBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtDescripcionConvocatoria = new System.Windows.Forms.TextBox();
            this.txtIdConvocatoria = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBeca = new System.Windows.Forms.Button();
            this.lbNombreConvocatoria = new System.Windows.Forms.Label();
            this.txtNombreConvocatoria = new System.Windows.Forms.TextBox();
            this.lbBeca = new System.Windows.Forms.Label();
            this.lbDescripciónConvocatoria = new System.Windows.Forms.Label();
            this.lbNumeroRespuestas = new System.Windows.Forms.Label();
            this.toolStrip_historiaacademica = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.panelCC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip_historiaacademica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCC
            // 
            this.panelCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCC.Controls.Add(this.groupBox1);
            this.panelCC.Controls.Add(this.lbNumeroRespuestas);
            this.panelCC.Location = new System.Drawing.Point(13, 21);
            this.panelCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCC.Name = "panelCC";
            this.panelCC.Size = new System.Drawing.Size(986, 301);
            this.panelCC.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidadSeleccionados);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbCicloConvocatoria);
            this.groupBox1.Controls.Add(this.txtCreadorConvocatoria);
            this.groupBox1.Controls.Add(this.txtTotalCandidatos);
            this.groupBox1.Controls.Add(this.txtCantidadCandidatosPrevistos);
            this.groupBox1.Controls.Add(this.txtCantidadPostulantes);
            this.groupBox1.Controls.Add(this.dtFechaCreacion);
            this.groupBox1.Controls.Add(this.txtBecaAsociada);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.dtFechaInicio);
            this.groupBox1.Controls.Add(this.txtDescripcionConvocatoria);
            this.groupBox1.Controls.Add(this.txtIdConvocatoria);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBeca);
            this.groupBox1.Controls.Add(this.lbNombreConvocatoria);
            this.groupBox1.Controls.Add(this.txtNombreConvocatoria);
            this.groupBox1.Controls.Add(this.lbBeca);
            this.groupBox1.Controls.Add(this.lbDescripciónConvocatoria);
            this.groupBox1.Location = new System.Drawing.Point(25, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(933, 261);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales de la Convocatoria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtCantidadSeleccionados
            // 
            this.txtCantidadSeleccionados.Location = new System.Drawing.Point(847, 183);
            this.txtCantidadSeleccionados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadSeleccionados.Name = "txtCantidadSeleccionados";
            this.txtCantidadSeleccionados.Size = new System.Drawing.Size(59, 22);
            this.txtCantidadSeleccionados.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 17);
            this.label10.TabIndex = 71;
            this.label10.Text = "Cantidad de Seleccionados:";
            // 
            // cbCicloConvocatoria
            // 
            this.cbCicloConvocatoria.FormattingEnabled = true;
            this.cbCicloConvocatoria.Location = new System.Drawing.Point(252, 213);
            this.cbCicloConvocatoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCicloConvocatoria.Name = "cbCicloConvocatoria";
            this.cbCicloConvocatoria.Size = new System.Drawing.Size(181, 24);
            this.cbCicloConvocatoria.TabIndex = 9;
            // 
            // txtCreadorConvocatoria
            // 
            this.txtCreadorConvocatoria.Location = new System.Drawing.Point(715, 124);
            this.txtCreadorConvocatoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCreadorConvocatoria.Name = "txtCreadorConvocatoria";
            this.txtCreadorConvocatoria.Size = new System.Drawing.Size(191, 22);
            this.txtCreadorConvocatoria.TabIndex = 11;
            // 
            // txtTotalCandidatos
            // 
            this.txtTotalCandidatos.Location = new System.Drawing.Point(847, 154);
            this.txtTotalCandidatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalCandidatos.Name = "txtTotalCandidatos";
            this.txtTotalCandidatos.Size = new System.Drawing.Size(59, 22);
            this.txtTotalCandidatos.TabIndex = 7;
            // 
            // txtCantidadCandidatosPrevistos
            // 
            this.txtCantidadCandidatosPrevistos.Location = new System.Drawing.Point(252, 154);
            this.txtCantidadCandidatosPrevistos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadCandidatosPrevistos.MaxLength = 4;
            this.txtCantidadCandidatosPrevistos.Name = "txtCantidadCandidatosPrevistos";
            this.txtCantidadCandidatosPrevistos.Size = new System.Drawing.Size(59, 22);
            this.txtCantidadCandidatosPrevistos.TabIndex = 8;
            // 
            // txtCantidadPostulantes
            // 
            this.txtCantidadPostulantes.Location = new System.Drawing.Point(252, 183);
            this.txtCantidadPostulantes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadPostulantes.Name = "txtCantidadPostulantes";
            this.txtCantidadPostulantes.Size = new System.Drawing.Size(59, 22);
            this.txtCantidadPostulantes.TabIndex = 10;
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.Location = new System.Drawing.Point(252, 124);
            this.dtFechaCreacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(252, 22);
            this.dtFechaCreacion.TabIndex = 6;
            // 
            // txtBecaAsociada
            // 
            this.txtBecaAsociada.Location = new System.Drawing.Point(625, 213);
            this.txtBecaAsociada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBecaAsociada.Name = "txtBecaAsociada";
            this.txtBecaAsociada.Size = new System.Drawing.Size(237, 22);
            this.txtBecaAsociada.TabIndex = 12;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(648, 64);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(257, 22);
            this.dtFechaFin.TabIndex = 4;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(647, 36);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(259, 22);
            this.dtFechaInicio.TabIndex = 2;
            this.dtFechaInicio.Value = new System.DateTime(2109, 12, 31, 0, 0, 0, 0);
            // 
            // txtDescripcionConvocatoria
            // 
            this.txtDescripcionConvocatoria.Location = new System.Drawing.Point(252, 95);
            this.txtDescripcionConvocatoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripcionConvocatoria.MaxLength = 200;
            this.txtDescripcionConvocatoria.Name = "txtDescripcionConvocatoria";
            this.txtDescripcionConvocatoria.Size = new System.Drawing.Size(653, 22);
            this.txtDescripcionConvocatoria.TabIndex = 5;
            // 
            // txtIdConvocatoria
            // 
            this.txtIdConvocatoria.Location = new System.Drawing.Point(252, 36);
            this.txtIdConvocatoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdConvocatoria.Name = "txtIdConvocatoria";
            this.txtIdConvocatoria.Size = new System.Drawing.Size(59, 22);
            this.txtIdConvocatoria.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 17);
            this.label9.TabIndex = 69;
            this.label9.Text = "Id Convocatoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(511, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Creador de Convocatoria:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ciclo de Convocatoria:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Cantidad Total de Candidatos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cantidad de Postulantes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cantidad de Candidatos Previstos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fecha Creación:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Fecha Fin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha Inicio:";
            // 
            // btnBeca
            // 
            this.btnBeca.Location = new System.Drawing.Point(872, 213);
            this.btnBeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeca.Name = "btnBeca";
            this.btnBeca.Size = new System.Drawing.Size(35, 25);
            this.btnBeca.TabIndex = 13;
            this.btnBeca.Text = "...";
            this.btnBeca.UseVisualStyleBackColor = true;
            this.btnBeca.Click += new System.EventHandler(this.btnBeca_Click_1);
            // 
            // lbNombreConvocatoria
            // 
            this.lbNombreConvocatoria.AutoSize = true;
            this.lbNombreConvocatoria.Location = new System.Drawing.Point(23, 69);
            this.lbNombreConvocatoria.Name = "lbNombreConvocatoria";
            this.lbNombreConvocatoria.Size = new System.Drawing.Size(169, 17);
            this.lbNombreConvocatoria.TabIndex = 47;
            this.lbNombreConvocatoria.Text = "Nombre de Convocatoria:";
            // 
            // txtNombreConvocatoria
            // 
            this.txtNombreConvocatoria.Location = new System.Drawing.Point(252, 65);
            this.txtNombreConvocatoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreConvocatoria.MaxLength = 50;
            this.txtNombreConvocatoria.Name = "txtNombreConvocatoria";
            this.txtNombreConvocatoria.Size = new System.Drawing.Size(192, 22);
            this.txtNombreConvocatoria.TabIndex = 3;
            this.txtNombreConvocatoria.TextChanged += new System.EventHandler(this.txtNombreConvocatoria_TextChanged);
            // 
            // lbBeca
            // 
            this.lbBeca.AutoSize = true;
            this.lbBeca.Location = new System.Drawing.Point(511, 217);
            this.lbBeca.Name = "lbBeca";
            this.lbBeca.Size = new System.Drawing.Size(106, 17);
            this.lbBeca.TabIndex = 57;
            this.lbBeca.Text = "Beca Asociada:";
            // 
            // lbDescripciónConvocatoria
            // 
            this.lbDescripciónConvocatoria.AutoSize = true;
            this.lbDescripciónConvocatoria.Location = new System.Drawing.Point(21, 98);
            this.lbDescripciónConvocatoria.Name = "lbDescripciónConvocatoria";
            this.lbDescripciónConvocatoria.Size = new System.Drawing.Size(193, 17);
            this.lbDescripciónConvocatoria.TabIndex = 56;
            this.lbDescripciónConvocatoria.Text = "Descripción de Convocatoria:";
            // 
            // lbNumeroRespuestas
            // 
            this.lbNumeroRespuestas.AutoSize = true;
            this.lbNumeroRespuestas.Location = new System.Drawing.Point(12, 119);
            this.lbNumeroRespuestas.Name = "lbNumeroRespuestas";
            this.lbNumeroRespuestas.Size = new System.Drawing.Size(0, 17);
            this.lbNumeroRespuestas.TabIndex = 44;
            this.lbNumeroRespuestas.Click += new System.EventHandler(this.lbNumeroRespuestas_Click);
            // 
            // toolStrip_historiaacademica
            // 
            this.toolStrip_historiaacademica.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_historiaacademica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnBuscar,
            this.btnLimpiar});
            this.toolStrip_historiaacademica.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_historiaacademica.Name = "toolStrip_historiaacademica";
            this.toolStrip_historiaacademica.Size = new System.Drawing.Size(1019, 27);
            this.toolStrip_historiaacademica.TabIndex = 5;
            this.toolStrip_historiaacademica.Text = "toolStrip2";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 24);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 24);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmGConvocatoriaActual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 699);
            this.Controls.Add(this.toolStrip_historiaacademica);
            this.Controls.Add(this.panelCC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGConvocatoriaActual";
            this.Text = "CoordinadorComunicaciones";
            this.Load += new System.EventHandler(this.CoordinadorComunicaciones_Load);
            this.panelCC.ResumeLayout(false);
            this.panelCC.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip_historiaacademica.ResumeLayout(false);
            this.toolStrip_historiaacademica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCC;
        private System.Windows.Forms.Label lbNumeroRespuestas;
        private System.Windows.Forms.Label lbNombreConvocatoria;
        private System.Windows.Forms.TextBox txtNombreConvocatoria;
        private System.Windows.Forms.Label lbDescripciónConvocatoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCreadorConvocatoria;
        private System.Windows.Forms.TextBox txtTotalCandidatos;
        private System.Windows.Forms.TextBox txtCantidadCandidatosPrevistos;
        private System.Windows.Forms.TextBox txtCantidadPostulantes;
        private System.Windows.Forms.DateTimePicker dtFechaCreacion;
        private System.Windows.Forms.TextBox txtBecaAsociada;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.TextBox txtDescripcionConvocatoria;
        private System.Windows.Forms.TextBox txtIdConvocatoria;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBeca;
        private System.Windows.Forms.Label lbBeca;
        private System.Windows.Forms.ComboBox cbCicloConvocatoria;
        private System.Windows.Forms.TextBox txtCantidadSeleccionados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStrip toolStrip_historiaacademica;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
    }
}