namespace Vista {
    partial class frmCambiarContrasena {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.txtContraNueva = new System.Windows.Forms.TextBox();
            this.txtContraNuevaConf = new System.Windows.Forms.TextBox();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cambiar contraseña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña actual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nueva contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar nueva contraseña";
            // 
            // txtContraActual
            // 
            this.txtContraActual.Location = new System.Drawing.Point(266, 127);
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.PasswordChar = '●';
            this.txtContraActual.Size = new System.Drawing.Size(315, 22);
            this.txtContraActual.TabIndex = 4;
            this.txtContraActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraActual_KeyPress);
            // 
            // txtContraNueva
            // 
            this.txtContraNueva.Location = new System.Drawing.Point(266, 203);
            this.txtContraNueva.Name = "txtContraNueva";
            this.txtContraNueva.PasswordChar = '●';
            this.txtContraNueva.Size = new System.Drawing.Size(315, 22);
            this.txtContraNueva.TabIndex = 5;
            this.txtContraNueva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraNueva_KeyPress);
            // 
            // txtContraNuevaConf
            // 
            this.txtContraNuevaConf.Location = new System.Drawing.Point(266, 284);
            this.txtContraNuevaConf.Name = "txtContraNuevaConf";
            this.txtContraNuevaConf.PasswordChar = '●';
            this.txtContraNuevaConf.Size = new System.Drawing.Size(315, 22);
            this.txtContraNuevaConf.TabIndex = 6;
            this.txtContraNuevaConf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContraNuevaConf_KeyPress);
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.Location = new System.Drawing.Point(196, 360);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(264, 29);
            this.btnCambiarContra.TabIndex = 7;
            this.btnCambiarContra.Text = "Cambiar contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = true;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(415, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Asegúrese de que su contraseña sea lo suficientemente segura.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(340, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ingrese una contraseña no mayor a 20 a caracteres.";
            // 
            // frmCambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 419);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCambiarContra);
            this.Controls.Add(this.txtContraNuevaConf);
            this.Controls.Add(this.txtContraNueva);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCambiarContrasena";
            this.Text = "Cambio de Contraseña";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.TextBox txtContraNueva;
        private System.Windows.Forms.TextBox txtContraNuevaConf;
        private System.Windows.Forms.Button btnCambiarContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}