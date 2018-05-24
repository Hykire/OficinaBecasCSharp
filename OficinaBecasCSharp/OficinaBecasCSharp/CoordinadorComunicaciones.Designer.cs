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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinadorComunicaciones));
            this.panelCC = new System.Windows.Forms.Panel();
            this.lbNumeroRespuestas = new System.Windows.Forms.Label();
            this.lbNombreConvocatoria = new System.Windows.Forms.Label();
            this.txtNombreConvocatoria = new System.Windows.Forms.TextBox();
            this.lbDescripciónConvocatoria = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdConvocatoria = new System.Windows.Forms.TextBox();
            this.txtDescripcionConvocatoria = new System.Windows.Forms.TextBox();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.lbBeca = new System.Windows.Forms.Label();
            this.btnBeca = new System.Windows.Forms.Button();
            this.txtBecaAsociada = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.txtCantidadPersonasCovocadas = new System.Windows.Forms.TextBox();
            this.txtCantidadPersonasPrevistas = new System.Windows.Forms.TextBox();
            this.txtCantidadRespuestas = new System.Windows.Forms.TextBox();
            this.txtCreadorConvocatoria = new System.Windows.Forms.TextBox();
            this.cbCicloConvocatoria = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.panelCC.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCC
            // 
            this.panelCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCC.Controls.Add(this.groupBox1);
            this.panelCC.Controls.Add(this.lbNumeroRespuestas);
            this.panelCC.Location = new System.Drawing.Point(31, 2);
            this.panelCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelCC.Name = "panelCC";
            this.panelCC.Size = new System.Drawing.Size(1036, 553);
            this.panelCC.TabIndex = 1;
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
            // lbNombreConvocatoria
            // 
            this.lbNombreConvocatoria.AutoSize = true;
            this.lbNombreConvocatoria.Location = new System.Drawing.Point(23, 91);
            this.lbNombreConvocatoria.Name = "lbNombreConvocatoria";
            this.lbNombreConvocatoria.Size = new System.Drawing.Size(169, 17);
            this.lbNombreConvocatoria.TabIndex = 47;
            this.lbNombreConvocatoria.Text = "Nombre de Convocatoria:";
            // 
            // txtNombreConvocatoria
            // 
            this.txtNombreConvocatoria.Location = new System.Drawing.Point(234, 86);
            this.txtNombreConvocatoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombreConvocatoria.Name = "txtNombreConvocatoria";
            this.txtNombreConvocatoria.Size = new System.Drawing.Size(192, 22);
            this.txtNombreConvocatoria.TabIndex = 3;
            this.txtNombreConvocatoria.TextChanged += new System.EventHandler(this.txtNombreConvocatoria_TextChanged);
            // 
            // lbDescripciónConvocatoria
            // 
            this.lbDescripciónConvocatoria.AutoSize = true;
            this.lbDescripciónConvocatoria.Location = new System.Drawing.Point(23, 139);
            this.lbDescripciónConvocatoria.Name = "lbDescripciónConvocatoria";
            this.lbDescripciónConvocatoria.Size = new System.Drawing.Size(193, 17);
            this.lbDescripciónConvocatoria.TabIndex = 56;
            this.lbDescripciónConvocatoria.Text = "Descripción de Convocatoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 61;
            this.label1.Text = "Fecha Inicio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(560, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Fecha Fin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 63;
            this.label3.Text = "Fecha Creación:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 17);
            this.label4.TabIndex = 64;
            this.label4.Text = "Cantidad de Personas Previstas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cantidad de Personas Convocadas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(517, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Cantidad de Respuestas:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(517, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Ciclo de Convocatoria:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 296);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 17);
            this.label8.TabIndex = 68;
            this.label8.Text = "Creador de Convocatoria:";
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
            // txtIdConvocatoria
            // 
            this.txtIdConvocatoria.Location = new System.Drawing.Point(234, 36);
            this.txtIdConvocatoria.Name = "txtIdConvocatoria";
            this.txtIdConvocatoria.Size = new System.Drawing.Size(59, 22);
            this.txtIdConvocatoria.TabIndex = 1;
            // 
            // txtDescripcionConvocatoria
            // 
            this.txtDescripcionConvocatoria.Location = new System.Drawing.Point(234, 139);
            this.txtDescripcionConvocatoria.Name = "txtDescripcionConvocatoria";
            this.txtDescripcionConvocatoria.Size = new System.Drawing.Size(722, 22);
            this.txtDescripcionConvocatoria.TabIndex = 5;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Location = new System.Drawing.Point(683, 36);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.dtFechaInicio.TabIndex = 2;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(683, 84);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(200, 22);
            this.dtFechaFin.TabIndex = 4;
            // 
            // lbBeca
            // 
            this.lbBeca.AutoSize = true;
            this.lbBeca.Location = new System.Drawing.Point(245, 356);
            this.lbBeca.Name = "lbBeca";
            this.lbBeca.Size = new System.Drawing.Size(106, 17);
            this.lbBeca.TabIndex = 57;
            this.lbBeca.Text = "Beca Asociada:";
            // 
            // btnBeca
            // 
            this.btnBeca.Location = new System.Drawing.Point(612, 352);
            this.btnBeca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBeca.Name = "btnBeca";
            this.btnBeca.Size = new System.Drawing.Size(35, 25);
            this.btnBeca.TabIndex = 13;
            this.btnBeca.Text = "...";
            this.btnBeca.UseVisualStyleBackColor = true;
            this.btnBeca.Click += new System.EventHandler(this.btnBeca_Click_1);
            // 
            // txtBecaAsociada
            // 
            this.txtBecaAsociada.Location = new System.Drawing.Point(380, 353);
            this.txtBecaAsociada.Name = "txtBecaAsociada";
            this.txtBecaAsociada.Size = new System.Drawing.Size(212, 22);
            this.txtBecaAsociada.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCicloConvocatoria);
            this.groupBox1.Controls.Add(this.txtCreadorConvocatoria);
            this.groupBox1.Controls.Add(this.txtCantidadRespuestas);
            this.groupBox1.Controls.Add(this.txtCantidadPersonasPrevistas);
            this.groupBox1.Controls.Add(this.txtCantidadPersonasCovocadas);
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
            this.groupBox1.Location = new System.Drawing.Point(15, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1020, 481);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Generales de la Convocatoria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtFechaCreacion
            // 
            this.dtFechaCreacion.Location = new System.Drawing.Point(234, 186);
            this.dtFechaCreacion.Name = "dtFechaCreacion";
            this.dtFechaCreacion.Size = new System.Drawing.Size(200, 22);
            this.dtFechaCreacion.TabIndex = 6;
            // 
            // txtCantidadPersonasCovocadas
            // 
            this.txtCantidadPersonasCovocadas.Location = new System.Drawing.Point(274, 293);
            this.txtCantidadPersonasCovocadas.Name = "txtCantidadPersonasCovocadas";
            this.txtCantidadPersonasCovocadas.Size = new System.Drawing.Size(59, 22);
            this.txtCantidadPersonasCovocadas.TabIndex = 10;
            // 
            // txtCantidadPersonasPrevistas
            // 
            this.txtCantidadPersonasPrevistas.Location = new System.Drawing.Point(274, 240);
            this.txtCantidadPersonasPrevistas.Name = "txtCantidadPersonasPrevistas";
            this.txtCantidadPersonasPrevistas.Size = new System.Drawing.Size(59, 22);
            this.txtCantidadPersonasPrevistas.TabIndex = 8;
            // 
            // txtCantidadRespuestas
            // 
            this.txtCantidadRespuestas.Location = new System.Drawing.Point(714, 188);
            this.txtCantidadRespuestas.Name = "txtCantidadRespuestas";
            this.txtCantidadRespuestas.Size = new System.Drawing.Size(59, 22);
            this.txtCantidadRespuestas.TabIndex = 7;
            // 
            // txtCreadorConvocatoria
            // 
            this.txtCreadorConvocatoria.Location = new System.Drawing.Point(720, 291);
            this.txtCreadorConvocatoria.Name = "txtCreadorConvocatoria";
            this.txtCreadorConvocatoria.Size = new System.Drawing.Size(182, 22);
            this.txtCreadorConvocatoria.TabIndex = 11;
            // 
            // cbCicloConvocatoria
            // 
            this.cbCicloConvocatoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCicloConvocatoria.FormattingEnabled = true;
            this.cbCicloConvocatoria.Location = new System.Drawing.Point(720, 238);
            this.cbCicloConvocatoria.Name = "cbCicloConvocatoria";
            this.cbCicloConvocatoria.Size = new System.Drawing.Size(181, 24);
            this.cbCicloConvocatoria.TabIndex = 9;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnCancelar,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(76, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(86, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 24);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CoordinadorComunicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelCC);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CoordinadorComunicaciones";
            this.Text = "CoordinadorComunicaciones";
            this.Load += new System.EventHandler(this.CoordinadorComunicaciones_Load);
            this.panelCC.ResumeLayout(false);
            this.panelCC.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCantidadRespuestas;
        private System.Windows.Forms.TextBox txtCantidadPersonasPrevistas;
        private System.Windows.Forms.TextBox txtCantidadPersonasCovocadas;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
    }
}