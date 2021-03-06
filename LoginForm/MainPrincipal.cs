﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LoginForm
{
    public partial class MainPrincipal : Form
    {
        public MainPrincipal()
        {
            InitializeComponent();
        }
        
        private void MainPrincipal_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
        }

        private void lklSalir_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lblAdmin_Click(object sender, EventArgs e)
        {
            AdminUsuarioForm frm = new AdminUsuarioForm();
            frm.ShowDialog();
        }

        private void lklSalir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show(" Desea cerrar esta vista ahora.", "Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            { Close(); }
            loginForm frm = new loginForm();
            frm.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            AgregarVuelo vuelo = new AgregarVuelo();
            vuelo.Show();
        }

        private void lblPlanVuelo_Click(object sender, EventArgs e)
        {
            RegistroPlanDeVuelo vuelo = new RegistroPlanDeVuelo();
            vuelo.Show();
        }

        private void lblRegAeronave_Click(object sender, EventArgs e)
        {
            AgregarAeronave aeronave = new AgregarAeronave();
            aeronave.Show();
        }

        private void lblRegPiloto_Click(object sender, EventArgs e)
        {
            agregarPiloto piloto = new agregarPiloto();
            piloto.Show();
        }
        private void lblMantenimiento_Click(object sender, EventArgs e)
        {
            ConsultarMantenimiento form = new ConsultarMantenimiento();
            form.ShowDialog();
        }

        private void lblPlanMant_Click(object sender, EventArgs e)
        {
            ConsultarPlanMantenimiento form = new ConsultarPlanMantenimiento();
            form.ShowDialog();
        }
        private void lblRegComponente_Click(object sender, EventArgs e)
        {
            MComponente componente = new MComponente();
            componente.ShowDialog();
        }
    }
}
