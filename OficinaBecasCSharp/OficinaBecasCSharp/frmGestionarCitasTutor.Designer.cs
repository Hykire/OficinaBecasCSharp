namespace Vista
{
    partial class frmGestionarCitasTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarCitasTutor));
            this.PGestCitas = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIdtutOculto = new System.Windows.Forms.TextBox();
            this.btnBuscarTutor = new System.Windows.Forms.Button();
            this.txtBTutorGC = new System.Windows.Forms.TextBox();
            this.txtCodTutorGC = new System.Windows.Forms.TextBox();
            this.LTuutorGC = new System.Windows.Forms.Label();
            this.LCodTutorGC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdBecOculto = new System.Windows.Forms.TextBox();
            this.btnBuscarBecario = new System.Windows.Forms.Button();
            this.txtBBecarioGC = new System.Windows.Forms.TextBox();
            this.txtCodBecGC = new System.Windows.Forms.TextBox();
            this.LBecarioGC = new System.Windows.Forms.Label();
            this.LCódigoBecarioGC = new System.Windows.Forms.Label();
            this.GBObservGC = new System.Windows.Forms.GroupBox();
            this.txtBObsGC = new System.Windows.Forms.TextBox();
            this.BBuscarCitaGC = new System.Windows.Forms.Button();
            this.LTituloGC = new System.Windows.Forms.Label();
            this.GBDetalleCitaGC = new System.Windows.Forms.GroupBox();
            this.txtidCitaOculto = new System.Windows.Forms.TextBox();
            this.txtBLugarGC = new System.Windows.Forms.TextBox();
            this.LLugarGC = new System.Windows.Forms.Label();
            this.LFechaGC = new System.Windows.Forms.Label();
            this.LSelFechaGC = new System.Windows.Forms.Label();
            this.DTPSelDiaGC = new System.Windows.Forms.DateTimePicker();
            this.toolStrip_GestionarTutores = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.txtBFechaGC = new System.Windows.Forms.TextBox();
            this.PGestCitas.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBObservGC.SuspendLayout();
            this.GBDetalleCitaGC.SuspendLayout();
            this.toolStrip_GestionarTutores.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGestCitas
            // 
            this.PGestCitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PGestCitas.AutoSize = true;
            this.PGestCitas.Controls.Add(this.groupBox2);
            this.PGestCitas.Controls.Add(this.groupBox1);
            this.PGestCitas.Controls.Add(this.GBObservGC);
            this.PGestCitas.Controls.Add(this.BBuscarCitaGC);
            this.PGestCitas.Controls.Add(this.LTituloGC);
            this.PGestCitas.Controls.Add(this.GBDetalleCitaGC);
            this.PGestCitas.Controls.Add(this.LSelFechaGC);
            this.PGestCitas.Controls.Add(this.DTPSelDiaGC);
            this.PGestCitas.Location = new System.Drawing.Point(-1, -2);
            this.PGestCitas.Name = "PGestCitas";
            this.PGestCitas.Size = new System.Drawing.Size(802, 452);
            this.PGestCitas.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdtutOculto);
            this.groupBox2.Controls.Add(this.btnBuscarTutor);
            this.groupBox2.Controls.Add(this.txtBTutorGC);
            this.groupBox2.Controls.Add(this.txtCodTutorGC);
            this.groupBox2.Controls.Add(this.LTuutorGC);
            this.groupBox2.Controls.Add(this.LCodTutorGC);
            this.groupBox2.Location = new System.Drawing.Point(30, 282);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 98);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Tutor";
            // 
            // txtIdtutOculto
            // 
            this.txtIdtutOculto.Location = new System.Drawing.Point(295, 30);
            this.txtIdtutOculto.Name = "txtIdtutOculto";
            this.txtIdtutOculto.Size = new System.Drawing.Size(49, 20);
            this.txtIdtutOculto.TabIndex = 19;
            // 
            // btnBuscarTutor
            // 
            this.btnBuscarTutor.Location = new System.Drawing.Point(204, 27);
            this.btnBuscarTutor.Name = "btnBuscarTutor";
            this.btnBuscarTutor.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarTutor.TabIndex = 19;
            this.btnBuscarTutor.Text = "Buscar";
            this.btnBuscarTutor.UseVisualStyleBackColor = true;
            this.btnBuscarTutor.Click += new System.EventHandler(this.btnBuscarTutor_Click);
            // 
            // txtBTutorGC
            // 
            this.txtBTutorGC.Location = new System.Drawing.Point(89, 55);
            this.txtBTutorGC.Name = "txtBTutorGC";
            this.txtBTutorGC.Size = new System.Drawing.Size(255, 20);
            this.txtBTutorGC.TabIndex = 9;
            // 
            // txtCodTutorGC
            // 
            this.txtCodTutorGC.Location = new System.Drawing.Point(89, 29);
            this.txtCodTutorGC.Name = "txtCodTutorGC";
            this.txtCodTutorGC.Size = new System.Drawing.Size(100, 20);
            this.txtCodTutorGC.TabIndex = 16;
            // 
            // LTuutorGC
            // 
            this.LTuutorGC.AutoSize = true;
            this.LTuutorGC.Location = new System.Drawing.Point(16, 62);
            this.LTuutorGC.Name = "LTuutorGC";
            this.LTuutorGC.Size = new System.Drawing.Size(35, 13);
            this.LTuutorGC.TabIndex = 3;
            this.LTuutorGC.Text = "Tutor:";
            // 
            // LCodTutorGC
            // 
            this.LCodTutorGC.AutoSize = true;
            this.LCodTutorGC.Location = new System.Drawing.Point(16, 32);
            this.LCodTutorGC.Name = "LCodTutorGC";
            this.LCodTutorGC.Size = new System.Drawing.Size(67, 13);
            this.LCodTutorGC.TabIndex = 15;
            this.LCodTutorGC.Text = "Código tutor:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdBecOculto);
            this.groupBox1.Controls.Add(this.btnBuscarBecario);
            this.groupBox1.Controls.Add(this.txtBBecarioGC);
            this.groupBox1.Controls.Add(this.txtCodBecGC);
            this.groupBox1.Controls.Add(this.LBecarioGC);
            this.groupBox1.Controls.Add(this.LCódigoBecarioGC);
            this.groupBox1.Location = new System.Drawing.Point(434, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 103);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Becario";
            // 
            // txtIdBecOculto
            // 
            this.txtIdBecOculto.Location = new System.Drawing.Point(299, 29);
            this.txtIdBecOculto.Name = "txtIdBecOculto";
            this.txtIdBecOculto.Size = new System.Drawing.Size(49, 20);
            this.txtIdBecOculto.TabIndex = 20;
            // 
            // btnBuscarBecario
            // 
            this.btnBuscarBecario.Location = new System.Drawing.Point(208, 27);
            this.btnBuscarBecario.Name = "btnBuscarBecario";
            this.btnBuscarBecario.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarBecario.TabIndex = 18;
            this.btnBuscarBecario.Text = "Buscar";
            this.btnBuscarBecario.UseVisualStyleBackColor = true;
            this.btnBuscarBecario.Click += new System.EventHandler(this.btnBuscarBecario_Click);
            // 
            // txtBBecarioGC
            // 
            this.txtBBecarioGC.Location = new System.Drawing.Point(101, 58);
            this.txtBBecarioGC.Name = "txtBBecarioGC";
            this.txtBBecarioGC.Size = new System.Drawing.Size(248, 20);
            this.txtBBecarioGC.TabIndex = 10;
            // 
            // txtCodBecGC
            // 
            this.txtCodBecGC.Location = new System.Drawing.Point(101, 30);
            this.txtCodBecGC.Name = "txtCodBecGC";
            this.txtCodBecGC.Size = new System.Drawing.Size(100, 20);
            this.txtCodBecGC.TabIndex = 17;
            // 
            // LBecarioGC
            // 
            this.LBecarioGC.AutoSize = true;
            this.LBecarioGC.Location = new System.Drawing.Point(13, 66);
            this.LBecarioGC.Name = "LBecarioGC";
            this.LBecarioGC.Size = new System.Drawing.Size(46, 13);
            this.LBecarioGC.TabIndex = 4;
            this.LBecarioGC.Text = "Becario:";
            // 
            // LCódigoBecarioGC
            // 
            this.LCódigoBecarioGC.AutoSize = true;
            this.LCódigoBecarioGC.Location = new System.Drawing.Point(13, 34);
            this.LCódigoBecarioGC.Name = "LCódigoBecarioGC";
            this.LCódigoBecarioGC.Size = new System.Drawing.Size(82, 13);
            this.LCódigoBecarioGC.TabIndex = 16;
            this.LCódigoBecarioGC.Text = "Código Becario:";
            // 
            // GBObservGC
            // 
            this.GBObservGC.Controls.Add(this.txtBObsGC);
            this.GBObservGC.Location = new System.Drawing.Point(434, 282);
            this.GBObservGC.Name = "GBObservGC";
            this.GBObservGC.Size = new System.Drawing.Size(355, 98);
            this.GBObservGC.TabIndex = 8;
            this.GBObservGC.TabStop = false;
            this.GBObservGC.Text = "Observaciones";
            // 
            // txtBObsGC
            // 
            this.txtBObsGC.Location = new System.Drawing.Point(6, 28);
            this.txtBObsGC.Multiline = true;
            this.txtBObsGC.Name = "txtBObsGC";
            this.txtBObsGC.Size = new System.Drawing.Size(343, 61);
            this.txtBObsGC.TabIndex = 13;
            // 
            // BBuscarCitaGC
            // 
            this.BBuscarCitaGC.Location = new System.Drawing.Point(357, 72);
            this.BBuscarCitaGC.Name = "BBuscarCitaGC";
            this.BBuscarCitaGC.Size = new System.Drawing.Size(94, 23);
            this.BBuscarCitaGC.TabIndex = 4;
            this.BBuscarCitaGC.Text = "Buscar Cita";
            this.BBuscarCitaGC.UseVisualStyleBackColor = true;
            this.BBuscarCitaGC.Click += new System.EventHandler(this.BBuscarCitaGC_Click);
            // 
            // LTituloGC
            // 
            this.LTituloGC.AutoSize = true;
            this.LTituloGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGC.Location = new System.Drawing.Point(19, 35);
            this.LTituloGC.Name = "LTituloGC";
            this.LTituloGC.Size = new System.Drawing.Size(134, 20);
            this.LTituloGC.TabIndex = 2;
            this.LTituloGC.Text = "Gestionar Citas";
            // 
            // GBDetalleCitaGC
            // 
            this.GBDetalleCitaGC.Controls.Add(this.txtidCitaOculto);
            this.GBDetalleCitaGC.Controls.Add(this.txtBLugarGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBFechaGC);
            this.GBDetalleCitaGC.Controls.Add(this.LLugarGC);
            this.GBDetalleCitaGC.Controls.Add(this.LFechaGC);
            this.GBDetalleCitaGC.Location = new System.Drawing.Point(30, 145);
            this.GBDetalleCitaGC.Name = "GBDetalleCitaGC";
            this.GBDetalleCitaGC.Size = new System.Drawing.Size(356, 103);
            this.GBDetalleCitaGC.TabIndex = 3;
            this.GBDetalleCitaGC.TabStop = false;
            this.GBDetalleCitaGC.Text = "Detalle de Cita";
            // 
            // txtidCitaOculto
            // 
            this.txtidCitaOculto.Location = new System.Drawing.Point(266, 29);
            this.txtidCitaOculto.Name = "txtidCitaOculto";
            this.txtidCitaOculto.Size = new System.Drawing.Size(49, 20);
            this.txtidCitaOculto.TabIndex = 18;
            // 
            // txtBLugarGC
            // 
            this.txtBLugarGC.Location = new System.Drawing.Point(89, 63);
            this.txtBLugarGC.Name = "txtBLugarGC";
            this.txtBLugarGC.Size = new System.Drawing.Size(225, 20);
            this.txtBLugarGC.TabIndex = 11;
            // 
            // LLugarGC
            // 
            this.LLugarGC.AutoSize = true;
            this.LLugarGC.Location = new System.Drawing.Point(16, 66);
            this.LLugarGC.Name = "LLugarGC";
            this.LLugarGC.Size = new System.Drawing.Size(37, 13);
            this.LLugarGC.TabIndex = 5;
            this.LLugarGC.Text = "Lugar:";
            // 
            // LFechaGC
            // 
            this.LFechaGC.AutoSize = true;
            this.LFechaGC.Location = new System.Drawing.Point(12, 34);
            this.LFechaGC.Name = "LFechaGC";
            this.LFechaGC.Size = new System.Drawing.Size(74, 13);
            this.LFechaGC.TabIndex = 2;
            this.LFechaGC.Text = "Fecha y Hora:";
            // 
            // LSelFechaGC
            // 
            this.LSelFechaGC.AutoSize = true;
            this.LSelFechaGC.Location = new System.Drawing.Point(27, 82);
            this.LSelFechaGC.Name = "LSelFechaGC";
            this.LSelFechaGC.Size = new System.Drawing.Size(100, 13);
            this.LSelFechaGC.TabIndex = 1;
            this.LSelFechaGC.Text = "Seleccionar un día:";
            // 
            // DTPSelDiaGC
            // 
            this.DTPSelDiaGC.Location = new System.Drawing.Point(144, 76);
            this.DTPSelDiaGC.Name = "DTPSelDiaGC";
            this.DTPSelDiaGC.Size = new System.Drawing.Size(200, 20);
            this.DTPSelDiaGC.TabIndex = 0;
            // 
            // toolStrip_GestionarTutores
            // 
            this.toolStrip_GestionarTutores.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnCancelar,
            this.btnEliminar});
            this.toolStrip_GestionarTutores.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_GestionarTutores.Name = "toolStrip_GestionarTutores";
            this.toolStrip_GestionarTutores.Size = new System.Drawing.Size(800, 25);
            this.toolStrip_GestionarTutores.TabIndex = 18;
            this.toolStrip_GestionarTutores.Text = "toolStrip2";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(57, 22);
            this.btnEditar.Text = "Editar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(70, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtBFechaGC
            // 
            this.txtBFechaGC.Location = new System.Drawing.Point(89, 31);
            this.txtBFechaGC.Name = "txtBFechaGC";
            this.txtBFechaGC.Size = new System.Drawing.Size(154, 20);
            this.txtBFechaGC.TabIndex = 7;
            // 
            // frmGestionarCitasTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip_GestionarTutores);
            this.Controls.Add(this.PGestCitas);
            this.Name = "frmGestionarCitasTutor";
            this.Text = "frmGestionarCitasTutor";
            this.Load += new System.EventHandler(this.frmGestionarCitasTutor_Load);
            this.PGestCitas.ResumeLayout(false);
            this.PGestCitas.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBObservGC.ResumeLayout(false);
            this.GBObservGC.PerformLayout();
            this.GBDetalleCitaGC.ResumeLayout(false);
            this.GBDetalleCitaGC.PerformLayout();
            this.toolStrip_GestionarTutores.ResumeLayout(false);
            this.toolStrip_GestionarTutores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PGestCitas;
        private System.Windows.Forms.GroupBox GBObservGC;
        private System.Windows.Forms.TextBox txtBObsGC;
        private System.Windows.Forms.Button BBuscarCitaGC;
        private System.Windows.Forms.Label LTituloGC;
        private System.Windows.Forms.GroupBox GBDetalleCitaGC;
        private System.Windows.Forms.TextBox txtCodBecGC;
        private System.Windows.Forms.TextBox txtCodTutorGC;
        private System.Windows.Forms.Label LCódigoBecarioGC;
        private System.Windows.Forms.TextBox txtBLugarGC;
        private System.Windows.Forms.Label LCodTutorGC;
        private System.Windows.Forms.TextBox txtBBecarioGC;
        private System.Windows.Forms.TextBox txtBTutorGC;
        private System.Windows.Forms.Label LLugarGC;
        private System.Windows.Forms.Label LBecarioGC;
        private System.Windows.Forms.Label LTuutorGC;
        private System.Windows.Forms.Label LFechaGC;
        private System.Windows.Forms.Label LSelFechaGC;
        private System.Windows.Forms.DateTimePicker DTPSelDiaGC;
        private System.Windows.Forms.TextBox txtidCitaOculto;
        private System.Windows.Forms.ToolStrip toolStrip_GestionarTutores;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarTutor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarBecario;
        private System.Windows.Forms.TextBox txtIdtutOculto;
        private System.Windows.Forms.TextBox txtIdBecOculto;
        private System.Windows.Forms.TextBox txtBFechaGC;
    }
}