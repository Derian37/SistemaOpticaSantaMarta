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
    public partial class frmUsuarios : Form
    {
        private string accion;
        private int id_usuario;
        DataTable dtUsuario = new DataTable();
        DataSet dsUsuario = new DataSet();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarGridUsuarios();
        }

        private void cargarGridUsuarios()
        {
            using (GestorUsuario usuario  = new GestorUsuario())
            {
                dgv_Usuarios.DataSource = usuario.ListarUsuarios();

                dgv_Usuarios.Columns["id_usuario"].Visible = false;
                dgv_Usuarios.Columns["cedula"].HeaderText = "CEDULA";
                dgv_Usuarios.Columns["contrasenna"].HeaderText = "CONTRASEÑA";
                dgv_Usuarios.Columns["nombre"].HeaderText = "NOMBRE";
                dgv_Usuarios.Columns["cargo"].HeaderText = "CARGO";
                dgv_Usuarios.Columns["estado"].Visible = false;
            }
        }
        private void dgv_Usuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            bloquearCamposUsuario();
            id_usuario = int.Parse(dgv_Usuarios.CurrentRow.Cells[0].Value.ToString());
            txt_cedulaUsuario.Text = dgv_Usuarios.CurrentRow.Cells[1].Value.ToString();
            txt_contrasenaUsuario1.Text = dgv_Usuarios.CurrentRow.Cells[2].Value.ToString();
            txt_nombreUsuario.Text = dgv_Usuarios.CurrentRow.Cells[3].Value.ToString();
            txt_cargoUsuario.Text = dgv_Usuarios.CurrentRow.Cells[4].Value.ToString();
            btnInsertarUsuario.Visible = false;
            lbl_agregarUsuario.Visible = false;
            btn_EditarUsuario.Visible = true;
            lbl_editarUsuario.Visible = true;
            btn_EliminarUsuario.Visible = true;
            lbl_eliminarUsuario.Visible = true;
            lbl_contrasenaUsuario2.Visible = false;
            txt_contrasenaUsuario2.Visible = false;
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            desbloquearCamposUsuario();
            limpiarCamposUsuario();
            btn_guardarUsuario.Visible = true;
            lbl_guardarUsuario.Visible = true;
            accion = "insertar";
        }
        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            desbloquearCamposUsuario();
            lbl_editarUsuario.Visible = false;
            btn_EditarUsuario.Visible = false;
            lbl_contrasenaUsuario2.Visible = true;
            txt_contrasenaUsuario2.Visible = true;
            btn_EliminarUsuario.Visible = false;
            lbl_eliminarUsuario.Visible = false;
            btn_guardarUsuario.Visible = true;
            lbl_guardarUsuario.Visible = true;
            accion = "editar";
        }

        private void btn_EliminarUsuario_Click(object sender, EventArgs e)
        {
            using (GestorUsuario usuario = new GestorUsuario())
            {
                DialogResult result = MessageBox.Show("Seguro que desea eliminar el producto", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    usuario.InactivarUsuario(txt_cedulaUsuario.Text);
                }
            }
            limpiarCamposUsuario();
            lbl_contrasenaUsuario2.Visible = true;
            txt_contrasenaUsuario2.Visible = true;
            btn_EditarUsuario.Visible = false;
            lbl_editarUsuario.Visible = false;
            btn_EliminarUsuario.Visible = false;
            lbl_eliminarUsuario.Visible = false;
            cargarGridUsuarios();            
        }

        private void btn_guardarUsuario_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case "editar":
                    if (string.IsNullOrWhiteSpace(txt_cedulaUsuario.Text) || string.IsNullOrWhiteSpace(txt_nombreUsuario.Text) ||
                        string.IsNullOrWhiteSpace(txt_cargoUsuario.Text) || string.IsNullOrWhiteSpace(txt_contrasenaUsuario1.Text)
                        || string.IsNullOrWhiteSpace(txt_contrasenaUsuario2.Text))
                        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    else if (!txt_contrasenaUsuario1.Text.Equals(txt_contrasenaUsuario2.Text))
                    {
                        MessageBox.Show("Las contraseñas no son iguales!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (GestorUsuario usuario = new GestorUsuario())
                        {
                            usuario.ModificarUsuario(id_usuario, txt_cedulaUsuario.Text, txt_nombreUsuario.Text.ToUpper(), txt_contrasenaUsuario1.Text, txt_cargoUsuario.Text.ToUpper(), "A");
                        }
                        bloquearCamposUsuario();
                        MessageBox.Show("Datos Modificados Satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCamposUsuario();
                        estadoInicial();
                        cargarGridUsuarios();
                    }
                    break;
                case "insertar":
                    if (string.IsNullOrWhiteSpace(txt_cedulaUsuario.Text) || string.IsNullOrWhiteSpace(txt_nombreUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txt_cargoUsuario.Text) || string.IsNullOrWhiteSpace(txt_contrasenaUsuario1.Text)
                    || string.IsNullOrWhiteSpace(txt_contrasenaUsuario2.Text))
                        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    else if (!txt_contrasenaUsuario1.Text.Equals(txt_contrasenaUsuario2.Text))
                    {
                        MessageBox.Show("Las contraseñas no son iguales!", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (GestorUsuario usuario = new GestorUsuario())
                        {
                            usuario.InsertarUsuario(txt_cedulaUsuario.Text, txt_nombreUsuario.Text.ToUpper(), txt_contrasenaUsuario1.Text, txt_cargoUsuario.Text, "A");
                        }
                        bloquearCamposUsuario();
                        MessageBox.Show("Datos Registrados Satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        limpiarCamposUsuario();
                        btn_guardarUsuario.Visible = false;
                        lbl_guardarUsuario.Visible = false;
                        cargarGridUsuarios();
                    }
                    break;
                default:
                    break;
            }
        }

        private void estadoInicial()
        {
            btnInsertarUsuario.Visible = true;
            lbl_agregarUsuario.Visible = true;
            btn_EditarUsuario.Visible = false;
            lbl_editarUsuario.Visible = false;
            btn_EliminarUsuario.Visible = false;
            lbl_eliminarUsuario.Visible = false;
            btn_guardarUsuario.Visible = false;
            lbl_guardarUsuario.Visible = false;
        }

        private void bloquearCamposUsuario()
        {
            txt_cedulaUsuario.Enabled = false;
            txt_nombreUsuario.Enabled = false;
            txt_cargoUsuario.Enabled = false;
            txt_contrasenaUsuario1.Enabled = false;
            txt_contrasenaUsuario2.Enabled = false;
        }

        private void desbloquearCamposUsuario()
        {
            txt_cedulaUsuario.Enabled = true;
            txt_nombreUsuario.Enabled = true;
            txt_cargoUsuario.Enabled = true;
            txt_contrasenaUsuario1.Enabled = true;
            txt_contrasenaUsuario2.Enabled = true;
        }

        private void limpiarCamposUsuario()
        {
            txt_cedulaUsuario.Text = "";
            txt_nombreUsuario.Text = "";
            txt_cargoUsuario.Text = "";
            txt_contrasenaUsuario1.Text = "";
            txt_contrasenaUsuario2.Text = "";
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
