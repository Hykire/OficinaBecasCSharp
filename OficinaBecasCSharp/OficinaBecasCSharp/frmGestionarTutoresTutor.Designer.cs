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
            this.panelTutor = new System.Windows.Forms.Panel();
            this.LGestTutBXT = new System.Windows.Forms.Label();
            this.DGVTutores = new System.Windows.Forms.DataGridView();
            this.C1Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C2Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C3Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profesion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C5Tutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarTutor = new System.Windows.Forms.Button();
            this.btnEditarTutor = new System.Windows.Forms.Button();
            this.btnNuevoTutor = new System.Windows.Forms.Button();
            this.panelTutor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTutores)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTutor
            // 
            this.panelTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelTutor.AutoSize = true;
            this.panelTutor.Controls.Add(this.LGestTutBXT);
            this.panelTutor.Controls.Add(this.DGVTutores);
            this.panelTutor.Controls.Add(this.label1);
            this.panelTutor.Controls.Add(this.btnEliminarTutor);
            this.panelTutor.Controls.Add(this.btnEditarTutor);
            this.panelTutor.Controls.Add(this.btnNuevoTutor);
            this.panelTutor.Location = new System.Drawing.Point(25, 59);
            this.panelTutor.Name = "panelTutor";
            this.panelTutor.Size = new System.Drawing.Size(787, 449);
            this.panelTutor.TabIndex = 4;
            // 
            // LGestTutBXT
            // 
            this.LGestTutBXT.AutoSize = true;
            this.LGestTutBXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestTutBXT.Location = new System.Drawing.Point(9, 13);
            this.LGestTutBXT.Name = "LGestTutBXT";
            this.LGestTutBXT.Size = new System.Drawing.Size(154, 20);
            this.LGestTutBXT.TabIndex = 5;
            this.LGestTutBXT.Text = "Gestionar Tutores";
            // 
            // DGVTutores
            // 
            this.DGVTutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1Tutor,
            this.DNI,
            this.Correo,
            this.C2Tutor,
            this.C3Tutor,
            this.Profesion,
            this.Telefono,
            this.C4Tutor,
            this.C5Tutor});
            this.DGVTutores.Location = new System.Drawing.Point(27, 133);
            this.DGVTutores.Name = "DGVTutores";
            this.DGVTutores.Size = new System.Drawing.Size(737, 186);
            this.DGVTutores.TabIndex = 4;
            // 
            // C1Tutor
            // 
            this.C1Tutor.HeaderText = "Codigo";
            this.C1Tutor.Name = "C1Tutor";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            // 
            // C2Tutor
            // 
            this.C2Tutor.HeaderText = "Nombre";
            this.C2Tutor.Name = "C2Tutor";
            // 
            // C3Tutor
            // 
            this.C3Tutor.HeaderText = "Apellidos";
            this.C3Tutor.Name = "C3Tutor";
            // 
            // Profesion
            // 
            this.Profesion.HeaderText = "Profesion";
            this.Profesion.Name = "Profesion";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // C4Tutor
            // 
            this.C4Tutor.HeaderText = "Fecha Inicio";
            this.C4Tutor.Name = "C4Tutor";
            // 
            // C5Tutor
            // 
            this.C5Tutor.HeaderText = "N° Becarios";
            this.C5Tutor.Name = "C5Tutor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(611, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Si se desea Editar, solo \r\ndebe seleccionar UN Tutor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminarTutor
            // 
            this.btnEliminarTutor.Location = new System.Drawing.Point(221, 75);
            this.btnEliminarTutor.Name = "btnEliminarTutor";
            this.btnEliminarTutor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarTutor.TabIndex = 2;
            this.btnEliminarTutor.Text = "Eliminar";
            this.btnEliminarTutor.UseVisualStyleBackColor = true;
            this.btnEliminarTutor.Click += new System.EventHandler(this.btnEliminarTutor_Click);
            // 
            // btnEditarTutor
            // 
            this.btnEditarTutor.Location = new System.Drawing.Point(117, 75);
            this.btnEditarTutor.Name = "btnEditarTutor";
            this.btnEditarTutor.Size = new System.Drawing.Size(98, 23);
            this.btnEditarTutor.TabIndex = 1;
            this.btnEditarTutor.Text = "Modificar Tutor";
            this.btnEditarTutor.UseVisualStyleBackColor = true;
            this.btnEditarTutor.Click += new System.EventHandler(this.btnEditarTutor_Click);
            // 
            // btnNuevoTutor
            // 
            this.btnNuevoTutor.Location = new System.Drawing.Point(36, 76);
            this.btnNuevoTutor.Name = "btnNuevoTutor";
            this.btnNuevoTutor.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoTutor.TabIndex = 0;
            this.btnNuevoTutor.Text = "Nuevo Tutor";
            this.btnNuevoTutor.UseVisualStyleBackColor = true;
            this.btnNuevoTutor.Click += new System.EventHandler(this.btnNuevoTutor_Click);
            // 
            // frmGestionarTutoresTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 568);
            this.Controls.Add(this.panelTutor);
            this.Name = "frmGestionarTutoresTutor";
            this.Text = "frmGestionarTutoresTutor";
            this.Load += new System.EventHandler(this.frmGestionarTutoresTutor_Load);
            this.panelTutor.ResumeLayout(false);
            this.panelTutor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTutor;
        private System.Windows.Forms.Label LGestTutBXT;
        private System.Windows.Forms.DataGridView DGVTutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C2Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C3Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profesion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4Tutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn C5Tutor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarTutor;
        private System.Windows.Forms.Button btnEditarTutor;
        private System.Windows.Forms.Button btnNuevoTutor;
    }
}