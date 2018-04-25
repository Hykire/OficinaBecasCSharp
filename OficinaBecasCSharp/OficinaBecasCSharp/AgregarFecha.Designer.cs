namespace Vista
{
    partial class AgregarFecha
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
            this.btnCancelarBuscFechaGC = new System.Windows.Forms.Button();
            this.btnAceptarBuscFechaGC = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // btnCancelarBuscFechaGC
            // 
            this.btnCancelarBuscFechaGC.Location = new System.Drawing.Point(266, 222);
            this.btnCancelarBuscFechaGC.Name = "btnCancelarBuscFechaGC";
            this.btnCancelarBuscFechaGC.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarBuscFechaGC.TabIndex = 5;
            this.btnCancelarBuscFechaGC.Text = "Cancelar";
            this.btnCancelarBuscFechaGC.UseVisualStyleBackColor = true;
            this.btnCancelarBuscFechaGC.Click += new System.EventHandler(this.btnCancelarBuscFechaGC_Click);
            // 
            // btnAceptarBuscFechaGC
            // 
            this.btnAceptarBuscFechaGC.Location = new System.Drawing.Point(185, 222);
            this.btnAceptarBuscFechaGC.Name = "btnAceptarBuscFechaGC";
            this.btnAceptarBuscFechaGC.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarBuscFechaGC.TabIndex = 4;
            this.btnAceptarBuscFechaGC.Text = "Aceptar";
            this.btnAceptarBuscFechaGC.UseVisualStyleBackColor = true;
            this.btnAceptarBuscFechaGC.Click += new System.EventHandler(this.btnAceptarBuscFechaGC_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(52, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            // 
            // AgregarFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 258);
            this.Controls.Add(this.btnCancelarBuscFechaGC);
            this.Controls.Add(this.btnAceptarBuscFechaGC);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "AgregarFecha";
            this.Text = "AgregarFecha";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelarBuscFechaGC;
        private System.Windows.Forms.Button btnAceptarBuscFechaGC;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}