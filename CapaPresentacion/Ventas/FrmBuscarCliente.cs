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
    public partial class FrmBuscarCliente : Form
    {
        int id_usuario;
        string nombre, cargo;
        private string cedula_cliente;
        string nombreCompleto;
        private DataTable dtVentas = new DataTable();
        private DataSet dsVentas = new DataSet();

        public string Cedula_cliente { get => cedula_cliente; set => cedula_cliente = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }

        public FrmBuscarCliente(int id_usuario, string nombre, string cargo)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
            cargarGrid();
        }

        private void cargarGrid()
        {
            using (GestorCliente cliente = new GestorCliente())
            {
                dgv_Clientes.DataSource = cliente.ListarCliente();

                dgv_Clientes.Columns["id_cliente"].Visible = false;
                dgv_Clientes.Columns["cedula"].HeaderText = "CEDULA";
                dgv_Clientes.Columns["nombre"].HeaderText = "NOMBRE";
                dgv_Clientes.Columns["apellido1"].HeaderText = "APELLIDO";
                dgv_Clientes.Columns["apellido2"].HeaderText = "APELLIDO";
                dgv_Clientes.Columns["telefono"].HeaderText = "TELEFONO";
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cedulaCliente.Text == "")
            {
                MessageBox.Show("Inserte un dato valido ", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string cedulaCliente = txt_cedulaCliente.Text;
                    using (GestorCliente cliente = new GestorCliente())
                    {
                        dsVentas = cliente.ConsultarClienteCedula(cedulaCliente);
                        dtVentas = this.dsVentas.Tables[0];
                        Cedula_cliente = dtVentas.Rows[0]["id_cliente"].ToString();
                        string nombre = dtVentas.Rows[0]["nombre"].ToString();
                        string apellido1 = dtVentas.Rows[0]["apellido1"].ToString();
                        string apellido2 = dtVentas.Rows[0]["apellido2"].ToString();
                        NombreCompleto = string.Concat(nombre, " ", apellido1, " ", apellido2);
                        dgv_Clientes.DataSource = this.dtVentas;
                        dgv_Clientes.Columns["id_cliente"].Visible = false;
                        dgv_Clientes.Columns["cedula"].HeaderText = "CEDULA";
                        dgv_Clientes.Columns["nombre"].HeaderText = "NOMBRE";
                        dgv_Clientes.Columns["apellido1"].HeaderText = "APELLIDO";
                        dgv_Clientes.Columns["apellido2"].HeaderText = "APELLIDO";
                        dgv_Clientes.Columns["telefono"].HeaderText = "TELEFONO";
                    }
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show("Desea Registrar el cliente? ", "Cliente no registrado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (result == DialogResult.OK)
                    {
                        frmCliente cliente = new frmCliente(id_usuario, nombre, cargo);
                        cliente.Show();
                    }
                }
            }
    }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string nombre = dgv_Clientes.CurrentRow.Cells[2].Value.ToString();
            string apellido1 = dgv_Clientes.CurrentRow.Cells[3].Value.ToString();
            string apellido2 = dgv_Clientes.CurrentRow.Cells[4].Value.ToString();
            NombreCompleto = string.Concat(nombre, " ", apellido1, " ", apellido2);
            this.Close();
        }

        private void FrmBuscarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
