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
    public partial class frmCliente : Form
    {

        DataTable dtCliente = new DataTable();
        DataSet dsCliente = new DataSet();

        string usuario;
        string cargo;
        int id_usuario;

        public frmCliente(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
            usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpediente frm_Expediente = new frmExpediente(id_usuario, usuario,cargo);
            frm_Expediente.Show();
            this.SetVisibleCore(false);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarGridCliente();
            CargarComboCliente();
            CargarComboOjo();
            defecto();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtDeuda.Text != "" && cbxOjo.SelectedItem != null)
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.InsertarCliente(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text, txtDireccion.Text, int.Parse(txtDeuda.Text));
                }
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGridCliente();
            CargarComboCliente();
            CargarComboOjo();
            defecto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedItem != null  && txtCedula.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtTelefono.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtDeuda.Text != "" && cbxOjo.SelectedItem != null)
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.ModificarCliente(int.Parse(cbxCliente.SelectedValue.ToString()),txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtTelefono.Text, txtDireccion.Text, int.Parse(txtDeuda.Text));
                }
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarGridCliente();
            CargarComboCliente();
            CargarComboOjo();
            defecto();
        }

       /* private void btnInactivar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedItem != null)
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.InactivarCliente(int.Parse(cbxCliente.SelectedValue.ToString()));
                }
            }
            else
            {
                MessageBox.Show("¡ Debe Seleccionar un Estudiante ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }*/

        private void defecto()
        {
            //cbxCliente.SelectedItem = null;
            cbxOjo.SelectedItem = null;
        }

        private void CargarComboOjo()

        {
            try
            {
                using (GestorGeneral elGestorOjo = new GestorGeneral())
                {

                    cbxOjo.DataSource = elGestorOjo.ListarOjo();
                    cbxOjo.ValueMember = "id_ojo";
                    cbxOjo.DisplayMember = "tipo";
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }

        }

        private void CargarGridCliente()
        {
            using (GestorCliente elCliente = new GestorCliente())
            {
                dgvCliente.DataSource = elCliente.ListarCliente();
                dgvCliente.Columns["id_cliente"].Visible = false;
                dgvCliente.Columns["cedula"].HeaderText = "Cedula";
                dgvCliente.Columns["nombre"].HeaderText = "Nombre";
                dgvCliente.Columns["apellido1"].HeaderText = "PrimerApellido";
                dgvCliente.Columns["apellido2"].HeaderText = "SegundoApellido";
                dgvCliente.Columns["direccion"].HeaderText = "Direccion";
                dgvCliente.Columns["telefono"].HeaderText = "Telefono";
                dgvCliente.Columns["deuda"].HeaderText = "Deuda";

            }
        }

        private void CargarComboCliente()
        {
            try
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    cbxCliente.DataSource = elCliente.ListarCliente();
                    cbxCliente.ValueMember = "id_cliente";
                    cbxCliente.DisplayMember = "cedula";
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbxCliente.SelectedItem != null)
            {
                int Id_cliente = int.Parse(cbxCliente.SelectedValue.ToString());

                using (GestorCliente Cliente = new GestorCliente())
                {
                    this.dsCliente = Cliente.ConsultarCliente(Id_cliente);
                    this.dtCliente = this.dsCliente.Tables[0];

                }
                CargarGridCliente();
                CargarComboCliente();
                CargarComboOjo();
                defecto();
            }
            else
            {
                MessageBox.Show("¡ Debe Seleccionar un Cliente ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            CargarDatosCliente();
        }

        private void CargarDatosCliente()
        {
            cbxCliente.SelectedValue = this.dtCliente.Rows[0]["id_cliente"].ToString();
            txtCedula.Text = this.dtCliente.Rows[0]["cedula"].ToString();
            txtNombre.Text = this.dtCliente.Rows[0]["nombre"].ToString();
            txtApellido1.Text = this.dtCliente.Rows[0]["apellido1"].ToString();
            txtApellido2.Text = this.dtCliente.Rows[0]["apellido2"].ToString();
            txtDireccion.Text = this.dtCliente.Rows[0]["direccion"].ToString();
            txtTelefono.Text = this.dtCliente.Rows[0]["telefono"].ToString();
            txtDeuda.Text = this.dtCliente.Rows[0]["deuda"].ToString();

        }

        private void cbxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
