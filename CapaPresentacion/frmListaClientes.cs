﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOptica.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmListaClientes : Form
    {
        int id_usuario;
        bool bandera = false;
        string usuario;
        string cargo;
        public frmListaClientes(int id_usuario, string usuario, string cargo)
        {
            this.id_usuario = id_usuario;
            this.usuario = usuario;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void frmListaClientes_Load(object sender, EventArgs e)
        {
            CargarGridCliente();
        }

        private void CargarGridCliente()
        {
            using (GestorCliente elCliente = new GestorCliente())
            {
                dgvCliente.DataSource = elCliente.ListarClienteSinTarjeta();
                dgvCliente.Columns["id_cliente"].Visible = false;
                dgvCliente.Columns["cedula"].HeaderText = "Cedula";
                dgvCliente.Columns["nombre"].HeaderText = "Nombre";
                dgvCliente.Columns["apellido1"].HeaderText = "PrimerApellido";
                dgvCliente.Columns["apellido2"].HeaderText = "SegundoApellido";
                dgvCliente.Columns["direccion"].HeaderText = "Direccion";
                dgvCliente.Columns["telefono"].HeaderText = "Telefono";
                dgvCliente.Columns["deuda"].Visible = false;

            }
        }
         private void btnExpediente_Click(object sender, EventArgs e)
        {
            if (bandera == true)
            {
                try
                {
                    bandera = false;
                    frmNuevaTarjeta frmNuevaTargea = new frmNuevaTarjeta(id_usuario, label_id.Text, usuario, cargo);
                    frmNuevaTargea.Show();
                    this.SetVisibleCore(false);
                }
                catch (Exception u)
                {
                    Console.Write(u);
                  
                }
            }
            else {
                MessageBox.Show("No ha elegido un cliente", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void grbInformacion_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmListaClientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpediente frmExpediente = new frmExpediente(id_usuario, usuario, cargo);
            frmExpediente.Show();
            this.SetVisibleCore(false);
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bandera = true;
            label_id.Text = dgvCliente.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
