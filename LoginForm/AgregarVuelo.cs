﻿using BibliotecaEscuadron;
using System;
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
    public partial class AgregarVuelo : Form
    {
        public AgregarVuelo()
        {
            InitializeComponent();
        }

        private void ListadoAeronave_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.UtcNow.ToLongDateString();
            lblHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOrigen_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtNroVuelo.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el numero de vuelo.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else if(txtCondicion.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar la condicion del vuelo.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else if(txtTotalTv.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el total tv.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else if(txtOrigen.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el origen.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else if(txtDestino.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar el destino.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else if(txtFecha.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar la fecha.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else if(txtMision.Text.Trim() == "")
            {
                MessageBox.Show("Asegurese de ingresar la mision.", "Close Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNroVuelo.Focus();

            } else
            {
                ConsumeWebApi consume = new ConsumeWebApi();
                Boolean registrarVuelo = consume.nuevoVuelo(Int32.Parse(txtNroVuelo.Text), txtCondicion.Text, Int32.Parse(txtTotalTv.Text), txtOrigen.Text, txtDestino.Text, txtFecha.Text, Int32.Parse(txtMision.Text));
                if (registrarVuelo)
                {
                    MessageBox.Show("Nuevo vuelo creado.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "Close Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var txt in Controls)
            {
                if (txt is TextBox)
                {
                    ((TextBox)txt).Clear();
                } else if (txt is ComboBox)
                {
                    ((ComboBox)txt).SelectedIndex = 0;
                }
            }
        }
    }
}
