using System;
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
            frmExpediente frm_Expediente = new frmExpediente(id_usuario, usuario, cargo);
            frm_Expediente.Show();
            this.SetVisibleCore(false);
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            CargarGridCliente();
            defecto();

        }


        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            /*---------------------------------------------------------------------------*/
            if (txtCedula.Text.Trim().Length != 9)
            {
                MessageBox.Show("La Cedula debe tener 9 dígitos");
                return; //Salimos 
            }
            /*---------------------------------------------------------------------------*/
            if (txtTelefono.Text.Trim().Length != 8)
            {
                MessageBox.Show("El Teléfono debe tener 8 dígitos");
                return; //Salimos 
            }
            CargarGridCliente();
            //CargarComboCliente();
            //CargarComboOjo();
            defecto();
            /*---------------------------------------------------------------------------*/
            if (txtCedula.Text != "" && txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != ""  && txtDireccion.Text != "" && txtTelefono.Text != "" && txtDeuda.Text != "")
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.InsertarCliente(txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtDireccion.Text, txtTelefono.Text, int.Parse(txtDeuda.Text));
                }
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            /*---------------------------------------------------------------------------*/
            if (txtCedula.Text.Trim().Length < 11 && txtCedula.Text.Trim().Length > 9)
            {
                MessageBox.Show("La Cedula debe tener 11 dígitos");
                return; //Salimos 
            }
            /*---------------------------------------------------------------------------*/
            if (txtTelefono.Text.Trim().Length != 8)
            {
                MessageBox.Show("El Teléfono debe tener 8 dígitos");
                return; //Salimos 
            }
            CargarGridCliente();

            defecto();
            /*---------------------------------------------------------------------------*/
            if (txtNombre.Text != "" && txtApellido1.Text != "" && txtApellido2.Text != "" && txtDireccion.Text != "" && txtTelefono.Text != "" && txtDeuda.Text != "")
            {
                using (GestorCliente elCliente = new GestorCliente())
                {
                    elCliente.ModificarCliente( txtCedula.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, txtDireccion.Text, txtTelefono.Text, int.Parse(txtDeuda.Text));
                }
            }
            else
            {
                MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void defecto()
        {
            txtBuscar.Text = null;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {

                if (txtBuscar.Text == "")
                {
                    MessageBox.Show("Inserte un dato valido", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                }

                if (txtBuscar.Text != null)
                {

                    using (GestorCliente Cliente = new GestorCliente())
                    {
                        this.dsCliente = Cliente.ConsultarClienteCedula(txtBuscar.Text);
                        this.dtCliente = this.dsCliente.Tables[0];

                    }
                    CargarGridCliente();

                }
                else
                {
                    MessageBox.Show("¡ Debe insertar una cedula ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

                CargarDatosCliente();
            }
            else
            {
                MessageBox.Show("¡ Debe insertar una cedula ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        

        private void CargarDatosCliente()
        {
            //cbxCliente.SelectedValue = this.dtCliente.Rows[0]["id_cliente"].ToString();
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

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void lblDeuda_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxDatos_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCedula.Text = dgvCliente.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dgvCliente.CurrentRow.Cells[2].Value.ToString();
            txtApellido1.Text = dgvCliente.CurrentRow.Cells[3].Value.ToString();
            txtApellido2.Text = dgvCliente.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvCliente.CurrentRow.Cells[5].Value.ToString();
            txtTelefono.Text = dgvCliente.CurrentRow.Cells[6].Value.ToString();
            txtDeuda.Text = dgvCliente.CurrentRow.Cells[7].Value.ToString();
        }

        /* private void cbxOjo_SelectedIndexChanged(object sender, EventArgs e)
         {

         }*/
    }
}
