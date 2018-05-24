namespace Vista
{
    partial class frmCambiarTutorABecario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApCambiar = new System.Windows.Forms.TextBox();
            this.txtNombCambiar = new System.Windows.Forms.TextBox();
            this.txtCodCambiar = new System.Windows.Forms.TextBox();
            this.LBXA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTutorCambiar = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdOcultoCambiar = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(209, 226);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(128, 226);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nombres:";
            // 
            // txtApCambiar
            // 
            this.txtApCambiar.Location = new System.Drawing.Point(66, 79);
            this.txtApCambiar.Name = "txtApCambiar";
            this.txtApCambiar.Size = new System.Drawing.Size(197, 20);
            this.txtApCambiar.TabIndex = 22;
            // 
            // txtNombCambiar
            // 
            this.txtNombCambiar.Location = new System.Drawing.Point(66, 53);
            this.txtNombCambiar.Name = "txtNombCambiar";
            this.txtNombCambiar.Size = new System.Drawing.Size(197, 20);
            this.txtNombCambiar.TabIndex = 21;
            // 
            // txtCodCambiar
            // 
            this.txtCodCambiar.Location = new System.Drawing.Point(66, 23);
            this.txtCodCambiar.Name = "txtCodCambiar";
            this.txtCodCambiar.Size = new System.Drawing.Size(124, 20);
            this.txtCodCambiar.TabIndex = 18;
            // 
            // LBXA
            // 
            this.LBXA.AutoSize = true;
            this.LBXA.Location = new System.Drawing.Point(6, 30);
            this.LBXA.Name = "LBXA";
            this.LBXA.Size = new System.Drawing.Size(43, 13);
            this.LBXA.TabIndex = 19;
            this.LBXA.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tutor:";
            // 
            // cbxTutorCambiar
            // 
            this.cbxTutorCambiar.FormattingEnabled = true;
            this.cbxTutorCambiar.Location = new System.Drawing.Point(70, 162);
            this.cbxTutorCambiar.Name = "cbxTutorCambiar";
            this.cbxTutorCambiar.Size = new System.Drawing.Size(205, 21);
            this.cbxTutorCambiar.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdOcultoCambiar);
            this.groupBox1.Controls.Add(this.LBXA);
            this.groupBox1.Controls.Add(this.txtCodCambiar);
            this.groupBox1.Controls.Add(this.txtNombCambiar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtApCambiar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 132);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // txtIdOcultoCambiar
            // 
            this.txtIdOcultoCambiar.Location = new System.Drawing.Point(196, 23);
            this.txtIdOcultoCambiar.Name = "txtIdOcultoCambiar";
            this.txtIdOcultoCambiar.Size = new System.Drawing.Size(66, 20);
            this.txtIdOcultoCambiar.TabIndex = 25;
            this.txtIdOcultoCambiar.Visible = false;
            // 
            // frmCambiarTutorABecario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbxTutorCambiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Name = "frmCambiarTutorABecario";
            this.Text = "Cambiar Tutor A Becario";
            this.Load += new System.EventHandler(this.frmCambiarTutorABecario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBXA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTutorCambiar;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtApCambiar;
        public System.Windows.Forms.TextBox txtNombCambiar;
        public System.Windows.Forms.TextBox txtCodCambiar;
        public System.Windows.Forms.TextBox txtIdOcultoCambiar;
    }
}