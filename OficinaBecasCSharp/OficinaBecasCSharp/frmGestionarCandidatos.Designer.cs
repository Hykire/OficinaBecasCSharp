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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(764, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(66, 24);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(73, 24);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(61, 24);
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
            this.btnBuscar.Size = new System.Drawing.Size(66, 24);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(71, 24);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id Convocatoria:";
            // 
            // txtIdConvocatoria
            // 
            this.txtIdConvocatoria.Location = new System.Drawing.Point(106, 28);
            this.txtIdConvocatoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdConvocatoria.Name = "txtIdConvocatoria";
            this.txtIdConvocatoria.Size = new System.Drawing.Size(38, 20);
            this.txtIdConvocatoria.TabIndex = 5;
            // 
            // btnBuscarConvocatoria
            // 
            this.btnBuscarConvocatoria.Location = new System.Drawing.Point(150, 25);
            this.btnBuscarConvocatoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarConvocatoria.Name = "btnBuscarConvocatoria";
            this.btnBuscarConvocatoria.Size = new System.Drawing.Size(123, 25);
            this.btnBuscarConvocatoria.TabIndex = 6;
            this.btnBuscarConvocatoria.Text = "Buscar Convocatoria";
            this.btnBuscarConvocatoria.UseVisualStyleBackColor = true;
            this.btnBuscarConvocatoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.textBox1);
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
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(700, 131);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Convocatoria";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(352, 94);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Cantidad de Seleccionados:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(352, 62);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Cantidad de Postulantes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cantidad de Candidatos:";
            // 
            // txtSeleccionados
            // 
            this.txtSeleccionados.Location = new System.Drawing.Point(525, 90);
            this.txtSeleccionados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSeleccionados.Name = "txtSeleccionados";
            this.txtSeleccionados.Size = new System.Drawing.Size(37, 20);
            this.txtSeleccionados.TabIndex = 15;
            // 
            // txtPostulantes
            // 
            this.txtPostulantes.Location = new System.Drawing.Point(525, 58);
            this.txtPostulantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPostulantes.Name = "txtPostulantes";
            this.txtPostulantes.Size = new System.Drawing.Size(37, 20);
            this.txtPostulantes.TabIndex = 14;
            // 
            // txtCandidatos
            // 
            this.txtCandidatos.Location = new System.Drawing.Point(525, 27);
            this.txtCandidatos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCandidatos.Name = "txtCandidatos";
            this.txtCandidatos.Size = new System.Drawing.Size(37, 20);
            this.txtCandidatos.TabIndex = 13;
            // 
            // txtNombreConvocatoria
            // 
            this.txtNombreConvocatoria.Location = new System.Drawing.Point(71, 59);
            this.txtNombreConvocatoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreConvocatoria.Name = "txtNombreConvocatoria";
            this.txtNombreConvocatoria.Size = new System.Drawing.Size(203, 20);
            this.txtNombreConvocatoria.TabIndex = 12;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Location = new System.Drawing.Point(80, 90);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(203, 20);
            this.dtFechaFin.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Código PUCP:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 91);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nombres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 121);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Apellidos:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 150);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "DNI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 206);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Edad:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 63);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha de Nacimiento:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 91);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Correo PUCP:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 121);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "Correo Alternativo:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 150);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Teléfono Fijo:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 179);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Teléfono Móvil:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 241);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 13);
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
            this.groupBox2.Location = new System.Drawing.Point(19, 168);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(700, 275);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Candidato";
            // 
            // btnBuscarCandidato
            // 
            this.btnBuscarCandidato.Location = new System.Drawing.Point(313, 22);
            this.btnBuscarCandidato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscarCandidato.Name = "btnBuscarCandidato";
            this.btnBuscarCandidato.Size = new System.Drawing.Size(113, 24);
            this.btnBuscarCandidato.TabIndex = 39;
            this.btnBuscarCandidato.Text = "Buscar Candidato";
            this.btnBuscarCandidato.UseVisualStyleBackColor = true;
            this.btnBuscarCandidato.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtIdCandidato
            // 
            this.txtIdCandidato.Location = new System.Drawing.Point(233, 24);
            this.txtIdCandidato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCandidato.Name = "txtIdCandidato";
            this.txtIdCandidato.Size = new System.Drawing.Size(41, 20);
            this.txtIdCandidato.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(159, 27);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 37;
            this.label20.Text = "ID Candidato:";
            // 
            // txtTelefonoFijo
            // 
            this.txtTelefonoFijo.Location = new System.Drawing.Point(412, 147);
            this.txtTelefonoFijo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoFijo.MaxLength = 15;
            this.txtTelefonoFijo.Name = "txtTelefonoFijo";
            this.txtTelefonoFijo.Size = new System.Drawing.Size(159, 20);
            this.txtTelefonoFijo.TabIndex = 36;
            // 
            // txtTelefonoMovil
            // 
            this.txtTelefonoMovil.Location = new System.Drawing.Point(412, 176);
            this.txtTelefonoMovil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefonoMovil.MaxLength = 15;
            this.txtTelefonoMovil.Name = "txtTelefonoMovil";
            this.txtTelefonoMovil.Size = new System.Drawing.Size(159, 20);
            this.txtTelefonoMovil.TabIndex = 35;
            // 
            // txtCorreoAlternativo
            // 
            this.txtCorreoAlternativo.Location = new System.Drawing.Point(412, 117);
            this.txtCorreoAlternativo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoAlternativo.Name = "txtCorreoAlternativo";
            this.txtCorreoAlternativo.Size = new System.Drawing.Size(159, 20);
            this.txtCorreoAlternativo.TabIndex = 34;
            // 
            // txtCorreoPUCP
            // 
            this.txtCorreoPUCP.Location = new System.Drawing.Point(412, 89);
            this.txtCorreoPUCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCorreoPUCP.Name = "txtCorreoPUCP";
            this.txtCorreoPUCP.Size = new System.Drawing.Size(159, 20);
            this.txtCorreoPUCP.TabIndex = 33;
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(412, 61);
            this.dtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(198, 20);
            this.dtFechaNacimiento.TabIndex = 32;
            this.dtFechaNacimiento.ValueChanged += new System.EventHandler(this.dtFechaNacimiento_ValueChanged);
            this.dtFechaNacimiento.ContextMenuStripChanged += new System.EventHandler(this.dtFechaNacimiento_ContextMenuStripChanged);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(115, 204);
            this.txtEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(40, 20);
            this.txtEdad.TabIndex = 31;
            // 
            // chFueSeleccionado
            // 
            this.chFueSeleccionado.AutoSize = true;
            this.chFueSeleccionado.Location = new System.Drawing.Point(392, 240);
            this.chFueSeleccionado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chFueSeleccionado.Name = "chFueSeleccionado";
            this.chFueSeleccionado.Size = new System.Drawing.Size(112, 17);
            this.chFueSeleccionado.TabIndex = 30;
            this.chFueSeleccionado.Text = "Fue Seleccionado";
            this.chFueSeleccionado.UseVisualStyleBackColor = true;
            // 
            // chPostulo
            // 
            this.chPostulo.AutoSize = true;
            this.chPostulo.Location = new System.Drawing.Point(278, 240);
            this.chPostulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chPostulo.Name = "chPostulo";
            this.chPostulo.Size = new System.Drawing.Size(61, 17);
            this.chPostulo.TabIndex = 29;
            this.chPostulo.Text = "Postuló";
            this.chPostulo.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(203, 176);
            this.rbFemenino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 28;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(115, 176);
            this.rbMasculino.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 27;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(118, 147);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(156, 20);
            this.txtDNI.TabIndex = 26;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(118, 119);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellidos.MaxLength = 50;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(156, 20);
            this.txtApellidos.TabIndex = 24;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(118, 91);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombres.MaxLength = 50;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(156, 20);
            this.txtNombres.TabIndex = 23;
            // 
            // txtCodigoPUCP
            // 
            this.txtCodigoPUCP.Location = new System.Drawing.Point(118, 61);
            this.txtCodigoPUCP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoPUCP.MaxLength = 8;
            this.txtCodigoPUCP.Name = "txtCodigoPUCP";
            this.txtCodigoPUCP.Size = new System.Drawing.Size(156, 20);
            this.txtCodigoPUCP.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 525);
            this.panel1.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 20);
            this.textBox1.TabIndex = 0;
            // 
            // frmGestionarCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 568);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGestionarCandidatos";
            this.Text = "Gestionar Candidatos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}