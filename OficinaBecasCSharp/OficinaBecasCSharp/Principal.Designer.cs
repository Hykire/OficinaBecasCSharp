﻿namespace Vista {
    partial class Principal {
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
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAC = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonTutor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.buttonCT = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonAdmin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.btnCambiarContra = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.btnCambiarContra);
            this.panel1.Controls.Add(this.lblNombreUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonAC);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonTutor);
            this.panel1.Controls.Add(this.buttonCT);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.buttonAdmin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1409, 100);
            this.panel1.TabIndex = 8;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.lblNombreUsuario.Location = new System.Drawing.Point(1198, 29);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombreUsuario.Size = new System.Drawing.Size(94, 20);
            this.lblNombreUsuario.TabIndex = 16;
            this.lblNombreUsuario.Text = "Freddy Paz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(1256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Bienvenido";
            // 
            // buttonAC
            // 
            this.buttonAC.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonAC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAC.BorderRadius = 0;
            this.buttonAC.ButtonText = "Asistente de Comunicaciones";
            this.buttonAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAC.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAC.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAC.Iconimage = null;
            this.buttonAC.Iconimage_right = null;
            this.buttonAC.Iconimage_right_Selected = null;
            this.buttonAC.Iconimage_Selected = null;
            this.buttonAC.IconMarginLeft = 0;
            this.buttonAC.IconMarginRight = 0;
            this.buttonAC.IconRightVisible = false;
            this.buttonAC.IconRightZoom = 0D;
            this.buttonAC.IconVisible = false;
            this.buttonAC.IconZoom = 90D;
            this.buttonAC.IsTab = false;
            this.buttonAC.Location = new System.Drawing.Point(903, 0);
            this.buttonAC.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAC.Name = "buttonAC";
            this.buttonAC.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.buttonAC.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonAC.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAC.selected = false;
            this.buttonAC.Size = new System.Drawing.Size(213, 65);
            this.buttonAC.TabIndex = 14;
            this.buttonAC.Text = "Asistente de Comunicaciones";
            this.buttonAC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAC.Textcolor = System.Drawing.Color.White;
            this.buttonAC.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonAC.Click += new System.EventHandler(this.bunifuFlatButton4_Click);
            // 
            // buttonTutor
            // 
            this.buttonTutor.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(148)))), ((int)(((byte)(17)))));
            this.buttonTutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(148)))), ((int)(((byte)(17)))));
            this.buttonTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonTutor.BorderRadius = 0;
            this.buttonTutor.ButtonText = "Tutor";
            this.buttonTutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTutor.DisabledColor = System.Drawing.Color.Gray;
            this.buttonTutor.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonTutor.Iconimage = null;
            this.buttonTutor.Iconimage_right = null;
            this.buttonTutor.Iconimage_right_Selected = null;
            this.buttonTutor.Iconimage_Selected = null;
            this.buttonTutor.IconMarginLeft = 0;
            this.buttonTutor.IconMarginRight = 0;
            this.buttonTutor.IconRightVisible = false;
            this.buttonTutor.IconRightZoom = 0D;
            this.buttonTutor.IconVisible = false;
            this.buttonTutor.IconZoom = 90D;
            this.buttonTutor.IsTab = false;
            this.buttonTutor.Location = new System.Drawing.Point(691, 0);
            this.buttonTutor.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTutor.Name = "buttonTutor";
            this.buttonTutor.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(148)))), ((int)(((byte)(17)))));
            this.buttonTutor.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonTutor.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonTutor.selected = false;
            this.buttonTutor.Size = new System.Drawing.Size(213, 65);
            this.buttonTutor.TabIndex = 13;
            this.buttonTutor.Text = "Tutor";
            this.buttonTutor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonTutor.Textcolor = System.Drawing.Color.White;
            this.buttonTutor.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonTutor.Click += new System.EventHandler(this.buttonTutor_Click);
            // 
            // buttonCT
            // 
            this.buttonCT.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.buttonCT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.buttonCT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCT.BorderRadius = 0;
            this.buttonCT.ButtonText = "Coordinador de Tutor";
            this.buttonCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCT.DisabledColor = System.Drawing.Color.Gray;
            this.buttonCT.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonCT.Iconimage = null;
            this.buttonCT.Iconimage_right = null;
            this.buttonCT.Iconimage_right_Selected = null;
            this.buttonCT.Iconimage_Selected = null;
            this.buttonCT.IconMarginLeft = 0;
            this.buttonCT.IconMarginRight = 0;
            this.buttonCT.IconRightVisible = false;
            this.buttonCT.IconRightZoom = 0D;
            this.buttonCT.IconVisible = false;
            this.buttonCT.IconZoom = 90D;
            this.buttonCT.IsTab = false;
            this.buttonCT.Location = new System.Drawing.Point(479, 0);
            this.buttonCT.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCT.Name = "buttonCT";
            this.buttonCT.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.buttonCT.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonCT.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonCT.selected = false;
            this.buttonCT.Size = new System.Drawing.Size(213, 65);
            this.buttonCT.TabIndex = 12;
            this.buttonCT.Text = "Coordinador de Tutor";
            this.buttonCT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonCT.Textcolor = System.Drawing.Color.White;
            this.buttonCT.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonCT.Click += new System.EventHandler(this.buttonCT_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panel4.Location = new System.Drawing.Point(360, 262);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(727, 405);
            this.panel4.TabIndex = 10;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdmin.BorderRadius = 0;
            this.buttonAdmin.ButtonText = "Administrador";
            this.buttonAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdmin.DisabledColor = System.Drawing.Color.Gray;
            this.buttonAdmin.Iconcolor = System.Drawing.Color.Transparent;
            this.buttonAdmin.Iconimage = null;
            this.buttonAdmin.Iconimage_right = null;
            this.buttonAdmin.Iconimage_right_Selected = null;
            this.buttonAdmin.Iconimage_Selected = null;
            this.buttonAdmin.IconMarginLeft = 0;
            this.buttonAdmin.IconMarginRight = 0;
            this.buttonAdmin.IconRightVisible = false;
            this.buttonAdmin.IconRightZoom = 0D;
            this.buttonAdmin.IconVisible = false;
            this.buttonAdmin.IconZoom = 90D;
            this.buttonAdmin.IsTab = false;
            this.buttonAdmin.Location = new System.Drawing.Point(267, 0);
            this.buttonAdmin.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonAdmin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.buttonAdmin.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAdmin.selected = false;
            this.buttonAdmin.Size = new System.Drawing.Size(213, 65);
            this.buttonAdmin.TabIndex = 11;
            this.buttonAdmin.Text = "Administrador";
            this.buttonAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonAdmin.Textcolor = System.Drawing.Color.White;
            this.buttonAdmin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel_Principal
            // 
            this.panel_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 100);
            this.panel_Principal.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Size = new System.Drawing.Size(1409, 867);
            this.panel_Principal.TabIndex = 12;
            // 
            // btnCambiarContra
            // 
            this.btnCambiarContra.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCambiarContra.Location = new System.Drawing.Point(1216, 62);
            this.btnCambiarContra.Name = "btnCambiarContra";
            this.btnCambiarContra.Size = new System.Drawing.Size(164, 31);
            this.btnCambiarContra.TabIndex = 17;
            this.btnCambiarContra.Text = "Cambiar contraseña";
            this.btnCambiarContra.UseVisualStyleBackColor = true;
            this.btnCambiarContra.Click += new System.EventHandler(this.btnCambiarContra_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Vista.Properties.Resources.logoOficinaBecas3;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 967);
            this.Controls.Add(this.panel_Principal);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Becas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAdmin;
        private Bunifu.Framework.UI.BunifuFlatButton buttonAC;
        private Bunifu.Framework.UI.BunifuFlatButton buttonTutor;
        private Bunifu.Framework.UI.BunifuFlatButton buttonCT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarContra;
    }
}