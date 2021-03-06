﻿using CapaPresentacion.Ventas;
using ProyectoOptica.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmContenedor : Form
    {
        int id_usuario;
        string nombre, cargo, nombreImpresora;
        private DataTable dtImpresora = new DataTable();
        private DataSet dsImpresora = new DataSet();

        public FrmContenedor(int id_usuario, string nombre, string cargo)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
        }

        private void FrmContenedor_Load(object sender, EventArgs e)
        {
            FrmVentas venta = new FrmVentas(id_usuario, nombre, cargo, nombreImpresora);
            venta.MdiParent = this;
            venta.Show();
            cargarNombreImpresora();
        }

        private void cargarNombreImpresora()
        {
            using (GestorImpresora impresora = new GestorImpresora())
            {
                //dsImpresora = impresora.Consultar_impresoraPredeterminada();
                //dtImpresora = dsImpresora.Tables[0];

                nombreImpresora = "Microsoft XPS Document Writer";
            }
        }

        private void FrmContenedor_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, nombre, cargo);
            principal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos(id_usuario, nombre, cargo);
            productos.MdiParent = this;
            productos.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente(id_usuario, nombre, cargo);
            cliente.MdiParent = this;
            cliente.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ajustesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImpresoras impresora = new FrmImpresoras();
            impresora.MdiParent = this;
            impresora.Show();
            //nombreImpresora = impresora.NombreImpresora;
        }

        private void reciboToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentas venta = new FrmVentas(id_usuario, nombre, cargo, nombreImpresora);
            venta.MdiParent = this;
            venta.Show();
        }
    }
}
