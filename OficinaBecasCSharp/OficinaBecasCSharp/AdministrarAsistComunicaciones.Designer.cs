namespace Vista
{
    partial class AdministrarAsistComunicaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrarAsistComunicaciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.GC_button = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.cbConsulta = new System.Windows.Forms.ComboBox();
            this.btnFiltrarResultados = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 554);
            this.panel1.TabIndex = 62;
            // 
            // GC_button
            // 
            this.GC_button.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.GC_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GC_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GC_button.BorderRadius = 0;
            this.GC_button.ButtonText = "            Gestionar                                Convocatoria";
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
            this.GC_button.Location = new System.Drawing.Point(-2, 250);
            this.GC_button.Margin = new System.Windows.Forms.Padding(5);
            this.GC_button.Name = "GC_button";
            this.GC_button.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.GC_button.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.GC_button.OnHoverTextColor = System.Drawing.Color.White;
            this.GC_button.selected = false;
            this.GC_button.Size = new System.Drawing.Size(267, 59);
            this.GC_button.TabIndex = 41;
            this.GC_button.Text = "            Gestionar                                Convocatoria";
            this.GC_button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GC_button.Textcolor = System.Drawing.Color.White;
            this.GC_button.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GC_button.Click += new System.EventHandler(this.GC_button_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Consultar:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(628, 320);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(575, 22);
            this.txtFiltro.TabIndex = 60;
            // 
            // cbConsulta
            // 
            this.cbConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbConsulta.FormattingEnabled = true;
            this.cbConsulta.Location = new System.Drawing.Point(47, 178);
            this.cbConsulta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbConsulta.Name = "cbConsulta";
            this.cbConsulta.Size = new System.Drawing.Size(156, 32);
            this.cbConsulta.TabIndex = 39;
            // 
            // btnFiltrarResultados
            // 
            this.btnFiltrarResultados.Location = new System.Drawing.Point(1236, 314);
            this.btnFiltrarResultados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrarResultados.Name = "btnFiltrarResultados";
            this.btnFiltrarResultados.Size = new System.Drawing.Size(139, 33);
            this.btnFiltrarResultados.TabIndex = 42;
            this.btnFiltrarResultados.Text = "Filtrar Resultados";
            this.btnFiltrarResultados.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(264, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(805, 554);
            this.panel2.TabIndex = 63;
            // 
            // AdministrarAsistComunicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdministrarAsistComunicaciones";
            this.Text = "AdministrarAsistComunicaciones";
            this.Load += new System.EventHandler(this.AdministrarAsistComunicaciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton GC_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.ComboBox cbConsulta;
        private System.Windows.Forms.Button btnFiltrarResultados;
        private System.Windows.Forms.Panel panel2;
    }
}