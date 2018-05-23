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
            this.PGestCitas = new System.Windows.Forms.Panel();
            this.GBObservGC = new System.Windows.Forms.GroupBox();
            this.txtBObsGC = new System.Windows.Forms.TextBox();
            this.BEliminarCitaGC = new System.Windows.Forms.Button();
            this.BEditarCitaGC = new System.Windows.Forms.Button();
            this.BAgregarCitaGC = new System.Windows.Forms.Button();
            this.BBuscarCitaGC = new System.Windows.Forms.Button();
            this.LTituloGC = new System.Windows.Forms.Label();
            this.GBDetalleCitaGC = new System.Windows.Forms.GroupBox();
            this.txtCodBecGC = new System.Windows.Forms.TextBox();
            this.txtCodTutorGC = new System.Windows.Forms.TextBox();
            this.LCódigoBecarioGC = new System.Windows.Forms.Label();
            this.txtBLugarGC = new System.Windows.Forms.TextBox();
            this.LCodTutorGC = new System.Windows.Forms.Label();
            this.txtBBecarioGC = new System.Windows.Forms.TextBox();
            this.txtBTutorGC = new System.Windows.Forms.TextBox();
            this.txtBHoraGC = new System.Windows.Forms.TextBox();
            this.txtBFechaGC = new System.Windows.Forms.TextBox();
            this.LHoraGC = new System.Windows.Forms.Label();
            this.LLugarGC = new System.Windows.Forms.Label();
            this.LBecarioGC = new System.Windows.Forms.Label();
            this.LTuutorGC = new System.Windows.Forms.Label();
            this.LFechaGC = new System.Windows.Forms.Label();
            this.LSelFechaGC = new System.Windows.Forms.Label();
            this.DTPSelDiaGC = new System.Windows.Forms.DateTimePicker();
            this.PGestCitas.SuspendLayout();
            this.GBObservGC.SuspendLayout();
            this.GBDetalleCitaGC.SuspendLayout();
            this.SuspendLayout();
            // 
            // PGestCitas
            // 
            this.PGestCitas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PGestCitas.AutoSize = true;
            this.PGestCitas.Controls.Add(this.GBObservGC);
            this.PGestCitas.Controls.Add(this.BEliminarCitaGC);
            this.PGestCitas.Controls.Add(this.BEditarCitaGC);
            this.PGestCitas.Controls.Add(this.BAgregarCitaGC);
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
            // GBObservGC
            // 
            this.GBObservGC.Controls.Add(this.txtBObsGC);
            this.GBObservGC.Location = new System.Drawing.Point(442, 127);
            this.GBObservGC.Name = "GBObservGC";
            this.GBObservGC.Size = new System.Drawing.Size(283, 196);
            this.GBObservGC.TabIndex = 8;
            this.GBObservGC.TabStop = false;
            this.GBObservGC.Text = "Observaciones";
            // 
            // txtBObsGC
            // 
            this.txtBObsGC.Location = new System.Drawing.Point(6, 28);
            this.txtBObsGC.Multiline = true;
            this.txtBObsGC.Name = "txtBObsGC";
            this.txtBObsGC.Size = new System.Drawing.Size(271, 146);
            this.txtBObsGC.TabIndex = 13;
            // 
            // BEliminarCitaGC
            // 
            this.BEliminarCitaGC.Location = new System.Drawing.Point(653, 72);
            this.BEliminarCitaGC.Name = "BEliminarCitaGC";
            this.BEliminarCitaGC.Size = new System.Drawing.Size(75, 23);
            this.BEliminarCitaGC.TabIndex = 7;
            this.BEliminarCitaGC.Text = "Eliminar Cita";
            this.BEliminarCitaGC.UseVisualStyleBackColor = true;
            this.BEliminarCitaGC.Click += new System.EventHandler(this.BEliminarCitaGC_Click_1);
            // 
            // BEditarCitaGC
            // 
            this.BEditarCitaGC.Location = new System.Drawing.Point(572, 73);
            this.BEditarCitaGC.Name = "BEditarCitaGC";
            this.BEditarCitaGC.Size = new System.Drawing.Size(75, 23);
            this.BEditarCitaGC.TabIndex = 6;
            this.BEditarCitaGC.Text = "Editar Cita";
            this.BEditarCitaGC.UseVisualStyleBackColor = true;
            this.BEditarCitaGC.Click += new System.EventHandler(this.BEditarCitaGC_Click_1);
            // 
            // BAgregarCitaGC
            // 
            this.BAgregarCitaGC.Location = new System.Drawing.Point(491, 73);
            this.BAgregarCitaGC.Name = "BAgregarCitaGC";
            this.BAgregarCitaGC.Size = new System.Drawing.Size(75, 23);
            this.BAgregarCitaGC.TabIndex = 5;
            this.BAgregarCitaGC.Text = "Agregar Cita";
            this.BAgregarCitaGC.UseVisualStyleBackColor = true;
            this.BAgregarCitaGC.Click += new System.EventHandler(this.BAgregarCitaGC_Click_1);
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
            this.LTituloGC.Location = new System.Drawing.Point(19, 20);
            this.LTituloGC.Name = "LTituloGC";
            this.LTituloGC.Size = new System.Drawing.Size(134, 20);
            this.LTituloGC.TabIndex = 2;
            this.LTituloGC.Text = "Gestionar Citas";
            // 
            // GBDetalleCitaGC
            // 
            this.GBDetalleCitaGC.Controls.Add(this.txtCodBecGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtCodTutorGC);
            this.GBDetalleCitaGC.Controls.Add(this.LCódigoBecarioGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBLugarGC);
            this.GBDetalleCitaGC.Controls.Add(this.LCodTutorGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBBecarioGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBTutorGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBHoraGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBFechaGC);
            this.GBDetalleCitaGC.Controls.Add(this.LHoraGC);
            this.GBDetalleCitaGC.Controls.Add(this.LLugarGC);
            this.GBDetalleCitaGC.Controls.Add(this.LBecarioGC);
            this.GBDetalleCitaGC.Controls.Add(this.LTuutorGC);
            this.GBDetalleCitaGC.Controls.Add(this.LFechaGC);
            this.GBDetalleCitaGC.Location = new System.Drawing.Point(23, 111);
            this.GBDetalleCitaGC.Name = "GBDetalleCitaGC";
            this.GBDetalleCitaGC.Size = new System.Drawing.Size(321, 267);
            this.GBDetalleCitaGC.TabIndex = 3;
            this.GBDetalleCitaGC.TabStop = false;
            this.GBDetalleCitaGC.Text = "Detalle de Cita";
            // 
            // txtCodBecGC
            // 
            this.txtCodBecGC.Location = new System.Drawing.Point(159, 137);
            this.txtCodBecGC.Name = "txtCodBecGC";
            this.txtCodBecGC.Size = new System.Drawing.Size(100, 20);
            this.txtCodBecGC.TabIndex = 17;
            // 
            // txtCodTutorGC
            // 
            this.txtCodTutorGC.Location = new System.Drawing.Point(159, 83);
            this.txtCodTutorGC.Name = "txtCodTutorGC";
            this.txtCodTutorGC.Size = new System.Drawing.Size(100, 20);
            this.txtCodTutorGC.TabIndex = 16;
            // 
            // LCódigoBecarioGC
            // 
            this.LCódigoBecarioGC.AutoSize = true;
            this.LCódigoBecarioGC.Location = new System.Drawing.Point(35, 140);
            this.LCódigoBecarioGC.Name = "LCódigoBecarioGC";
            this.LCódigoBecarioGC.Size = new System.Drawing.Size(82, 13);
            this.LCódigoBecarioGC.TabIndex = 16;
            this.LCódigoBecarioGC.Text = "Código Becario:";
            // 
            // txtBLugarGC
            // 
            this.txtBLugarGC.Location = new System.Drawing.Point(82, 192);
            this.txtBLugarGC.Name = "txtBLugarGC";
            this.txtBLugarGC.Size = new System.Drawing.Size(177, 20);
            this.txtBLugarGC.TabIndex = 11;
            // 
            // LCodTutorGC
            // 
            this.LCodTutorGC.AutoSize = true;
            this.LCodTutorGC.Location = new System.Drawing.Point(35, 86);
            this.LCodTutorGC.Name = "LCodTutorGC";
            this.LCodTutorGC.Size = new System.Drawing.Size(67, 13);
            this.LCodTutorGC.TabIndex = 15;
            this.LCodTutorGC.Text = "Código tutor:";
            // 
            // txtBBecarioGC
            // 
            this.txtBBecarioGC.Location = new System.Drawing.Point(82, 164);
            this.txtBBecarioGC.Name = "txtBBecarioGC";
            this.txtBBecarioGC.Size = new System.Drawing.Size(177, 20);
            this.txtBBecarioGC.TabIndex = 10;
            // 
            // txtBTutorGC
            // 
            this.txtBTutorGC.Location = new System.Drawing.Point(82, 109);
            this.txtBTutorGC.Name = "txtBTutorGC";
            this.txtBTutorGC.Size = new System.Drawing.Size(177, 20);
            this.txtBTutorGC.TabIndex = 9;
            // 
            // txtBHoraGC
            // 
            this.txtBHoraGC.Location = new System.Drawing.Point(159, 56);
            this.txtBHoraGC.Name = "txtBHoraGC";
            this.txtBHoraGC.Size = new System.Drawing.Size(100, 20);
            this.txtBHoraGC.TabIndex = 8;
            // 
            // txtBFechaGC
            // 
            this.txtBFechaGC.Location = new System.Drawing.Point(105, 28);
            this.txtBFechaGC.Name = "txtBFechaGC";
            this.txtBFechaGC.Size = new System.Drawing.Size(154, 20);
            this.txtBFechaGC.TabIndex = 7;
            // 
            // LHoraGC
            // 
            this.LHoraGC.AutoSize = true;
            this.LHoraGC.Location = new System.Drawing.Point(35, 61);
            this.LHoraGC.Name = "LHoraGC";
            this.LHoraGC.Size = new System.Drawing.Size(33, 13);
            this.LHoraGC.TabIndex = 6;
            this.LHoraGC.Text = "Hora:";
            // 
            // LLugarGC
            // 
            this.LLugarGC.AutoSize = true;
            this.LLugarGC.Location = new System.Drawing.Point(35, 200);
            this.LLugarGC.Name = "LLugarGC";
            this.LLugarGC.Size = new System.Drawing.Size(37, 13);
            this.LLugarGC.TabIndex = 5;
            this.LLugarGC.Text = "Lugar:";
            // 
            // LBecarioGC
            // 
            this.LBecarioGC.AutoSize = true;
            this.LBecarioGC.Location = new System.Drawing.Point(35, 172);
            this.LBecarioGC.Name = "LBecarioGC";
            this.LBecarioGC.Size = new System.Drawing.Size(46, 13);
            this.LBecarioGC.TabIndex = 4;
            this.LBecarioGC.Text = "Becario:";
            // 
            // LTuutorGC
            // 
            this.LTuutorGC.AutoSize = true;
            this.LTuutorGC.Location = new System.Drawing.Point(35, 116);
            this.LTuutorGC.Name = "LTuutorGC";
            this.LTuutorGC.Size = new System.Drawing.Size(35, 13);
            this.LTuutorGC.TabIndex = 3;
            this.LTuutorGC.Text = "Tutor:";
            // 
            // LFechaGC
            // 
            this.LFechaGC.AutoSize = true;
            this.LFechaGC.Location = new System.Drawing.Point(35, 33);
            this.LFechaGC.Name = "LFechaGC";
            this.LFechaGC.Size = new System.Drawing.Size(40, 13);
            this.LFechaGC.TabIndex = 2;
            this.LFechaGC.Text = "Fecha:";
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
            // frmGestionarCitasTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PGestCitas);
            this.Name = "frmGestionarCitasTutor";
            this.Text = "frmGestionarCitasTutor";
            this.Load += new System.EventHandler(this.frmGestionarCitasTutor_Load);
            this.PGestCitas.ResumeLayout(false);
            this.PGestCitas.PerformLayout();
            this.GBObservGC.ResumeLayout(false);
            this.GBObservGC.PerformLayout();
            this.GBDetalleCitaGC.ResumeLayout(false);
            this.GBDetalleCitaGC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PGestCitas;
        private System.Windows.Forms.GroupBox GBObservGC;
        private System.Windows.Forms.TextBox txtBObsGC;
        private System.Windows.Forms.Button BEliminarCitaGC;
        private System.Windows.Forms.Button BEditarCitaGC;
        private System.Windows.Forms.Button BAgregarCitaGC;
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
        private System.Windows.Forms.TextBox txtBHoraGC;
        private System.Windows.Forms.TextBox txtBFechaGC;
        private System.Windows.Forms.Label LHoraGC;
        private System.Windows.Forms.Label LLugarGC;
        private System.Windows.Forms.Label LBecarioGC;
        private System.Windows.Forms.Label LTuutorGC;
        private System.Windows.Forms.Label LFechaGC;
        private System.Windows.Forms.Label LSelFechaGC;
        private System.Windows.Forms.DateTimePicker DTPSelDiaGC;
    }
}