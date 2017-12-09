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


namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        int id_usuario;
        DataTable dtUsuario = new DataTable();
        DataSet dsUsuario = new DataSet();

        public frmLogin()
        {
            InitializeComponent();
        }

       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            CargarComboUsuario();
        }

        private void CargarComboUsuario()
        {
            try
            {
                using (GestorUsuario elGestorUsuario = new GestorUsuario())
                {
                    cbx_usuario_nombre.DataSource = elGestorUsuario.ListarUsuarios();
                    cbx_usuario_nombre.ValueMember = "cedula";
                    cbx_usuario_nombre.DisplayMember = "nombre";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            try
            {
                using (GestorUsuario elUsuario = new GestorUsuario())
                {
                    string ced = cbx_usuario_nombre.SelectedValue.ToString();
                    this.dsUsuario = elUsuario.ConsultarUsuario(ced);
                    this.dtUsuario = this.dsUsuario.Tables[0];

                    id_usuario = int.Parse(this.dtUsuario.Rows[0]["id_usuario"].ToString());
                    string cedula = this.dtUsuario.Rows[0]["cedula"].ToString();
                    string nombre = this.dtUsuario.Rows[0]["nombre"].ToString();
                    string contrasena = this.dtUsuario.Rows[0]["contrasenna"].ToString();
                    string cargo = this.dtUsuario.Rows[0]["cargo"].ToString();
                    
                    if ( cedula.Equals(cbx_usuario_nombre.SelectedValue.ToString()) && txt_usuario_Contrasena.Text.Equals(contrasena))
                    {
                        
                        frmPrincipal principal = new frmPrincipal(id_usuario, nombre, cargo);
                        this.Hide();
                        principal.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            	}
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de SQL: " + x.Message);
            }


        }

        private void txt_usuario_Contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }
    

