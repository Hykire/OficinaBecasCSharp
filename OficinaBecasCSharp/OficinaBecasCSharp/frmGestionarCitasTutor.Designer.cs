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
            this.BBuscarCita2GC = new System.Windows.Forms.Button();
            this.LSelFechaGC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBTutorGC2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdtutOculto2 = new System.Windows.Forms.TextBox();
            this.btnBuscarTutor2 = new System.Windows.Forms.Button();
            this.txtCodTutor2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCitaOculto = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtBLugarGC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DGVCitas = new System.Windows.Forms.DataGridView();
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
            this.DTPSelDiaGC = new System.Windows.Forms.DateTimePicker();
            this.toolStrip_GestionarTutores = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PGestCitas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCitas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBObservGC.SuspendLayout();
            this.toolStrip_GestionarTutores.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGestCitas
            // 
            this.PGestCitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PGestCitas.AutoSize = true;
            this.PGestCitas.Controls.Add(this.BBuscarCita2GC);
            this.PGestCitas.Controls.Add(this.LSelFechaGC);
            this.PGestCitas.Controls.Add(this.label3);
            this.PGestCitas.Controls.Add(this.txtBTutorGC2);
            this.PGestCitas.Controls.Add(this.label5);
            this.PGestCitas.Controls.Add(this.txtIdtutOculto2);
            this.PGestCitas.Controls.Add(this.btnBuscarTutor2);
            this.PGestCitas.Controls.Add(this.txtCodTutor2);
            this.PGestCitas.Controls.Add(this.groupBox3);
            this.PGestCitas.Controls.Add(this.label4);
            this.PGestCitas.Controls.Add(this.DGVCitas);
            this.PGestCitas.Controls.Add(this.groupBox2);
            this.PGestCitas.Controls.Add(this.groupBox1);
            this.PGestCitas.Controls.Add(this.GBObservGC);
            this.PGestCitas.Controls.Add(this.BBuscarCitaGC);
            this.PGestCitas.Controls.Add(this.LTituloGC);
            this.PGestCitas.Controls.Add(this.DTPSelDiaGC);
            this.PGestCitas.Location = new System.Drawing.Point(12, 28);
            this.PGestCitas.Name = "PGestCitas";
            this.PGestCitas.Size = new System.Drawing.Size(802, 523);
            this.PGestCitas.TabIndex = 17;
            // 
            // BBuscarCita2GC
            // 
            this.BBuscarCita2GC.Location = new System.Drawing.Point(558, 145);
            this.BBuscarCita2GC.Name = "BBuscarCita2GC";
            this.BBuscarCita2GC.Size = new System.Drawing.Size(145, 23);
            this.BBuscarCita2GC.TabIndex = 26;
            this.BBuscarCita2GC.Text = "Buscar Cita";
            this.BBuscarCita2GC.UseVisualStyleBackColor = true;
            this.BBuscarCita2GC.Click += new System.EventHandler(this.BBuscarCita2GC_Click);
            // 
            // LSelFechaGC
            // 
            this.LSelFechaGC.AutoSize = true;
            this.LSelFechaGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSelFechaGC.Location = new System.Drawing.Point(80, 66);
            this.LSelFechaGC.Name = "LSelFechaGC";
            this.LSelFechaGC.Size = new System.Drawing.Size(80, 13);
            this.LSelFechaGC.TabIndex = 25;
            this.LSelFechaGC.Text = "Buscar por día:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Buscar por tutor:";
            // 
            // txtBTutorGC2
            // 
            this.txtBTutorGC2.Enabled = false;
            this.txtBTutorGC2.Location = new System.Drawing.Point(448, 119);
            this.txtBTutorGC2.Name = "txtBTutorGC2";
            this.txtBTutorGC2.Size = new System.Drawing.Size(255, 20);
            this.txtBTutorGC2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tutor:";
            // 
            // txtIdtutOculto2
            // 
            this.txtIdtutOculto2.Enabled = false;
            this.txtIdtutOculto2.Location = new System.Drawing.Point(558, 93);
            this.txtIdtutOculto2.Name = "txtIdtutOculto2";
            this.txtIdtutOculto2.Size = new System.Drawing.Size(49, 20);
            this.txtIdtutOculto2.TabIndex = 22;
            // 
            // btnBuscarTutor2
            // 
            this.btnBuscarTutor2.Location = new System.Drawing.Point(618, 90);
            this.btnBuscarTutor2.Name = "btnBuscarTutor2";
            this.btnBuscarTutor2.Size = new System.Drawing.Size(85, 23);
            this.btnBuscarTutor2.TabIndex = 23;
            this.btnBuscarTutor2.Text = "Buscar";
            this.btnBuscarTutor2.UseVisualStyleBackColor = true;
            this.btnBuscarTutor2.Click += new System.EventHandler(this.btnBuscarTutor2_Click);
            // 
            // txtCodTutor2
            // 
            this.txtCodTutor2.Enabled = false;
            this.txtCodTutor2.Location = new System.Drawing.Point(448, 92);
            this.txtCodTutor2.Name = "txtCodTutor2";
            this.txtCodTutor2.Size = new System.Drawing.Size(104, 20);
            this.txtCodTutor2.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtIdCitaOculto);
            this.groupBox3.Controls.Add(this.txtHora);
            this.groupBox3.Controls.Add(this.txtBLugarGC);
            this.groupBox3.Location = new System.Drawing.Point(410, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 89);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hora:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lugar:";
            // 
            // txtIdCitaOculto
            // 
            this.txtIdCitaOculto.Location = new System.Drawing.Point(266, 29);
            this.txtIdCitaOculto.Name = "txtIdCitaOculto";
            this.txtIdCitaOculto.Size = new System.Drawing.Size(60, 20);
            this.txtIdCitaOculto.TabIndex = 2;
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(54, 56);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(121, 20);
            this.txtHora.TabIndex = 1;
            // 
            // txtBLugarGC
            // 
            this.txtBLugarGC.Location = new System.Drawing.Point(54, 29);
            this.txtBLugarGC.Name = "txtBLugarGC";
            this.txtBLugarGC.Size = new System.Drawing.Size(206, 20);
            this.txtBLugarGC.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Código tutor:";
            // 
            // DGVCitas
            // 
            this.DGVCitas.AllowUserToAddRows = false;
            this.DGVCitas.AllowUserToDeleteRows = false;
            this.DGVCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCitas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Fecha,
            this.Tutor,
            this.Alumno,
            this.Hora,
            this.Lugar});
            this.DGVCitas.Location = new System.Drawing.Point(46, 179);
            this.DGVCitas.Name = "DGVCitas";
            this.DGVCitas.ReadOnly = true;
            this.DGVCitas.Size = new System.Drawing.Size(708, 119);
            this.DGVCitas.TabIndex = 11;
            this.DGVCitas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCitas_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtIdtutOculto);
            this.groupBox2.Controls.Add(this.btnBuscarTutor);
            this.groupBox2.Controls.Add(this.txtBTutorGC);
            this.groupBox2.Controls.Add(this.txtCodTutorGC);
            this.groupBox2.Controls.Add(this.LTuutorGC);
            this.groupBox2.Controls.Add(this.LCodTutorGC);
            this.groupBox2.Location = new System.Drawing.Point(27, 307);
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
            this.txtBTutorGC.Location = new System.Drawing.Point(89, 57);
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
            this.groupBox1.Location = new System.Drawing.Point(410, 307);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 98);
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
            this.GBObservGC.Location = new System.Drawing.Point(31, 411);
            this.GBObservGC.Name = "GBObservGC";
            this.GBObservGC.Size = new System.Drawing.Size(352, 96);
            this.GBObservGC.TabIndex = 8;
            this.GBObservGC.TabStop = false;
            this.GBObservGC.Text = "Observaciones";
            // 
            // txtBObsGC
            // 
            this.txtBObsGC.Location = new System.Drawing.Point(6, 19);
            this.txtBObsGC.Multiline = true;
            this.txtBObsGC.Name = "txtBObsGC";
            this.txtBObsGC.Size = new System.Drawing.Size(340, 71);
            this.txtBObsGC.TabIndex = 13;
            // 
            // BBuscarCitaGC
            // 
            this.BBuscarCitaGC.Location = new System.Drawing.Point(191, 119);
            this.BBuscarCitaGC.Name = "BBuscarCitaGC";
            this.BBuscarCitaGC.Size = new System.Drawing.Size(134, 23);
            this.BBuscarCitaGC.TabIndex = 4;
            this.BBuscarCitaGC.Text = "Buscar Cita";
            this.BBuscarCitaGC.UseVisualStyleBackColor = true;
            this.BBuscarCitaGC.Click += new System.EventHandler(this.BBuscarCitaGC_Click);
            // 
            // LTituloGC
            // 
            this.LTituloGC.AutoSize = true;
            this.LTituloGC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTituloGC.Location = new System.Drawing.Point(19, 16);
            this.LTituloGC.Name = "LTituloGC";
            this.LTituloGC.Size = new System.Drawing.Size(134, 20);
            this.LTituloGC.TabIndex = 2;
            this.LTituloGC.Text = "Gestionar Citas";
            // 
            // DTPSelDiaGC
            // 
            this.DTPSelDiaGC.Location = new System.Drawing.Point(83, 93);
            this.DTPSelDiaGC.Name = "DTPSelDiaGC";
            this.DTPSelDiaGC.Size = new System.Drawing.Size(242, 20);
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
            this.toolStrip_GestionarTutores.Size = new System.Drawing.Size(826, 25);
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
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Tutor
            // 
            this.Tutor.DataPropertyName = "IdTutor";
            this.Tutor.HeaderText = "Tutor";
            this.Tutor.Name = "Tutor";
            this.Tutor.ReadOnly = true;
            this.Tutor.Width = 150;
            // 
            // Alumno
            // 
            this.Alumno.DataPropertyName = "IdBecado";
            this.Alumno.HeaderText = "Alumno";
            this.Alumno.Name = "Alumno";
            this.Alumno.ReadOnly = true;
            this.Alumno.Width = 150;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "Hora";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // Lugar
            // 
            this.Lugar.DataPropertyName = "Lugar";
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            this.Lugar.Width = 150;
            // 
            // frmGestionarCitasTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 568);
            this.Controls.Add(this.toolStrip_GestionarTutores);
            this.Controls.Add(this.PGestCitas);
            this.Name = "frmGestionarCitasTutor";
            this.Text = "frmGestionarCitasTutor";
            this.PGestCitas.ResumeLayout(false);
            this.PGestCitas.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCitas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBObservGC.ResumeLayout(false);
            this.GBObservGC.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCodBecGC;
        private System.Windows.Forms.TextBox txtCodTutorGC;
        private System.Windows.Forms.Label LCódigoBecarioGC;
        private System.Windows.Forms.Label LCodTutorGC;
        private System.Windows.Forms.TextBox txtBBecarioGC;
        private System.Windows.Forms.TextBox txtBTutorGC;
        private System.Windows.Forms.Label LBecarioGC;
        private System.Windows.Forms.Label LTuutorGC;
        private System.Windows.Forms.DateTimePicker DTPSelDiaGC;
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
        private System.Windows.Forms.DataGridView DGVCitas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCitaOculto;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtBLugarGC;
        private System.Windows.Forms.TextBox txtIdtutOculto2;
        private System.Windows.Forms.Button btnBuscarTutor2;
        private System.Windows.Forms.TextBox txtCodTutor2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBTutorGC2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BBuscarCita2GC;
        private System.Windows.Forms.Label LSelFechaGC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
    }
}