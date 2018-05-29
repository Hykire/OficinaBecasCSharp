﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class AdministrarTareaTutor : Form
    {
        public AdministrarTareaTutor()
        {
            InitializeComponent();
        }

        private void CB_button_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            GestionarTutor form = Application.OpenForms.OfType<GestionarTutor>().FirstOrDefault();
            GestionarTutor ventana = form ?? new GestionarTutor();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmConsultarBecarioT form = Application.OpenForms.OfType<frmConsultarBecarioT>().FirstOrDefault();
            frmConsultarBecarioT ventana = form ?? new frmConsultarBecarioT();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            frmConsultarCorreos form = Application.OpenForms.OfType<frmConsultarCorreos>().FirstOrDefault();
            frmConsultarCorreos ventana = form ?? new frmConsultarCorreos();
            ventana.TopLevel = false;
            ventana.FormBorderStyle = FormBorderStyle.None;
            ventana.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(ventana);
            this.panel2.Tag = ventana;
            ventana.Show();
        }
    }
}
