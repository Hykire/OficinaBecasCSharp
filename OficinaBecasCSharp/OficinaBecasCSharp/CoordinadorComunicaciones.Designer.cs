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
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBeca = new System.Windows.Forms.Button();
            this.txtDescripcionConvocatoria = new System.Windows.Forms.TextBox();
            this.lbBeca = new System.Windows.Forms.Label();
            this.lbDescripciónConvocatoria = new System.Windows.Forms.Label();
            this.txtNombreConvocatoria = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cbBeca = new System.Windows.Forms.ComboBox();
            this.txtNumeroEnviados = new System.Windows.Forms.TextBox();
            this.txtNumeroRespuestas = new System.Windows.Forms.TextBox();
            this.txtFechaConvocatoria = new System.Windows.Forms.TextBox();
            this.lbNombreConvocatoria = new System.Windows.Forms.Label();
            this.lbFechaConvocatoria = new System.Windows.Forms.Label();
            this.lbNumeroTotalEnviados = new System.Windows.Forms.Label();
            this.lbNumeroRespuestas = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnFiltrarResultados = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.idConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NúmeroDeRespuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroTotalEnviados = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripciónConvocatoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GC_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCC = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCC.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(471, 260);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(432, 20);
            this.txtFiltro.TabIndex = 60;
            // 
            // btnBeca
            // 
            this.btnBeca.Location = new System.Drawing.Point(340, 284);
            this.btnBeca.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeca.Name = "btnBeca";
            this.btnBeca.Size = new System.Drawing.Size(26, 20);
            this.btnBeca.TabIndex = 59;
            this.btnBeca.Text = "...";
            this.btnBeca.UseVisualStyleBackColor = true;
            this.btnBeca.Click += new System.EventHandler(this.btnBeca_Click);
            // 
            // txtDescripcionConvocatoria
            // 
            this.txtDescripcionConvocatoria.Location = new System.Drawing.Point(180, 247);
            this.txtDescripcionConvocatoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcionConvocatoria.Name = "txtDescripcionConvocatoria";
            this.txtDescripcionConvocatoria.Size = new System.Drawing.Size(188, 20);
            this.txtDescripcionConvocatoria.TabIndex = 58;
            // 
            // lbBeca
            // 
            this.lbBeca.AutoSize = true;
            this.lbBeca.Location = new System.Drawing.Point(13, 286);
            this.lbBeca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBeca.Name = "lbBeca";
            this.lbBeca.Size = new System.Drawing.Size(35, 13);
            this.lbBeca.TabIndex = 57;
            this.lbBeca.Text = "Beca:";
            // 
            // lbDescripciónConvocatoria
            // 
            this.lbDescripciónConvocatoria.AutoSize = true;
            this.lbDescripciónConvocatoria.Location = new System.Drawing.Point(13, 251);
            this.lbDescripciónConvocatoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDescripciónConvocatoria.Name = "lbDescripciónConvocatoria";
            this.lbDescripciónConvocatoria.Size = new System.Drawing.Size(147, 13);
            this.lbDescripciónConvocatoria.TabIndex = 56;
            this.lbDescripciónConvocatoria.Text = "Descripción de Convocatoria:";
            // 
            // txtNombreConvocatoria
            // 
            this.txtNombreConvocatoria.Location = new System.Drawing.Point(180, 208);
            this.txtNombreConvocatoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreConvocatoria.Name = "txtNombreConvocatoria";
            this.txtNombreConvocatoria.Size = new System.Drawing.Size(188, 20);
            this.txtNombreConvocatoria.TabIndex = 55;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(800, 311);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 27);
            this.btnEliminar.TabIndex = 54;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(496, 311);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 27);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(117, 333);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 27);
            this.btnAceptar.TabIndex = 52;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // cbBeca
            // 
            this.cbBeca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBeca.FormattingEnabled = true;
            this.cbBeca.Location = new System.Drawing.Point(180, 284);
            this.cbBeca.Margin = new System.Windows.Forms.Padding(2);
            this.cbBeca.Name = "cbBeca";
            this.cbBeca.Size = new System.Drawing.Size(147, 21);
            this.cbBeca.TabIndex = 51;
            // 
            // txtNumeroEnviados
            // 
            this.txtNumeroEnviados.Location = new System.Drawing.Point(180, 128);
            this.txtNumeroEnviados.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroEnviados.Name = "txtNumeroEnviados";
            this.txtNumeroEnviados.Size = new System.Drawing.Size(188, 20);
            this.txtNumeroEnviados.TabIndex = 50;
            // 
            // txtNumeroRespuestas
            // 
            this.txtNumeroRespuestas.Location = new System.Drawing.Point(180, 88);
            this.txtNumeroRespuestas.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroRespuestas.Name = "txtNumeroRespuestas";
            this.txtNumeroRespuestas.Size = new System.Drawing.Size(188, 20);
            this.txtNumeroRespuestas.TabIndex = 49;
            // 
            // txtFechaConvocatoria
            // 
            this.txtFechaConvocatoria.Location = new System.Drawing.Point(180, 168);
            this.txtFechaConvocatoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaConvocatoria.Name = "txtFechaConvocatoria";
            this.txtFechaConvocatoria.Size = new System.Drawing.Size(188, 20);
            this.txtFechaConvocatoria.TabIndex = 48;
            // 
            // lbNombreConvocatoria
            // 
            this.lbNombreConvocatoria.AutoSize = true;
            this.lbNombreConvocatoria.Location = new System.Drawing.Point(13, 212);
            this.lbNombreConvocatoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombreConvocatoria.Name = "lbNombreConvocatoria";
            this.lbNombreConvocatoria.Size = new System.Drawing.Size(128, 13);
            this.lbNombreConvocatoria.TabIndex = 47;
            this.lbNombreConvocatoria.Text = "Nombre de Convocatoria:";
            // 
            // lbFechaConvocatoria
            // 
            this.lbFechaConvocatoria.AutoSize = true;
            this.lbFechaConvocatoria.Location = new System.Drawing.Point(13, 172);
            this.lbFechaConvocatoria.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFechaConvocatoria.Name = "lbFechaConvocatoria";
            this.lbFechaConvocatoria.Size = new System.Drawing.Size(121, 13);
            this.lbFechaConvocatoria.TabIndex = 46;
            this.lbFechaConvocatoria.Text = "Fecha de Convocatoria:";
            // 
            // lbNumeroTotalEnviados
            // 
            this.lbNumeroTotalEnviados.AutoSize = true;
            this.lbNumeroTotalEnviados.Location = new System.Drawing.Point(13, 132);
            this.lbNumeroTotalEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumeroTotalEnviados.Name = "lbNumeroTotalEnviados";
            this.lbNumeroTotalEnviados.Size = new System.Drawing.Size(136, 13);
            this.lbNumeroTotalEnviados.TabIndex = 45;
            this.lbNumeroTotalEnviados.Text = "Número Total de Enviados:";
            // 
            // lbNumeroRespuestas
            // 
            this.lbNumeroRespuestas.AutoSize = true;
            this.lbNumeroRespuestas.Location = new System.Drawing.Point(13, 88);
            this.lbNumeroRespuestas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNumeroRespuestas.Name = "lbNumeroRespuestas";
            this.lbNumeroRespuestas.Size = new System.Drawing.Size(118, 13);
            this.lbNumeroRespuestas.TabIndex = 44;
            this.lbNumeroRespuestas.Text = "Número de Respuestas";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(644, 311);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 27);
            this.btnModificar.TabIndex = 43;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnFiltrarResultados
            // 
            this.btnFiltrarResultados.Location = new System.Drawing.Point(927, 255);
            this.btnFiltrarResultados.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrarResultados.Name = "btnFiltrarResultados";
            this.btnFiltrarResultados.Size = new System.Drawing.Size(104, 27);
            this.btnFiltrarResultados.TabIndex = 42;
            this.btnFiltrarResultados.Text = "Filtrar Resultados";
            this.btnFiltrarResultados.UseVisualStyleBackColor = true;
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToOrderColumns = true;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idConvocatoria,
            this.NúmeroDeRespuestas,
            this.NumeroTotalEnviados,
            this.FechaConvocatoria,
            this.NombreConvocatoria,
            this.DescripciónConvocatoria,
            this.Beca});
            this.dgvDatos.Location = new System.Drawing.Point(404, 5);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowTemplate.Height = 24;
            this.dgvDatos.Size = new System.Drawing.Size(560, 288);
            this.dgvDatos.TabIndex = 41;
            // 
            // idConvocatoria
            // 
            this.idConvocatoria.HeaderText = "idConvocatoria";
            this.idConvocatoria.Name = "idConvocatoria";
            // 
            // NúmeroDeRespuestas
            // 
            this.NúmeroDeRespuestas.HeaderText = "NúmeroDeRespuestas";
            this.NúmeroDeRespuestas.Name = "NúmeroDeRespuestas";
            // 
            // NumeroTotalEnviados
            // 
            this.NumeroTotalEnviados.HeaderText = "NumeroTotalEnviados";
            this.NumeroTotalEnviados.Name = "NumeroTotalEnviados";
            // 
            // FechaConvocatoria
            // 
            this.FechaConvocatoria.HeaderText = "FechaConvocatoria";
            this.FechaConvocatoria.Name = "FechaConvocatoria";
            // 
            // NombreConvocatoria
            // 
            this.NombreConvocatoria.HeaderText = "NombreConvocatoria";
            this.NombreConvocatoria.Name = "NombreConvocatoria";
            // 
            // DescripciónConvocatoria
            // 
            this.DescripciónConvocatoria.HeaderText = "DescripciónConvocatoria";
            this.DescripciónConvocatoria.Name = "DescripciónConvocatoria";
            // 
            // Beca
            // 
            this.Beca.HeaderText = "Beca";
            this.Beca.Name = "Beca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Consultar:";
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(35, 145);
            this.cbConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(118, 21);
            this.cbConsulta.TabIndex = 39;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.GC_button);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.cbConsulta);
            this.panel1.Controls.Add(this.btnFiltrarResultados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 441);
            this.panel1.TabIndex = 61;
            // 
            // GC_button
            // 
            this.GC_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GC_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GC_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GC_button.BorderRadius = 0;
            this.GC_button.ButtonText = "Gestionar        Convocatoria";
            this.GC_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GC_button.DisabledColor = System.Drawing.Color.Gray;
            this.GC_button.Iconcolor = System.Drawing.Color.Transparent;
            this.GC_button.Iconimage = ((System.Drawing.Image)(resources.GetObject("GC_button.Iconimage")));
            this.GC_button.Iconimage_right = null;
            this.GC_button.Iconimage_right_Selected = null;
            this.GC_button.Iconimage_Selected = null;
            this.GC_button.IconMarginLeft = 0;
            this.GC_button.IconMarginRight = 0;
            this.GC_button.IconRightVisible = true;
            this.GC_button.IconRightZoom = 0D;
            this.GC_button.IconVisible = true;
            this.GC_button.IconZoom = 90D;
            this.GC_button.IsTab = false;
            this.GC_button.Location = new System.Drawing.Point(0, 186);
            this.GC_button.Name = "GC_button";
            this.GC_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GC_button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.GC_button.OnHoverTextColor = System.Drawing.Color.White;
            this.GC_button.selected = false;
            this.GC_button.Size = new System.Drawing.Size(200, 48);
            this.GC_button.TabIndex = 41;
            this.GC_button.Text = "Gestionar        Convocatoria";
            this.GC_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GC_button.Textcolor = System.Drawing.Color.White;
            this.GC_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GC_button.Click += new System.EventHandler(this.GC_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.panel2.Controls.Add(this.panelCC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 441);
            this.panel2.TabIndex = 62;
            // 
            // panelCC
            // 
            this.panelCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCC.Controls.Add(this.lbNumeroRespuestas);
            this.panelCC.Controls.Add(this.cbBeca);
            this.panelCC.Controls.Add(this.txtNumeroRespuestas);
            this.panelCC.Controls.Add(this.txtNumeroEnviados);
            this.panelCC.Controls.Add(this.btnAceptar);
            this.panelCC.Controls.Add(this.txtFechaConvocatoria);
            this.panelCC.Controls.Add(this.btnAgregar);
            this.panelCC.Controls.Add(this.btnBeca);
            this.panelCC.Controls.Add(this.lbNombreConvocatoria);
            this.panelCC.Controls.Add(this.dgvDatos);
            this.panelCC.Controls.Add(this.btnEliminar);
            this.panelCC.Controls.Add(this.txtDescripcionConvocatoria);
            this.panelCC.Controls.Add(this.lbFechaConvocatoria);
            this.panelCC.Controls.Add(this.txtNombreConvocatoria);
            this.panelCC.Controls.Add(this.lbBeca);
            this.panelCC.Controls.Add(this.lbNumeroTotalEnviados);
            this.panelCC.Controls.Add(this.btnModificar);
            this.panelCC.Controls.Add(this.lbDescripciónConvocatoria);
            this.panelCC.Location = new System.Drawing.Point(46, 35);
            this.panelCC.Name = "panelCC";
            this.panelCC.Size = new System.Drawing.Size(990, 370);
            this.panelCC.TabIndex = 0;
            // 
            // CoordinadorComunicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CoordinadorComunicaciones";
            this.Text = "CoordinadorComunicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelCC.ResumeLayout(false);
            this.panelCC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBeca;
        private System.Windows.Forms.TextBox txtDescripcionConvocatoria;
        private System.Windows.Forms.Label lbBeca;
        private System.Windows.Forms.Label lbDescripciónConvocatoria;
        private System.Windows.Forms.TextBox txtNombreConvocatoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cbBeca;
        private System.Windows.Forms.TextBox txtNumeroEnviados;
        private System.Windows.Forms.TextBox txtNumeroRespuestas;
        private System.Windows.Forms.TextBox txtFechaConvocatoria;
        private System.Windows.Forms.Label lbNombreConvocatoria;
        private System.Windows.Forms.Label lbFechaConvocatoria;
        private System.Windows.Forms.Label lbNumeroTotalEnviados;
        private System.Windows.Forms.Label lbNumeroRespuestas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnFiltrarResultados;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NúmeroDeRespuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroTotalEnviados;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripciónConvocatoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton GC_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCC;
    }
}