namespace Vista
{
    partial class frmGestionarTutoresTutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionarTutoresTutor));
            this.panelTutor = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtIdOcultoGT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtTelf = new System.Windows.Forms.TextBox();
            this.GBEstadoNT = new System.Windows.Forms.GroupBox();
            this.cbxCoordinador = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBEstadoNT = new System.Windows.Forms.ComboBox();
            this.GBNuevoTutorNT = new System.Windows.Forms.GroupBox();
            this.btnBuscarNT = new System.Windows.Forms.Button();
            this.txtApGt = new System.Windows.Forms.TextBox();
            this.txtNombGT = new System.Windows.Forms.TextBox();
            this.txtCodGT = new System.Windows.Forms.TextBox();
            this.LApeTutNT = new System.Windows.Forms.Label();
            this.LNombreTutNT = new System.Windows.Forms.Label();
            this.LCodigoTutNT = new System.Windows.Forms.Label();
            this.LGestTutBXT = new System.Windows.Forms.Label();
            this.DGVTutores = new System.Windows.Forms.DataGridView();
            this.C1Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip_GestionarTutores = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.panelTutor.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.GBEstadoNT.SuspendLayout();
            this.GBNuevoTutorNT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTutores)).BeginInit();
            this.toolStrip_GestionarTutores.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTutor.AutoSize = true;
            this.panelTutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTutor.Controls.Add(this.groupBox1);
            this.panelTutor.Controls.Add(this.GBEstadoNT);
            this.panelTutor.Controls.Add(this.GBNuevoTutorNT);
            this.panelTutor.Controls.Add(this.LGestTutBXT);
            this.panelTutor.Controls.Add(this.DGVTutores);
            this.panelTutor.Location = new System.Drawing.Point(12, 17);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(740, 457);
            this.panelTutor.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtIdOcultoGT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtTelf);
            this.groupBox1.Location = new System.Drawing.Point(378, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 138);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Contacto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(84, 89);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(100, 20);
            this.txtEstado.TabIndex = 12;
            // 
            // txtIdOcultoGT
            // 
            this.txtIdOcultoGT.Enabled = false;
            this.txtIdOcultoGT.Location = new System.Drawing.Point(226, 19);
            this.txtIdOcultoGT.Name = "txtIdOcultoGT";
            this.txtIdOcultoGT.Size = new System.Drawing.Size(63, 20);
            this.txtIdOcultoGT.TabIndex = 11;
            this.txtIdOcultoGT.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teléfono:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(84, 37);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(117, 20);
            this.txtDni.TabIndex = 8;
            // 
            // txtTelf
            // 
            this.txtTelf.Location = new System.Drawing.Point(84, 63);
            this.txtTelf.Name = "txtTelf";
            this.txtTelf.Size = new System.Drawing.Size(117, 20);
            this.txtTelf.TabIndex = 9;
            // 
            // GBEstadoNT
            // 
            this.GBEstadoNT.Controls.Add(this.cbxCoordinador);
            this.GBEstadoNT.Controls.Add(this.label5);
            this.GBEstadoNT.Controls.Add(this.label4);
            this.GBEstadoNT.Controls.Add(this.CBEstadoNT);
            this.GBEstadoNT.Location = new System.Drawing.Point(26, 382);
            this.GBEstadoNT.Name = "GBEstadoNT";
            this.GBEstadoNT.Size = new System.Drawing.Size(682, 57);
            this.GBEstadoNT.TabIndex = 7;
            this.GBEstadoNT.TabStop = false;
            this.GBEstadoNT.Text = "Nuevo";
            // 
            // cbxCoordinador
            // 
            this.cbxCoordinador.FormattingEnabled = true;
            this.cbxCoordinador.Location = new System.Drawing.Point(451, 25);
            this.cbxCoordinador.Name = "cbxCoordinador";
            this.cbxCoordinador.Size = new System.Drawing.Size(138, 21);
            this.cbxCoordinador.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Coordinador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Estado:";
            // 
            // CBEstadoNT
            // 
            this.CBEstadoNT.FormattingEnabled = true;
            this.CBEstadoNT.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CBEstadoNT.Location = new System.Drawing.Point(76, 25);
            this.CBEstadoNT.Name = "CBEstadoNT";
            this.CBEstadoNT.Size = new System.Drawing.Size(99, 21);
            this.CBEstadoNT.TabIndex = 0;
            // 
            // GBNuevoTutorNT
            // 
            this.GBNuevoTutorNT.Controls.Add(this.btnBuscarNT);
            this.GBNuevoTutorNT.Controls.Add(this.txtApGt);
            this.GBNuevoTutorNT.Controls.Add(this.txtNombGT);
            this.GBNuevoTutorNT.Controls.Add(this.txtCodGT);
            this.GBNuevoTutorNT.Controls.Add(this.LApeTutNT);
            this.GBNuevoTutorNT.Controls.Add(this.LNombreTutNT);
            this.GBNuevoTutorNT.Controls.Add(this.LCodigoTutNT);
            this.GBNuevoTutorNT.Location = new System.Drawing.Point(26, 238);
            this.GBNuevoTutorNT.Name = "GBNuevoTutorNT";
            this.GBNuevoTutorNT.Size = new System.Drawing.Size(330, 138);
            this.GBNuevoTutorNT.TabIndex = 6;
            this.GBNuevoTutorNT.TabStop = false;
            this.GBNuevoTutorNT.Text = "Datos Principales";
            // 
            // btnBuscarNT
            // 
            this.btnBuscarNT.Location = new System.Drawing.Point(228, 39);
            this.btnBuscarNT.Name = "btnBuscarNT";
            this.btnBuscarNT.Size = new System.Drawing.Size(82, 20);
            this.btnBuscarNT.TabIndex = 6;
            this.btnBuscarNT.Text = "Buscar";
            this.btnBuscarNT.UseVisualStyleBackColor = true;
            this.btnBuscarNT.Click += new System.EventHandler(this.btnBuscarNT_Click);
            // 
            // txtApGt
            // 
            this.txtApGt.Location = new System.Drawing.Point(76, 89);
            this.txtApGt.Name = "txtApGt";
            this.txtApGt.Size = new System.Drawing.Size(234, 20);
            this.txtApGt.TabIndex = 5;
            // 
            // txtNombGT
            // 
            this.txtNombGT.Location = new System.Drawing.Point(76, 63);
            this.txtNombGT.Name = "txtNombGT";
            this.txtNombGT.Size = new System.Drawing.Size(234, 20);
            this.txtNombGT.TabIndex = 4;
            // 
            // txtCodGT
            // 
            this.txtCodGT.Location = new System.Drawing.Point(76, 37);
            this.txtCodGT.Name = "txtCodGT";
            this.txtCodGT.Size = new System.Drawing.Size(106, 20);
            this.txtCodGT.TabIndex = 3;
            // 
            // LApeTutNT
            // 
            this.LApeTutNT.AutoSize = true;
            this.LApeTutNT.Location = new System.Drawing.Point(18, 92);
            this.LApeTutNT.Name = "LApeTutNT";
            this.LApeTutNT.Size = new System.Drawing.Size(52, 13);
            this.LApeTutNT.TabIndex = 2;
            this.LApeTutNT.Text = "Apellidos:";
            // 
            // LNombreTutNT
            // 
            this.LNombreTutNT.AutoSize = true;
            this.LNombreTutNT.Location = new System.Drawing.Point(18, 66);
            this.LNombreTutNT.Name = "LNombreTutNT";
            this.LNombreTutNT.Size = new System.Drawing.Size(47, 13);
            this.LNombreTutNT.TabIndex = 1;
            this.LNombreTutNT.Text = "Nombre:";
            // 
            // LCodigoTutNT
            // 
            this.LCodigoTutNT.AutoSize = true;
            this.LCodigoTutNT.Location = new System.Drawing.Point(18, 43);
            this.LCodigoTutNT.Name = "LCodigoTutNT";
            this.LCodigoTutNT.Size = new System.Drawing.Size(43, 13);
            this.LCodigoTutNT.TabIndex = 0;
            this.LCodigoTutNT.Text = "Codigo:";
            // 
            // LGestTutBXT
            // 
            this.LGestTutBXT.AutoSize = true;
            this.LGestTutBXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestTutBXT.Location = new System.Drawing.Point(29, 10);
            this.LGestTutBXT.Name = "LGestTutBXT";
            this.LGestTutBXT.Size = new System.Drawing.Size(154, 20);
            this.LGestTutBXT.TabIndex = 5;
            this.LGestTutBXT.Text = "Gestionar Tutores";
            // 
            // DGVTutores
            // 
            this.DGVTutores.AllowUserToAddRows = false;
            this.DGVTutores.AllowUserToDeleteRows = false;
            this.DGVTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1Tutor,
            this.IdTutor,
            this.DNI,
            this.Correo,
            this.C2Tutor,
            this.C3Tutor,
            this.Telefono,
            this.Estado});
            this.DGVTutores.Location = new System.Drawing.Point(28, 38);
            this.DGVTutores.Name = "DGVTutores";
            this.DGVTutores.ReadOnly = true;
            this.DGVTutores.Size = new System.Drawing.Size(680, 186);
            this.DGVTutores.TabIndex = 4;
            this.DGVTutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTutores_CellClick);
            // 
            // C1Tutor
            // 
            this.C1Tutor.DataPropertyName = "CodigoPUCP";
            this.C1Tutor.HeaderText = "Codigo";
            this.C1Tutor.Name = "C1Tutor";
            this.C1Tutor.ReadOnly = true;
            // 
            // IdTutor
            // 
            this.IdTutor.DataPropertyName = "IdTutor";
            this.IdTutor.HeaderText = "IdTutor";
            this.IdTutor.Name = "IdTutor";
            this.IdTutor.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "DNI";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "CorreoPUCP";
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // C2Tutor
            // 
            this.C2Tutor.DataPropertyName = "Nombres";
            this.C2Tutor.HeaderText = "Nombre";
            this.C2Tutor.Name = "C2Tutor";
            this.C2Tutor.ReadOnly = true;
            // 
            // C3Tutor
            // 
            this.C3Tutor.DataPropertyName = "Apellidos";
            this.C3Tutor.HeaderText = "Apellidos";
            this.C3Tutor.Name = "C3Tutor";
            this.C3Tutor.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "TelfMovil";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Visible = false;
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
            this.toolStrip_GestionarTutores.Size = new System.Drawing.Size(764, 25);
            this.toolStrip_GestionarTutores.TabIndex = 5;
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
            // frmGestionarTutoresTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 568);
            this.Controls.Add(this.toolStrip_GestionarTutores);
            this.Controls.Add(this.panelTutor);
            this.Name = "frmGestionarTutoresTutor";
            this.Text = "frmGestionarTutoresTutor";
            this.Load += new System.EventHandler(this.frmGestionarTutoresTutor_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBEstadoNT.ResumeLayout(false);
            this.GBEstadoNT.PerformLayout();
            this.GBNuevoTutorNT.ResumeLayout(false);
            this.GBNuevoTutorNT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTutores)).EndInit();
            this.toolStrip_GestionarTutores.ResumeLayout(false);
            this.toolStrip_GestionarTutores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTutor;
        private System.Windows.Forms.Label LGestTutBXT;
        private System.Windows.Forms.DataGridView DGVTutores;
        private System.Windows.Forms.ToolStrip toolStrip_GestionarTutores;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.GroupBox GBEstadoNT;
        private System.Windows.Forms.GroupBox GBNuevoTutorNT;
        private System.Windows.Forms.Button btnBuscarNT;
        private System.Windows.Forms.TextBox txtApGt;
        private System.Windows.Forms.TextBox txtNombGT;
        private System.Windows.Forms.TextBox txtCodGT;
        private System.Windows.Forms.Label LApeTutNT;
        private System.Windows.Forms.Label LNombreTutNT;
        private System.Windows.Forms.Label LCodigoTutNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelf;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdOcultoGT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.ComboBox cbxCoordinador;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBEstadoNT;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}