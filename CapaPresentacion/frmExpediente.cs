using System;
using System.Data;
using System.Windows.Forms;
using ProyectoOptica.CapaIntegracion;

namespace CapaPresentacion
{
    public partial class frmExpediente : Form
    {
        int id_usuario;
        string usuario;
        string cargo;
        string id_cliente;
        DataTable dtExpediente = new DataTable();
        DataSet dsExpediente = new DataSet();

        public frmExpediente(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
            usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipal frm_Principal = new frmPrincipal(id_usuario,usuario, cargo);
            frm_Principal.Show();
            this.SetVisibleCore(false);
        }

        private void frmExpediente_Load(object sender, EventArgs e)
        {
            cargarGridExpediente();
            cargarNombreUsuario();
        }
        void cargarNombreUsuario()
        {
            lblUNombre.Text = usuario;
            lbl_usuarioCargo.Text = cargo;
        }
        private void cargarGridExpediente()
        {
            using (GestorExpediente expediente = new GestorExpediente())
            {
                dgvExpediente.DataSource = expediente.ListarExpediente();

                dgvExpediente.Columns["id_cliente"].Visible = false;
                dgvExpediente.Columns["cedula"].HeaderText = "Cedula";
                dgvExpediente.Columns["nombre"].HeaderText = "Nombre";
                dgvExpediente.Columns["apellido1"].HeaderText = "Apellido 1°";
                dgvExpediente.Columns["apellido2"].HeaderText = "apellido 2°";
                dgvExpediente.Columns["direccion"].HeaderText = "Direccion";
                dgvExpediente.Columns["telefono"].HeaderText = "Telefono";
                dgvExpediente.Columns["deuda"].HeaderText = "Deuda";
               

            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string cedulaCliente = txt_Cliente_Cedula.Text;
            using (GestorExpediente expediente = new GestorExpediente())
            {
                if (txt_Cliente_Cedula.Text == "")
                {
                    MessageBox.Show("Inserte un dato valido", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    grbInformacion.Visible = false;
                }
                else
                {
                    grbInformacion.Visible = true;
                    dgvExpediente.DataSource = expediente.ConsultarExpediente(cedulaCliente);
                    label_id.Text = expediente.ConsultarExpediente(cedulaCliente).Tables[0].Rows[0][0].ToString();
                    textBox1.Text = (string)expediente.ConsultarExpediente(cedulaCliente).Tables[0].Rows[0][1];
                    textBox2.Text = (string)expediente.ConsultarExpediente(cedulaCliente).Tables[0].Rows[0][2];
                    this.id_cliente = label_id.Text;
                  
                }
            }
            cargarGridExpediente();
            cargarNombreUsuario();
        }

        private void btnInsertarDuenno_Click(object sender, EventArgs e)
        {
            frmCliente frm_cliente = new frmCliente(id_usuario, usuario, cargo);
            frm_cliente.Show();
            this.SetVisibleCore(false);
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            try
            {
                frmTarjeta frm_Tarjeta = new frmTarjeta(id_usuario, id_cliente, usuario, cargo);
                frm_Tarjeta.Show();
                this.SetVisibleCore(false);
            }
            catch (Exception o)
            {
                Console.Write(o);


                MessageBox.Show("No posee tarjeta", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmListaClientes frmListaClientes = new frmListaClientes(id_usuario, usuario, cargo);
            frmListaClientes.Show();
            this.SetVisibleCore(false);
        }

        private void dgvExpediente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void frmExpediente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvExpediente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cliente_Cedula.Text = dgvExpediente.CurrentRow.Cells[1].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
