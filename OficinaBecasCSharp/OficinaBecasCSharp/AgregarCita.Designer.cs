namespace Vista
{
    partial class AgregarCita
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
            this.btnCancelarAGGC = new System.Windows.Forms.Button();
            this.btnAceptarACGC = new System.Windows.Forms.Button();
            this.GBObservAgregarCitaGC = new System.Windows.Forms.GroupBox();
            this.txtBAgrearCitaGC = new System.Windows.Forms.TextBox();
            this.GBDetalleCitaGC = new System.Windows.Forms.GroupBox();
            this.btnBuscarBecarioACGC = new System.Windows.Forms.Button();
            this.CBTutorACGC = new System.Windows.Forms.ComboBox();
            this.txtBLugarGC = new System.Windows.Forms.TextBox();
            this.txtCodBecarioACGC = new System.Windows.Forms.TextBox();
            this.txtBHoraGC = new System.Windows.Forms.TextBox();
            this.txtBFechaGC = new System.Windows.Forms.TextBox();
            this.LHoraGC = new System.Windows.Forms.Label();
            this.LLugarGC = new System.Windows.Forms.Label();
            this.LBecarioGC = new System.Windows.Forms.Label();
            this.LTuutorGC = new System.Windows.Forms.Label();
            this.LFechaGC = new System.Windows.Forms.Label();
            this.LSelFechaGC = new System.Windows.Forms.Label();
            this.DTPSelDiaGC = new System.Windows.Forms.DateTimePicker();
            this.GBObservAgregarCitaGC.SuspendLayout();
            this.GBDetalleCitaGC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelarAGGC
            // 
            this.btnCancelarAGGC.Location = new System.Drawing.Point(454, 265);
            this.btnCancelarAGGC.Name = "btnCancelarAGGC";
            this.btnCancelarAGGC.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAGGC.TabIndex = 13;
            this.btnCancelarAGGC.Text = "Cancelar";
            this.btnCancelarAGGC.UseVisualStyleBackColor = true;
            this.btnCancelarAGGC.Click += new System.EventHandler(this.btnCancelarAGGC_Click);
            // 
            // btnAceptarACGC
            // 
            this.btnAceptarACGC.Location = new System.Drawing.Point(362, 265);
            this.btnAceptarACGC.Name = "btnAceptarACGC";
            this.btnAceptarACGC.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarACGC.TabIndex = 12;
            this.btnAceptarACGC.Text = "Aceptar";
            this.btnAceptarACGC.UseVisualStyleBackColor = true;
            this.btnAceptarACGC.Click += new System.EventHandler(this.btnAceptarACGC_Click);
            // 
            // GBObservAgregarCitaGC
            // 
            this.GBObservAgregarCitaGC.Controls.Add(this.txtBAgrearCitaGC);
            this.GBObservAgregarCitaGC.Location = new System.Drawing.Point(328, 73);
            this.GBObservAgregarCitaGC.Name = "GBObservAgregarCitaGC";
            this.GBObservAgregarCitaGC.Size = new System.Drawing.Size(200, 162);
            this.GBObservAgregarCitaGC.TabIndex = 11;
            this.GBObservAgregarCitaGC.TabStop = false;
            this.GBObservAgregarCitaGC.Text = "Observaciones";
            // 
            // txtBAgrearCitaGC
            // 
            this.txtBAgrearCitaGC.Location = new System.Drawing.Point(6, 28);
            this.txtBAgrearCitaGC.Multiline = true;
            this.txtBAgrearCitaGC.Name = "txtBAgrearCitaGC";
            this.txtBAgrearCitaGC.Size = new System.Drawing.Size(188, 122);
            this.txtBAgrearCitaGC.TabIndex = 13;
            // 
            // GBDetalleCitaGC
            // 
            this.GBDetalleCitaGC.Controls.Add(this.btnBuscarBecarioACGC);
            this.GBDetalleCitaGC.Controls.Add(this.CBTutorACGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBLugarGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtCodBecarioACGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBHoraGC);
            this.GBDetalleCitaGC.Controls.Add(this.txtBFechaGC);
            this.GBDetalleCitaGC.Controls.Add(this.LHoraGC);
            this.GBDetalleCitaGC.Controls.Add(this.LLugarGC);
            this.GBDetalleCitaGC.Controls.Add(this.LBecarioGC);
            this.GBDetalleCitaGC.Controls.Add(this.LTuutorGC);
            this.GBDetalleCitaGC.Controls.Add(this.LFechaGC);
            this.GBDetalleCitaGC.Location = new System.Drawing.Point(17, 62);
            this.GBDetalleCitaGC.Name = "GBDetalleCitaGC";
            this.GBDetalleCitaGC.Size = new System.Drawing.Size(285, 187);
            this.GBDetalleCitaGC.TabIndex = 10;
            this.GBDetalleCitaGC.TabStop = false;
            this.GBDetalleCitaGC.Text = "Detalle de Cita";
            // 
            // btnBuscarBecarioACGC
            // 
            this.btnBuscarBecarioACGC.Location = new System.Drawing.Point(184, 110);
            this.btnBuscarBecarioACGC.Name = "btnBuscarBecarioACGC";
            this.btnBuscarBecarioACGC.Size = new System.Drawing.Size(95, 23);
            this.btnBuscarBecarioACGC.TabIndex = 13;
            this.btnBuscarBecarioACGC.Text = "Buscar Becario";
            this.btnBuscarBecarioACGC.UseVisualStyleBackColor = true;
            this.btnBuscarBecarioACGC.Click += new System.EventHandler(this.btnBuscarBecarioACGC_Click);
            // 
            // CBTutorACGC
            // 
            this.CBTutorACGC.FormattingEnabled = true;
            this.CBTutorACGC.Items.AddRange(new object[] {
            "Tutor 1",
            "Tutor 2",
            "Tutor 2",
            "Tutor 4"});
            this.CBTutorACGC.Location = new System.Drawing.Point(82, 80);
            this.CBTutorACGC.Name = "CBTutorACGC";
            this.CBTutorACGC.Size = new System.Drawing.Size(177, 21);
            this.CBTutorACGC.TabIndex = 12;
            // 
            // txtBLugarGC
            // 
            this.txtBLugarGC.Location = new System.Drawing.Point(82, 141);
            this.txtBLugarGC.Name = "txtBLugarGC";
            this.txtBLugarGC.Size = new System.Drawing.Size(177, 20);
            this.txtBLugarGC.TabIndex = 11;
            // 
            // txtCodBecarioACGC
            // 
            this.txtCodBecarioACGC.Location = new System.Drawing.Point(82, 113);
            this.txtCodBecarioACGC.Name = "txtCodBecarioACGC";
            this.txtCodBecarioACGC.Size = new System.Drawing.Size(83, 20);
            this.txtCodBecarioACGC.TabIndex = 10;
            // 
            // txtBHoraGC
            // 
            this.txtBHoraGC.Location = new System.Drawing.Point(82, 54);
            this.txtBHoraGC.Name = "txtBHoraGC";
            this.txtBHoraGC.Size = new System.Drawing.Size(100, 20);
            this.txtBHoraGC.TabIndex = 8;
            // 
            // txtBFechaGC
            // 
            this.txtBFechaGC.Location = new System.Drawing.Point(82, 25);
            this.txtBFechaGC.Name = "txtBFechaGC";
            this.txtBFechaGC.Size = new System.Drawing.Size(154, 20);
            this.txtBFechaGC.TabIndex = 7;
            // 
            // LHoraGC
            // 
            this.LHoraGC.AutoSize = true;
            this.LHoraGC.Location = new System.Drawing.Point(38, 61);
            this.LHoraGC.Name = "LHoraGC";
            this.LHoraGC.Size = new System.Drawing.Size(33, 13);
            this.LHoraGC.TabIndex = 6;
            this.LHoraGC.Text = "Hora:";
            // 
            // LLugarGC
            // 
            this.LLugarGC.AutoSize = true;
            this.LLugarGC.Location = new System.Drawing.Point(35, 149);
            this.LLugarGC.Name = "LLugarGC";
            this.LLugarGC.Size = new System.Drawing.Size(37, 13);
            this.LLugarGC.TabIndex = 5;
            this.LLugarGC.Text = "Lugar:";
            // 
            // LBecarioGC
            // 
            this.LBecarioGC.AutoSize = true;
            this.LBecarioGC.Location = new System.Drawing.Point(35, 121);
            this.LBecarioGC.Name = "LBecarioGC";
            this.LBecarioGC.Size = new System.Drawing.Size(46, 13);
            this.LBecarioGC.TabIndex = 4;
            this.LBecarioGC.Text = "Becario:";
            // 
            // LTuutorGC
            // 
            this.LTuutorGC.AutoSize = true;
            this.LTuutorGC.Location = new System.Drawing.Point(35, 89);
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
            this.LSelFechaGC.Location = new System.Drawing.Point(44, 24);
            this.LSelFechaGC.Name = "LSelFechaGC";
            this.LSelFechaGC.Size = new System.Drawing.Size(100, 13);
            this.LSelFechaGC.TabIndex = 9;
            this.LSelFechaGC.Text = "Seleccionar un día:";
            // 
            // DTPSelDiaGC
            // 
            this.DTPSelDiaGC.Location = new System.Drawing.Point(161, 18);
            this.DTPSelDiaGC.Name = "DTPSelDiaGC";
            this.DTPSelDiaGC.Size = new System.Drawing.Size(200, 20);
            this.DTPSelDiaGC.TabIndex = 8;
            // 
            // AgregarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 301);
            this.Controls.Add(this.btnCancelarAGGC);
            this.Controls.Add(this.btnAceptarACGC);
            this.Controls.Add(this.GBObservAgregarCitaGC);
            this.Controls.Add(this.GBDetalleCitaGC);
            this.Controls.Add(this.LSelFechaGC);
            this.Controls.Add(this.DTPSelDiaGC);
            this.Name = "AgregarCita";
            this.Text = "AgregarCita";
            this.GBObservAgregarCitaGC.ResumeLayout(false);
            this.GBObservAgregarCitaGC.PerformLayout();
            this.GBDetalleCitaGC.ResumeLayout(false);
            this.GBDetalleCitaGC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarAGGC;
        private System.Windows.Forms.Button btnAceptarACGC;
        private System.Windows.Forms.GroupBox GBObservAgregarCitaGC;
        private System.Windows.Forms.TextBox txtBAgrearCitaGC;
        private System.Windows.Forms.GroupBox GBDetalleCitaGC;
        private System.Windows.Forms.Button btnBuscarBecarioACGC;
        private System.Windows.Forms.ComboBox CBTutorACGC;
        private System.Windows.Forms.TextBox txtBLugarGC;
        private System.Windows.Forms.TextBox txtCodBecarioACGC;
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