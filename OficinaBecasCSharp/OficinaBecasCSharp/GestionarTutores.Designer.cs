namespace Vista
{
    partial class GestionarTutores
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
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.btnMNBesBecariosXtutor = new System.Windows.Forms.Button();
            this.btnMNGesCitas = new System.Windows.Forms.Button();
            this.btnMNGesTutores = new System.Windows.Forms.Button();
            this.btnMNConsBecas = new System.Windows.Forms.Button();
            this.panelTutor = new System.Windows.Forms.Panel();
            this.LGestTutBXT = new System.Windows.Forms.Label();
            this.DGVTutores = new System.Windows.Forms.DataGridView();
            this.C1Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarTutor = new System.Windows.Forms.Button();
            this.btnEditarTutor = new System.Windows.Forms.Button();
            this.btnNuevoTutor = new System.Windows.Forms.Button();
            this.panelBecariosXTutor = new System.Windows.Forms.Panel();
            this.LGestBecXTutBXT = new System.Windows.Forms.Label();
            this.LNotaTXB = new System.Windows.Forms.Label();
            this.btnModificarTXB = new System.Windows.Forms.Button();
            this.LSelecTutor = new System.Windows.Forms.Label();
            this.CBTutorGBXT = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtNombTutorBXT = new System.Windows.Forms.TextBox();
            this.TxtCodTutorBXT = new System.Windows.Forms.TextBox();
            this.LNombTutor = new System.Windows.Forms.Label();
            this.LCodTutor = new System.Windows.Forms.Label();
            this.btnBXTVer = new System.Windows.Forms.Button();
            this.DGVBXT = new System.Windows.Forms.DataGridView();
            this.C1BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4BXT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBXTAnadir = new System.Windows.Forms.Button();
            this.panelConsultarBecaT = new System.Windows.Forms.Panel();
            this.LabelCBT = new System.Windows.Forms.Label();
            this.LNombBecaCBT = new System.Windows.Forms.Label();
            this.btnBuscarBecaCBT = new System.Windows.Forms.Button();
            this.DGVConsBecaT = new System.Windows.Forms.DataGridView();
            this.NombreBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidosBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPUCPBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoBecario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BecarioActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodBecCBT = new System.Windows.Forms.TextBox();
            this.btnBecasExternasCBT = new System.Windows.Forms.Button();
            this.btnBecasPUCPCBT = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTutores)).BeginInit();
            this.panelBecariosXTutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBXT)).BeginInit();
            this.panelConsultarBecaT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsBecaT)).BeginInit();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbMenu.Controls.Add(this.btnMNBesBecariosXtutor);
            this.gbMenu.Controls.Add(this.btnMNGesCitas);
            this.gbMenu.Controls.Add(this.btnMNGesTutores);
            this.gbMenu.Controls.Add(this.btnMNConsBecas);
            this.gbMenu.Location = new System.Drawing.Point(30, 78);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(204, 342);
            this.gbMenu.TabIndex = 4;
            this.gbMenu.TabStop = false;
            this.gbMenu.Text = "MENU";
            // 
            // btnMNBesBecariosXtutor
            // 
            this.btnMNBesBecariosXtutor.Location = new System.Drawing.Point(6, 238);
            this.btnMNBesBecariosXtutor.Name = "btnMNBesBecariosXtutor";
            this.btnMNBesBecariosXtutor.Size = new System.Drawing.Size(191, 23);
            this.btnMNBesBecariosXtutor.TabIndex = 3;
            this.btnMNBesBecariosXtutor.Text = "Gestionar Becarios por Tutor";
            this.btnMNBesBecariosXtutor.UseVisualStyleBackColor = true;
            this.btnMNBesBecariosXtutor.Click += new System.EventHandler(this.btnMNBesBecariosXtutor_Click);
            // 
            // btnMNGesCitas
            // 
            this.btnMNGesCitas.Location = new System.Drawing.Point(6, 175);
            this.btnMNGesCitas.Name = "btnMNGesCitas";
            this.btnMNGesCitas.Size = new System.Drawing.Size(191, 23);
            this.btnMNGesCitas.TabIndex = 2;
            this.btnMNGesCitas.Text = "Gestionar Citas";
            this.btnMNGesCitas.UseVisualStyleBackColor = true;
            // 
            // btnMNGesTutores
            // 
            this.btnMNGesTutores.Location = new System.Drawing.Point(6, 110);
            this.btnMNGesTutores.Name = "btnMNGesTutores";
            this.btnMNGesTutores.Size = new System.Drawing.Size(191, 23);
            this.btnMNGesTutores.TabIndex = 1;
            this.btnMNGesTutores.Text = "Gestionar Tutores";
            this.btnMNGesTutores.UseVisualStyleBackColor = true;
            this.btnMNGesTutores.Click += new System.EventHandler(this.btnMNGesTutores_Click);
            // 
            // btnMNConsBecas
            // 
            this.btnMNConsBecas.Location = new System.Drawing.Point(7, 48);
            this.btnMNConsBecas.Name = "btnMNConsBecas";
            this.btnMNConsBecas.Size = new System.Drawing.Size(191, 24);
            this.btnMNConsBecas.TabIndex = 0;
            this.btnMNConsBecas.Text = "Consultar Becas";
            this.btnMNConsBecas.UseVisualStyleBackColor = true;
            this.btnMNConsBecas.Click += new System.EventHandler(this.btnMNConsBecas_Click);
            // 
            // panelTutor
            // 
            this.panelTutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTutor.AutoSize = true;
            this.panelTutor.Controls.Add(this.LGestTutBXT);
            this.panelTutor.Controls.Add(this.DGVTutores);
            this.panelTutor.Controls.Add(this.label1);
            this.panelTutor.Controls.Add(this.btnEliminarTutor);
            this.panelTutor.Controls.Add(this.btnEditarTutor);
            this.panelTutor.Controls.Add(this.btnNuevoTutor);
            this.panelTutor.Location = new System.Drawing.Point(255, 78);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(522, 342);
            this.panelTutor.TabIndex = 3;
            // 
            // LGestTutBXT
            // 
            this.LGestTutBXT.AutoSize = true;
            this.LGestTutBXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestTutBXT.Location = new System.Drawing.Point(9, 13);
            this.LGestTutBXT.Name = "LGestTutBXT";
            this.LGestTutBXT.Size = new System.Drawing.Size(154, 20);
            this.LGestTutBXT.TabIndex = 5;
            this.LGestTutBXT.Text = "Gestionar Tutores";
            // 
            // DGVTutores
            // 
            this.DGVTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1Tutor,
            this.C2Tutor,
            this.C3Tutor,
            this.C4Tutor,
            this.C5Tutor});
            this.DGVTutores.Location = new System.Drawing.Point(27, 133);
            this.DGVTutores.Name = "DGVTutores";
            this.DGVTutores.Size = new System.Drawing.Size(459, 150);
            this.DGVTutores.TabIndex = 4;
            // 
            // C1Tutor
            // 
            this.C1Tutor.HeaderText = "Codigo";
            this.C1Tutor.Name = "C1Tutor";
            // 
            // C2Tutor
            // 
            this.C2Tutor.HeaderText = "Nombre";
            this.C2Tutor.Name = "C2Tutor";
            // 
            // C3Tutor
            // 
            this.C3Tutor.HeaderText = "Apellidos";
            this.C3Tutor.Name = "C3Tutor";
            // 
            // C4Tutor
            // 
            this.C4Tutor.HeaderText = "Fecha Inicio";
            this.C4Tutor.Name = "C4Tutor";
            // 
            // C5Tutor
            // 
            this.C5Tutor.HeaderText = "N° Becarios";
            this.C5Tutor.Name = "C5Tutor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Si se desea Editar, solo \r\ndebe seleccionar UN Tutor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEliminarTutor
            // 
            this.btnEliminarTutor.Location = new System.Drawing.Point(221, 75);
            this.btnEliminarTutor.Name = "btnEliminarTutor";
            this.btnEliminarTutor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTutor.TabIndex = 2;
            this.btnEliminarTutor.Text = "Eliminar";
            this.btnEliminarTutor.UseVisualStyleBackColor = true;
            this.btnEliminarTutor.Click += new System.EventHandler(this.btnEliminarTutor_Click);
            // 
            // btnEditarTutor
            // 
            this.btnEditarTutor.Location = new System.Drawing.Point(139, 75);
            this.btnEditarTutor.Name = "btnEditarTutor";
            this.btnEditarTutor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarTutor.TabIndex = 1;
            this.btnEditarTutor.Text = "Editar";
            this.btnEditarTutor.UseVisualStyleBackColor = true;
            this.btnEditarTutor.Click += new System.EventHandler(this.btnEditarTutor_Click);
            // 
            // btnNuevoTutor
            // 
            this.btnNuevoTutor.Location = new System.Drawing.Point(57, 75);
            this.btnNuevoTutor.Name = "btnNuevoTutor";
            this.btnNuevoTutor.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoTutor.TabIndex = 0;
            this.btnNuevoTutor.Text = "Nuevo";
            this.btnNuevoTutor.UseVisualStyleBackColor = true;
            this.btnNuevoTutor.Click += new System.EventHandler(this.btnNuevoTutor_Click);
            // 
            // panelBecariosXTutor
            // 
            this.panelBecariosXTutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBecariosXTutor.AutoSize = true;
            this.panelBecariosXTutor.Controls.Add(this.LGestBecXTutBXT);
            this.panelBecariosXTutor.Controls.Add(this.LNotaTXB);
            this.panelBecariosXTutor.Controls.Add(this.btnModificarTXB);
            this.panelBecariosXTutor.Controls.Add(this.LSelecTutor);
            this.panelBecariosXTutor.Controls.Add(this.CBTutorGBXT);
            this.panelBecariosXTutor.Controls.Add(this.groupBox1);
            this.panelBecariosXTutor.Controls.Add(this.DGVBXT);
            this.panelBecariosXTutor.Controls.Add(this.btnBXTAnadir);
            this.panelBecariosXTutor.Location = new System.Drawing.Point(255, 78);
            this.panelBecariosXTutor.Name = "panelBecariosXTutor";
            this.panelBecariosXTutor.Size = new System.Drawing.Size(522, 345);
            this.panelBecariosXTutor.TabIndex = 5;
            // 
            // LGestBecXTutBXT
            // 
            this.LGestBecXTutBXT.AutoSize = true;
            this.LGestBecXTutBXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestBecXTutBXT.Location = new System.Drawing.Point(10, 13);
            this.LGestBecXTutBXT.Name = "LGestBecXTutBXT";
            this.LGestBecXTutBXT.Size = new System.Drawing.Size(241, 20);
            this.LGestBecXTutBXT.TabIndex = 10;
            this.LGestBecXTutBXT.Text = "Gestionar Becarios por Tutor";
            // 
            // LNotaTXB
            // 
            this.LNotaTXB.AutoSize = true;
            this.LNotaTXB.Location = new System.Drawing.Point(263, 94);
            this.LNotaTXB.Name = "LNotaTXB";
            this.LNotaTXB.Size = new System.Drawing.Size(226, 26);
            this.LNotaTXB.TabIndex = 9;
            this.LNotaTXB.Text = "Para modificar el Tutor de un Becario\r\nseleccionar una fila y hacer clic en \"Modi" +
    "ficar\"";
            // 
            // btnModificarTXB
            // 
            this.btnModificarTXB.Location = new System.Drawing.Point(429, 307);
            this.btnModificarTXB.Name = "btnModificarTXB";
            this.btnModificarTXB.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTXB.TabIndex = 8;
            this.btnModificarTXB.Text = "Modificar";
            this.btnModificarTXB.UseVisualStyleBackColor = true;
            this.btnModificarTXB.Click += new System.EventHandler(this.btnModificarTXB_Click);
            // 
            // LSelecTutor
            // 
            this.LSelecTutor.AutoSize = true;
            this.LSelecTutor.Location = new System.Drawing.Point(21, 80);
            this.LSelecTutor.Name = "LSelecTutor";
            this.LSelecTutor.Size = new System.Drawing.Size(91, 13);
            this.LSelecTutor.TabIndex = 7;
            this.LSelecTutor.Text = "Seleccionar Tutor";
            // 
            // CBTutorGBXT
            // 
            this.CBTutorGBXT.FormattingEnabled = true;
            this.CBTutorGBXT.Items.AddRange(new object[] {
            "Seleccionar",
            "Tutor 1",
            "Tutor 2",
            "Tutor 3"});
            this.CBTutorGBXT.Location = new System.Drawing.Point(21, 99);
            this.CBTutorGBXT.Name = "CBTutorGBXT";
            this.CBTutorGBXT.Size = new System.Drawing.Size(200, 21);
            this.CBTutorGBXT.TabIndex = 6;
            this.CBTutorGBXT.SelectedIndexChanged += new System.EventHandler(this.CBTutorGBXT_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtNombTutorBXT);
            this.groupBox1.Controls.Add(this.TxtCodTutorBXT);
            this.groupBox1.Controls.Add(this.LNombTutor);
            this.groupBox1.Controls.Add(this.LCodTutor);
            this.groupBox1.Controls.Add(this.btnBXTVer);
            this.groupBox1.Location = new System.Drawing.Point(21, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tutor";
            // 
            // TxtNombTutorBXT
            // 
            this.TxtNombTutorBXT.Location = new System.Drawing.Point(59, 52);
            this.TxtNombTutorBXT.Name = "TxtNombTutorBXT";
            this.TxtNombTutorBXT.Size = new System.Drawing.Size(163, 20);
            this.TxtNombTutorBXT.TabIndex = 5;
            // 
            // TxtCodTutorBXT
            // 
            this.TxtCodTutorBXT.Location = new System.Drawing.Point(59, 30);
            this.TxtCodTutorBXT.Name = "TxtCodTutorBXT";
            this.TxtCodTutorBXT.Size = new System.Drawing.Size(100, 20);
            this.TxtCodTutorBXT.TabIndex = 4;
            this.TxtCodTutorBXT.TextChanged += new System.EventHandler(this.TBCodTutor_TextChanged);
            // 
            // LNombTutor
            // 
            this.LNombTutor.AutoSize = true;
            this.LNombTutor.Location = new System.Drawing.Point(9, 55);
            this.LNombTutor.Name = "LNombTutor";
            this.LNombTutor.Size = new System.Drawing.Size(47, 13);
            this.LNombTutor.TabIndex = 3;
            this.LNombTutor.Text = "Nombre:";
            // 
            // LCodTutor
            // 
            this.LCodTutor.AutoSize = true;
            this.LCodTutor.Location = new System.Drawing.Point(9, 30);
            this.LCodTutor.Name = "LCodTutor";
            this.LCodTutor.Size = new System.Drawing.Size(43, 13);
            this.LCodTutor.TabIndex = 2;
            this.LCodTutor.Text = "Código:";
            this.LCodTutor.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBXTVer
            // 
            this.btnBXTVer.Location = new System.Drawing.Point(125, 93);
            this.btnBXTVer.Name = "btnBXTVer";
            this.btnBXTVer.Size = new System.Drawing.Size(103, 23);
            this.btnBXTVer.TabIndex = 1;
            this.btnBXTVer.Text = "Ver Becarios";
            this.btnBXTVer.UseVisualStyleBackColor = true;
            this.btnBXTVer.Click += new System.EventHandler(this.btnBXTVer_Click);
            // 
            // DGVBXT
            // 
            this.DGVBXT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVBXT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1BXT,
            this.C2BXT,
            this.C3BXT,
            this.C4BXT});
            this.DGVBXT.Location = new System.Drawing.Point(266, 136);
            this.DGVBXT.Name = "DGVBXT";
            this.DGVBXT.Size = new System.Drawing.Size(238, 150);
            this.DGVBXT.TabIndex = 4;
            this.DGVBXT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // C1BXT
            // 
            this.C1BXT.HeaderText = "Codigo";
            this.C1BXT.Name = "C1BXT";
            // 
            // C2BXT
            // 
            this.C2BXT.HeaderText = "Nombre";
            this.C2BXT.Name = "C2BXT";
            // 
            // C3BXT
            // 
            this.C3BXT.HeaderText = "Apellidos";
            this.C3BXT.Name = "C3BXT";
            // 
            // C4BXT
            // 
            this.C4BXT.HeaderText = "Correo Electronico";
            this.C4BXT.Name = "C4BXT";
            // 
            // btnBXTAnadir
            // 
            this.btnBXTAnadir.Location = new System.Drawing.Point(308, 307);
            this.btnBXTAnadir.Name = "btnBXTAnadir";
            this.btnBXTAnadir.Size = new System.Drawing.Size(100, 23);
            this.btnBXTAnadir.TabIndex = 0;
            this.btnBXTAnadir.Text = "Añadir Becario\r\n";
            this.btnBXTAnadir.UseVisualStyleBackColor = true;
            this.btnBXTAnadir.Click += new System.EventHandler(this.btnBXTAnadir_Click);
            // 
            // panelConsultarBecaT
            // 
            this.panelConsultarBecaT.Controls.Add(this.btnBecasExternasCBT);
            this.panelConsultarBecaT.Controls.Add(this.btnBecasPUCPCBT);
            this.panelConsultarBecaT.Controls.Add(this.LabelCBT);
            this.panelConsultarBecaT.Controls.Add(this.LNombBecaCBT);
            this.panelConsultarBecaT.Controls.Add(this.btnBuscarBecaCBT);
            this.panelConsultarBecaT.Controls.Add(this.DGVConsBecaT);
            this.panelConsultarBecaT.Controls.Add(this.txtCodBecCBT);
            this.panelConsultarBecaT.Location = new System.Drawing.Point(255, 78);
            this.panelConsultarBecaT.Name = "panelConsultarBecaT";
            this.panelConsultarBecaT.Size = new System.Drawing.Size(522, 345);
            this.panelConsultarBecaT.TabIndex = 14;
            this.panelConsultarBecaT.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsultarBecaT_Paint);
            // 
            // LabelCBT
            // 
            this.LabelCBT.AutoSize = true;
            this.LabelCBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCBT.Location = new System.Drawing.Point(19, 12);
            this.LabelCBT.Name = "LabelCBT";
            this.LabelCBT.Size = new System.Drawing.Size(132, 20);
            this.LabelCBT.TabIndex = 18;
            this.LabelCBT.Text = "Consultar Beca";
            this.LabelCBT.Click += new System.EventHandler(this.lvlBecario_Click);
            // 
            // LNombBecaCBT
            // 
            this.LNombBecaCBT.AutoSize = true;
            this.LNombBecaCBT.Location = new System.Drawing.Point(57, 41);
            this.LNombBecaCBT.Name = "LNombBecaCBT";
            this.LNombBecaCBT.Size = new System.Drawing.Size(87, 13);
            this.LNombBecaCBT.TabIndex = 6;
            this.LNombBecaCBT.Text = "Nombre de Beca";
            // 
            // btnBuscarBecaCBT
            // 
            this.btnBuscarBecaCBT.Location = new System.Drawing.Point(367, 54);
            this.btnBuscarBecaCBT.Name = "btnBuscarBecaCBT";
            this.btnBuscarBecaCBT.Size = new System.Drawing.Size(92, 23);
            this.btnBuscarBecaCBT.TabIndex = 2;
            this.btnBuscarBecaCBT.Text = "Buscar";
            this.btnBuscarBecaCBT.UseVisualStyleBackColor = true;
            this.btnBuscarBecaCBT.Click += new System.EventHandler(this.btnBuscarBeca_Click);
            // 
            // DGVConsBecaT
            // 
            this.DGVConsBecaT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVConsBecaT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsBecaT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreBecario,
            this.ApellidosBecario,
            this.codPUCPBecario,
            this.sexoBecario,
            this.correoBecario,
            this.BecarioActivo});
            this.DGVConsBecaT.Location = new System.Drawing.Point(189, 99);
            this.DGVConsBecaT.Name = "DGVConsBecaT";
            this.DGVConsBecaT.Size = new System.Drawing.Size(300, 210);
            this.DGVConsBecaT.TabIndex = 3;
            // 
            // NombreBecario
            // 
            this.NombreBecario.HeaderText = "Nombres";
            this.NombreBecario.Name = "NombreBecario";
            // 
            // ApellidosBecario
            // 
            this.ApellidosBecario.HeaderText = "Apellidos";
            this.ApellidosBecario.Name = "ApellidosBecario";
            // 
            // codPUCPBecario
            // 
            this.codPUCPBecario.HeaderText = "Código PUCP";
            this.codPUCPBecario.Name = "codPUCPBecario";
            // 
            // sexoBecario
            // 
            this.sexoBecario.HeaderText = "Sexo";
            this.sexoBecario.Name = "sexoBecario";
            // 
            // correoBecario
            // 
            this.correoBecario.HeaderText = "Correo Electrónico";
            this.correoBecario.Name = "correoBecario";
            // 
            // BecarioActivo
            // 
            this.BecarioActivo.HeaderText = "Activo";
            this.BecarioActivo.Name = "BecarioActivo";
            // 
            // txtCodBecCBT
            // 
            this.txtCodBecCBT.Location = new System.Drawing.Point(60, 57);
            this.txtCodBecCBT.Name = "txtCodBecCBT";
            this.txtCodBecCBT.Size = new System.Drawing.Size(251, 20);
            this.txtCodBecCBT.TabIndex = 1;
            // 
            // btnBecasExternasCBT
            // 
            this.btnBecasExternasCBT.AutoSize = true;
            this.btnBecasExternasCBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasExternasCBT.Location = new System.Drawing.Point(46, 211);
            this.btnBecasExternasCBT.Name = "btnBecasExternasCBT";
            this.btnBecasExternasCBT.Size = new System.Drawing.Size(91, 23);
            this.btnBecasExternasCBT.TabIndex = 20;
            this.btnBecasExternasCBT.Text = "Becas Externas";
            this.btnBecasExternasCBT.UseVisualStyleBackColor = true;
            // 
            // btnBecasPUCPCBT
            // 
            this.btnBecasPUCPCBT.AutoSize = true;
            this.btnBecasPUCPCBT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBecasPUCPCBT.Location = new System.Drawing.Point(46, 155);
            this.btnBecasPUCPCBT.Name = "btnBecasPUCPCBT";
            this.btnBecasPUCPCBT.Size = new System.Drawing.Size(79, 23);
            this.btnBecasPUCPCBT.TabIndex = 19;
            this.btnBecasPUCPCBT.Text = "Becas PUCP";
            this.btnBecasPUCPCBT.UseVisualStyleBackColor = true;
            // 
            // GestionarTutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelConsultarBecaT);
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.panelBecariosXTutor);
            this.Controls.Add(this.panelTutor);
            this.IsMdiContainer = true;
            this.Name = "GestionarTutores";
            this.Text = "GestionarTutores";
            this.Load += new System.EventHandler(this.GestionarTutores_Load);
            this.gbMenu.ResumeLayout(false);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTutores)).EndInit();
            this.panelBecariosXTutor.ResumeLayout(false);
            this.panelBecariosXTutor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVBXT)).EndInit();
            this.panelConsultarBecaT.ResumeLayout(false);
            this.panelConsultarBecaT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsBecaT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMenu;
        private System.Windows.Forms.Button btnMNGesTutores;
        private System.Windows.Forms.Button btnMNConsBecas;
        private System.Windows.Forms.Button btnMNGesCitas;
        private System.Windows.Forms.Button btnMNBesBecariosXtutor;
        private System.Windows.Forms.Panel panelTutor;
        private System.Windows.Forms.DataGridView DGVTutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5Tutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarTutor;
        private System.Windows.Forms.Button btnEditarTutor;
        private System.Windows.Forms.Button btnNuevoTutor;
        private System.Windows.Forms.Panel panelBecariosXTutor;
        private System.Windows.Forms.DataGridView DGVBXT;
        private System.Windows.Forms.Button btnBXTVer;
        private System.Windows.Forms.Button btnBXTAnadir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LCodTutor;
        private System.Windows.Forms.Label LNombTutor;
        private System.Windows.Forms.Label LSelecTutor;
        private System.Windows.Forms.ComboBox CBTutorGBXT;
        private System.Windows.Forms.TextBox TxtNombTutorBXT;
        private System.Windows.Forms.TextBox TxtCodTutorBXT;
        private System.Windows.Forms.Label LGestTutBXT;
        private System.Windows.Forms.Label LGestBecXTutBXT;
        private System.Windows.Forms.Label LNotaTXB;
        private System.Windows.Forms.Button btnModificarTXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1BXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2BXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3BXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4BXT;
        private System.Windows.Forms.Panel panelConsultarBecaT;
        private System.Windows.Forms.Label LabelCBT;
        private System.Windows.Forms.Label LNombBecaCBT;
        private System.Windows.Forms.Button btnBuscarBecaCBT;
        private System.Windows.Forms.DataGridView DGVConsBecaT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidosBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn codPUCPBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoBecario;
        private System.Windows.Forms.DataGridViewTextBoxColumn BecarioActivo;
        private System.Windows.Forms.TextBox txtCodBecCBT;
        private System.Windows.Forms.Button btnBecasExternasCBT;
        private System.Windows.Forms.Button btnBecasPUCPCBT;
    }
}