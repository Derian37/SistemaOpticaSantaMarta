using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaIntegracion;
using ProyectoOptica.CapaLogica.Servicio;
using CapaLogica.LogicaNegocio;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        int id_usuario;
    	string usuario;
        string cargo;
    	
        public frmPrincipal(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
        	usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
           
        }

        
        void FrmPrincipalLoad(object sender, EventArgs e)
        {
            cargarUsuario();
        }

        private void btnExpediente_Click(object sender, EventArgs e)
        {
            frmExpediente frm_Expediente = new frmExpediente(id_usuario,usuario, cargo);
            frm_Expediente.Show();
            this.SetVisibleCore(false);
        }
       
        private void btnCita_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("¡ En Contrucción ¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            frmCitas frm_citas = new frmCitas(id_usuario, usuario, cargo);
            frm_citas.Show();
            this.Hide();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos frm_Productos = new frmProductos(id_usuario, usuario, cargo);
            frm_Productos.Show();
            this.Hide();
        }
        
        void Btn_SalirClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la aplicación?", "Cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
                principal.Show();
            }
            else
            {
                Application.Exit();
            }

        }
        
        void cargarUsuario(){
            lbl_usuarioCargo.Text = cargo;
            lbl_usuarioNombre.Text = usuario;
        }

        private void btnControlTrabajo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡ En Contrucción ¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            FrmContenedor cont = new FrmContenedor(id_usuario, usuario, cargo);
            cont.Show();
            this.Close();
        }

        private void btnProforma_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡ En Contrucción ¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVales_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡ En Contrucción ¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAbonos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡ En Contrucción ¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void GrpPrincipal_Enter(object sender, EventArgs e)
        {

        }

        private void toolstrip_usuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios usuarios = new frmUsuarios();
            usuarios.Show();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
