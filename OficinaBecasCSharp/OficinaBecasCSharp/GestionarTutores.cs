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
    public partial class GestionarTutores : Form
    {
        public GestionarTutores()
        {
            InitializeComponent();
            

            CBTutorGBXT.SelectedIndex = 0;
            TxtCodTutorBXT.Enabled = false;
            TxtNombTutorBXT.Enabled = false;
            btnBXTVer.Enabled = false;
            DGVBXT.AutoGenerateColumns = false;

            
        }

        private void btnEditarTutor_Click(object sender, EventArgs e)
        {
            EditarTutor frmET = new EditarTutor();
            frmET.ShowDialog();
        }

        private void btnBXTAnadir_Click(object sender, EventArgs e)
        {
            AgregarBecarioATutor frmABTXB = new AgregarBecarioATutor();
            frmABTXB.ShowDialog();
        }


        private void btnNuevoTutor_Click(object sender, EventArgs e)
        {
            NuevoTutor frmNT = new NuevoTutor();
            frmNT.ShowDialog();
        }

        private void GestionarTutores_Load(object sender, EventArgs e)
        {
            //ni bien aparezca este modal, se muestre la lista de tutores en el DGV
        }

        private void btnEliminarTutor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea eliminar de la lista el Tutor seleccionado?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

        }

        private void CBTutorGBXT_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBXTVer.Enabled = true;
        }

        private void TBCodTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnModificarTXB_Click(object sender, EventArgs e)
        {
            ModificarTXB frmTXB = new ModificarTXB();
            frmTXB.ShowDialog();
        }


        private void btnBuscarBeca_Click(object sender, EventArgs e)
        {
            BuscarBeca frmBuscarBecaT = new BuscarBeca();
            frmBuscarBecaT.Show();
        }

        private void btnBXTAnadir_Click_1(object sender, EventArgs e)
        {
            AgregarBecarioATutor frmABTXB = new AgregarBecarioATutor();
            frmABTXB.ShowDialog();
        }

        /*
        private void btnMNGesCitas_Click(object sender, EventArgs e)
        {
            PGestCitas.Visible = true;
            panelConsultarBecaT.Visible = false;
            panelBecariosXTutor.Visible = false;
            panelTutor.Visible = false;
        }
       
        

        private void GBT_button_Click(object sender, EventArgs e)
        {
            PGestCitas.Visible = false;
            panelConsultarBecaT.Visible = false;
            panelBecariosXTutor.Visible = true;
            panelTutor.Visible = false;
        }

        private void GT_button_Click(object sender, EventArgs e)
        {
            panelConsultarBecaT.Visible = false;
            panelBecariosXTutor.Visible = false;
            panelTutor.Visible = true;
            PGestCitas.Visible = false;
        }

        private void GC_button_Click(object sender, EventArgs e)
        {
            PGestCitas.Visible = true;
            panelConsultarBecaT.Visible = false;
            panelBecariosXTutor.Visible = false;
            panelTutor.Visible = false;
        }

        private void CB_button_Click(object sender, EventArgs e)
        {
            panelConsultarBecaT.Visible = true;
            panelBecariosXTutor.Visible = false;
            panelTutor.Visible = false;
            PGestCitas.Visible = false;
        }*/
    }
}
