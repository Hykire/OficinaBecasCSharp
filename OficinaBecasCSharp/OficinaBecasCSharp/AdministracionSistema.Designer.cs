namespace Vista {
    partial class AdministracionSistema {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelGestUsuarios = new System.Windows.Forms.Panel();
            this.panelGestBecarios = new System.Windows.Forms.Panel();
            this.btnElimBec = new System.Windows.Forms.Button();
            this.btnModifBec = new System.Windows.Forms.Button();
            this.btnNuevoBec = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnElimUsu = new System.Windows.Forms.Button();
            this.btnModifUsu = new System.Windows.Forms.Button();
            this.btnNuevoUsu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelGestUsuarios.SuspendLayout();
            this.panelGestBecarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 550);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(33, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Gestionar Becarios";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gestionar Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelGestUsuarios
            // 
            this.panelGestUsuarios.Controls.Add(this.panelGestBecarios);
            this.panelGestUsuarios.Controls.Add(this.btnElimUsu);
            this.panelGestUsuarios.Controls.Add(this.btnModifUsu);
            this.panelGestUsuarios.Controls.Add(this.btnNuevoUsu);
            this.panelGestUsuarios.Controls.Add(this.button3);
            this.panelGestUsuarios.Controls.Add(this.textBox1);
            this.panelGestUsuarios.Controls.Add(this.label1);
            this.panelGestUsuarios.Controls.Add(this.dataGridView1);
            this.panelGestUsuarios.Location = new System.Drawing.Point(255, 12);
            this.panelGestUsuarios.Name = "panelGestUsuarios";
            this.panelGestUsuarios.Size = new System.Drawing.Size(906, 550);
            this.panelGestUsuarios.TabIndex = 2;
            // 
            // panelGestBecarios
            // 
            this.panelGestBecarios.Controls.Add(this.btnElimBec);
            this.panelGestBecarios.Controls.Add(this.btnModifBec);
            this.panelGestBecarios.Controls.Add(this.btnNuevoBec);
            this.panelGestBecarios.Controls.Add(this.button9);
            this.panelGestBecarios.Controls.Add(this.textBox2);
            this.panelGestBecarios.Controls.Add(this.label2);
            this.panelGestBecarios.Controls.Add(this.dataGridView2);
            this.panelGestBecarios.Location = new System.Drawing.Point(0, 0);
            this.panelGestBecarios.Name = "panelGestBecarios";
            this.panelGestBecarios.Size = new System.Drawing.Size(906, 550);
            this.panelGestBecarios.TabIndex = 7;
            // 
            // btnElimBec
            // 
            this.btnElimBec.Location = new System.Drawing.Point(798, 45);
            this.btnElimBec.Name = "btnElimBec";
            this.btnElimBec.Size = new System.Drawing.Size(75, 23);
            this.btnElimBec.TabIndex = 12;
            this.btnElimBec.Text = "Eliminar";
            this.btnElimBec.UseVisualStyleBackColor = true;
            // 
            // btnModifBec
            // 
            this.btnModifBec.Location = new System.Drawing.Point(703, 46);
            this.btnModifBec.Name = "btnModifBec";
            this.btnModifBec.Size = new System.Drawing.Size(75, 23);
            this.btnModifBec.TabIndex = 11;
            this.btnModifBec.Text = "Modificar";
            this.btnModifBec.UseVisualStyleBackColor = true;
            this.btnModifBec.Click += new System.EventHandler(this.btnModifBec_Click);
            // 
            // btnNuevoBec
            // 
            this.btnNuevoBec.Location = new System.Drawing.Point(602, 46);
            this.btnNuevoBec.Name = "btnNuevoBec";
            this.btnNuevoBec.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoBec.TabIndex = 10;
            this.btnNuevoBec.Text = "Nuevo";
            this.btnNuevoBec.UseVisualStyleBackColor = true;
            this.btnNuevoBec.Click += new System.EventHandler(this.btnNuevoBec_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(393, 45);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Buscar";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(118, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(248, 22);
            this.textBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Busqueda";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(34, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(839, 405);
            this.dataGridView2.TabIndex = 6;
            // 
            // btnElimUsu
            // 
            this.btnElimUsu.Location = new System.Drawing.Point(800, 59);
            this.btnElimUsu.Name = "btnElimUsu";
            this.btnElimUsu.Size = new System.Drawing.Size(75, 23);
            this.btnElimUsu.TabIndex = 6;
            this.btnElimUsu.Text = "Eliminar";
            this.btnElimUsu.UseVisualStyleBackColor = true;
            // 
            // btnModifUsu
            // 
            this.btnModifUsu.Location = new System.Drawing.Point(705, 59);
            this.btnModifUsu.Name = "btnModifUsu";
            this.btnModifUsu.Size = new System.Drawing.Size(75, 23);
            this.btnModifUsu.TabIndex = 5;
            this.btnModifUsu.Text = "Modificar";
            this.btnModifUsu.UseVisualStyleBackColor = true;
            this.btnModifUsu.Click += new System.EventHandler(this.btnModifUsu_Click);
            // 
            // btnNuevoUsu
            // 
            this.btnNuevoUsu.Location = new System.Drawing.Point(604, 59);
            this.btnNuevoUsu.Name = "btnNuevoUsu";
            this.btnNuevoUsu.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoUsu.TabIndex = 4;
            this.btnNuevoUsu.Text = "Nuevo";
            this.btnNuevoUsu.UseVisualStyleBackColor = true;
            this.btnNuevoUsu.Click += new System.EventHandler(this.btnNuevoUsu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(395, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Buscar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(839, 405);
            this.dataGridView1.TabIndex = 0;
            // 
            // AdministracionSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 574);
            this.Controls.Add(this.panelGestUsuarios);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "AdministracionSistema";
            this.Text = "AdministracionSistema";
            this.panel1.ResumeLayout(false);
            this.panelGestUsuarios.ResumeLayout(false);
            this.panelGestUsuarios.PerformLayout();
            this.panelGestBecarios.ResumeLayout(false);
            this.panelGestBecarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelGestUsuarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnElimUsu;
        private System.Windows.Forms.Button btnModifUsu;
        private System.Windows.Forms.Button btnNuevoUsu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelGestBecarios;
        private System.Windows.Forms.Button btnElimBec;
        private System.Windows.Forms.Button btnModifBec;
        private System.Windows.Forms.Button btnNuevoBec;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}