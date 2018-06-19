namespace Vista
{
    partial class frmGestionarCandidatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarCandidatos));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdConvocatoria = new System.Windows.Forms.TextBox();
            this.btnBuscarConvocatoria = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeleccionados = new System.Windows.Forms.TextBox();
            this.txtPostulantes = new System.Windows.Forms.TextBox();
            this.txtCandidatos = new System.Windows.Forms.TextBox();
            this.txtNombreConvocatoria = new System.Windows.Forms.TextBox();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCandidato = new System.Windows.Forms.Button();
            this.txtIdCandidato = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtTelefonoFijo = new System.Windows.Forms.TextBox();
            this.txtTelefonoMovil = new System.Windows.Forms.TextBox();
            this.txtCorreoAlternativo = new System.Windows.Forms.TextBox();
            this.txtCorreoPUCP = new System.Windows.Forms.TextBox();
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.chFueSeleccionado = new System.Windows.Forms.CheckBox();
            this.chPostulo = new System.Windows.Forms.CheckBox();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigoPUCP = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnBuscar,
            this.btnLimpiar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1019, 27);
            this.toolStrip1.TabIndex = 3;
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
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(72, 24);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(83, 24);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Convocatoria:";
            // 
            // txtIdConvocatoria
            // 
            this.txtIdConvocatoria.Location = new System.Drawing.Point(129, 35);
            this.txtIdConvocatoria.Name = "txtIdConvocatoria";
            this.txtIdConvocatoria.Size = new System.Drawing.Size(49, 22);
            this.txtIdConvocatoria.TabIndex = 5;
            // 
            // btnBuscarConvocatoria
            // 
            this.btnBuscarConvocatoria.Location = new System.Drawing.Point(200, 31);
            this.btnBuscarConvocatoria.Name = "btnBuscarConvocatoria";
            this.btnBuscarConvocatoria.Size = new System.Drawing.Size(164, 31);
            this.btnBuscarConvocatoria.TabIndex = 6;
            this.btnBuscarConvocatoria.Text = "Buscar Convocatoria";
            this.btnBuscarConvocatoria.UseVisualStyleBackColor = true;
            this.btnBuscarConvocatoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSeleccionados);
            this.groupBox1.Controls.Add(this.txtPostulantes);
            this.groupBox1.Controls.Add(this.txtCandidatos);
            this.groupBox1.Controls.Add(this.txtNombreConvocatoria);
            this.groupBox1.Controls.Add(this.dtFechaFin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnBuscarConvocatoria);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdConvocatoria);
            this.groupBox1.Location = new System.Drawing.Point(92, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(837, 162);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Convocatoria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(470, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(184, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Cantidad de Seleccionados:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(470, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 17);
            this.label17.TabIndex = 17;
            this.label17.Text = "Cantidad de Postulantes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad de Candidatos:";
            // 
            // txtSeleccionados
            // 
            this.txtSeleccionados.Location = new System.Drawing.Point(700, 111);
            this.txtSeleccionados.Name = "txtSeleccionados";
            this.txtSeleccionados.Size = new System.Drawing.Size(48, 22);
            this.txtSeleccionados.TabIndex = 15;
            // 
            // txtPostulantes
            // 
            this.txtPostulantes.Location = new System.Drawing.Point(700, 71);
            this.txtPostulantes.Name = "txtPostulantes";
            this.txtPostulantes.Size = new System.Drawing.Size(48, 22);
            this.txtPostulantes.TabIndex = 14;
            // 
            // txtCandidatos
            // 
            this.txtCandidatos.Location = new System.Drawing.Point(700, 33);
            this.txtCandidatos.Name = "txtCandidatos";
            this.txtCandidatos.Size = new System.Drawing.Size(48, 22);
            this.txtCandidatos.TabIndex = 13;
            // 
            // txtNombreConvocatoria
            // 
            this.txtNombreConvocatoria.Location = new System.Drawing.Point(95, 73);
            this.txtNombreConvocatoria.Name = "txtNombreConvocatoria";
            this.txtNombreConvocatoria.Size = new System.Drawing.Size(269, 22);
            this.txtNombreConvocatoria.TabIndex = 12;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(106, 111);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(269, 22);
            this.dtFechaFin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código PUCP:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "DNI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "Edad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(398, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha de Nacimiento:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(398, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 15;
            this.label12.Text = "Correo PUCP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(398, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 17);
            this.label13.TabIndex = 16;
            this.label13.Text = "Correo Alternativo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(398, 184);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Teléfono Fijo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(398, 220);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "Teléfono Móvil:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 297);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(218, 17);
            this.label16.TabIndex = 19;
            this.label16.Text = "Estado de Postulación/Selección:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarCandidato);
            this.groupBox2.Controls.Add(this.txtIdCandidato);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtTelefonoFijo);
            this.groupBox2.Controls.Add(this.txtTelefonoMovil);
            this.groupBox2.Controls.Add(this.txtCorreoAlternativo);
            this.groupBox2.Controls.Add(this.txtCorreoPUCP);
            this.groupBox2.Controls.Add(this.dtFechaNacimiento);
            this.groupBox2.Controls.Add(this.txtEdad);
            this.groupBox2.Controls.Add(this.chFueSeleccionado);
            this.groupBox2.Controls.Add(this.chPostulo);
            this.groupBox2.Controls.Add(this.rbFemenino);
            this.groupBox2.Controls.Add(this.rbMasculino);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.txtCodigoPUCP);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(92, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 339);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Candidato";
            // 
            // btnBuscarCandidato
            // 
            this.btnBuscarCandidato.Location = new System.Drawing.Point(417, 27);
            this.btnBuscarCandidato.Name = "btnBuscarCandidato";
            this.btnBuscarCandidato.Size = new System.Drawing.Size(151, 29);
            this.btnBuscarCandidato.TabIndex = 39;
            this.btnBuscarCandidato.Text = "Buscar Candidato";
            this.btnBuscarCandidato.UseVisualStyleBackColor = true;
            this.btnBuscarCandidato.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtIdCandidato
            // 
            this.txtIdCandidato.Location = new System.Drawing.Point(311, 30);
            this.txtIdCandidato.Name = "txtIdCandidato";
            this.txtIdCandidato.Size = new System.Drawing.Size(53, 22);
            this.txtIdCandidato.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(212, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(93, 17);
            this.label20.TabIndex = 37;
            this.label20.Text = "ID Candidato:";
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(549, 181);
            this.txtTelefonoFijo.MaxLength = 15;
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(211, 22);
            this.txtTelefonoFijo.TabIndex = 36;
            // 
            // txtTelefonoMovil
            // 
            this.txtTelefonoMovil.Location = new System.Drawing.Point(549, 217);
            this.txtTelefonoMovil.MaxLength = 15;
            this.txtTelefonoMovil.Name = "txtTelefonoMovil";
            this.txtTelefonoMovil.Size = new System.Drawing.Size(211, 22);
            this.txtTelefonoMovil.TabIndex = 35;
            // 
            // txtCorreoAlternativo
            // 
            this.txtCorreoAlternativo.Location = new System.Drawing.Point(549, 144);
            this.txtCorreoAlternativo.Name = "txtCorreoAlternativo";
            this.txtCorreoAlternativo.Size = new System.Drawing.Size(211, 22);
            this.txtCorreoAlternativo.TabIndex = 34;
            // 
            // txtCorreoPUCP
            // 
            this.txtCorreoPUCP.Location = new System.Drawing.Point(549, 109);
            this.txtCorreoPUCP.Name = "txtCorreoPUCP";
            this.txtCorreoPUCP.Size = new System.Drawing.Size(211, 22);
            this.txtCorreoPUCP.TabIndex = 33;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(549, 75);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(263, 22);
            this.dtFechaNacimiento.TabIndex = 32;
            this.dtFechaNacimiento.ValueChanged += new System.EventHandler(this.dtFechaNacimiento_ValueChanged);
            this.dtFechaNacimiento.ContextMenuStripChanged += new System.EventHandler(this.dtFechaNacimiento_ContextMenuStripChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(153, 251);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(52, 22);
            this.txtEdad.TabIndex = 31;
            // 
            // chFueSeleccionado
            // 
            this.chFueSeleccionado.AutoSize = true;
            this.chFueSeleccionado.Location = new System.Drawing.Point(523, 296);
            this.chFueSeleccionado.Name = "chFueSeleccionado";
            this.chFueSeleccionado.Size = new System.Drawing.Size(143, 21);
            this.chFueSeleccionado.TabIndex = 30;
            this.chFueSeleccionado.Text = "Fue Seleccionado";
            this.chFueSeleccionado.UseVisualStyleBackColor = true;
            // 
            // chPostulo
            // 
            this.chPostulo.AutoSize = true;
            this.chPostulo.Location = new System.Drawing.Point(370, 296);
            this.chPostulo.Name = "chPostulo";
            this.chPostulo.Size = new System.Drawing.Size(77, 21);
            this.chPostulo.TabIndex = 29;
            this.chPostulo.Text = "Postuló";
            this.chPostulo.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(271, 216);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(91, 21);
            this.rbFemenino.TabIndex = 28;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(153, 216);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(92, 21);
            this.rbMasculino.TabIndex = 27;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(157, 181);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(207, 22);
            this.txtDNI.TabIndex = 26;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(157, 146);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(207, 22);
            this.txtApellidos.TabIndex = 24;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(157, 112);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(207, 22);
            this.txtNombres.TabIndex = 23;
            // 
            // txtCodigoPUCP
            // 
            this.txtCodigoPUCP.Location = new System.Drawing.Point(157, 75);
            this.txtCodigoPUCP.MaxLength = 8;
            this.txtCodigoPUCP.Name = "txtCodigoPUCP";
            this.txtCodigoPUCP.Size = new System.Drawing.Size(207, 22);
            this.txtCodigoPUCP.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(26, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 601);
            this.panel1.TabIndex = 22;
            // 
            // frmGestionarCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 699);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "frmGestionarCandidatos";
            this.Text = "Gestionar Candidatos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdConvocatoria;
        private System.Windows.Forms.Button btnBuscarConvocatoria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombreConvocatoria;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefonoFijo;
        private System.Windows.Forms.TextBox txtTelefonoMovil;
        private System.Windows.Forms.TextBox txtCorreoAlternativo;
        private System.Windows.Forms.TextBox txtCorreoPUCP;
        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.CheckBox chFueSeleccionado;
        private System.Windows.Forms.CheckBox chPostulo;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigoPUCP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeleccionados;
        private System.Windows.Forms.TextBox txtPostulantes;
        private System.Windows.Forms.TextBox txtCandidatos;
        private System.Windows.Forms.Button btnBuscarCandidato;
        private System.Windows.Forms.TextBox txtIdCandidato;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
    }
}