namespace Vista
{
    partial class FormTutor
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
            this.menuCT = new System.Windows.Forms.GroupBox();
            this.boton_buscarB = new System.Windows.Forms.Button();
            this.boton_agregarC = new System.Windows.Forms.Button();
            this.menuCT.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuCT
            // 
            this.menuCT.Controls.Add(this.boton_agregarC);
            this.menuCT.Controls.Add(this.boton_buscarB);
            this.menuCT.Location = new System.Drawing.Point(41, 35);
            this.menuCT.Name = "menuCT";
            this.menuCT.Size = new System.Drawing.Size(200, 139);
            this.menuCT.TabIndex = 0;
            this.menuCT.TabStop = false;
            this.menuCT.Text = "Menu";
            // 
            // boton_buscarB
            // 
            this.boton_buscarB.Location = new System.Drawing.Point(52, 86);
            this.boton_buscarB.Name = "boton_buscarB";
            this.boton_buscarB.Size = new System.Drawing.Size(92, 23);
            this.boton_buscarB.TabIndex = 4;
            this.boton_buscarB.Text = "Buscar Becario";
            this.boton_buscarB.UseVisualStyleBackColor = true;
            // 
            // boton_agregarC
            // 
            this.boton_agregarC.Location = new System.Drawing.Point(52, 43);
            this.boton_agregarC.Name = "boton_agregarC";
            this.boton_agregarC.Size = new System.Drawing.Size(92, 23);
            this.boton_agregarC.TabIndex = 5;
            this.boton_agregarC.Text = "Agregar Cita";
            this.boton_agregarC.UseVisualStyleBackColor = true;
            this.boton_agregarC.Click += new System.EventHandler(this.boton_agregarC_Click);
            // 
            // FormTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 213);
            this.Controls.Add(this.menuCT);
            this.Name = "FormTutor";
            this.Text = "formTutoria";
            this.menuCT.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox menuCT;
        private System.Windows.Forms.Button boton_buscarB;
        private System.Windows.Forms.Button boton_agregarC;
    }
}