namespace Vista
{
    partial class frmAlumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumno));
            this.panel_Alumno = new System.Windows.Forms.Panel();
            this.btn_historiaacademica = new System.Windows.Forms.Button();
            this.gbox_datosIngreso = new System.Windows.Forms.GroupBox();
            this.tbox_facultad = new System.Windows.Forms.TextBox();
            this.cbox_especialidad = new System.Windows.Forms.ComboBox();
            this.label_tipogrupo = new System.Windows.Forms.Label();
            this.tbox_tipogrupo = new System.Windows.Forms.TextBox();
            this.tbox_ciclo = new System.Windows.Forms.TextBox();
            this.label_especialidad = new System.Windows.Forms.Label();
            this.label_facultad = new System.Windows.Forms.Label();
            this.label_cicloI = new System.Windows.Forms.Label();
            this.gbox_datosNacimiento = new System.Windows.Forms.GroupBox();
            this.label_paisN = new System.Windows.Forms.Label();
            this.tbox_paisN = new System.Windows.Forms.TextBox();
            this.cbox_departamentoN = new System.Windows.Forms.ComboBox();
            this.label_departamentoN = new System.Windows.Forms.Label();
            this.label_fechaNacimiento = new System.Windows.Forms.Label();
            this.dt_fechanacimiento = new System.Windows.Forms.DateTimePicker();
            this.tbox_provinciaN = new System.Windows.Forms.TextBox();
            this.label_distritoN = new System.Windows.Forms.Label();
            this.label_provinciaN = new System.Windows.Forms.Label();
            this.tbox_distritoN = new System.Windows.Forms.TextBox();
            this.gbox_datosLocalidad = new System.Windows.Forms.GroupBox();
            this.cbox_departamento = new System.Windows.Forms.ComboBox();
            this.label_departamento = new System.Windows.Forms.Label();
            this.label_provincia = new System.Windows.Forms.Label();
            this.tbox_provincia = new System.Windows.Forms.TextBox();
            this.tbox_distrito = new System.Windows.Forms.TextBox();
            this.label_distrito = new System.Windows.Forms.Label();
            this.tbox_direccion = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.gbox_datosGenerales = new System.Windows.Forms.GroupBox();
            this.tbox_id = new System.Windows.Forms.TextBox();
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
            this.toolStrip_historiaacademica = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.panel_Alumno.SuspendLayout();
            this.gbox_datosIngreso.SuspendLayout();
            this.gbox_datosNacimiento.SuspendLayout();
            this.gbox_datosLocalidad.SuspendLayout();
            this.gbox_datosGenerales.SuspendLayout();
            this.toolStrip_historiaacademica.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Alumno
            // 
            this.panel_Alumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Alumno.Controls.Add(this.btn_historiaacademica);
            this.panel_Alumno.Controls.Add(this.gbox_datosIngreso);
            this.panel_Alumno.Controls.Add(this.gbox_datosNacimiento);
            this.panel_Alumno.Controls.Add(this.gbox_datosLocalidad);
            this.panel_Alumno.Controls.Add(this.gbox_datosGenerales);
            this.panel_Alumno.Location = new System.Drawing.Point(24, 28);
            this.panel_Alumno.Name = "panel_Alumno";
            this.panel_Alumno.Size = new System.Drawing.Size(799, 525);
            this.panel_Alumno.TabIndex = 0;
            // 
            // btn_historiaacademica
            // 
            this.btn_historiaacademica.Location = new System.Drawing.Point(571, 415);
            this.btn_historiaacademica.Name = "btn_historiaacademica";
            this.btn_historiaacademica.Size = new System.Drawing.Size(106, 23);
            this.btn_historiaacademica.TabIndex = 12;
            this.btn_historiaacademica.Text = "Historia Academica";
            this.btn_historiaacademica.UseVisualStyleBackColor = true;
            // 
            // gbox_datosIngreso
            // 
            this.gbox_datosIngreso.Controls.Add(this.tbox_facultad);
            this.gbox_datosIngreso.Controls.Add(this.cbox_especialidad);
            this.gbox_datosIngreso.Controls.Add(this.label_tipogrupo);
            this.gbox_datosIngreso.Controls.Add(this.tbox_tipogrupo);
            this.gbox_datosIngreso.Controls.Add(this.tbox_ciclo);
            this.gbox_datosIngreso.Controls.Add(this.label_especialidad);
            this.gbox_datosIngreso.Controls.Add(this.label_facultad);
            this.gbox_datosIngreso.Controls.Add(this.label_cicloI);
            this.gbox_datosIngreso.Location = new System.Drawing.Point(24, 360);
            this.gbox_datosIngreso.Name = "gbox_datosIngreso";
            this.gbox_datosIngreso.Size = new System.Drawing.Size(350, 147);
            this.gbox_datosIngreso.TabIndex = 11;
            this.gbox_datosIngreso.TabStop = false;
            this.gbox_datosIngreso.Text = "Datos de Ingreso";
            // 
            // tbox_facultad
            // 
            this.tbox_facultad.Location = new System.Drawing.Point(123, 81);
            this.tbox_facultad.Name = "tbox_facultad";
            this.tbox_facultad.Size = new System.Drawing.Size(200, 20);
            this.tbox_facultad.TabIndex = 32;
            // 
            // cbox_especialidad
            // 
            this.cbox_especialidad.FormattingEnabled = true;
            this.cbox_especialidad.Location = new System.Drawing.Point(123, 52);
            this.cbox_especialidad.Name = "cbox_especialidad";
            this.cbox_especialidad.Size = new System.Drawing.Size(200, 21);
            this.cbox_especialidad.Sorted = true;
            this.cbox_especialidad.TabIndex = 31;
            this.cbox_especialidad.SelectedIndexChanged += new System.EventHandler(this.cbox_especialidad_SelectedIndexChanged);
            // 
            // label_tipogrupo
            // 
            this.label_tipogrupo.AutoSize = true;
            this.label_tipogrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_tipogrupo.Location = new System.Drawing.Point(21, 109);
            this.label_tipogrupo.Name = "label_tipogrupo";
            this.label_tipogrupo.Size = new System.Drawing.Size(76, 13);
            this.label_tipogrupo.TabIndex = 29;
            this.label_tipogrupo.Text = "Tipo de grupo:";
            // 
            // tbox_tipogrupo
            // 
            this.tbox_tipogrupo.Location = new System.Drawing.Point(123, 106);
            this.tbox_tipogrupo.Name = "tbox_tipogrupo";
            this.tbox_tipogrupo.Size = new System.Drawing.Size(200, 20);
            this.tbox_tipogrupo.TabIndex = 30;
            // 
            // tbox_ciclo
            // 
            this.tbox_ciclo.Location = new System.Drawing.Point(123, 26);
            this.tbox_ciclo.Name = "tbox_ciclo";
            this.tbox_ciclo.Size = new System.Drawing.Size(100, 20);
            this.tbox_ciclo.TabIndex = 25;
            // 
            // label_especialidad
            // 
            this.label_especialidad.AutoSize = true;
            this.label_especialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_especialidad.Location = new System.Drawing.Point(21, 55);
            this.label_especialidad.Name = "label_especialidad";
            this.label_especialidad.Size = new System.Drawing.Size(70, 13);
            this.label_especialidad.TabIndex = 26;
            this.label_especialidad.Text = "Especialidad:";
            // 
            // label_facultad
            // 
            this.label_facultad.AutoSize = true;
            this.label_facultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_facultad.Location = new System.Drawing.Point(22, 84);
            this.label_facultad.Name = "label_facultad";
            this.label_facultad.Size = new System.Drawing.Size(51, 13);
            this.label_facultad.TabIndex = 24;
            this.label_facultad.Text = "Facultad:";
            // 
            // label_cicloI
            // 
            this.label_cicloI.AutoSize = true;
            this.label_cicloI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_cicloI.Location = new System.Drawing.Point(21, 29);
            this.label_cicloI.Name = "label_cicloI";
            this.label_cicloI.Size = new System.Drawing.Size(33, 13);
            this.label_cicloI.TabIndex = 23;
            this.label_cicloI.Text = "Ciclo:";
            // 
            // gbox_datosNacimiento
            // 
            this.gbox_datosNacimiento.Controls.Add(this.label_paisN);
            this.gbox_datosNacimiento.Controls.Add(this.tbox_paisN);
            this.gbox_datosNacimiento.Controls.Add(this.cbox_departamentoN);
            this.gbox_datosNacimiento.Controls.Add(this.label_departamentoN);
            this.gbox_datosNacimiento.Controls.Add(this.label_fechaNacimiento);
            this.gbox_datosNacimiento.Controls.Add(this.dt_fechanacimiento);
            this.gbox_datosNacimiento.Controls.Add(this.tbox_provinciaN);
            this.gbox_datosNacimiento.Controls.Add(this.label_distritoN);
            this.gbox_datosNacimiento.Controls.Add(this.label_provinciaN);
            this.gbox_datosNacimiento.Controls.Add(this.tbox_distritoN);
            this.gbox_datosNacimiento.Location = new System.Drawing.Point(401, 176);
            this.gbox_datosNacimiento.Name = "gbox_datosNacimiento";
            this.gbox_datosNacimiento.Size = new System.Drawing.Size(350, 172);
            this.gbox_datosNacimiento.TabIndex = 10;
            this.gbox_datosNacimiento.TabStop = false;
            this.gbox_datosNacimiento.Text = "Datos de Nacimiento";
            // 
            // label_paisN
            // 
            this.label_paisN.AutoSize = true;
            this.label_paisN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_paisN.Location = new System.Drawing.Point(21, 134);
            this.label_paisN.Name = "label_paisN";
            this.label_paisN.Size = new System.Drawing.Size(32, 13);
            this.label_paisN.TabIndex = 29;
            this.label_paisN.Text = "País:";
            // 
            // tbox_paisN
            // 
            this.tbox_paisN.Location = new System.Drawing.Point(123, 131);
            this.tbox_paisN.Name = "tbox_paisN";
            this.tbox_paisN.Size = new System.Drawing.Size(200, 20);
            this.tbox_paisN.TabIndex = 28;
            // 
            // cbox_departamentoN
            // 
            this.cbox_departamentoN.FormattingEnabled = true;
            this.cbox_departamentoN.Items.AddRange(new object[] {
            "--",
            "Amazonas",
            "Áncash",
            "Apurímac",
            "Arequipa",
            "Ayacucho",
            "Cajamarca",
            "Callao",
            "Cuzco",
            "Huancavelica",
            "Huánuco",
            "Ica",
            "Junín",
            "La Libertad",
            "Lambayeque",
            "Lima",
            "Loreto",
            "Madre de Dios",
            "Moquegua",
            "Pasco",
            "Piura",
            "Puno",
            "San Martín",
            "Tacna",
            "Tumbes",
            "Ucayali"});
            this.cbox_departamentoN.Location = new System.Drawing.Point(123, 104);
            this.cbox_departamentoN.Name = "cbox_departamentoN";
            this.cbox_departamentoN.Size = new System.Drawing.Size(100, 21);
            this.cbox_departamentoN.TabIndex = 22;
            // 
            // label_departamentoN
            // 
            this.label_departamentoN.AutoSize = true;
            this.label_departamentoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_departamentoN.Location = new System.Drawing.Point(21, 107);
            this.label_departamentoN.Name = "label_departamentoN";
            this.label_departamentoN.Size = new System.Drawing.Size(77, 13);
            this.label_departamentoN.TabIndex = 27;
            this.label_departamentoN.Text = "Departamento:";
            // 
            // label_fechaNacimiento
            // 
            this.label_fechaNacimiento.AutoSize = true;
            this.label_fechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_fechaNacimiento.Location = new System.Drawing.Point(21, 32);
            this.label_fechaNacimiento.Name = "label_fechaNacimiento";
            this.label_fechaNacimiento.Size = new System.Drawing.Size(96, 13);
            this.label_fechaNacimiento.TabIndex = 6;
            this.label_fechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // dt_fechanacimiento
            // 
            this.dt_fechanacimiento.Location = new System.Drawing.Point(123, 26);
            this.dt_fechanacimiento.Name = "dt_fechanacimiento";
            this.dt_fechanacimiento.Size = new System.Drawing.Size(200, 20);
            this.dt_fechanacimiento.TabIndex = 11;
            this.dt_fechanacimiento.ValueChanged += new System.EventHandler(this.dt_fechanacimiento_ValueChanged);
            // 
            // tbox_provinciaN
            // 
            this.tbox_provinciaN.Location = new System.Drawing.Point(123, 78);
            this.tbox_provinciaN.Name = "tbox_provinciaN";
            this.tbox_provinciaN.Size = new System.Drawing.Size(200, 20);
            this.tbox_provinciaN.TabIndex = 25;
            // 
            // label_distritoN
            // 
            this.label_distritoN.AutoSize = true;
            this.label_distritoN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_distritoN.Location = new System.Drawing.Point(21, 55);
            this.label_distritoN.Name = "label_distritoN";
            this.label_distritoN.Size = new System.Drawing.Size(42, 13);
            this.label_distritoN.TabIndex = 23;
            this.label_distritoN.Text = "Distrito:";
            // 
            // label_provinciaN
            // 
            this.label_provinciaN.AutoSize = true;
            this.label_provinciaN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_provinciaN.Location = new System.Drawing.Point(21, 81);
            this.label_provinciaN.Name = "label_provinciaN";
            this.label_provinciaN.Size = new System.Drawing.Size(54, 13);
            this.label_provinciaN.TabIndex = 24;
            this.label_provinciaN.Text = "Provincia:";
            // 
            // tbox_distritoN
            // 
            this.tbox_distritoN.Location = new System.Drawing.Point(123, 52);
            this.tbox_distritoN.Name = "tbox_distritoN";
            this.tbox_distritoN.Size = new System.Drawing.Size(200, 20);
            this.tbox_distritoN.TabIndex = 22;
            // 
            // gbox_datosLocalidad
            // 
            this.gbox_datosLocalidad.Controls.Add(this.cbox_departamento);
            this.gbox_datosLocalidad.Controls.Add(this.label_departamento);
            this.gbox_datosLocalidad.Controls.Add(this.label_provincia);
            this.gbox_datosLocalidad.Controls.Add(this.tbox_provincia);
            this.gbox_datosLocalidad.Controls.Add(this.tbox_distrito);
            this.gbox_datosLocalidad.Controls.Add(this.label_distrito);
            this.gbox_datosLocalidad.Controls.Add(this.tbox_direccion);
            this.gbox_datosLocalidad.Controls.Add(this.label_direccion);
            this.gbox_datosLocalidad.Location = new System.Drawing.Point(401, 15);
            this.gbox_datosLocalidad.Name = "gbox_datosLocalidad";
            this.gbox_datosLocalidad.Size = new System.Drawing.Size(350, 147);
            this.gbox_datosLocalidad.TabIndex = 9;
            this.gbox_datosLocalidad.TabStop = false;
            this.gbox_datosLocalidad.Text = "Datos Domicilio ";
            // 
            // cbox_departamento
            // 
            this.cbox_departamento.FormattingEnabled = true;
            this.cbox_departamento.Items.AddRange(new object[] {
            "--",
            "Amazonas",
            "Áncash",
            "Apurímac",
            "Arequipa",
            "Ayacucho",
            "Cajamarca",
            "Callao",
            "Cuzco",
            "Huancavelica",
            "Huánuco",
            "Ica",
            "Junín",
            "La Libertad",
            "Lambayeque",
            "Lima",
            "Loreto",
            "Madre de Dios",
            "Moquegua",
            "Pasco",
            "Piura",
            "Puno",
            "San Martín",
            "Tacna",
            "Tumbes",
            "Ucayali"});
            this.cbox_departamento.Location = new System.Drawing.Point(123, 105);
            this.cbox_departamento.Name = "cbox_departamento";
            this.cbox_departamento.Size = new System.Drawing.Size(100, 21);
            this.cbox_departamento.TabIndex = 10;
            // 
            // label_departamento
            // 
            this.label_departamento.AutoSize = true;
            this.label_departamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_departamento.Location = new System.Drawing.Point(21, 108);
            this.label_departamento.Name = "label_departamento";
            this.label_departamento.Size = new System.Drawing.Size(77, 13);
            this.label_departamento.TabIndex = 21;
            this.label_departamento.Text = "Departamento:";
            // 
            // label_provincia
            // 
            this.label_provincia.AutoSize = true;
            this.label_provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_provincia.Location = new System.Drawing.Point(21, 82);
            this.label_provincia.Name = "label_provincia";
            this.label_provincia.Size = new System.Drawing.Size(54, 13);
            this.label_provincia.TabIndex = 20;
            this.label_provincia.Text = "Provincia:";
            // 
            // tbox_provincia
            // 
            this.tbox_provincia.Location = new System.Drawing.Point(123, 79);
            this.tbox_provincia.Name = "tbox_provincia";
            this.tbox_provincia.Size = new System.Drawing.Size(200, 20);
            this.tbox_provincia.TabIndex = 18;
            // 
            // tbox_distrito
            // 
            this.tbox_distrito.Location = new System.Drawing.Point(123, 53);
            this.tbox_distrito.Name = "tbox_distrito";
            this.tbox_distrito.Size = new System.Drawing.Size(200, 20);
            this.tbox_distrito.TabIndex = 17;
            // 
            // label_distrito
            // 
            this.label_distrito.AutoSize = true;
            this.label_distrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_distrito.Location = new System.Drawing.Point(21, 56);
            this.label_distrito.Name = "label_distrito";
            this.label_distrito.Size = new System.Drawing.Size(42, 13);
            this.label_distrito.TabIndex = 16;
            this.label_distrito.Text = "Distrito:";
            // 
            // tbox_direccion
            // 
            this.tbox_direccion.Location = new System.Drawing.Point(123, 27);
            this.tbox_direccion.Name = "tbox_direccion";
            this.tbox_direccion.Size = new System.Drawing.Size(200, 20);
            this.tbox_direccion.TabIndex = 15;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_direccion.Location = new System.Drawing.Point(21, 30);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(55, 13);
            this.label_direccion.TabIndex = 15;
            this.label_direccion.Text = "Dirección:";
            // 
            // gbox_datosGenerales
            // 
            this.gbox_datosGenerales.Controls.Add(this.tbox_id);
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
            this.gbox_datosGenerales.Location = new System.Drawing.Point(24, 15);
            this.gbox_datosGenerales.Name = "gbox_datosGenerales";
            this.gbox_datosGenerales.Size = new System.Drawing.Size(350, 301);
            this.gbox_datosGenerales.TabIndex = 8;
            this.gbox_datosGenerales.TabStop = false;
            this.gbox_datosGenerales.Text = "Datos Generales";
            // 
            // tbox_id
            // 
            this.tbox_id.Location = new System.Drawing.Point(273, 27);
            this.tbox_id.Name = "tbox_id";
            this.tbox_id.Size = new System.Drawing.Size(50, 20);
            this.tbox_id.TabIndex = 23;
            this.tbox_id.Visible = false;
            // 
            // label_fijo
            // 
            this.label_fijo.AutoSize = true;
            this.label_fijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_fijo.Location = new System.Drawing.Point(21, 262);
            this.label_fijo.Name = "label_fijo";
            this.label_fijo.Size = new System.Drawing.Size(71, 13);
            this.label_fijo.TabIndex = 22;
            this.label_fijo.Text = "Teléfono Fijo:";
            // 
            // label_movil
            // 
            this.label_movil.AutoSize = true;
            this.label_movil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_movil.Location = new System.Drawing.Point(21, 236);
            this.label_movil.Name = "label_movil";
            this.label_movil.Size = new System.Drawing.Size(80, 13);
            this.label_movil.TabIndex = 21;
            this.label_movil.Text = "Teléfono Móvil:";
            // 
            // label_correoAlternativo
            // 
            this.label_correoAlternativo.AutoSize = true;
            this.label_correoAlternativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_correoAlternativo.Location = new System.Drawing.Point(21, 210);
            this.label_correoAlternativo.Name = "label_correoAlternativo";
            this.label_correoAlternativo.Size = new System.Drawing.Size(94, 13);
            this.label_correoAlternativo.TabIndex = 20;
            this.label_correoAlternativo.Text = "Correo Alternativo:";
            // 
            // tbox_fijo
            // 
            this.tbox_fijo.Location = new System.Drawing.Point(123, 259);
            this.tbox_fijo.Name = "tbox_fijo";
            this.tbox_fijo.Size = new System.Drawing.Size(200, 20);
            this.tbox_fijo.TabIndex = 19;
            // 
            // tbox_movil
            // 
            this.tbox_movil.Location = new System.Drawing.Point(123, 233);
            this.tbox_movil.Name = "tbox_movil";
            this.tbox_movil.Size = new System.Drawing.Size(200, 20);
            this.tbox_movil.TabIndex = 18;
            // 
            // tbox_correoalternativo
            // 
            this.tbox_correoalternativo.Location = new System.Drawing.Point(123, 207);
            this.tbox_correoalternativo.Name = "tbox_correoalternativo";
            this.tbox_correoalternativo.Size = new System.Drawing.Size(200, 20);
            this.tbox_correoalternativo.TabIndex = 17;
            // 
            // tbox_correopucp
            // 
            this.tbox_correopucp.Location = new System.Drawing.Point(123, 181);
            this.tbox_correopucp.Name = "tbox_correopucp";
            this.tbox_correopucp.Size = new System.Drawing.Size(200, 20);
            this.tbox_correopucp.TabIndex = 16;
            // 
            // label_correopucp
            // 
            this.label_correopucp.AutoSize = true;
            this.label_correopucp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_correopucp.Location = new System.Drawing.Point(21, 184);
            this.label_correopucp.Name = "label_correopucp";
            this.label_correopucp.Size = new System.Drawing.Size(73, 13);
            this.label_correopucp.TabIndex = 15;
            this.label_correopucp.Text = "Correo PUCP:";
            // 
            // tbox_edad
            // 
            this.tbox_edad.Location = new System.Drawing.Point(123, 155);
            this.tbox_edad.Name = "tbox_edad";
            this.tbox_edad.Size = new System.Drawing.Size(50, 20);
            this.tbox_edad.TabIndex = 14;
            // 
            // label_edad
            // 
            this.label_edad.AutoSize = true;
            this.label_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_edad.Location = new System.Drawing.Point(21, 158);
            this.label_edad.Name = "label_edad";
            this.label_edad.Size = new System.Drawing.Size(35, 13);
            this.label_edad.TabIndex = 13;
            this.label_edad.Text = "Edad:";
            // 
            // tbox_dni
            // 
            this.tbox_dni.Location = new System.Drawing.Point(123, 129);
            this.tbox_dni.Name = "tbox_dni";
            this.tbox_dni.Size = new System.Drawing.Size(100, 20);
            this.tbox_dni.TabIndex = 12;
            // 
            // rbutton_masculino
            // 
            this.rbutton_masculino.AutoSize = true;
            this.rbutton_masculino.Location = new System.Drawing.Point(123, 106);
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
            this.label_dni.Location = new System.Drawing.Point(21, 132);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(29, 13);
            this.label_dni.TabIndex = 5;
            this.label_dni.Text = "DNI:";
            // 
            // rbutton_femenino
            // 
            this.rbutton_femenino.AutoSize = true;
            this.rbutton_femenino.Location = new System.Drawing.Point(227, 106);
            this.rbutton_femenino.Name = "rbutton_femenino";
            this.rbutton_femenino.Size = new System.Drawing.Size(71, 17);
            this.rbutton_femenino.TabIndex = 9;
            this.rbutton_femenino.TabStop = true;
            this.rbutton_femenino.Text = "Femenino";
            this.rbutton_femenino.UseVisualStyleBackColor = true;
            // 
            // tbox_apellidos
            // 
            this.tbox_apellidos.Location = new System.Drawing.Point(123, 79);
            this.tbox_apellidos.Name = "tbox_apellidos";
            this.tbox_apellidos.Size = new System.Drawing.Size(200, 20);
            this.tbox_apellidos.TabIndex = 4;
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_sexo.Location = new System.Drawing.Point(21, 108);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(34, 13);
            this.label_sexo.TabIndex = 7;
            this.label_sexo.Text = "Sexo:";
            // 
            // tbox_nombres
            // 
            this.tbox_nombres.Location = new System.Drawing.Point(123, 53);
            this.tbox_nombres.Name = "tbox_nombres";
            this.tbox_nombres.Size = new System.Drawing.Size(200, 20);
            this.tbox_nombres.TabIndex = 3;
            // 
            // tbox_codigo
            // 
            this.tbox_codigo.Location = new System.Drawing.Point(123, 27);
            this.tbox_codigo.Name = "tbox_codigo";
            this.tbox_codigo.Size = new System.Drawing.Size(100, 20);
            this.tbox_codigo.TabIndex = 2;
            // 
            // label_codigo
            // 
            this.label_codigo.AutoSize = true;
            this.label_codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_codigo.Location = new System.Drawing.Point(21, 30);
            this.label_codigo.Name = "label_codigo";
            this.label_codigo.Size = new System.Drawing.Size(43, 13);
            this.label_codigo.TabIndex = 0;
            this.label_codigo.Text = "Código:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_nombre.Location = new System.Drawing.Point(21, 56);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(52, 13);
            this.label_nombre.TabIndex = 1;
            this.label_nombre.Text = "Nombres:";
            // 
            // label_apellidos
            // 
            this.label_apellidos.AutoSize = true;
            this.label_apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label_apellidos.Location = new System.Drawing.Point(21, 82);
            this.label_apellidos.Name = "label_apellidos";
            this.label_apellidos.Size = new System.Drawing.Size(52, 13);
            this.label_apellidos.TabIndex = 2;
            this.label_apellidos.Text = "Apellidos:";
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
            this.toolStrip_historiaacademica.Size = new System.Drawing.Size(826, 25);
            this.toolStrip_historiaacademica.TabIndex = 2;
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
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 568);
            this.Controls.Add(this.toolStrip_historiaacademica);
            this.Controls.Add(this.panel_Alumno);
            this.Name = "frmAlumno";
            this.Text = "frmAlumno";
            this.panel_Alumno.ResumeLayout(false);
            this.gbox_datosIngreso.ResumeLayout(false);
            this.gbox_datosIngreso.PerformLayout();
            this.gbox_datosNacimiento.ResumeLayout(false);
            this.gbox_datosNacimiento.PerformLayout();
            this.gbox_datosLocalidad.ResumeLayout(false);
            this.gbox_datosLocalidad.PerformLayout();
            this.gbox_datosGenerales.ResumeLayout(false);
            this.gbox_datosGenerales.PerformLayout();
            this.toolStrip_historiaacademica.ResumeLayout(false);
            this.toolStrip_historiaacademica.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Alumno;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.Label label_fechaNacimiento;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label label_apellidos;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Label label_codigo;
        private System.Windows.Forms.GroupBox gbox_datosGenerales;
        private System.Windows.Forms.TextBox tbox_apellidos;
        private System.Windows.Forms.TextBox tbox_nombres;
        private System.Windows.Forms.TextBox tbox_codigo;
        private System.Windows.Forms.RadioButton rbutton_femenino;
        private System.Windows.Forms.RadioButton rbutton_masculino;
        private System.Windows.Forms.TextBox tbox_dni;
        private System.Windows.Forms.DateTimePicker dt_fechanacimiento;
        private System.Windows.Forms.GroupBox gbox_datosLocalidad;
        private System.Windows.Forms.TextBox tbox_edad;
        private System.Windows.Forms.Label label_edad;
        private System.Windows.Forms.ComboBox cbox_departamento;
        private System.Windows.Forms.Label label_departamento;
        private System.Windows.Forms.Label label_provincia;
        private System.Windows.Forms.TextBox tbox_provincia;
        private System.Windows.Forms.TextBox tbox_distrito;
        private System.Windows.Forms.Label label_distrito;
        private System.Windows.Forms.TextBox tbox_direccion;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.TextBox tbox_fijo;
        private System.Windows.Forms.TextBox tbox_movil;
        private System.Windows.Forms.TextBox tbox_correoalternativo;
        private System.Windows.Forms.TextBox tbox_correopucp;
        private System.Windows.Forms.Label label_correopucp;
        private System.Windows.Forms.GroupBox gbox_datosNacimiento;
        private System.Windows.Forms.ComboBox cbox_departamentoN;
        private System.Windows.Forms.Label label_departamentoN;
        private System.Windows.Forms.TextBox tbox_provinciaN;
        private System.Windows.Forms.Label label_distritoN;
        private System.Windows.Forms.Label label_provinciaN;
        private System.Windows.Forms.TextBox tbox_distritoN;
        private System.Windows.Forms.Label label_fijo;
        private System.Windows.Forms.Label label_movil;
        private System.Windows.Forms.Label label_correoAlternativo;
        private System.Windows.Forms.GroupBox gbox_datosIngreso;
        private System.Windows.Forms.Label label_paisN;
        private System.Windows.Forms.TextBox tbox_paisN;
        private System.Windows.Forms.Button btn_historiaacademica;
        private System.Windows.Forms.ComboBox cbox_especialidad;
        private System.Windows.Forms.Label label_tipogrupo;
        private System.Windows.Forms.TextBox tbox_tipogrupo;
        private System.Windows.Forms.TextBox tbox_ciclo;
        private System.Windows.Forms.Label label_especialidad;
        private System.Windows.Forms.Label label_facultad;
        private System.Windows.Forms.Label label_cicloI;
        private System.Windows.Forms.ToolStrip toolStrip_historiaacademica;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.TextBox tbox_facultad;
        private System.Windows.Forms.TextBox tbox_id;
    }
}