namespace Vista
{
    partial class frmGestionarPersona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarPersona));
            this.toolStrip_historiaacademica = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_id_usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_tipo = new System.Windows.Forms.ComboBox();
            this.tbox_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbox_datosGenerales = new System.Windows.Forms.GroupBox();
            this.label_fechaNacimiento = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.label_estado = new System.Windows.Forms.Label();
            this.cbox_estado = new System.Windows.Forms.ComboBox();
            this.tbox_id_persona = new System.Windows.Forms.TextBox();
            this.label_fijo = new System.Windows.Forms.Label();
            this.label_movil = new System.Windows.Forms.Label();
            this.label_correoAlternativo = new System.Windows.Forms.Label();
            this.tbox_fijo = new System.Windows.Forms.TextBox();
            this.tbox_movil = new System.Windows.Forms.TextBox();
            this.tbox_correoalternativo = new System.Windows.Forms.TextBox();
            this.tbox_correopucp = new System.Windows.Forms.TextBox();
            this.label_correopucp = new System.Windows.Forms.Label();
            this.tbox_edad = new System.Windows.Forms.TextBox();
            this.label_edad = new System.Windows.Forms.Label();
            this.tbox_dni = new System.Windows.Forms.TextBox();
            this.rbutton_masculino = new System.Windows.Forms.RadioButton();
            this.label_dni = new System.Windows.Forms.Label();
            this.rbutton_femenino = new System.Windows.Forms.RadioButton();
            this.tbox_apellidos = new System.Windows.Forms.TextBox();
            this.label_sexo = new System.Windows.Forms.Label();
            this.tbox_nombres = new System.Windows.Forms.TextBox();
            this.tbox_codigo = new System.Windows.Forms.TextBox();
            this.label_codigo = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.label_apellidos = new System.Windows.Forms.Label();
            this.toolStrip_historiaacademica.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbox_datosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_historiaacademica
            // 
            this.toolStrip_historiaacademica.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnEditar,
            this.toolStripSeparator1,
            this.btnBuscar,
            this.btnCancelar});
            this.toolStrip_historiaacademica.Location = new System.Drawing.Point(0, 0);
            this.toolStrip_historiaacademica.Name = "toolStrip_historiaacademica";
            this.toolStrip_historiaacademica.Size = new System.Drawing.Size(764, 25);
            this.toolStrip_historiaacademica.TabIndex = 4;
            this.toolStrip_historiaacademica.Text = "toolStrip2";
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
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(67, 22);
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.gbox_datosGenerales);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 384);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbox_id_usuario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbox_tipo);
            this.groupBox1.Controls.Add(this.tbox_password);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbox_user);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(379, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 149);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "4: Administrador, 5: Comunicaciones, 6: Default";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "1: Alumno, 2: Tutor, 3: Coordinador Tutor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(228, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Id usuario:";
            // 
            // tbox_id_usuario
            // 
            this.tbox_id_usuario.Location = new System.Drawing.Point(291, 82);
            this.tbox_id_usuario.Name = "tbox_id_usuario";
            this.tbox_id_usuario.Size = new System.Drawing.Size(28, 20);
            this.tbox_id_usuario.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(17, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tipo:";
            // 
            // cbox_tipo
            // 
            this.cbox_tipo.FormattingEnabled = true;
            this.cbox_tipo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbox_tipo.Location = new System.Drawing.Point(104, 79);
            this.cbox_tipo.Name = "cbox_tipo";
            this.cbox_tipo.Size = new System.Drawing.Size(100, 21);
            this.cbox_tipo.Sorted = true;
            this.cbox_tipo.TabIndex = 37;
            // 
            // tbox_password
            // 
            this.tbox_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_password.Location = new System.Drawing.Point(104, 53);
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.Size = new System.Drawing.Size(215, 20);
            this.tbox_password.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(17, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Contraseña:";
            // 
            // tbox_user
            // 
            this.tbox_user.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_user.Location = new System.Drawing.Point(104, 27);
            this.tbox_user.Name = "tbox_user";
            this.tbox_user.Size = new System.Drawing.Size(215, 20);
            this.tbox_user.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(17, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 37;
            this.label1.Text = "Nombre:";
            // 
            // gbox_datosGenerales
            // 
            this.gbox_datosGenerales.Controls.Add(this.label_fechaNacimiento);
            this.gbox_datosGenerales.Controls.Add(this.label4);
            this.gbox_datosGenerales.Controls.Add(this.dt_fechanacimiento);
            this.gbox_datosGenerales.Controls.Add(this.label_estado);
            this.gbox_datosGenerales.Controls.Add(this.cbox_estado);
            this.gbox_datosGenerales.Controls.Add(this.tbox_id_persona);
            this.gbox_datosGenerales.Controls.Add(this.label_fijo);
            this.gbox_datosGenerales.Controls.Add(this.label_movil);
            this.gbox_datosGenerales.Controls.Add(this.label_correoAlternativo);
            this.gbox_datosGenerales.Controls.Add(this.tbox_fijo);
            this.gbox_datosGenerales.Controls.Add(this.tbox_movil);
            this.gbox_datosGenerales.Controls.Add(this.tbox_correoalternativo);
            this.gbox_datosGenerales.Controls.Add(this.tbox_correopucp);
            this.gbox_datosGenerales.Controls.Add(this.label_correopucp);
            this.gbox_datosGenerales.Controls.Add(this.tbox_edad);
            this.gbox_datosGenerales.Controls.Add(this.label_edad);
            this.gbox_datosGenerales.Controls.Add(this.tbox_dni);
            this.gbox_datosGenerales.Controls.Add(this.rbutton_masculino);
            this.gbox_datosGenerales.Controls.Add(this.label_dni);
            this.gbox_datosGenerales.Controls.Add(this.rbutton_femenino);
            this.gbox_datosGenerales.Controls.Add(this.tbox_apellidos);
            this.gbox_datosGenerales.Controls.Add(this.label_sexo);
            this.gbox_datosGenerales.Controls.Add(this.tbox_nombres);
            this.gbox_datosGenerales.Controls.Add(this.tbox_codigo);
            this.gbox_datosGenerales.Controls.Add(this.label_codigo);
            this.gbox_datosGenerales.Controls.Add(this.label_nombre);
            this.gbox_datosGenerales.Controls.Add(this.label_apellidos);
            this.gbox_datosGenerales.Location = new System.Drawing.Point(20, 13);
            this.gbox_datosGenerales.Name = "gbox_datosGenerales";
            this.gbox_datosGenerales.Size = new System.Drawing.Size(340, 352);
            this.gbox_datosGenerales.TabIndex = 14;
            this.gbox_datosGenerales.TabStop = false;
            this.gbox_datosGenerales.Text = "Datos Generales";
            // 
            // label_fechaNacimiento
            // 
            this.label_fechaNacimiento.AutoSize = true;
            this.label_fechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_fechaNacimiento.Location = new System.Drawing.Point(18, 161);
            this.label_fechaNacimiento.Name = "label_fechaNacimiento";
            this.label_fechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.label_fechaNacimiento.TabIndex = 16;
            this.label_fechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(226, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Id persona:";
            // 
            // dt_fechanacimiento
            // 
            this.dt_fechanacimiento.Location = new System.Drawing.Point(120, 155);
            this.dt_fechanacimiento.Name = "dt_fechanacimiento";
            this.dt_fechanacimiento.Size = new System.Drawing.Size(200, 20);
            this.dt_fechanacimiento.TabIndex = 17;
            this.dt_fechanacimiento.ValueChanged += new System.EventHandler(this.dt_fechanacimiento_ValueChanged);
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_estado.Location = new System.Drawing.Point(18, 314);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(43, 13);
            this.label_estado.TabIndex = 36;
            this.label_estado.Text = "Estado:";
            // 
            // cbox_estado
            // 
            this.cbox_estado.FormattingEnabled = true;
            this.cbox_estado.Items.AddRange(new object[] {
            "ACTIVO",
            "INACTIVO"});
            this.cbox_estado.Location = new System.Drawing.Point(120, 311);
            this.cbox_estado.Name = "cbox_estado";
            this.cbox_estado.Size = new System.Drawing.Size(100, 21);
            this.cbox_estado.Sorted = true;
            this.cbox_estado.TabIndex = 35;
            // 
            // tbox_id_persona
            // 
            this.tbox_id_persona.Location = new System.Drawing.Point(292, 27);
            this.tbox_id_persona.Name = "tbox_id_persona";
            this.tbox_id_persona.Size = new System.Drawing.Size(28, 20);
            this.tbox_id_persona.TabIndex = 23;
            // 
            // label_fijo
            // 
            this.label_fijo.AutoSize = true;
            this.label_fijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_fijo.Location = new System.Drawing.Point(18, 288);
            this.label_fijo.Name = "label_fijo";
            this.label_fijo.Size = new System.Drawing.Size(71, 13);
            this.label_fijo.TabIndex = 22;
            this.label_fijo.Text = "Teléfono Fijo:";
            // 
            // label_movil
            // 
            this.label_movil.AutoSize = true;
            this.label_movil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_movil.Location = new System.Drawing.Point(18, 262);
            this.label_movil.Name = "label_movil";
            this.label_movil.Size = new System.Drawing.Size(80, 13);
            this.label_movil.TabIndex = 21;
            this.label_movil.Text = "Teléfono Móvil:";
            // 
            // label_correoAlternativo
            // 
            this.label_correoAlternativo.AutoSize = true;
            this.label_correoAlternativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_correoAlternativo.Location = new System.Drawing.Point(18, 236);
            this.label_correoAlternativo.Name = "label_correoAlternativo";
            this.label_correoAlternativo.Size = new System.Drawing.Size(94, 13);
            this.label_correoAlternativo.TabIndex = 20;
            this.label_correoAlternativo.Text = "Correo Alternativo:";
            // 
            // tbox_fijo
            // 
            this.tbox_fijo.Location = new System.Drawing.Point(120, 285);
            this.tbox_fijo.Name = "tbox_fijo";
            this.tbox_fijo.Size = new System.Drawing.Size(200, 20);
            this.tbox_fijo.TabIndex = 19;
            // 
            // tbox_movil
            // 
            this.tbox_movil.Location = new System.Drawing.Point(120, 259);
            this.tbox_movil.Name = "tbox_movil";
            this.tbox_movil.Size = new System.Drawing.Size(200, 20);
            this.tbox_movil.TabIndex = 18;
            // 
            // tbox_correoalternativo
            // 
            this.tbox_correoalternativo.Location = new System.Drawing.Point(120, 233);
            this.tbox_correoalternativo.Name = "tbox_correoalternativo";
            this.tbox_correoalternativo.Size = new System.Drawing.Size(200, 20);
            this.tbox_correoalternativo.TabIndex = 17;
            // 
            // tbox_correopucp
            // 
            this.tbox_correopucp.Location = new System.Drawing.Point(120, 207);
            this.tbox_correopucp.Name = "tbox_correopucp";
            this.tbox_correopucp.Size = new System.Drawing.Size(200, 20);
            this.tbox_correopucp.TabIndex = 16;
            // 
            // label_correopucp
            // 
            this.label_correopucp.AutoSize = true;
            this.label_correopucp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_correopucp.Location = new System.Drawing.Point(18, 210);
            this.label_correopucp.Name = "label_correopucp";
            this.label_correopucp.Size = new System.Drawing.Size(73, 13);
            this.label_correopucp.TabIndex = 15;
            this.label_correopucp.Text = "Correo PUCP:";
            // 
            // tbox_edad
            // 
            this.tbox_edad.Location = new System.Drawing.Point(120, 181);
            this.tbox_edad.Name = "tbox_edad";
            this.tbox_edad.Size = new System.Drawing.Size(50, 20);
            this.tbox_edad.TabIndex = 14;
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_edad.Location = new System.Drawing.Point(18, 184);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(35, 13);
            this.label_edad.TabIndex = 13;
            this.label_edad.Text = "Edad:";
            // 
            // tbox_dni
            // 
            this.tbox_dni.Location = new System.Drawing.Point(120, 129);
            this.tbox_dni.Name = "tbox_dni";
            this.tbox_dni.Size = new System.Drawing.Size(100, 20);
            this.tbox_dni.TabIndex = 12;
            // 
            // rbutton_masculino
            // 
            this.rbutton_masculino.AutoSize = true;
            this.rbutton_masculino.Location = new System.Drawing.Point(120, 106);
            this.rbutton_masculino.Name = "rbutton_masculino";
            this.rbutton_masculino.Size = new System.Drawing.Size(73, 17);
            this.rbutton_masculino.TabIndex = 10;
            this.rbutton_masculino.TabStop = true;
            this.rbutton_masculino.Text = "Masculino";
            this.rbutton_masculino.UseVisualStyleBackColor = true;
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_dni.Location = new System.Drawing.Point(18, 132);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(29, 13);
            this.label_dni.TabIndex = 5;
            this.label_dni.Text = "DNI:";
            // 
            // rbutton_femenino
            // 
            this.rbutton_femenino.AutoSize = true;
            this.rbutton_femenino.Location = new System.Drawing.Point(224, 106);
            this.rbutton_femenino.Name = "rbutton_femenino";
            this.rbutton_femenino.Size = new System.Drawing.Size(71, 17);
            this.rbutton_femenino.TabIndex = 9;
            this.rbutton_femenino.TabStop = true;
            this.rbutton_femenino.Text = "Femenino";
            this.rbutton_femenino.UseVisualStyleBackColor = true;
            // 
            // tbox_apellidos
            // 
            this.tbox_apellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_apellidos.Location = new System.Drawing.Point(120, 79);
            this.tbox_apellidos.Name = "tbox_apellidos";
            this.tbox_apellidos.Size = new System.Drawing.Size(200, 20);
            this.tbox_apellidos.TabIndex = 4;
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_sexo.Location = new System.Drawing.Point(18, 108);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(34, 13);
            this.label_sexo.TabIndex = 7;
            this.label_sexo.Text = "Sexo:";
            // 
            // tbox_nombres
            // 
            this.tbox_nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbox_nombres.Location = new System.Drawing.Point(120, 53);
            this.tbox_nombres.Name = "tbox_nombres";
            this.tbox_nombres.Size = new System.Drawing.Size(200, 20);
            this.tbox_nombres.TabIndex = 3;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(120, 27);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.Size = new System.Drawing.Size(100, 20);
            this.tbox_codigo.TabIndex = 2;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_codigo.Location = new System.Drawing.Point(18, 30);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(43, 13);
            this.label_codigo.TabIndex = 0;
            this.label_codigo.Text = "Código:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_nombre.Location = new System.Drawing.Point(18, 56);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(52, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombres:";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_apellidos.Location = new System.Drawing.Point(18, 82);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(52, 13);
            this.label_apellidos.TabIndex = 2;
            this.label_apellidos.Text = "Apellidos:";
            // 
            // frmGestionarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip_historiaacademica);
            this.Name = "frmGestionarPersona";
            this.Text = "frmPersona";
            this.toolStrip_historiaacademica.ResumeLayout(false);
            this.toolStrip_historiaacademica.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbox_datosGenerales.ResumeLayout(false);
            this.gbox_datosGenerales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_historiaacademica;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbox_tipo;
        private System.Windows.Forms.TextBox tbox_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbox_datosGenerales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.ComboBox cbox_estado;
        private System.Windows.Forms.TextBox tbox_id_persona;
        private System.Windows.Forms.Label label_fijo;
        private System.Windows.Forms.Label label_movil;
        private System.Windows.Forms.Label label_correoAlternativo;
        private System.Windows.Forms.TextBox tbox_fijo;
        private System.Windows.Forms.TextBox tbox_movil;
        private System.Windows.Forms.TextBox tbox_correoalternativo;
        private System.Windows.Forms.TextBox tbox_correopucp;
        private System.Windows.Forms.Label label_correopucp;
        private System.Windows.Forms.TextBox tbox_edad;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.TextBox tbox_dni;
        private System.Windows.Forms.RadioButton rbutton_masculino;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.RadioButton rbutton_femenino;
        private System.Windows.Forms.TextBox tbox_apellidos;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.TextBox tbox_nombres;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_apellidos;
        private System.Windows.Forms.Label label_fechaNacimiento;
        private System.Windows.Forms.DateTimePicker dt_fechanacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_id_usuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}